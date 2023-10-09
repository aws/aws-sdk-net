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
    /// Container for the parameters to the PutAccountSetting operation.
    /// Modifies an account setting. Account settings are set on a per-Region basis.
    /// 
    ///  
    /// <para>
    /// If you change the root user account setting, the default settings are reset for users
    /// and roles that do not have specified individual account settings. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html">Account
    /// Settings</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you specify <code>serviceLongArnFormat</code>, <code>taskLongArnFormat</code>,
    /// or <code>containerInstanceLongArnFormat</code>, the Amazon Resource Name (ARN) and
    /// resource ID format of the resource type for a specified user, role, or the root user
    /// for an account is affected. The opt-in and opt-out account setting must be set for
    /// each Amazon ECS resource separately. The ARN and resource ID format of a resource
    /// is defined by the opt-in status of the user or role that created the resource. You
    /// must turn on this setting to use Amazon ECS features such as resource tagging.
    /// </para>
    ///  
    /// <para>
    /// When you specify <code>awsvpcTrunking</code>, the elastic network interface (ENI)
    /// limit for any new container instances that support the feature is changed. If <code>awsvpcTrunking</code>
    /// is turned on, any new container instances that support the feature are launched have
    /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
    /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you specify <code>containerInsights</code>, the default setting indicating whether
    /// Amazon Web Services CloudWatch Container Insights is turned on for your clusters is
    /// changed. If <code>containerInsights</code> is turned on, any new clusters that are
    /// created will have Container Insights turned on unless you disable it during cluster
    /// creation. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">CloudWatch
    /// Container Insights</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Amazon ECS is introducing tagging authorization for resource creation. Users must
    /// have permissions for actions that create the resource, such as <code>ecsCreateCluster</code>.
    /// If tags are specified when you create a resource, Amazon Web Services performs additional
    /// authorization to verify if users or roles have permissions to create tags. Therefore,
    /// you must grant explicit permissions to use the <code>ecs:TagResource</code> action.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/supported-iam-actions-tagging.html">Grant
    /// permission to tag resources on creation</a> in the <i>Amazon ECS Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When Amazon Web Services determines that a security or infrastructure update is needed
    /// for an Amazon ECS task hosted on Fargate, the tasks need to be stopped and new tasks
    /// launched to replace them. Use <code>fargateTaskRetirementWaitPeriod</code> to configure
    /// the wait time to retire a Fargate task. For information about the Fargate tasks maintenance,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-maintenance.html">Amazon
    /// Web Services Fargate task maintenance</a> in the <i>Amazon ECS Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutAccountSettingRequest : AmazonECSRequest
    {
        private SettingName _name;
        private string _principalArn;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Amazon ECS resource name for which to modify the account setting. If you specify
        /// <code>serviceLongArnFormat</code>, the ARN for your Amazon ECS services is affected.
        /// If you specify <code>taskLongArnFormat</code>, the ARN and resource ID for your Amazon
        /// ECS tasks is affected. If you specify <code>containerInstanceLongArnFormat</code>,
        /// the ARN and resource ID for your Amazon ECS container instances is affected. If you
        /// specify <code>awsvpcTrunking</code>, the elastic network interface (ENI) limit for
        /// your Amazon ECS container instances is affected. If you specify <code>containerInsights</code>,
        /// the default setting for Amazon Web Services CloudWatch Container Insights for your
        /// clusters is affected. If you specify <code>fargateFIPSMode</code>, Fargate FIPS 140
        /// compliance is affected. If you specify <code>tagResourceAuthorization</code>, the
        /// opt-in option for tagging resources on creation is affected. For information about
        /// the opt-in timeline, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-account-settings.html#tag-resources">Tagging
        /// authorization timeline</a> in the <i>Amazon ECS Developer Guide</i>. If you specify
        /// <code>fargateTaskRetirementWaitPeriod</code>, the wait time to retire a Fargate task
        /// is affected.
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
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal, which can be a user, role, or the root user. If you specify
        /// the root user, it modifies the account setting for all users, roles, and the root
        /// user of the account unless a user or role explicitly overrides these settings. If
        /// this field is omitted, the setting is changed only for the authenticated user.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must use the root user when you set the Fargate wait time (<code>fargateTaskRetirementWaitPeriod</code>).
        /// 
        /// </para>
        ///  
        /// <para>
        /// Federated users assume the account setting of the root user and can't have explicit
        /// account settings set for them.
        /// </para>
        ///  </note>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
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