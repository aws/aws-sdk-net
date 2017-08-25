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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Structure containing the rollback triggers for AWS CloudFormation to monitor during
    /// stack creation and updating operations, and for the specified monitoring period afterwards.
    /// 
    ///  
    /// <para>
    /// Rollback triggers enable you to have AWS CloudFormation monitor the state of your
    /// application during stack creation and updating, and to roll back that operation if
    /// the application breaches the threshold of any of the alarms you've specified. For
    /// each rollback trigger you create, you specify the Cloudwatch alarm that CloudFormation
    /// should monitor. CloudFormation monitors the specified alarms during the stack create
    /// or update operation, and for the specified amount of time after all resources have
    /// been deployed. If any of the alarms goes to ALERT state during the stack operation
    /// or the monitoring period, CloudFormation rolls back the entire stack operation. If
    /// the monitoring period expires without any alarms going to ALERT state, CloudFormation
    /// proceeds to dispose of old resources as usual.
    /// </para>
    ///  
    /// <para>
    /// By default, CloudFormation only rolls back stack operations if an alarm goes to ALERT
    /// state, not INSUFFICIENT_DATA state. To have CloudFormation roll back the stack operation
    /// if an alarm goes to INSUFFICIENT_DATA state as well, edit the CloudWatch alarm to
    /// treat missing data as <code>breaching</code>. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html">Configuring
    /// How CloudWatch Alarms Treats Missing Data</a>.
    /// </para>
    ///  
    /// <para>
    /// AWS CloudFormation does not monitor rollback triggers when it rolls back a stack during
    /// an update operation.
    /// </para>
    /// </summary>
    public partial class RollbackConfiguration
    {
        private int? _monitoringTimeInMinutes;
        private List<RollbackTrigger> _rollbackTriggers = new List<RollbackTrigger>();

        /// <summary>
        /// Gets and sets the property MonitoringTimeInMinutes. 
        /// <para>
        /// The amount of time, in minutes, during which CloudFormation should monitor all the
        /// rollback triggers after the stack creation or update operation deploys all necessary
        /// resources. If any of the alarms goes to ALERT state during the stack operation or
        /// this monitoring period, CloudFormation rolls back the entire stack operation. Then,
        /// for update operations, if the monitoring period expires without any alarms going to
        /// ALERT state CloudFormation proceeds to dispose of old resources as usual.
        /// </para>
        ///  
        /// <para>
        /// If you specify a monitoring period but do not specify any rollback triggers, CloudFormation
        /// still waits the specified period of time before cleaning up old resources for update
        /// operations. You can use this monitoring period to perform any manual stack validation
        /// desired, and manually cancel the stack creation or update (using <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_CancelUpdateStack.html">CancelUpdateStack</a>,
        /// for example) as necessary.
        /// </para>
        ///  
        /// <para>
        /// If you specify 0 for this parameter, CloudFormation still monitors the specified rollback
        /// triggers during stack creation and update operations. Then, for update operations,
        /// it begins disposing of old resources immediately once the operation completes.
        /// </para>
        /// </summary>
        public int MonitoringTimeInMinutes
        {
            get { return this._monitoringTimeInMinutes.GetValueOrDefault(); }
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
        /// By default, AWS CloudFormation saves the rollback triggers specified for a stack and
        /// applies them to any subsequent update operations for the stack, unless you specify
        /// otherwise. If you do specify rollback triggers for this parameter, those triggers
        /// replace any list of triggers previously specified for the stack. This means:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify this parameter, AWS CloudFormation uses the rollback triggers
        /// previously specified for this stack, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify any rollback triggers using this parameter, you must specify all the
        /// triggers that you want used for this stack, even triggers you've specifed before (for
        /// example, when creating the stack or during a previous stack update). Any triggers
        /// that you don't include in the updated list of triggers are no longer applied to the
        /// stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an empty list, AWS CloudFormation removes all currently specified triggers.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a specified Cloudwatch alarm is missing, the entire stack operation fails and is
        /// rolled back. 
        /// </para>
        /// </summary>
        public List<RollbackTrigger> RollbackTriggers
        {
            get { return this._rollbackTriggers; }
            set { this._rollbackTriggers = value; }
        }

        // Check to see if RollbackTriggers property is set
        internal bool IsSetRollbackTriggers()
        {
            return this._rollbackTriggers != null && this._rollbackTriggers.Count > 0; 
        }

    }
}