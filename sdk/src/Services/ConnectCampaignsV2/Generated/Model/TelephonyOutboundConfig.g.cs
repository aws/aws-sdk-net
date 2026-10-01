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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Default Telephony Outbound config
    /// </summary>
    public partial class TelephonyOutboundConfig
    {
        /// <summary>
        /// Gets and sets the property AnswerMachineDetectionConfig.
        /// </summary>
        public AnswerMachineDetectionConfig AnswerMachineDetectionConfig { get; set; }

        /// <summary>
        /// Checks to see if the AnswerMachineDetectionConfig property is set.
        /// </summary>
        internal bool IsSetAnswerMachineDetectionConfig() => this.AnswerMachineDetectionConfig != null;

        /// <summary>
        /// Gets and sets the property ConnectContactFlowId.
        /// </summary>
        [AWSProperty(Required = true, Max = 500)]
        public string ConnectContactFlowId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectContactFlowId property is set.
        /// </summary>
        internal bool IsSetConnectContactFlowId() => this.ConnectContactFlowId != null;

        /// <summary>
        /// Gets and sets the property ConnectSourcePhoneNumber.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string ConnectSourcePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the ConnectSourcePhoneNumber property is set.
        /// </summary>
        internal bool IsSetConnectSourcePhoneNumber() => this.ConnectSourcePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property RingTimeout.
        /// </summary>
        [AWSProperty(Min = 15, Max = 60)]
        public int? RingTimeout { get; set; }

        /// <summary>
        /// Checks to see if the RingTimeout property is set.
        /// </summary>
        internal bool IsSetRingTimeout() => this.RingTimeout.HasValue;
    }
}
