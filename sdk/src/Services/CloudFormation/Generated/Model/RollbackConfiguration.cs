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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Structure that contains the rollback triggers for CloudFormation to monitor during
    /// stack creation and updating operations, and for the specified monitoring period afterwards.
    /// 
    ///  
    /// <para>
    /// Rollback triggers enable you to have CloudFormation monitor the state of your application
    /// during stack creation and updating, and to roll back that operation if the application
    /// breaches the threshold of any of the alarms you've specified. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-rollback-triggers.html">Roll
    /// back your CloudFormation stack on alarm breach with rollback triggers</a>.
    /// </para>
    /// </summary>
    public partial class RollbackConfiguration
    {
        private int? _monitoringTimeInMinutes;
        private List<RollbackTrigger> _rollbackTriggers = AWSConfigs.InitializeCollections ? new List<RollbackTrigger>() : null;

        /// <summary>
        /// Gets and sets the property MonitoringTimeInMinutes. 
        /// <para>
        /// The amount of time, in minutes, during which CloudFormation should monitor all the
        /// rollback triggers after the stack creation or update operation deploys all necessary
        /// resources.
        /// </para>
        ///  
        /// <para>
        /// The default is 0 minutes.
        /// </para>
        ///  
        /// <para>
        /// If you specify a monitoring period but don't specify any rollback triggers, CloudFormation
        /// still waits the specified period of time before cleaning up old resources after update
        /// operations. You can use this monitoring period to perform any manual stack validation
        /// desired, and manually cancel the stack creation or update (using <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CancelUpdateStack.html">CancelUpdateStack</a>,
        /// for example) as necessary.
        /// </para>
        ///  
        /// <para>
        /// If you specify 0 for this parameter, CloudFormation still monitors the specified rollback
        /// triggers during stack creation and update operations. Then, for update operations,
        /// it begins disposing of old resources immediately once the operation completes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=180)]
        public int? MonitoringTimeInMinutes
        {
            get { return this._monitoringTimeInMinutes; }
            set { this._monitoringTimeInMinutes = value; }
        }

        // Check to see if MonitoringTimeInMinutes property is set
        internal bool IsSetMonitoringTimeInMinutes()
        {
            return this._monitoringTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RollbackTriggers. 
        /// <para>
        /// The triggers to monitor during stack creation or update actions.
        /// </para>
        ///  
        /// <para>
        /// By default, CloudFormation saves the rollback triggers specified for a stack and applies
        /// them to any subsequent update operations for the stack, unless you specify otherwise.
        /// If you do specify rollback triggers for this parameter, those triggers replace any
        /// list of triggers previously specified for the stack. This means:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To use the rollback triggers previously specified for this stack, if any, don't specify
        /// this parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To specify new or updated rollback triggers, you must specify <i>all</i> the triggers
        /// that you want used for this stack, even triggers you've specified before (for example,
        /// when creating the stack or during a previous stack update). Any triggers that you
        /// don't include in the updated list of triggers are no longer applied to the stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove all currently specified triggers, specify an empty list for this parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a specified trigger is missing, the entire stack operation fails and is rolled
        /// back.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<RollbackTrigger> RollbackTriggers
        {
            get { return this._rollbackTriggers; }
            set { this._rollbackTriggers = value; }
        }

        // Check to see if RollbackTriggers property is set
        internal bool IsSetRollbackTriggers()
        {
            return this._rollbackTriggers != null && (this._rollbackTriggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}