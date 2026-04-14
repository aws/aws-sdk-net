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
 * Do not modify this file. This file is generated from the interconnect-2022-07-26.normal.json service model.
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
namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnection operation.
    /// Initiates the process to create a Connection across the specified Environment. 
    /// 
    ///  
    /// <para>
    /// The Environment dictates the specified partner and location to which the other end
    /// of the connection should attach. You can see a list of the available Environments
    /// by calling <a>ListEnvironments</a> 
    /// </para>
    ///  
    /// <para>
    /// The Attach Point specifies where within the AWS Network your connection will logically
    /// connect.
    /// </para>
    ///  
    /// <para>
    /// After a successful call to this method, the resulting <a>Connection</a> will return
    /// an Activation Key which will need to be brought to the specific partner's portal to
    /// confirm the <a>Connection</a> on both sides. (See <a>Environment$activationPageUrl</a>
    /// for a direct link to the partner portal). 
    /// </para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonInterconnectRequest
    {
        private AttachPoint _attachPoint;
        private string _bandwidth;
        private string _clientToken;
        private string _description;
        private string _environmentId;
        private RemoteAccountIdentifier _remoteAccount;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// The Attach Point to which the connection should be associated."
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttachPoint AttachPoint
        {
            get { return this._attachPoint; }
            set { this._attachPoint = value; }
        }

        // Check to see if AttachPoint property is set
        internal bool IsSetAttachPoint()
        {
            return this._attachPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The desired bandwidth of the requested <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public string Bandwidth
        {
            get { return this._bandwidth; }
            set { this._bandwidth = value; }
        }

        // Check to see if Bandwidth property is set
        internal bool IsSetBandwidth()
        {
            return this._bandwidth != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token used for the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to distinguish this <a>Connection</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the <a>Environment</a> across which this <a>Connection</a> should
        /// be created.
        /// </para>
        ///  
        /// <para>
        /// The available <a>Environment</a> objects can be determined using <a>ListEnvironments</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccount. 
        /// <para>
        /// Account and/or principal identifying information that can be verified by the partner
        /// of this specific Environment.
        /// </para>
        /// </summary>
        public RemoteAccountIdentifier RemoteAccount
        {
            get { return this._remoteAccount; }
            set { this._remoteAccount = value; }
        }

        // Check to see if RemoteAccount property is set
        internal bool IsSetRemoteAccount()
        {
            return this._remoteAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag to associate with the resulting <a>Connection</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
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