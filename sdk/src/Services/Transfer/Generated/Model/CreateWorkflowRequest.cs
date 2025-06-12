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
    /// Container for the parameters to the CreateWorkflow operation.
    /// Allows you to create a workflow with specified steps and step details the workflow
    /// invokes after file transfer completes. After creating a workflow, you can associate
    /// the workflow created with any transfer servers by specifying the <c>workflow-details</c>
    /// field in <c>CreateServer</c> and <c>UpdateServer</c> operations.
    /// </summary>
    public partial class CreateWorkflowRequest : AmazonTransferRequest
    {
        private string _description;
        private List<WorkflowStep> _onExceptionSteps = AWSConfigs.InitializeCollections ? new List<WorkflowStep>() : null;
        private List<WorkflowStep> _steps = AWSConfigs.InitializeCollections ? new List<WorkflowStep>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A textual description for the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property OnExceptionSteps. 
        /// <para>
        /// Specifies the steps (actions) to take if errors are encountered during execution of
        /// the workflow.
        /// </para>
        ///  <note> 
        /// <para>
        /// For custom steps, the Lambda function needs to send <c>FAILURE</c> to the call back
        /// API to kick off the exception steps. Additionally, if the Lambda does not send <c>SUCCESS</c>
        /// before it times out, the exception steps are executed.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public List<WorkflowStep> OnExceptionSteps
        {
            get { return this._onExceptionSteps; }
            set { this._onExceptionSteps = value; }
        }

        // Check to see if OnExceptionSteps property is set
        internal bool IsSetOnExceptionSteps()
        {
            return this._onExceptionSteps != null && (this._onExceptionSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// Specifies the details for the steps that are in the specified workflow.
        /// </para>
        ///  
        /// <para>
        ///  The <c>TYPE</c> specifies which of the following actions is being taken for this
        /// step. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>COPY</c> </b> - Copy the file to another location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>CUSTOM</c> </b> - Perform a custom step with an Lambda function target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DECRYPT</c> </b> - Decrypt a file that was encrypted before it was uploaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DELETE</c> </b> - Delete the file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>TAG</c> </b> - Add a tag to the file.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  Currently, copying and tagging are supported only on S3. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  For file location, you specify either the Amazon S3 bucket and key, or the Amazon
        /// EFS file system ID and path. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=8)]
        public List<WorkflowStep> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for workflows. Tags are metadata
        /// attached to workflows for any purpose.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}