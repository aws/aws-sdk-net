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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information summarizing an edge deployment plan.
    /// </summary>
    public partial class EdgeDeploymentPlanSummary
    {
        private DateTime? _creationTime;
        private string _deviceFleetName;
        private int? _edgeDeploymentFailed;
        private int? _edgeDeploymentPending;
        private string _edgeDeploymentPlanArn;
        private string _edgeDeploymentPlanName;
        private int? _edgeDeploymentSuccess;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the edge deployment plan was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the device fleet used for the deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentFailed. 
        /// <para>
        /// The number of edge devices that failed the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentFailed
        {
            get { return this._edgeDeploymentFailed; }
            set { this._edgeDeploymentFailed = value; }
        }

        // Check to see if EdgeDeploymentFailed property is set
        internal bool IsSetEdgeDeploymentFailed()
        {
            return this._edgeDeploymentFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPending. 
        /// <para>
        /// The number of edge devices yet to pick up the deployment, or in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentPending
        {
            get { return this._edgeDeploymentPending; }
            set { this._edgeDeploymentPending = value; }
        }

        // Check to see if EdgeDeploymentPending property is set
        internal bool IsSetEdgeDeploymentPending()
        {
            return this._edgeDeploymentPending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanArn. 
        /// <para>
        /// The ARN of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EdgeDeploymentPlanArn
        {
            get { return this._edgeDeploymentPlanArn; }
            set { this._edgeDeploymentPlanArn = value; }
        }

        // Check to see if EdgeDeploymentPlanArn property is set
        internal bool IsSetEdgeDeploymentPlanArn()
        {
            return this._edgeDeploymentPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeDeploymentPlanName
        {
            get { return this._edgeDeploymentPlanName; }
            set { this._edgeDeploymentPlanName = value; }
        }

        // Check to see if EdgeDeploymentPlanName property is set
        internal bool IsSetEdgeDeploymentPlanName()
        {
            return this._edgeDeploymentPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentSuccess. 
        /// <para>
        /// The number of edge devices with the successful deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentSuccess
        {
            get { return this._edgeDeploymentSuccess; }
            set { this._edgeDeploymentSuccess = value; }
        }

        // Check to see if EdgeDeploymentSuccess property is set
        internal bool IsSetEdgeDeploymentSuccess()
        {
            return this._edgeDeploymentSuccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the edge deployment plan was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}