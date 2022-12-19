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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// One of the methods which provide a way for you to quickly identify when a deployment
    /// has failed, and then to optionally roll back the failure to the last working deployment.
    /// 
    ///  
    /// <para>
    /// When the alarms are generated, Amazon ECS sets the service deployment to failed. Set
    /// the rollback parameter to have Amazon ECS to roll back your service to the last completed
    /// deployment after a failure.
    /// </para>
    ///  
    /// <para>
    /// You can only use the <code>DeploymentAlarms</code> method to detect failures when
    /// the <code>DeploymentController</code> is set to <code>ECS</code> (rolling update).
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html">Rolling
    /// update</a> in the <i> <i>Amazon Elastic Container Service Developer Guide</i> </i>.
    /// </para>
    /// </summary>
    public partial class DeploymentAlarms
    {
        private List<string> _alarmNames = new List<string>();
        private bool? _enable;
        private bool? _rollback;

        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        /// One or more CloudWatch alarm names. Use a "," to separate the alarms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AlarmNames
        {
            get { return this._alarmNames; }
            set { this._alarmNames = value; }
        }

        // Check to see if AlarmNames property is set
        internal bool IsSetAlarmNames()
        {
            return this._alarmNames != null && this._alarmNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Determines whether to use the CloudWatch alarm option in the service deployment process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enable
        {
            get { return this._enable.GetValueOrDefault(); }
            set { this._enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// Determines whether to configure Amazon ECS to roll back the service if a service deployment
        /// fails. If rollback is used, when a service deployment fails, the service is rolled
        /// back to the last deployment that completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Rollback
        {
            get { return this._rollback.GetValueOrDefault(); }
            set { this._rollback = value; }
        }

        // Check to see if Rollback property is set
        internal bool IsSetRollback()
        {
            return this._rollback.HasValue; 
        }

    }
}