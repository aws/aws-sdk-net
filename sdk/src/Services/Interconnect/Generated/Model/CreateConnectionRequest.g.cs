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

namespace Amazon.Interconnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnection operation. Initiates the process
    /// to create a Connection across the specified Environment. <para> The Environment dictates
    /// the specified partner and location to which the other end of the connection should
    /// attach. You can see a list of the available Environments by calling <a>ListEnvironments</a>
    /// </para> <para> The Attach Point specifies where within the AWS Network your connection
    /// will logically connect. </para> <para> After a successful call to this method, the
    /// resulting <a>Connection</a> will return an Activation Key which will need to be brought
    /// to the specific partner's portal to confirm the <a>Connection</a> on both sides. (See
    /// <a>Environment$activationPageUrl</a> for a direct link to the partner portal). </para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonInterconnectRequest
    {
        /// <summary>
        /// Gets and sets the property AttachPoint. 
        /// <para>
        /// The Attach Point to which the connection should be associated."
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AttachPoint AttachPoint { get; set; }

        /// <summary>
        /// Checks to see if the AttachPoint property is set.
        /// </summary>
        internal bool IsSetAttachPoint() => this.AttachPoint != null;

        /// <summary>
        /// Gets and sets the property Bandwidth. 
        /// <para>
        /// The desired bandwidth of the requested <a>Connection</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// Checks to see if the Bandwidth property is set.
        /// </summary>
        internal bool IsSetBandwidth() => this.Bandwidth != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token used for the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description to distinguish this <a>Connection</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property RemoteAccount. 
        /// <para>
        /// Account and/or principal identifying information that can be verified by the partner
        /// of this specific Environment.
        /// </para>
        /// </summary>
        public RemoteAccountIdentifier RemoteAccount { get; set; }

        /// <summary>
        /// Checks to see if the RemoteAccount property is set.
        /// </summary>
        internal bool IsSetRemoteAccount() => this.RemoteAccount != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag to associate with the resulting <a>Connection</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
