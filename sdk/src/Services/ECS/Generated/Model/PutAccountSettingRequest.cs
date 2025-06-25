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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// </summary>
    public partial class PutAccountSettingRequest : AmazonECSRequest
    {
        private SettingName _name;
        private string _principalArn;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Amazon ECS account setting name to modify.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid values for the account setting name.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>serviceLongArnFormat</c> - When modified, the Amazon Resource Name (ARN) and resource
        /// ID format of the resource type for a specified user, role, or the root user for an
        /// account is affected. The opt-in and opt-out account setting must be set for each Amazon
        /// ECS resource separately. The ARN and resource ID format of a resource is defined by
        /// the opt-in status of the user or role that created the resource. You must turn on
        /// this setting to use Amazon ECS features such as resource tagging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>taskLongArnFormat</c> - When modified, the Amazon Resource Name (ARN) and resource
        /// ID format of the resource type for a specified user, role, or the root user for an
        /// account is affected. The opt-in and opt-out account setting must be set for each Amazon
        /// ECS resource separately. The ARN and resource ID format of a resource is defined by
        /// the opt-in status of the user or role that created the resource. You must turn on
        /// this setting to use Amazon ECS features such as resource tagging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>containerInstanceLongArnFormat</c> - When modified, the Amazon Resource Name (ARN)
        /// and resource ID format of the resource type for a specified user, role, or the root
        /// user for an account is affected. The opt-in and opt-out account setting must be set
        /// for each Amazon ECS resource separately. The ARN and resource ID format of a resource
        /// is defined by the opt-in status of the user or role that created the resource. You
        /// must turn on this setting to use Amazon ECS features such as resource tagging.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>awsvpcTrunking</c> - When modified, the elastic network interface (ENI) limit
        /// for any new container instances that support the feature is changed. If <c>awsvpcTrunking</c>
        /// is turned on, any new container instances that support the feature are launched have
        /// the increased ENI limits available to them. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-instance-eni.html">Elastic
        /// Network Interface Trunking</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>containerInsights</c> - Container Insights with enhanced observability provides
        /// all the Container Insights metrics, plus additional task and container metrics. This
        /// version supports enhanced observability for Amazon ECS clusters using the Amazon EC2
        /// and Fargate launch types. After you configure Container Insights with enhanced observability
        /// on Amazon ECS, Container Insights auto-collects detailed infrastructure telemetry
        /// from the cluster level down to the container level in your environment and displays
        /// these critical performance data in curated dashboards removing the heavy lifting in
        /// observability set-up. 
        /// </para>
        ///  
        /// <para>
        /// To use Container Insights with enhanced observability, set the <c>containerInsights</c>
        /// account setting to <c>enhanced</c>.
        /// </para>
        ///  
        /// <para>
        /// To use Container Insights, set the <c>containerInsights</c> account setting to <c>enabled</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">Monitor
        /// Amazon ECS containers using Container Insights with enhanced observability</a> in
        /// the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dualStackIPv6</c> - When turned on, when using a VPC in dual stack mode, your
        /// tasks using the <c>awsvpc</c> network mode can have an IPv6 address assigned. For
        /// more information on using IPv6 with tasks launched on Amazon EC2 instances, see <a
        /// href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking-awsvpc.html#task-networking-vpc-dual-stack">Using
        /// a VPC in dual-stack mode</a>. For more information on using IPv6 with tasks launched
        /// on Fargate, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/fargate-task-networking.html#fargate-task-networking-vpc-dual-stack">Using
        /// a VPC in dual-stack mode</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fargateTaskRetirementWaitPeriod</c> - When Amazon Web Services determines that
        /// a security or infrastructure update is needed for an Amazon ECS task hosted on Fargate,
        /// the tasks need to be stopped and new tasks launched to replace them. Use <c>fargateTaskRetirementWaitPeriod</c>
        /// to configure the wait time to retire a Fargate task. For information about the Fargate
        /// tasks maintenance, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-maintenance.html">Amazon
        /// Web Services Fargate task maintenance</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tagResourceAuthorization</c> - Amazon ECS is introducing tagging authorization
        /// for resource creation. Users must have permissions for actions that create the resource,
        /// such as <c>ecsCreateCluster</c>. If tags are specified when you create a resource,
        /// Amazon Web Services performs additional authorization to verify if users or roles
        /// have permissions to create tags. Therefore, you must grant explicit permissions to
        /// use the <c>ecs:TagResource</c> action. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/supported-iam-actions-tagging.html">Grant
        /// permission to tag resources on creation</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>defaultLogDriverMode</c> - Amazon ECS supports setting a default delivery mode
        /// of log messages from a container to the <c>logDriver</c> that you specify in the container's
        /// <c>logConfiguration</c>. The delivery mode affects application stability when the
        /// flow of logs from the container to the log driver is interrupted. The <c>defaultLogDriverMode</c>
        /// setting supports two values: <c>blocking</c> and <c>non-blocking</c>. If you don't
        /// specify a delivery mode in your container definition's <c>logConfiguration</c>, the
        /// mode you specify using this account setting will be used as the default. For more
        /// information about log delivery modes, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_LogConfiguration.html">LogConfiguration</a>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// On June 25, 2025, Amazon ECS changed the default log driver mode from <c>blocking</c>
        /// to <c>non-blocking</c> to prioritize task availability over logging. To continue using
        /// the <c>blocking</c> mode after this change, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set the <c>mode</c> option in your container definition's <c>logConfiguration</c>
        /// as <c>blocking</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set the <c>defaultLogDriverMode</c> account setting to <c>blocking</c>.
        /// </para>
        ///  </li> </ul> </note> </li> <li> 
        /// <para>
        ///  <c>guardDutyActivate</c> - The <c>guardDutyActivate</c> parameter is read-only in
        /// Amazon ECS and indicates whether Amazon ECS Runtime Monitoring is enabled or disabled
        /// by your security administrator in your Amazon ECS account. Amazon GuardDuty controls
        /// this account setting on your behalf. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-guard-duty-integration.html">Protecting
        /// Amazon ECS workloads with Amazon ECS Runtime Monitoring</a>.
        /// </para>
        ///  </li> </ul>
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
        ///  
        /// <para>
        /// In order to use this parameter, you must be the root user, or the principal.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must use the root user when you set the Fargate wait time (<c>fargateTaskRetirementWaitPeriod</c>).
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
        /// The account setting value for the specified principal ARN. Accepted values are <c>enabled</c>,
        /// <c>disabled</c>, <c>enhanced</c>, <c>on</c>, and <c>off</c>.
        /// </para>
        ///  
        /// <para>
        /// When you specify <c>fargateTaskRetirementWaitPeriod</c> for the <c>name</c>, the following
        /// are the valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>0</c> - Amazon Web Services sends the notification, and immediately retires the
        /// affected tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>7</c> - Amazon Web Services sends the notification, and waits 7 calendar days
        /// to retire the tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>14</c> - Amazon Web Services sends the notification, and waits 14 calendar days
        /// to retire the tasks.
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