﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Telegram.Api.Native.TL;
using Windows.Security.Cryptography;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace Telegram.Api.Native.Test
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var connectionManager = ConnectionManager.Instance;
            connectionManager.CurrentNetworkTypeChanged += Instance_CurrentNetworkTypeChanged;
            connectionManager.ConnectionStateChanged += ConnectionManager_ConnectionStateChanged;
            connectionManager.UnparsedMessageReceived += ConnectionManager_UnparsedMessageReceived;

            connectionManager.SendRequest(new TLError(0, "Hello world"), null, null, 1, ConnectionType.Generic, false, 0);

            GC.Collect();
        }

        private void ConnectionManager_ConnectionStateChanged(ConnectionManager sender, object args)
        {
        }

        private void ConnectionManager_UnparsedMessageReceived(ConnectionManager sender, TLUnparsedMessage args)
        {
        }

        private void Instance_CurrentNetworkTypeChanged(ConnectionManager sender, object e)
        {
        }
    }
}
