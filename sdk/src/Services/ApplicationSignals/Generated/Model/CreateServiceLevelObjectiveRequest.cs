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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceLevelObjective operation.
    /// Creates a service level objective (SLO), which can help you ensure that your critical
    /// business operations are meeting customer expectations. Use SLOs to set and track specific
    /// target levels for the reliability and availability of your applications and services.
    /// SLOs use service level indicators (SLIs) to calculate whether the application is performing
    /// at the level that you want.
    /// 
    ///  
    /// <para>
    /// Create an SLO to set a target for a service or operation’s availability or latency.
    /// CloudWatch measures this target frequently you can find whether it has been breached.
    /// 
    /// </para>
    ///  
    /// <para>
    /// When you create an SLO, you set an <i>attainment goal</i> for it. An <i>attainment
    /// goal</i> is the ratio of good periods that meet the threshold requirements to the
    /// total periods within the interval. For example, an attainment goal of 99.9% means
    /// that within your interval, you are targeting 99.9% of the periods to be in healthy
    /// state.
    /// </para>
    ///  
    /// <para>
    /// After you have created an SLO, you can retrieve error budget reports for it. An <i>error
    /// budget</i> is the number of periods or amount of time that your service can accumulate
    /// during an interval before your overall SLO budget health is breached and the SLO is
    /// considered to be unmet. for example, an SLO with a threshold that 99.95% of requests
    /// must be completed under 2000ms every month translates to an error budget of 21.9 minutes
    /// of downtime per month.
    /// </para>
    ///  
    /// <para>
    /// When you call this operation, Application Signals creates the <i>AWSServiceRoleForCloudWatchApplicationSignals</i>
    /// service-linked role, if it doesn't already exist in your account. This service- linked
    /// role has the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>xray:GetServiceGraph</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>logs:StartQuery</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>logs:GetQueryResults</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudwatch:GetMetricData</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudwatch:ListMetrics</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>tag:GetResources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>autoscaling:DescribeAutoScalingGroups</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can easily set SLO targets for your applications that are discovered by Application
    /// Signals, using critical metrics such as latency and availability. You can also set
    /// SLOs against any CloudWatch metric or math expression that produces a time series.
    /// </para>
    ///  
    /// <para>
    /// For more information about SLOs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html">
    /// Service level objectives (SLOs)</a>. 
    /// </para>
    /// </summary>
    public partial class CreateServiceLevelObjectiveRequest : AmazonApplicationSignalsRequest
    {
        private string _description;
        private Goal _goal;
        private string _name;
        private ServiceLevelIndicatorConfig _sliConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Goal. 
        /// <para>
        /// A structure that contains the attributes that determine the goal of the SLO. This
        /// includes the time period for evaluation and the attainment threshold.
        /// </para>
        /// </summary>
        public Goal Goal
        {
            get { return this._goal; }
            set { this._goal = value; }
        }

        // Check to see if Goal property is set
        internal bool IsSetGoal()
        {
            return this._goal != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
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
        /// Gets and sets the property SliConfig. 
        /// <para>
        /// A structure that contains information about what service and what performance metric
        /// that this SLO will monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceLevelIndicatorConfig SliConfig
        {
            get { return this._sliConfig; }
            set { this._sliConfig = value; }
        }

        // Check to see if SliConfig property is set
        internal bool IsSetSliConfig()
        {
            return this._sliConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the SLO. You can associate as many as
        /// 50 tags with an SLO. To be able to associate tags with the SLO when you create the
        /// SLO, you must have the <c>cloudwatch:TagResource</c> permission.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}