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
    /// Container for the parameters to the PutAccountSettingDefault operation.
    /// Modifies an account setting for all users on an account for whom no individual account
    /// setting has been specified. Account settings are set on a per-Region basis.
    /// </summary>
    public partial class PutAccountSettingDefaultRequest : AmazonECSRequest
    {
        private SettingName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The resource name for which to modify the account setting. If you specify <code>serviceLongArnFormat</code>,
        /// the ARN for your Amazon ECS services is affected. If you specify <code>taskLongArnFormat</code>,
        /// the ARN and resource ID for your Amazon ECS tasks is affected. If you specify <code>containerInstanceLongArnFormat</code>,
        /// the ARN and resource ID for your Amazon ECS container instances is affected. If you
        /// specify <code>awsvpcTrunking</code>, the ENI limit for your Amazon ECS container instances
        /// is affected. If you specify <code>containerInsights</code>, the default setting for
        /// Amazon Web Services CloudWatch Container Insights for your clusters is affected. If
        /// you specify <code>tagResourceAuthorization</code>, the opt-in option for tagging resources
        /// on creation is affected. For information about the opt-in timeline, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#tag-resources">Tagging
        /// authorization timeline</a> in the <i>Amazon ECS Developer Guide</i>. If you specify
        /// <code>fargateTaskRetirementWaitPeriod</code>, the default wait time to retire a Fargate
        /// task due to required maintenance is affected.
        /// </para>
        ///  
        /// <para>
        /// When you specify <code>fargateFIPSMode</code> for the <code>name</code> and <code>enabled</code>
        /// for the <code>value</code>, Fargate uses FIPS-140 compliant cryptographic algorithms
        /// on your tasks. For more information about FIPS-140 compliance with Fargate, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-fips-compliance.html">
        /// Amazon Web Services Fargate Federal Information Processing Standard (FIPS) 140-2 compliance</a>
        /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When Amazon Web Services determines that a security or infrastructure update is needed
        /// for an Amazon ECS task hosted on Fargate, the tasks need to be stopped and new tasks
        /// launched to replace them. Use <code>fargateTaskRetirementWaitPeriod</code> to set
        /// the wait time to retire a Fargate task to the default. For information about the Fargate
        /// tasks maintenance, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-maintenance.html">Amazon
        /// Web Services Fargate task maintenance</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SettingName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The account setting value for the specified principal ARN. Accepted values are <code>enabled</code>,
        /// <code>disabled</code>, <code>on</code>, and <code>off</code>.
        /// </para>
        ///  
        /// <para>
        /// When you specify <code>fargateTaskRetirementWaitPeriod</code> for the <code>name</code>,
        /// the following are the valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>0</code> - Amazon Web Services sends the notification, and immediately retires
        /// the affected tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>7</code> - Amazon Web Services sends the notification, and waits 7 calendar
        /// days to retire the tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>14</code> - Amazon Web Services sends the notification, and waits 14 calendar
        /// days to retire the tasks.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}