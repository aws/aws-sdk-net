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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkflow operation.
    /// </summary>
    public partial class CreateWorkflowResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private string _workflowBuildVersionArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that uniquely identifies the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow resource that the request created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkflowBuildVersionArn
        {
            get { return this._workflowBuildVersionArn; }
            set { this._workflowBuildVersionArn = value; }
        }

        // Check to see if WorkflowBuildVersionArn property is set
        internal bool IsSetWorkflowBuildVersionArn()
        {
            return this._workflowBuildVersionArn != null;
        }

    }
}