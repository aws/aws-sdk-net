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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Each alias ("endpoint") is a fully-qualified name and port number that other tasks
    /// ("clients") can use to connect to this service.
    /// 
    ///  
    /// <para>
    /// Each name and port mapping must be unique within the namespace.
    /// </para>
    ///  
    /// <para>
    /// Tasks that run in a namespace can use short names to connect to services in the namespace.
    /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
    /// through a managed proxy container that collects logs and metrics for increased visibility.
    /// Only the tasks that Amazon ECS services create are supported with Service Connect.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServiceConnectClientAlias
    {
        private string _dnsName;
        private int? _port;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The <code>dnsName</code> is the name that you use in the applications of client tasks
        /// to connect to this service. The name must be a valid DNS name but doesn't need to
        /// be fully-qualified. Up to 127 characters are allowed. The characters can include lowercase
        /// letters, numbers, underscores (_), hyphens (-), and periods (.). A hyphen can't be
        /// the first character.
        /// </para>
        ///  
        /// <para>
        /// If this parameter isn't specified, the default value of <code>discoveryName.namespace</code>
        /// is used. If the <code>discoveryName</code> isn't specified, the <code>portName.namespace</code>
        /// from the task definition is used.
        /// </para>
        ///  
        /// <para>
        /// To avoid changing your applications in client Amazon ECS services, set this to the
        /// same name that the client application uses by default. For example, a few common names
        /// are <code>database</code>, <code>db</code>, or the lowercase name of a database, such
        /// as <code>mysql</code> or <code>redis</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The listening port number for the Service Connect proxy. This port is available inside
        /// of all of the tasks within the same namespace.
        /// </para>
        ///  
        /// <para>
        /// To avoid changing your applications in client Amazon ECS services, set this to the
        /// same port that the client application uses by default. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}