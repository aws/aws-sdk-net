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

#pragma warning disable CS0612,CS0618,CS1570
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
        private VoiceConnectorIntegrationType _integrationType;
        private string _name;
        private NetworkType _networkType;
        private bool? _requireEncryption;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The AWS Region in which the Amazon Chime SDK Voice Connector is created. Default value:
        /// <c>us-east-1</c> .
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
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The connectors for use with Amazon Connect.
        /// </para>
        ///  
        /// <para>
        /// The following options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONNECT_CALL_TRANSFER_CONNECTOR</c> - Enables enterprises to integrate Amazon
        /// Connect with other voice systems to directly transfer voice calls and metadata without
        /// using the public telephone network. They can use Amazon Connect telephony and Interactive
        /// Voice Response (IVR) with their existing voice systems to modernize the IVR experience
        /// of their existing contact center and their enterprise and branch voice systems. Additionally,
        /// enterprises migrating their contact center to Amazon Connect can start with Connect
        /// telephony and IVR for immediate modernization ahead of agent migration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECT_ANALYTICS_CONNECTOR</c> - Enables enterprises to integrate Amazon Connect
        /// with other voice systems for real-time and post-call analytics. They can use Amazon
        /// Connect Contact Lens with their existing voice systems to provides call recordings,
        /// conversational analytics (including contact transcript, sensitive data redaction,
        /// content categorization, theme detection, sentiment analysis, real-time alerts, and
        /// post-contact summary), and agent performance evaluations (including evaluation forms,
        /// automated evaluation, supervisor review) with a rich user experience to display, search
        /// and filter customer interactions, and programmatic access to data streams and the
        /// data lake. Additionally, enterprises migrating their contact center to Amazon Connect
        /// can start with Contact Lens analytics and performance insights ahead of agent migration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VoiceConnectorIntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
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
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of network for the Voice Connector. Either IPv4 only or dual-stack (IPv4
        /// and IPv6).
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property RequireEncryption. 
        /// <para>
        /// Enables or disables encryption for the Voice Connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RequireEncryption
        {
            get { return this._requireEncryption; }
            set { this._requireEncryption = value; }
        }

        // Check to see if RequireEncryption property is set
        internal bool IsSetRequireEncryption()
        {
            return this._requireEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Voice Connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}