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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTenant operation. Create a tenant. <para>
    /// <i>Tenants</i> are logical containers that group related SES resources together. Each
    /// tenant can have its own set of resources like email identities, configuration sets,
    /// and templates, along with reputation metrics and sending status. This helps isolate
    /// and manage email sending for different customers or business units within your Amazon
    /// SES API v2 account. </para> <para> You can optionally specify <c>SuppressionAttributes</c>
    /// to configure tenant-level suppression at creation time. When tenant-level suppression
    /// is enabled, Amazon SES maintains a separate suppression list for the tenant instead
    /// of using the account-level suppression list. </para>
    /// </summary>
    public partial class CreateTenantRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property SuppressionAttributes. 
        /// <para>
        /// An object that contains information about the suppression list preferences for the
        /// tenant. Use this to configure tenant-level suppression at creation time.
        /// </para>
        /// </summary>
        public TenantSuppressionAttributes SuppressionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionAttributes property is set.
        /// </summary>
        internal bool IsSetSuppressionAttributes() => this.SuppressionAttributes != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) to associate with the tenant
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant to create. The name can contain up to 64 alphanumeric characters,
        /// including letters, numbers, hyphens (-) and underscores (_) only.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TenantName { get; set; }

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null;
    }
}
