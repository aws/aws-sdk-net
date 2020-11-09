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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePipeline operation.
    /// Creates a pipeline. A pipeline consumes messages from a channel and allows you to
    /// process the messages before storing them in a data store. You must specify both a
    /// <code>channel</code> and a <code>datastore</code> activity and, optionally, as many
    /// as 23 additional activities in the <code>pipelineActivities</code> array.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonIoTAnalyticsRequest
    {
        private List<PipelineActivity> _pipelineActivities = new List<PipelineActivity>();
        private string _pipelineName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property PipelineActivities. 
        /// <para>
        /// A list of <code>PipelineActivity</code> objects. Activities perform transformations
        /// on your messages, such as removing, renaming or adding message attributes; filtering
        /// messages based on attribute values; invoking your Lambda functions on messages for
        /// advanced processing; or performing mathematical transformations to normalize device
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The list can be 2-25 <code>PipelineActivity</code> objects and must contain both a
        /// <code>channel</code> and a <code>datastore</code> activity. Each entry in the list
        /// must contain only one activity. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>pipelineActivities = [ { "channel": { ... } }, { "lambda": { ... } }, ... ]</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<PipelineActivity> PipelineActivities
        {
            get { return this._pipelineActivities; }
            set { this._pipelineActivities = value; }
        }

        // Check to see if PipelineActivities property is set
        internal bool IsSetPipelineActivities()
        {
            return this._pipelineActivities != null && this._pipelineActivities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}