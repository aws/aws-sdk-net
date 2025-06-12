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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the SetStatus operation.
    /// Requests that the status of the specified physical or logical pipeline objects be
    /// updated in the specified pipeline. This update might not occur immediately, but is
    /// eventually consistent. The status that can be set depends on the type of object (for
    /// example, DataNode or Activity). You cannot perform this operation on <c>FINISHED</c>
    /// pipelines and attempting to do so returns <c>InvalidRequestException</c>.
    /// </summary>
    public partial class SetStatusRequest : AmazonDataPipelineRequest
    {
        private List<string> _objectIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _pipelineId;
        private string _status;

        /// <summary>
        /// Gets and sets the property ObjectIds. 
        /// <para>
        /// The IDs of the objects. The corresponding objects can be either physical or components,
        /// but not a mix of both types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ObjectIds
        {
            get { return this._objectIds; }
            set { this._objectIds = value; }
        }

        // Check to see if ObjectIds property is set
        internal bool IsSetObjectIds()
        {
            return this._objectIds != null && (this._objectIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline that contains the objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string PipelineId
        {
            get { return this._pipelineId; }
            set { this._pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this._pipelineId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to be set on all the objects specified in <c>objectIds</c>. For components,
        /// use <c>PAUSE</c> or <c>RESUME</c>. For instances, use <c>TRY_CANCEL</c>, <c>RERUN</c>,
        /// or <c>MARK_FINISHED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Status
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