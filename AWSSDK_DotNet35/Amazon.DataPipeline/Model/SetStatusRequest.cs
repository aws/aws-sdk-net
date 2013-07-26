/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Requests that the status of an array of physical or logical pipeline objects be updated in the pipeline. This update may not occur
    /// immediately, but is eventually consistent. The status that can be set depends on the type of object.</para>
    /// </summary>
    public partial class SetStatusRequest : AmazonWebServiceRequest
    {
        private string pipelineId;
        private List<string> objectIds = new List<string>();
        private string status;

        /// <summary>
        /// Identifies the pipeline that contains the objects.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PipelineId
        {
            get { return this.pipelineId; }
            set { this.pipelineId = value; }
        }

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// Identifies an array of objects. The corresponding objects can be either physical or components, but not a mix of both types.
        ///  
        /// </summary>
        public List<string> ObjectIds
        {
            get { return this.objectIds; }
            set { this.objectIds = value; }
        }

        // Check to see if ObjectIds property is set
        internal bool IsSetObjectIds()
        {
            return this.objectIds.Count > 0;
        }

        /// <summary>
        /// Specifies the status to be set on all the objects in <c>objectIds</c>. For components, this can be either <c>PAUSE</c> or <c>RESUME</c>. For
        /// instances, this can be either <c>CANCEL</c>, <c>RERUN</c>, or <c>MARK_FINISHED</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

    }
}
    
