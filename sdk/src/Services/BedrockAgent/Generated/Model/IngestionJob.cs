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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the information of an ingestion job.
    /// </summary>
    public partial class IngestionJob
    {
        private string _dataSourceId;
        private string _description;
        private List<string> _failureReasons = new List<string>();
        private string _ingestionJobId;
        private string _knowledgeBaseId;
        private DateTime? _startedAt;
        private IngestionJobStatistics _statistics;
        private IngestionJobStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property DataSourceId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasons.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && this._failureReasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IngestionJobId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string IngestionJobId
        {
            get { return this._ingestionJobId; }
            set { this._ingestionJobId = value; }
        }

        // Check to see if IngestionJobId property is set
        internal bool IsSetIngestionJobId()
        {
            return this._ingestionJobId != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt.
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Statistics.
        /// </summary>
        public IngestionJobStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestionJobStatus Status
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
        /// Gets and sets the property UpdatedAt.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}