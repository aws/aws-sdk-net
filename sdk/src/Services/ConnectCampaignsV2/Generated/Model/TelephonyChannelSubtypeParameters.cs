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
    /// Parameters for the Telephony Channel Subtype
    /// </summary>
    public partial class TelephonyChannelSubtypeParameters
    {
        private AnswerMachineDetectionConfig _answerMachineDetectionConfig;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _connectSourcePhoneNumber;
        private string _destinationPhoneNumber;

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
        /// Gets and sets the property Attributes.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=20)]
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

    }
}