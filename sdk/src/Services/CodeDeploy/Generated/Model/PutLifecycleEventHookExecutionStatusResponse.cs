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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// This is the response object from the PutLifecycleEventHookExecutionStatus operation.
    /// </summary>
    public partial class PutLifecycleEventHookExecutionStatusResponse : AmazonWebServiceResponse
    {
        private string _lifecycleEventHookExecutionId;

        /// <summary>
        /// Gets and sets the property LifecycleEventHookExecutionId. 
        /// <para>
        /// The execution ID of the lifecycle event hook. A hook is specified in the <c>hooks</c>
        /// section of the deployment's AppSpec file.
        /// </para>
        /// </summary>
        public string LifecycleEventHookExecutionId
        {
            get { return this._lifecycleEventHookExecutionId; }
            set { this._lifecycleEventHookExecutionId = value; }
        }

        // Check to see if LifecycleEventHookExecutionId property is set
        internal bool IsSetLifecycleEventHookExecutionId()
        {
            return this._lifecycleEventHookExecutionId != null;
        }

    }
}