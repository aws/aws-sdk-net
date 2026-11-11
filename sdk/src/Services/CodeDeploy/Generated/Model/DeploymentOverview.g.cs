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
    /// Information about the deployment status of the instances in the deployment.
    /// </summary>
    public partial class DeploymentOverview
    {
        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of instances in the deployment in a failed state.
        /// </para>
        /// </summary>
        public long? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        /// The number of instances in which the deployment is in progress.
        /// </para>
        /// </summary>
        public long? InProgress { get; set; }

        /// <summary>
        /// Checks to see if the InProgress property is set.
        /// </summary>
        internal bool IsSetInProgress() => this.InProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of instances in the deployment in a pending state.
        /// </para>
        /// </summary>
        public long? Pending { get; set; }

        /// <summary>
        /// Checks to see if the Pending property is set.
        /// </summary>
        internal bool IsSetPending() => this.Pending.HasValue;

        /// <summary>
        /// Gets and sets the property Ready. 
        /// <para>
        /// The number of instances in a replacement environment ready to receive traffic in a
        /// blue/green deployment.
        /// </para>
        /// </summary>
        public long? Ready { get; set; }

        /// <summary>
        /// Checks to see if the Ready property is set.
        /// </summary>
        internal bool IsSetReady() => this.Ready.HasValue;

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of instances in the deployment in a skipped state.
        /// </para>
        /// </summary>
        public long? Skipped { get; set; }

        /// <summary>
        /// Checks to see if the Skipped property is set.
        /// </summary>
        internal bool IsSetSkipped() => this.Skipped.HasValue;

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The number of instances in the deployment to which revisions have been successfully
        /// deployed.
        /// </para>
        /// </summary>
        public long? Succeeded { get; set; }

        /// <summary>
        /// Checks to see if the Succeeded property is set.
        /// </summary>
        internal bool IsSetSucceeded() => this.Succeeded.HasValue;
    }
}
