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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about one of the following actions that affects or that was taken
    /// on a resource:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A remote IP address issued an Amazon Web Services API call
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A DNS request was received
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A remote IP address attempted to connect to an EC2 instance
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A remote IP address attempted a port probe on an EC2 instance
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Action
    {
        private string _actionType;
        private AwsApiCallAction _awsApiCallAction;
        private DnsRequestAction _dnsRequestAction;
        private NetworkConnectionAction _networkConnectionAction;
        private PortProbeAction _portProbeAction;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of action that was detected. The possible action types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NETWORK_CONNECTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_API_CALL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_REQUEST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PORT_PROBE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property AwsApiCallAction. 
        /// <para>
        /// Included if <c>ActionType</c> is <c>AWS_API_CALL</c>. Provides details about the API
        /// call that was detected. 
        /// </para>
        /// </summary>
        public AwsApiCallAction AwsApiCallAction
        {
            get { return this._awsApiCallAction; }
            set { this._awsApiCallAction = value; }
        }

        // Check to see if AwsApiCallAction property is set
        internal bool IsSetAwsApiCallAction()
        {
            return this._awsApiCallAction != null;
        }

        /// <summary>
        /// Gets and sets the property DnsRequestAction. 
        /// <para>
        /// Included if <c>ActionType</c> is <c>DNS_REQUEST</c>. Provides details about the DNS
        /// request that was detected. 
        /// </para>
        /// </summary>
        public DnsRequestAction DnsRequestAction
        {
            get { return this._dnsRequestAction; }
            set { this._dnsRequestAction = value; }
        }

        // Check to see if DnsRequestAction property is set
        internal bool IsSetDnsRequestAction()
        {
            return this._dnsRequestAction != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConnectionAction. 
        /// <para>
        /// Included if <c>ActionType</c> is <c>NETWORK_CONNECTION</c>. Provides details about
        /// the network connection that was detected.
        /// </para>
        /// </summary>
        public NetworkConnectionAction NetworkConnectionAction
        {
            get { return this._networkConnectionAction; }
            set { this._networkConnectionAction = value; }
        }

        // Check to see if NetworkConnectionAction property is set
        internal bool IsSetNetworkConnectionAction()
        {
            return this._networkConnectionAction != null;
        }

        /// <summary>
        /// Gets and sets the property PortProbeAction. 
        /// <para>
        /// Included if <c>ActionType</c> is <c>PORT_PROBE</c>. Provides details about the port
        /// probe that was detected. 
        /// </para>
        /// </summary>
        public PortProbeAction PortProbeAction
        {
            get { return this._portProbeAction; }
            set { this._portProbeAction = value; }
        }

        // Check to see if PortProbeAction property is set
        internal bool IsSetPortProbeAction()
        {
            return this._portProbeAction != null;
        }

    }
}