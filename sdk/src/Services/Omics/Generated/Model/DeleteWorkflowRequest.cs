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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkflow operation.
    /// Deletes a workflow by specifying its ID. No response is returned if the deletion is
    /// successful.
    /// 
    ///  
    /// <para>
    /// To verify that the workflow is deleted:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <c>ListWorkflows</c> to confirm the workflow no longer appears in the list.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>GetWorkflow</c> to verify the workflow cannot be found.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteWorkflowRequest : AmazonOmicsRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The workflow's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}