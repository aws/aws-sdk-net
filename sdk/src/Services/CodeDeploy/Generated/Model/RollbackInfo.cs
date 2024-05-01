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
    /// Information about a deployment rollback.
    /// </summary>
    public partial class RollbackInfo
    {
        private string _rollbackDeploymentId;
        private string _rollbackMessage;
        private string _rollbackTriggeringDeploymentId;

        /// <summary>
        /// Gets and sets the property RollbackDeploymentId. 
        /// <para>
        /// The ID of the deployment rollback.
        /// </para>
        /// </summary>
        public string RollbackDeploymentId
        {
            get { return this._rollbackDeploymentId; }
            set { this._rollbackDeploymentId = value; }
        }

        // Check to see if RollbackDeploymentId property is set
        internal bool IsSetRollbackDeploymentId()
        {
            return this._rollbackDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackMessage. 
        /// <para>
        /// Information that describes the status of a deployment rollback (for example, whether
        /// the deployment can't be rolled back, is in progress, failed, or succeeded). 
        /// </para>
        /// </summary>
        public string RollbackMessage
        {
            get { return this._rollbackMessage; }
            set { this._rollbackMessage = value; }
        }

        // Check to see if RollbackMessage property is set
        internal bool IsSetRollbackMessage()
        {
            return this._rollbackMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackTriggeringDeploymentId. 
        /// <para>
        /// The deployment ID of the deployment that was underway and triggered a rollback deployment
        /// because it failed or was stopped.
        /// </para>
        /// </summary>
        public string RollbackTriggeringDeploymentId
        {
            get { return this._rollbackTriggeringDeploymentId; }
            set { this._rollbackTriggeringDeploymentId = value; }
        }

        // Check to see if RollbackTriggeringDeploymentId property is set
        internal bool IsSetRollbackTriggeringDeploymentId()
        {
            return this._rollbackTriggeringDeploymentId != null;
        }

    }
}