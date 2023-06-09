﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace lab3
{
    public partial class server_t2 : Form
    {
        public server_t2()
        {
            InitializeComponent();
        }

        bool isListening = false;
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);

            Socket clientSocket = listenerSocket.Accept();
            lsv_Messages.Items.Add("New client connected");

            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                }
                while (text[text.Length - 1] != '\n');

                if (!string.IsNullOrWhiteSpace(text))
                    lsv_Messages.Items.Add(text);
            }
            listenerSocket.Close();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            if (isListening) return;
            isListening = true;
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(StartUnsafeThread);
            lsv_Messages.Items.Add("Telnet is running on" + ipepServer.ToString());

            serverThread.IsBackground = true;
            serverThread.Start();
        }
    }
}
