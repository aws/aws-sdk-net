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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceSnapshotJob operation.
    /// Use this action to create a job to generate a snapshot of the specified resource within
    /// an engagement. It initiates an asynchronous process to create a resource snapshot.
    /// The job creates a new snapshot only if the resource state has changed, adhering to
    /// the same access control and immutability rules as direct snapshot creation.
    /// </summary>
    public partial class CreateResourceSnapshotJobRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _clientToken;
        private string _engagementIdentifier;
        private string _resourceIdentifier;
        private string _resourceSnapshotTemplateIdentifier;
        private ResourceType _resourceType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which to create the snapshot job. Valid values are <c>AWS</c>
        /// and <c> Sandbox</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client-generated UUID used for idempotency check. The token helps prevent duplicate
        /// job creations.
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
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// Specifies the identifier of the engagement associated with the resource to be snapshotted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngagementIdentifier
        {
            get { return this._engagementIdentifier; }
            set { this._engagementIdentifier = value; }
        }

        // Check to see if EngagementIdentifier property is set
        internal bool IsSetEngagementIdentifier()
        {
            return this._engagementIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Specifies the identifier of the specific resource to be snapshotted. The format depends
        /// on the <c> ResourceType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateIdentifier. 
        /// <para>
        /// Specifies the name of the template that defines the schema for the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceSnapshotTemplateIdentifier
        {
            get { return this._resourceSnapshotTemplateIdentifier; }
            set { this._resourceSnapshotTemplateIdentifier = value; }
        }

        // Check to see if ResourceSnapshotTemplateIdentifier property is set
        internal bool IsSetResourceSnapshotTemplateIdentifier()
        {
            return this._resourceSnapshotTemplateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for which the snapshot job is being created. Must be one of the
        /// supported resource types i.e. <c>Opportunity</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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