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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecycleEventHookExecutionStatus operation.
    /// Sets the result of a Lambda validation function. The function validates one or both
    /// lifecycle events (<code>BeforeAllowTraffic</code> and <code>AfterAllowTraffic</code>)
    /// and returns <code>Succeeded</code> or <code>Failed</code>.
    /// </summary>
    public partial class PutLifecycleEventHookExecutionStatusRequest : AmazonCodeDeployRequest
    {
        private string _deploymentId;
        private string _lifecycleEventHookExecutionId;
        private LifecycleEventStatus _status;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. Pass this ID to a Lambda function that validates a
        /// deployment lifecycle event. 
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleEventHookExecutionId. 
        /// <para>
        ///  The execution ID of a deployment's lifecycle hook. A deployment lifecycle hook is
        /// specified in the <code>hooks</code> section of the AppSpec file. 
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result of a Lambda function that validates a deployment lifecycle event (<code>Succeeded</code>
        /// or <code>Failed</code>).
        /// </para>
        /// </summary>
        public LifecycleEventStatus Status
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