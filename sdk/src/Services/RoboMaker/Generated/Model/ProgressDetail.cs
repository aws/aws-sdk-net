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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about the progress of a deployment job.
    /// </summary>
    public partial class ProgressDetail
    {
        private RobotDeploymentStep _currentProgress;
        private int? _estimatedTimeRemainingSeconds;
        private float? _percentDone;
        private string _targetResource;

        /// <summary>
        /// Gets and sets the property CurrentProgress. 
        /// <para>
        /// The current progress status.
        /// </para>
        ///  <dl> <dt>Validating</dt> <dd> 
        /// <para>
        /// Validating the deployment.
        /// </para>
        ///  </dd> <dt>DownloadingExtracting</dt> <dd> 
        /// <para>
        /// Downloading and extracting the bundle on the robot.
        /// </para>
        ///  </dd> <dt>ExecutingPreLaunch</dt> <dd> 
        /// <para>
        /// Executing pre-launch script(s) if provided.
        /// </para>
        ///  </dd> <dt>Launching</dt> <dd> 
        /// <para>
        /// Launching the robot application.
        /// </para>
        ///  </dd> <dt>ExecutingPostLaunch</dt> <dd> 
        /// <para>
        /// Executing post-launch script(s) if provided.
        /// </para>
        ///  </dd> <dt>Finished</dt> <dd> 
        /// <para>
        /// Deployment is complete.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public RobotDeploymentStep CurrentProgress
        {
            get { return this._currentProgress; }
            set { this._currentProgress = value; }
        }

        // Check to see if CurrentProgress property is set
        internal bool IsSetCurrentProgress()
        {
            return this._currentProgress != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingSeconds. 
        /// <para>
        /// Estimated amount of time in seconds remaining in the step. This currently only applies
        /// to the <c>Downloading/Extracting</c> step of the deployment. It is empty for other
        /// steps.
        /// </para>
        /// </summary>
        public int? EstimatedTimeRemainingSeconds
        {
            get { return this._estimatedTimeRemainingSeconds; }
            set { this._estimatedTimeRemainingSeconds = value; }
        }

        // Check to see if EstimatedTimeRemainingSeconds property is set
        internal bool IsSetEstimatedTimeRemainingSeconds()
        {
            return this._estimatedTimeRemainingSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentDone. 
        /// <para>
        /// Precentage of the step that is done. This currently only applies to the <c>Downloading/Extracting</c>
        /// step of the deployment. It is empty for other steps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? PercentDone
        {
            get { return this._percentDone; }
            set { this._percentDone = value; }
        }

        // Check to see if PercentDone property is set
        internal bool IsSetPercentDone()
        {
            return this._percentDone.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}