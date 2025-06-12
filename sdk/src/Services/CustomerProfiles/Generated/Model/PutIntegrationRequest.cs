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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
    /// Container for the parameters to the PutIntegration operation.
    /// Adds an integration between the service and a third-party service, which includes
    /// Amazon AppFlow and Amazon Connect.
    /// 
    ///  
    /// <para>
    /// An integration can belong to only one domain.
    /// </para>
    ///  
    /// <para>
    /// To add or remove tags on an existing Integration, see <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_TagResource.html">
    /// TagResource </a>/<a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UntagResource.html">
    /// UntagResource</a>.
    /// </para>
    /// </summary>
    public partial class PutIntegrationRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private List<string> _eventTriggerNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FlowDefinition _flowDefinition;
        private string _objectTypeName;
        private Dictionary<string, string> _objectTypeNames = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uri;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EventTriggerNames. 
        /// <para>
        /// A list of unique names for active event triggers associated with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> EventTriggerNames
        {
            get { return this._eventTriggerNames; }
            set { this._eventTriggerNames = value; }
        }

        // Check to see if EventTriggerNames property is set
        internal bool IsSetEventTriggerNames()
        {
            return this._eventTriggerNames != null && (this._eventTriggerNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FlowDefinition. 
        /// <para>
        /// The configuration that controls how Customer Profiles retrieves data from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FlowDefinition FlowDefinition
        {
            get { return this._flowDefinition; }
            set { this._flowDefinition = value; }
        }

        // Check to see if FlowDefinition property is set
        internal bool IsSetFlowDefinition()
        {
            return this._flowDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The name of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ObjectTypeName
        {
            get { return this._objectTypeName; }
            set { this._objectTypeName = value; }
        }

        // Check to see if ObjectTypeName property is set
        internal bool IsSetObjectTypeName()
        {
            return this._objectTypeName != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ObjectTypeNames
        {
            get { return this._objectTypeNames; }
            set { this._objectTypeNames = value; }
        }

        // Check to see if ObjectTypeNames property is set
        internal bool IsSetObjectTypeNames()
        {
            return this._objectTypeNames != null && (this._objectTypeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. The Integration uses this role to
        /// make Customer Profiles requests on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the S3 bucket or any other type of data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}