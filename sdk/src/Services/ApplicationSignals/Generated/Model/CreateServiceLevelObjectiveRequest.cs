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
    /// The target performance quality that is defined for an SLO is the <i>attainment goal</i>.
    /// </para>
    ///  
    /// <para>
    /// You can set SLO targets for your applications that are discovered by Application Signals,
    /// using critical metrics such as latency and availability. You can also set SLOs against
    /// any CloudWatch metric or math expression that produces a time series.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't create an SLO for a service operation that was discovered by Application
    /// Signals until after that operation has reported standard metrics to Application Signals.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you create an SLO, you specify whether it is a <i>period-based SLO</i> or a <i>request-based
    /// SLO</i>. Each type of SLO has a different way of evaluating your application's performance
    /// against its attainment goal.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>period-based SLO</i> uses defined <i>periods</i> of time within a specified total
    /// time interval. For each period of time, Application Signals determines whether the
    /// application met its goal. The attainment rate is calculated as the <c>number of good
    /// periods/number of total periods</c>.
    /// </para>
    ///  
    /// <para>
    /// For example, for a period-based SLO, meeting an attainment goal of 99.9% means that
    /// within your interval, your application must meet its performance goal during at least
    /// 99.9% of the time periods.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>request-based SLO</i> doesn't use pre-defined periods of time. Instead, the SLO
    /// measures <c>number of good requests/number of total requests</c> during the interval.
    /// At any time, you can find the ratio of good requests to total requests for the interval
    /// up to the time stamp that you specify, and measure that ratio against the goal set
    /// in your SLO.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// After you have created an SLO, you can retrieve error budget reports for it. An <i>error
    /// budget</i> is the amount of time or amount of requests that your application can be
    /// non-compliant with the SLO's goal, and still have your application meet the goal.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a period-based SLO, the error budget starts at a number defined by the highest
    /// number of periods that can fail to meet the threshold, while still meeting the overall
    /// goal. The <i>remaining error budget</i> decreases with every failed period that is
    /// recorded. The error budget within one interval can never increase.
    /// </para>
    ///  
    /// <para>
    /// For example, an SLO with a threshold that 99.95% of requests must be completed under
    /// 2000ms every month translates to an error budget of 21.9 minutes of downtime per month.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a request-based SLO, the remaining error budget is dynamic and can increase or
    /// decrease, depending on the ratio of good requests to total requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about SLOs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html">
    /// Service level objectives (SLOs)</a>. 
    /// </para>
    ///  
    /// <para>
    /// When you perform a <c>CreateServiceLevelObjective</c> operation, Application Signals
    /// creates the <i>AWSServiceRoleForCloudWatchApplicationSignals</i> service-linked role,
    /// if it doesn't already exist in your account. This service- linked role has the following
    /// permissions:
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
    /// </summary>
    public partial class CreateServiceLevelObjectiveRequest : AmazonApplicationSignalsRequest
    {
        private List<BurnRateConfiguration> _burnRateConfigurations = AWSConfigs.InitializeCollections ? new List<BurnRateConfiguration>() : null;
        private string _description;
        private Goal _goal;
        private string _name;
        private RequestBasedServiceLevelIndicatorConfig _requestBasedSliConfig;
        private ServiceLevelIndicatorConfig _sliConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BurnRateConfigurations. 
        /// <para>
        /// Use this array to create <i>burn rates</i> for this SLO. Each burn rate is a metric
        /// that indicates how fast the service is consuming the error budget, relative to the
        /// attainment goal of the SLO.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<BurnRateConfiguration> BurnRateConfigurations
        {
            get { return this._burnRateConfigurations; }
            set { this._burnRateConfigurations = value; }
        }

        // Check to see if BurnRateConfigurations property is set
        internal bool IsSetBurnRateConfigurations()
        {
            return this._burnRateConfigurations != null && (this._burnRateConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// This structure contains the attributes that determine the goal of the SLO.
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
        /// Gets and sets the property RequestBasedSliConfig. 
        /// <para>
        /// If this SLO is a request-based SLO, this structure defines the information about what
        /// performance metric this SLO will monitor.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both <c>RequestBasedSliConfig</c> and <c>SliConfig</c> in the same
        /// operation.
        /// </para>
        /// </summary>
        public RequestBasedServiceLevelIndicatorConfig RequestBasedSliConfig
        {
            get { return this._requestBasedSliConfig; }
            set { this._requestBasedSliConfig = value; }
        }

        // Check to see if RequestBasedSliConfig property is set
        internal bool IsSetRequestBasedSliConfig()
        {
            return this._requestBasedSliConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SliConfig. 
        /// <para>
        /// If this SLO is a period-based SLO, this structure defines the information about what
        /// performance metric this SLO will monitor.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both <c>RequestBasedSliConfig</c> and <c>SliConfig</c> in the same
        /// operation.
        /// </para>
        /// </summary>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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