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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePrivateConnection operation. Creates a private
    /// connection for reaching a self-hosted provider instance over private networking using
    /// Amazon VPC Lattice.
    /// </summary>
    public partial class CreatePrivateConnectionRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The configuration for the private connection. Specify either a service-managed or
        /// a self-managed mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PrivateConnectionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// A unique name for the private connection within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the private connection.
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
