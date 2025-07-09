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
    /// This is the response object from the GetUploadJob operation.
    /// </summary>
    public partial class GetUploadJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private int? _dataExpiry;
        private string _displayName;
        private Dictionary<string, ObjectTypeField> _fields = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;
        private string _jobId;
        private ResultsSummary _resultsSummary;
        private UploadJobStatus _status;
        private StatusReason _statusReason;
        private string _uniqueKey;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp when the upload job was completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the upload job was created. 
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
        /// Gets and sets the property DataExpiry. 
        /// <para>
        /// The expiry duration for the profiles ingested with the upload job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1098)]
        public int? DataExpiry
        {
            get { return this._dataExpiry; }
            set { this._dataExpiry = value; }
        }

        // Check to see if DataExpiry property is set
        internal bool IsSetDataExpiry()
        {
            return this._dataExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The unique name of the upload job. Could be a file name to identify the upload job.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The mapping between CSV Columns and Profile Object attributes for the upload job.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, ObjectTypeField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the upload job. 
        /// </para>
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultsSummary. 
        /// <para>
        /// The summary of results for the upload job, including the number of updated, created,
        /// and failed records. 
        /// </para>
        /// </summary>
        public ResultsSummary ResultsSummary
        {
            get { return this._resultsSummary; }
            set { this._resultsSummary = value; }
        }

        // Check to see if ResultsSummary property is set
        internal bool IsSetResultsSummary()
        {
            return this._resultsSummary != null;
        }

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
        public UploadJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public StatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueKey. 
        /// <para>
        /// The unique key columns used for de-duping the keys in the upload job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string UniqueKey
        {
            get { return this._uniqueKey; }
            set { this._uniqueKey = value; }
        }

        // Check to see if UniqueKey property is set
        internal bool IsSetUniqueKey()
        {
            return this._uniqueKey != null;
        }

    }
}