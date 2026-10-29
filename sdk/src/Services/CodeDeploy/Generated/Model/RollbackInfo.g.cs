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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property RollbackDeploymentId. 
        /// <para>
        /// The ID of the deployment rollback.
        /// </para>
        /// </summary>
        public string RollbackDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the RollbackDeploymentId property is set.
        /// </summary>
        internal bool IsSetRollbackDeploymentId() => this.RollbackDeploymentId != null;

        /// <summary>
        /// Gets and sets the property RollbackMessage. 
        /// <para>
        /// Information that describes the status of a deployment rollback (for example, whether
        /// the deployment can't be rolled back, is in progress, failed, or succeeded). 
        /// </para>
        /// </summary>
        public string RollbackMessage { get; set; }

        /// <summary>
        /// Checks to see if the RollbackMessage property is set.
        /// </summary>
        internal bool IsSetRollbackMessage() => this.RollbackMessage != null;

        /// <summary>
        /// Gets and sets the property RollbackTriggeringDeploymentId. 
        /// <para>
        /// The deployment ID of the deployment that was underway and triggered a rollback deployment
        /// because it failed or was stopped.
        /// </para>
        /// </summary>
        public string RollbackTriggeringDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the RollbackTriggeringDeploymentId property is set.
        /// </summary>
        internal bool IsSetRollbackTriggeringDeploymentId() => this.RollbackTriggeringDeploymentId != null;
    }
}
