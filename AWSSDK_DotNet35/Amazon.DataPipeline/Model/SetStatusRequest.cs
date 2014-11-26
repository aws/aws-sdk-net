/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the SetStatus operation.
    /// Requests that the status of an array of physical or logical pipeline objects be updated
    /// in the pipeline. This update may not occur immediately, but is eventually consistent.
    /// The status that can be set depends on the type of object, e.g. DataNode or Activity.
    /// You cannot perform this operation on FINISHED pipelines and attempting to do so will
    /// return an InvalidRequestException.
    /// </summary>
    public partial class SetStatusRequest : AmazonDataPipelineRequest
    {
        private List<string> _objectIds = new List<string>();
        private string _pipelineId;
        private string _status;

        /// <summary>
        /// Gets and sets the property ObjectIds. 
        /// <para>
        /// Identifies an array of objects. The corresponding objects can be either physical or
        /// components, but not a mix of both types.
        /// </para>
        /// </summary>
        public List<string> ObjectIds
        {
            get { return this._objectIds; }
            set { this._objectIds = value; }
        }

        // Check to see if ObjectIds property is set
        internal bool IsSetObjectIds()
        {
            return this._objectIds != null && this._objectIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// Identifies the pipeline that contains the objects.
        /// </para>
        /// </summary>
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
        /// Specifies the status to be set on all the objects in <code>objectIds</code>. For components,
        /// this can be either <code>PAUSE</code> or <code>RESUME</code>. For instances, this
        /// can be either <code>CANCEL</code>, <code>RERUN</code>, or <code>MARK_FINISHED</code>.
        /// </para>
        /// </summary>
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