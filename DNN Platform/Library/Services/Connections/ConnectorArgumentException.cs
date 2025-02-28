﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Services.Connections
{
    using System;

    public class ConnectorArgumentException : ApplicationException
    {
        /// <summary>Initializes a new instance of the <see cref="ConnectorArgumentException"/> class.</summary>
        public ConnectorArgumentException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConnectorArgumentException"/> class.</summary>
        /// <param name="message"></param>
        public ConnectorArgumentException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConnectorArgumentException"/> class.</summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ConnectorArgumentException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
