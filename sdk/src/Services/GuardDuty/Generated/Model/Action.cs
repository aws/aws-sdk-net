/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the activity described in a finding.
    /// </summary>
    public partial class Action
    {
        private string _actionType;
        private AwsApiCallAction _awsApiCallAction;
        private DnsRequestAction _dnsRequestAction;
        private NetworkConnectionAction _networkConnectionAction;
        private PortProbeAction _portProbeAction;

        /// <summary>
        /// Gets and sets the property ActionType. GuardDuty Finding activity type.
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
        /// Gets and sets the property AwsApiCallAction. Information about the AWS_API_CALL action
        /// described in this finding.
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
        /// Gets and sets the property DnsRequestAction. Information about the DNS_REQUEST action
        /// described in this finding.
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
        /// Gets and sets the property NetworkConnectionAction. Information about the NETWORK_CONNECTION
        /// action described in this finding.
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
        /// Gets and sets the property PortProbeAction. Information about the PORT_PROBE action
        /// described in this finding.
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