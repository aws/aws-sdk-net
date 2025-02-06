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
    /// This is the response object from the GetResourceSnapshotJob operation.
    /// </summary>
    public partial class GetResourceSnapshotJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _catalog;
        private DateTime? _createdAt;
        private string _engagementId;
        private string _id;
        private string _lastFailure;
        private DateTime? _lastSuccessfulExecutionDate;
        private string _resourceArn;
        private string _resourceId;
        private string _resourceSnapshotTemplateName;
        private ResourceType _resourceType;
        private ResourceSnapshotJobStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot job. This globally unique identifier
        /// can be used for resource-specific operations across AWS services. 
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
        /// The catalog in which the snapshot job was created. This will match the Catalog specified
        /// in the request. 
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
        /// The date and time when the snapshot job was created in ISO 8601 format (UTC). Example:
        /// "2023-05-01T20:37:46Z" 
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
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The identifier of the engagement associated with this snapshot job. This links the
        /// job to a specific engagement context. 
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the snapshot job. This matches the ResourceSnapshotJobIdentifier
        /// provided in the request. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastFailure. 
        /// <para>
        /// If the job has encountered any failures, this field contains the error message from
        /// the most recent failure. This can be useful for troubleshooting issues with the job.
        /// 
        /// </para>
        /// </summary>
        public string LastFailure
        {
            get { return this._lastFailure; }
            set { this._lastFailure = value; }
        }

        // Check to see if LastFailure property is set
        internal bool IsSetLastFailure()
        {
            return this._lastFailure != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulExecutionDate. 
        /// <para>
        /// The date and time of the last successful execution of the job, in ISO 8601 format
        /// (UTC). Example: "2023-05-01T20:37:46Z" 
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulExecutionDate
        {
            get { return this._lastSuccessfulExecutionDate; }
            set { this._lastSuccessfulExecutionDate = value; }
        }

        // Check to see if LastSuccessfulExecutionDate property is set
        internal bool IsSetLastSuccessfulExecutionDate()
        {
            return this._lastSuccessfulExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource being snapshotted. This provides a
        /// globally unique identifier for the resource across AWS. 
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the specific resource being snapshotted. The format might vary depending
        /// on the ResourceType. 
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
        /// The name of the template used for creating the snapshot. This is the same as the template
        /// name. It defines the structure and content of the snapshot.
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
        /// The type of resource being snapshotted. This would have "Opportunity" as a value as
        /// it is dependent on the supported resource type.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the snapshot job. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// STOPPED: The job is not currently running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING: The job is actively executing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceSnapshotJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}