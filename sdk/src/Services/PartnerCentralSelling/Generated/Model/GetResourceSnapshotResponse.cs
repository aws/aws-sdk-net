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
    /// This is the response object from the GetResourceSnapshot operation.
    /// </summary>
    public partial class GetResourceSnapshotResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _catalog;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _engagementId;
        private ResourceSnapshotPayload _payload;
        private string _resourceId;
        private string _resourceSnapshotTemplateName;
        private ResourceType _resourceType;
        private int? _revision;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the resource snapshot.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog in which the snapshot was created. Matches the Catalog specified in the
        /// request.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the snapshot was created, in ISO 8601 format (e.g., "2023-06-01T14:30:00Z").
        /// This allows for precise tracking of when the snapshot was taken. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The AWS account ID of the principal (user or role) who created the snapshot. This
        /// helps in tracking the origin of the snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The identifier of the engagement associated with this snapshot. Matches the EngagementIdentifier
        /// specified in the request. 
        /// </para>
        /// </summary>
        public string EngagementId
        {
            get { return this._engagementId; }
            set { this._engagementId = value; }
        }

        // Check to see if EngagementId property is set
        internal bool IsSetEngagementId()
        {
            return this._engagementId != null;
        }

        /// <summary>
        /// Gets and sets the property Payload.
        /// </summary>
        public ResourceSnapshotPayload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the specific resource that was snapshotted. Matches the ResourceIdentifier
        /// specified in the request.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateName. 
        /// <para>
        /// The name of the view used for this snapshot. This is the same as the template name.
        /// </para>
        /// </summary>
        public string ResourceSnapshotTemplateName
        {
            get { return this._resourceSnapshotTemplateName; }
            set { this._resourceSnapshotTemplateName = value; }
        }

        // Check to see if ResourceSnapshotTemplateName property is set
        internal bool IsSetResourceSnapshotTemplateName()
        {
            return this._resourceSnapshotTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that was snapshotted. Matches the ResourceType specified
        /// in the request.
        /// </para>
        /// </summary>
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
        /// The revision number of this snapshot. This is a positive integer that is sequential
        /// and unique within the context of a resource view.
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