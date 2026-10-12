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
    /// This is the response object from the GetResourceSnapshotJob operation.
    /// </summary>
    public partial class GetResourceSnapshotJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot job. This globally unique identifier
        /// can be used for resource-specific operations across AWS services. 
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
        /// The catalog in which the snapshot job was created. This will match the Catalog specified
        /// in the request. 
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
        /// The date and time when the snapshot job was created in ISO 8601 format (UTC). Example:
        /// "2023-05-01T20:37:46Z" 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The identifier of the engagement associated with this snapshot job. This links the
        /// job to a specific engagement context. 
        /// </para>
        /// </summary>
        public string EngagementId { get; set; }

        /// <summary>
        /// Checks to see if the EngagementId property is set.
        /// </summary>
        internal bool IsSetEngagementId() => this.EngagementId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the snapshot job. This matches the ResourceSnapshotJobIdentifier
        /// provided in the request. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastFailure. 
        /// <para>
        /// If the job has encountered any failures, this field contains the error message from
        /// the most recent failure. This can be useful for troubleshooting issues with the job.
        /// 
        /// </para>
        /// </summary>
        public string LastFailure { get; set; }

        /// <summary>
        /// Checks to see if the LastFailure property is set.
        /// </summary>
        internal bool IsSetLastFailure() => this.LastFailure != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulExecutionDate. 
        /// <para>
        /// The date and time of the last successful execution of the job, in ISO 8601 format
        /// (UTC). Example: "2023-05-01T20:37:46Z" 
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulExecutionDate { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulExecutionDate property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulExecutionDate() => this.LastSuccessfulExecutionDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource being snapshotted. This provides a
        /// globally unique identifier for the resource across AWS. 
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the specific resource being snapshotted. The format might vary depending
        /// on the ResourceType. 
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
        /// The name of the template used for creating the snapshot. This is the same as the template
        /// name. It defines the structure and content of the snapshot.
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
        /// The type of resource being snapshotted. This would have "Opportunity" as a value as
        /// it is dependent on the supported resource type.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

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
        public ResourceSnapshotJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
