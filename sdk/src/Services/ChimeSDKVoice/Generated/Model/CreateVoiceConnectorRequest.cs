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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVoiceConnector operation.
    /// Creates an Amazon Chime SDK Voice Connector. For more information about Voice Connectors,
    /// see <a href="https://docs.aws.amazon.com/chime-sdk/latest/ag/voice-connector-groups.html">Managing
    /// Amazon Chime SDK Voice Connector groups</a> in the <i>Amazon Chime SDK Administrator
    /// Guide</i>.
    /// </summary>
    public partial class CreateVoiceConnectorRequest : AmazonChimeSDKVoiceRequest
    {
        private VoiceConnectorAwsRegion _awsRegion;
        private string _name;
        private bool? _requireEncryption;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region in which the Amazon Chime SDK Voice Connector is created. Default value:
        /// <code>us-east-1</code> .
        /// </para>
        /// </summary>
        public VoiceConnectorAwsRegion AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Voice Connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequireEncryption. 
        /// <para>
        /// Enables or disables encryption for the Voice Connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool RequireEncryption
        {
            get { return this._requireEncryption.GetValueOrDefault(); }
            set { this._requireEncryption = value; }
        }

        // Check to see if RequireEncryption property is set
        internal bool IsSetRequireEncryption()
        {
            return this._requireEncryption.HasValue; 
        }

    }
}