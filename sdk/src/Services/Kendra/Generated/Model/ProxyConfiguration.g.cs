/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for a web proxy to connect to website hosts.
    /// </summary>
    public partial class ProxyConfiguration
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret. You create a secret to
        /// store your credentials in <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html">Secrets
        /// Manager</a> 
        /// </para>
        ///  
        /// <para>
        /// The credentials are optional. You use a secret if web proxy credentials are required
        /// to connect to a website host. Amazon Kendra currently support basic authentication
        /// to connect to a web proxy server. The secret stores your credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1284)]
        public string Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The name of the website host you want to connect to via a web proxy server.
        /// </para>
        ///  
        /// <para>
        /// For example, the host name of https://a.example.com/page1.html is "a.example.com".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number of the website host you want to connect to via a web proxy server.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, the port for https://a.example.com/page1.html is 443, the standard port
        /// for HTTPS.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
