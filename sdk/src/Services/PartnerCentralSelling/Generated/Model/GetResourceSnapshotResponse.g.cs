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
    /// This is the response object from the GetResourceSnapshot operation.
    /// </summary>
    public partial class GetResourceSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the resource snapshot.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which the snapshot was created. Matches the Catalog specified in the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the snapshot was created, in ISO 8601 format (e.g., "2023-06-01T14:30:00Z").
        /// This allows for precise tracking of when the snapshot was taken. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The AWS account ID of the principal (user or role) who created the snapshot. This
        /// helps in tracking the origin of the snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The identifier of the engagement associated with this snapshot. Matches the EngagementIdentifier
        /// specified in the request. 
        /// </para>
        /// </summary>
        public string EngagementId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementId property is set.
        /// </summary>
        internal bool IsSetEngagementId() => this.EngagementId != null;

        /// <summary>
        /// Gets and sets the property Payload.
        /// </summary>
        public ResourceSnapshotPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the specific resource that was snapshotted. Matches the ResourceIdentifier
        /// specified in the request.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateName. 
        /// <para>
        /// The name of the view used for this snapshot. This is the same as the template name.
        /// </para>
        /// </summary>
        public string ResourceSnapshotTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotTemplateName property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotTemplateName() => this.ResourceSnapshotTemplateName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that was snapshotted. Matches the ResourceType specified
        /// in the request.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision number of this snapshot. This is a positive integer that is sequential
        /// and unique within the context of a resource view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property TargetMemberAccounts. 
        /// <para>
        /// Target member accounts associated with the resource snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> TargetMemberAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetMemberAccounts property is set.
        /// </summary>
        internal bool IsSetTargetMemberAccounts() => this.TargetMemberAccounts != null && (this.TargetMemberAccounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
