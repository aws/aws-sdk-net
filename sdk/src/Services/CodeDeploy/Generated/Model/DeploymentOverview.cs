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
    /// Information about the deployment status of the instances in the deployment.
    /// </summary>
    public partial class DeploymentOverview
    {
        private long? _failed;
        private long? _inProgress;
        private long? _pending;
        private long? _ready;
        private long? _skipped;
        private long? _succeeded;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of instances in the deployment in a failed state.
        /// </para>
        /// </summary>
        public long? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        /// The number of instances in which the deployment is in progress.
        /// </para>
        /// </summary>
        public long? InProgress
        {
            get { return this._inProgress; }
            set { this._inProgress = value; }
        }

        // Check to see if InProgress property is set
        internal bool IsSetInProgress()
        {
            return this._inProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of instances in the deployment in a pending state.
        /// </para>
        /// </summary>
        public long? Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ready. 
        /// <para>
        /// The number of instances in a replacement environment ready to receive traffic in a
        /// blue/green deployment.
        /// </para>
        /// </summary>
        public long? Ready
        {
            get { return this._ready; }
            set { this._ready = value; }
        }

        // Check to see if Ready property is set
        internal bool IsSetReady()
        {
            return this._ready.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of instances in the deployment in a skipped state.
        /// </para>
        /// </summary>
        public long? Skipped
        {
            get { return this._skipped; }
            set { this._skipped = value; }
        }

        // Check to see if Skipped property is set
        internal bool IsSetSkipped()
        {
            return this._skipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The number of instances in the deployment to which revisions have been successfully
        /// deployed.
        /// </para>
        /// </summary>
        public long? Succeeded
        {
            get { return this._succeeded; }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded.HasValue; 
        }

    }
}