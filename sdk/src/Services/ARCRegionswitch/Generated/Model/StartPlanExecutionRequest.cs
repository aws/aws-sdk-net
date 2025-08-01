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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Container for the parameters to the StartPlanExecution operation.
    /// Starts the execution of a Region switch plan. You can execute a plan in either PRACTICE
    /// or RECOVERY mode.
    /// 
    ///  
    /// <para>
    /// In PRACTICE mode, the execution simulates the steps without making actual changes
    /// to your application's traffic routing. In RECOVERY mode, the execution performs actual
    /// changes to shift traffic between Regions.
    /// </para>
    /// </summary>
    public partial class StartPlanExecutionRequest : AmazonARCRegionswitchRequest
    {
        private ExecutionAction _action;
        private string _comment;
        private string _latestVersion;
        private ExecutionMode _mode;
        private string _planArn;
        private string _targetRegion;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform. Valid values are ACTIVATE (to shift traffic to the target Region)
        /// or DEACTIVATE (to shift traffic away from the target Region).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment explaining why the plan execution is being started.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// A boolean value indicating whether to use the latest version of the plan. If set to
        /// false, you must specify a specific version.
        /// </para>
        /// </summary>
        public string LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The plan execution mode. Valid values are <c>Practice</c>, for testing without making
        /// actual changes, or <c>Recovery</c>, for actual traffic shifting and application recovery.
        /// </para>
        /// </summary>
        public ExecutionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property PlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the plan to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanArn
        {
            get { return this._planArn; }
            set { this._planArn = value; }
        }

        // Check to see if PlanArn property is set
        internal bool IsSetPlanArn()
        {
            return this._planArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The Amazon Web Services Region to target with this execution. This is the Region that
        /// traffic will be shifted to or from, depending on the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetRegion
        {
            get { return this._targetRegion; }
            set { this._targetRegion = value; }
        }

        // Check to see if TargetRegion property is set
        internal bool IsSetTargetRegion()
        {
            return this._targetRegion != null;
        }

    }
}