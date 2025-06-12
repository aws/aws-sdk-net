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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the <c>WorkflowDetail</c> data type. It is used by actions that trigger
    /// a workflow to begin execution.
    /// </summary>
    public partial class WorkflowDetails
    {
        private List<WorkflowDetail> _onPartialUpload = AWSConfigs.InitializeCollections ? new List<WorkflowDetail>() : null;
        private List<WorkflowDetail> _onUpload = AWSConfigs.InitializeCollections ? new List<WorkflowDetail>() : null;

        /// <summary>
        /// Gets and sets the property OnPartialUpload. 
        /// <para>
        /// A trigger that starts a workflow if a file is only partially uploaded. You can attach
        /// a workflow to a server that executes whenever there is a partial upload.
        /// </para>
        ///  
        /// <para>
        /// A <i>partial upload</i> occurs when a file is open when the session disconnects.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>OnPartialUpload</c> can contain a maximum of one <c>WorkflowDetail</c> object.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<WorkflowDetail> OnPartialUpload
        {
            get { return this._onPartialUpload; }
            set { this._onPartialUpload = value; }
        }

        // Check to see if OnPartialUpload property is set
        internal bool IsSetOnPartialUpload()
        {
            return this._onPartialUpload != null && (this._onPartialUpload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnUpload. 
        /// <para>
        /// A trigger that starts a workflow: the workflow begins to execute after a file is uploaded.
        /// </para>
        ///  
        /// <para>
        /// To remove an associated workflow from a server, you can provide an empty <c>OnUpload</c>
        /// object, as in the following example.
        /// </para>
        ///  
        /// <para>
        ///  <c>aws transfer update-server --server-id s-01234567890abcdef --workflow-details
        /// '{"OnUpload":[]}'</c> 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>OnUpload</c> can contain a maximum of one <c>WorkflowDetail</c> object.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<WorkflowDetail> OnUpload
        {
            get { return this._onUpload; }
            set { this._onUpload = value; }
        }

        // Check to see if OnUpload property is set
        internal bool IsSetOnUpload()
        {
            return this._onUpload != null && (this._onUpload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}