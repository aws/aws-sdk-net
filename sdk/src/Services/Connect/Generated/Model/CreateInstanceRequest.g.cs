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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstance operation. This API is in preview
    /// release for Connect Customer and is subject to change. <para> Initiates an Connect
    /// Customer instance with all the supported channels enabled. It does not attach any
    /// storage, such as Amazon Simple Storage Service (Amazon S3) or Amazon Kinesis. It also
    /// does not allow for any configurations on features, such as Contact Lens for Connect
    /// Customer. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-instances.html">Create
    /// an Connect Customer instance</a> in the <i>Connect Customer Administrator Guide</i>.
    /// </para> <para> Connect Customer enforces a limit on the total number of instances
    /// that you can create or delete in 30 days. If you exceed this limit, you will get an
    /// error message indicating there has been an excessive number of attempts at creating
    /// or deleting instances. You must wait 30 days before you can restart creating and deleting
    /// instances in your account. </para>
    /// </summary>
    public partial class CreateInstanceRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property IdentityManagementType. 
        /// <para>
        /// The type of identity management for your Connect Customer users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DirectoryType IdentityManagementType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityManagementType property is set.
        /// </summary>
        internal bool IsSetIdentityManagementType() => this.IdentityManagementType != null;

        /// <summary>
        /// Gets and sets the property InboundCallsEnabled. 
        /// <para>
        /// Your contact center handles incoming contacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? InboundCallsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InboundCallsEnabled property is set.
        /// </summary>
        internal bool IsSetInboundCallsEnabled() => this.InboundCallsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceAlias. 
        /// <para>
        /// The name for your instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 45)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// Checks to see if the InstanceAlias property is set.
        /// </summary>
        internal bool IsSetInstanceAlias() => this.InstanceAlias != null;

        /// <summary>
        /// Gets and sets the property OutboundCallsEnabled. 
        /// <para>
        /// Your contact center allows outbound calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? OutboundCallsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCallsEnabled property is set.
        /// </summary>
        internal bool IsSetOutboundCallsEnabled() => this.OutboundCallsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// <c>{ "tags": {"key1":"value1", "key2":"value2"} }</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
