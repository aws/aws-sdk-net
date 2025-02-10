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
    /// Container for the parameters to the GetResourceSnapshot operation.
    /// Use this action to retrieve a specific snapshot record.
    /// </summary>
    public partial class GetResourceSnapshotRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _engagementIdentifier;
        private string _resourceIdentifier;
        private string _resourceSnapshotTemplateIdentifier;
        private ResourceType _resourceType;
        private int? _revision;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog related to the request. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS: Retrieves the snapshot from the production AWS environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sandbox: Retrieves the snapshot from a sandbox environment used for testing or development
        /// purposes.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the engagement associated with the snapshot. This field links
        /// the snapshot to a specific engagement context.
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
        /// The unique identifier of the specific resource that was snapshotted. The format and
        /// constraints of this identifier depend on the ResourceType specified. For <c>Opportunity</c>
        /// type, it will be an <c>opportunity ID</c> 
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
        /// he name of the template that defines the schema for the snapshot. This template determines
        /// which subset of the resource data is included in the snapshot and must correspond
        /// to an existing and valid template for the specified <c>ResourceType</c>.
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
        /// Specifies the type of resource that was snapshotted. This field determines the structure
        /// and content of the snapshot payload. Valid value includes:<c>Opportunity</c>: For
        /// opportunity-related data. 
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
        /// Gets and sets the property Revision. 
        /// <para>
        /// Specifies which revision of the snapshot to retrieve. If omitted returns the latest
        /// revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

    }
}