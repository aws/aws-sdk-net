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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Default Telephony Outbound config
    /// </summary>
    public partial class TelephonyOutboundConfig
    {
        private AnswerMachineDetectionConfig _answerMachineDetectionConfig;
        private string _connectContactFlowId;
        private string _connectSourcePhoneNumber;

        /// <summary>
        /// Gets and sets the property AnswerMachineDetectionConfig.
        /// </summary>
        public AnswerMachineDetectionConfig AnswerMachineDetectionConfig
        {
            get { return this._answerMachineDetectionConfig; }
            set { this._answerMachineDetectionConfig = value; }
        }

        // Check to see if AnswerMachineDetectionConfig property is set
        internal bool IsSetAnswerMachineDetectionConfig()
        {
            return this._answerMachineDetectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectContactFlowId.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string ConnectContactFlowId
        {
            get { return this._connectContactFlowId; }
            set { this._connectContactFlowId = value; }
        }

        // Check to see if ConnectContactFlowId property is set
        internal bool IsSetConnectContactFlowId()
        {
            return this._connectContactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectSourcePhoneNumber.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string ConnectSourcePhoneNumber
        {
            get { return this._connectSourcePhoneNumber; }
            set { this._connectSourcePhoneNumber = value; }
        }

        // Check to see if ConnectSourcePhoneNumber property is set
        internal bool IsSetConnectSourcePhoneNumber()
        {
            return this._connectSourcePhoneNumber != null;
        }

    }
}