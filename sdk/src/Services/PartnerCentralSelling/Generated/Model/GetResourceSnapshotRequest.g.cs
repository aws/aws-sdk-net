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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceSnapshot operation. Use this action
    /// to retrieve a specific snapshot record.
    /// </summary>
    public partial class GetResourceSnapshotRequest : AmazonPartnerCentralSellingRequest
    {
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
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the engagement associated with the snapshot. This field links
        /// the snapshot to a specific engagement context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The unique identifier of the specific resource that was snapshotted. The format and
        /// constraints of this identifier depend on the ResourceType specified. For <c>Opportunity</c>
        /// type, it will be an <c>opportunity ID</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateIdentifier. 
        /// <para>
        /// he name of the template that defines the schema for the snapshot. This template determines
        /// which subset of the resource data is included in the snapshot and must correspond
        /// to an existing and valid template for the specified <c>ResourceType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceSnapshotTemplateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotTemplateIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotTemplateIdentifier() => this.ResourceSnapshotTemplateIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of resource that was snapshotted. This field determines the structure
        /// and content of the snapshot payload. Valid value includes:<c>Opportunity</c>: For
        /// opportunity-related data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// Specifies which revision of the snapshot to retrieve. If omitted returns the latest
        /// revision.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
