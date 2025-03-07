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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetExecutionPreview operation.
    /// Initiates the process of retrieving an existing preview that shows the effects that
    /// running a specified Automation runbook would have on the targeted resources.
    /// </summary>
    public partial class GetExecutionPreviewRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _executionPreviewId;

        /// <summary>
        /// Gets and sets the property ExecutionPreviewId. 
        /// <para>
        /// The ID of the existing execution preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ExecutionPreviewId
        {
            get { return this._executionPreviewId; }
            set { this._executionPreviewId = value; }
        }

        // Check to see if ExecutionPreviewId property is set
        internal bool IsSetExecutionPreviewId()
        {
            return this._executionPreviewId != null;
        }

    }
}