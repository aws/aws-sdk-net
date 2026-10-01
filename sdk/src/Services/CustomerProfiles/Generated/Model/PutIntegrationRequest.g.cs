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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the PutIntegration operation. Adds an integration
    /// between the service and a third-party service, which includes Amazon AppFlow and Amazon
    /// Connect. <para> An integration can belong to only one domain. </para> <para> To add
    /// or remove tags on an existing Integration, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
    /// TagResource </a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">
    /// UntagResource</a>. </para>
    /// </summary>
    public partial class PutIntegrationRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EventTriggerNames. 
        /// <para>
        /// A list of unique names for active event triggers associated with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> EventTriggerNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventTriggerNames property is set.
        /// </summary>
        internal bool IsSetEventTriggerNames() => this.EventTriggerNames != null && (this.EventTriggerNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowDefinition. 
        /// <para>
        /// The configuration that controls how Customer Profiles retrieves data from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowDefinition FlowDefinition { get; set; }

        /// <summary>
        /// Checks to see if the FlowDefinition property is set.
        /// </summary>
        internal bool IsSetFlowDefinition() => this.FlowDefinition != null;

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The name of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ObjectTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeName property is set.
        /// </summary>
        internal bool IsSetObjectTypeName() => this.ObjectTypeName != null;

        /// <summary>
        /// Gets and sets the property ObjectTypeNames. 
        /// <para>
        /// A map in which each key is an event type from an external application such as Segment
        /// or Shopify, and each value is an <c>ObjectTypeName</c> (template) used to ingest the
        /// event. It supports the following event types: <c>SegmentIdentify</c>, <c>ShopifyCreateCustomers</c>,
        /// <c>ShopifyUpdateCustomers</c>, <c>ShopifyCreateDraftOrders</c>, <c>ShopifyUpdateDraftOrders</c>,
        /// <c>ShopifyCreateOrders</c>, and <c>ShopifyUpdatedOrders</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ObjectTypeNames { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ObjectTypeNames property is set.
        /// </summary>
        internal bool IsSetObjectTypeNames() => this.ObjectTypeNames != null && (this.ObjectTypeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. The Integration uses this role to
        /// make Customer Profiles requests on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether the integration applies to profile level data (associated with profiles)
        /// or domain level data (not associated with any specific profile). The default value
        /// is PROFILE.
        /// </para>
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the S3 bucket or any other type of data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
