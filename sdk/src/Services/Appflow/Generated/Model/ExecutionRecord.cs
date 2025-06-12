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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies information about the past flow run instances for a given flow.
    /// </summary>
    public partial class ExecutionRecord
    {
        private DateTime? _dataPullEndTime;
        private DateTime? _dataPullStartTime;
        private string _executionId;
        private ExecutionResult _executionResult;
        private ExecutionStatus _executionStatus;
        private DateTime? _lastUpdatedAt;
        private List<MetadataCatalogDetail> _metadataCatalogDetails = AWSConfigs.InitializeCollections ? new List<MetadataCatalogDetail>() : null;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property DataPullEndTime. 
        /// <para>
        ///  The timestamp that indicates the last new or updated record to be transferred in
        /// the flow run. 
        /// </para>
        /// </summary>
        public DateTime? DataPullEndTime
        {
            get { return this._dataPullEndTime; }
            set { this._dataPullEndTime = value; }
        }

        // Check to see if DataPullEndTime property is set
        internal bool IsSetDataPullEndTime()
        {
            return this._dataPullEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataPullStartTime. 
        /// <para>
        ///  The timestamp that determines the first new or updated record to be transferred in
        /// the flow run. 
        /// </para>
        /// </summary>
        public DateTime? DataPullStartTime
        {
            get { return this._dataPullStartTime; }
            set { this._dataPullStartTime = value; }
        }

        // Check to see if DataPullStartTime property is set
        internal bool IsSetDataPullStartTime()
        {
            return this._dataPullStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        ///  Specifies the identifier of the given flow run. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionResult. 
        /// <para>
        ///  Describes the result of the given flow run. 
        /// </para>
        /// </summary>
        public ExecutionResult ExecutionResult
        {
            get { return this._executionResult; }
            set { this._executionResult = value; }
        }

        // Check to see if ExecutionResult property is set
        internal bool IsSetExecutionResult()
        {
            return this._executionResult != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  Specifies the flow run status and whether it is in progress, has completed successfully,
        /// or has failed. 
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  Specifies the time of the most recent update. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataCatalogDetails. 
        /// <para>
        /// Describes the metadata catalog, metadata table, and data partitions that Amazon AppFlow
        /// used for the associated flow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataCatalogDetail> MetadataCatalogDetails
        {
            get { return this._metadataCatalogDetails; }
            set { this._metadataCatalogDetails = value; }
        }

        // Check to see if MetadataCatalogDetails property is set
        internal bool IsSetMetadataCatalogDetails()
        {
            return this._metadataCatalogDetails != null && (this._metadataCatalogDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        ///  Specifies the start time of the flow run. 
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}