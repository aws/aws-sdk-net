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
    /// The settings to use when creating a cluster. This parameter is used to turn on CloudWatch
    /// Container Insights with enhanced observability or CloudWatch Container Insights for
    /// a cluster.
    /// 
    ///  
    /// <para>
    /// Container Insights with enhanced observability provides all the Container Insights
    /// metrics, plus additional task and container metrics. This version supports enhanced
    /// observability for Amazon ECS clusters using the Amazon EC2 and Fargate launch types.
    /// After you configure Container Insights with enhanced observability on Amazon ECS,
    /// Container Insights auto-collects detailed infrastructure telemetry from the cluster
    /// level down to the container level in your environment and displays these critical
    /// performance data in curated dashboards removing the heavy lifting in observability
    /// set-up. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cloudwatch-container-insights.html">Monitor
    /// Amazon ECS containers using Container Insights with enhanced observability</a> in
    /// the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ClusterSetting
    {
        private ClusterSettingName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster setting. The value is <c>containerInsights</c> .
        /// </para>
        /// </summary>
        public ClusterSettingName Name
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
        /// The value to set for the cluster setting. The supported values are <c>enhanced</c>,
        /// <c>enabled</c>, and <c>disabled</c>. 
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
        /// If a cluster value is specified, it will override the <c>containerInsights</c> value
        /// set with <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAccountSetting.html">PutAccountSetting</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_PutAccountSettingDefault.html">PutAccountSettingDefault</a>.
        /// </para>
        /// </summary>
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