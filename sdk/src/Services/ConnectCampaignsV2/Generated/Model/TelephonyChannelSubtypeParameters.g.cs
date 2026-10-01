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
    /// Parameters for the Telephony Channel Subtype
    /// </summary>
    public partial class TelephonyChannelSubtypeParameters
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
        /// Gets and sets the property Attributes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property DestinationPhoneNumber.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 20)]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

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
