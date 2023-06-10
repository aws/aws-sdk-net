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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Information about an existing OpenSearch Ingestion pipeline.
    /// </summary>
    public partial class Pipeline
    {
        private DateTime? _createdAt;
        private List<string> _ingestEndpointUrls = new List<string>();
        private DateTime? _lastUpdatedAt;
        private LogPublishingOptions _logPublishingOptions;
        private int? _maxUnits;
        private int? _minUnits;
        private string _pipelineArn;
        private string _pipelineConfigurationBody;
        private string _pipelineName;
        private PipelineStatus _status;
        private PipelineStatusReason _statusReason;
        private List<VpcEndpoint> _vpcEndpoints = new List<VpcEndpoint>();

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the pipeline was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestEndpointUrls. 
        /// <para>
        /// The ingestion endpoints for the pipeline, which you can send data to.
        /// </para>
        /// </summary>
        public List<string> IngestEndpointUrls
        {
            get { return this._ingestEndpointUrls; }
            set { this._ingestEndpointUrls = value; }
        }

        // Check to see if IngestEndpointUrls property is set
        internal bool IsSetIngestEndpointUrls()
        {
            return this._ingestEndpointUrls != null && this._ingestEndpointUrls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the pipeline was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogPublishingOptions. 
        /// <para>
        /// Key-value pairs that represent log publishing settings.
        /// </para>
        /// </summary>
        public LogPublishingOptions LogPublishingOptions
        {
            get { return this._logPublishingOptions; }
            set { this._logPublishingOptions = value; }
        }

        // Check to see if LogPublishingOptions property is set
        internal bool IsSetLogPublishingOptions()
        {
            return this._logPublishingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MaxUnits. 
        /// <para>
        /// The maximum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        public int MaxUnits
        {
            get { return this._maxUnits.GetValueOrDefault(); }
            set { this._maxUnits = value; }
        }

        // Check to see if MaxUnits property is set
        internal bool IsSetMaxUnits()
        {
            return this._maxUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinUnits. 
        /// <para>
        /// The minimum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        public int MinUnits
        {
            get { return this._minUnits.GetValueOrDefault(); }
            set { this._minUnits = value; }
        }

        // Check to see if MinUnits property is set
        internal bool IsSetMinUnits()
        {
            return this._minUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineConfigurationBody. 
        /// <para>
        /// The Data Prepper pipeline configuration in YAML format.
        /// </para>
        /// </summary>
        public string PipelineConfigurationBody
        {
            get { return this._pipelineConfigurationBody; }
            set { this._pipelineConfigurationBody = value; }
        }

        // Check to see if PipelineConfigurationBody property is set
        internal bool IsSetPipelineConfigurationBody()
        {
            return this._pipelineConfigurationBody != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pipeline.
        /// </para>
        /// </summary>
        public PipelineStatus Status
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
        /// The reason for the current status of the pipeline.
        /// </para>
        /// </summary>
        public PipelineStatusReason StatusReason
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
        /// Gets and sets the property VpcEndpoints. 
        /// <para>
        /// The VPC interface endpoints that have access to the pipeline.
        /// </para>
        /// </summary>
        public List<VpcEndpoint> VpcEndpoints
        {
            get { return this._vpcEndpoints; }
            set { this._vpcEndpoints = value; }
        }

        // Check to see if VpcEndpoints property is set
        internal bool IsSetVpcEndpoints()
        {
            return this._vpcEndpoints != null && this._vpcEndpoints.Count > 0; 
        }

    }
}