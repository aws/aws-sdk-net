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
    /// This is the response object from the GetUploadJob operation.
    /// </summary>
    public partial class GetUploadJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the upload job was completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the upload job was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataExpiry. 
        /// <para>
        /// The expiry duration for the profiles ingested with the upload job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1098)]
        public int? DataExpiry { get; set; }

        /// <summary>
        /// Checks to see if the DataExpiry property is set.
        /// </summary>
        internal bool IsSetDataExpiry() => this.DataExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The unique name of the upload job. Could be a file name to identify the upload job.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The mapping between CSV Columns and Profile Object attributes for the upload job.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, ObjectTypeField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the upload job. 
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property ResultsSummary. 
        /// <para>
        /// The summary of results for the upload job, including the number of updated, created,
        /// and failed records. 
        /// </para>
        /// </summary>
        public ResultsSummary ResultsSummary { get; set; }

        /// <summary>
        /// Checks to see if the ResultsSummary property is set.
        /// </summary>
        internal bool IsSetResultsSummary() => this.ResultsSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status describing the status for the upload job. The following are Valid Values:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CREATED</b>: The upload job has been created, but has not started processing yet.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IN_PROGRESS</b>: The upload job is currently in progress, ingesting and processing
        /// the profile data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PARTIALLY_SUCCEEDED</b>: The upload job has successfully completed the ingestion
        /// and processing of all profile data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCEEDED</b>: The upload job has successfully completed the ingestion and processing
        /// of all profile data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>: The upload job has failed to complete. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STOPPED</b>: The upload job has been manually stopped or terminated before completion.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UploadJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the upload job. Possible reasons: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>VALIDATION_FAILURE</b>: The upload job has encountered an error or issue and was
        /// unable to complete the profile data ingestion. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERNAL_FAILURE</b>: Failure caused from service side 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UniqueKey. 
        /// <para>
        /// The unique key columns used for de-duping the keys in the upload job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// Checks to see if the UniqueKey property is set.
        /// </summary>
        internal bool IsSetUniqueKey() => this.UniqueKey != null;
    }
}
