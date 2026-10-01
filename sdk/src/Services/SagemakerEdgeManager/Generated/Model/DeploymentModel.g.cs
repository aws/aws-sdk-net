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

namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// </summary>
    public partial class DeploymentModel
    {
        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The desired state of the model.
        /// </para>
        /// </summary>
        public ModelState DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

        /// <summary>
        /// Gets and sets the property ModelHandle. 
        /// <para>
        /// The unique handle of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelHandle { get; set; }

        /// <summary>
        /// Checks to see if the ModelHandle property is set.
        /// </summary>
        internal bool IsSetModelHandle() => this.ModelHandle != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 255)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion != null;

        /// <summary>
        /// Gets and sets the property RollbackFailureReason. 
        /// <para>
        /// Returns the error message if there is a rollback.
        /// </para>
        /// </summary>
        public string RollbackFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the RollbackFailureReason property is set.
        /// </summary>
        internal bool IsSetRollbackFailureReason() => this.RollbackFailureReason != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Returns the current state of the model.
        /// </para>
        /// </summary>
        public ModelState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Returns the deployment status of the model.
        /// </para>
        /// </summary>
        public DeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Returns the error message for the deployment status result.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
