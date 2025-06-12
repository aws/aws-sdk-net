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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Summary information for an OpenSearch Ingestion pipeline.
    /// </summary>
    public partial class PipelineSummary
    {
        private DateTime? _createdAt;
        private List<PipelineDestination> _destinations = AWSConfigs.InitializeCollections ? new List<PipelineDestination>() : null;
        private DateTime? _lastUpdatedAt;
        private int? _maxUnits;
        private int? _minUnits;
        private string _pipelineArn;
        private string _pipelineName;
        private PipelineStatus _status;
        private PipelineStatusReason _statusReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the pipeline was created.
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
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of destinations to which the pipeline writes data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the pipeline was last updated.
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
        /// Gets and sets the property MaxUnits. 
        /// <para>
        /// The maximum pipeline capacity, in Ingestion Compute Units (ICUs).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxUnits
        {
            get { return this._maxUnits; }
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
        [AWSProperty(Min=1)]
        public int? MinUnits
        {
            get { return this._minUnits; }
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
        [AWSProperty(Min=46, Max=76)]
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
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the given pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}