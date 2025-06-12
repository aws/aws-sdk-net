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
    /// A structure containing information about one service level objective (SLO) that has
    /// been created in Application Signals. Creating SLOs can help you ensure your services
    /// are performing to the level that you expect. SLOs help you set and track a specific
    /// target level for the reliability and availability of your applications and services.
    /// Each SLO uses a service level indicator (SLI), which is a key performance metric,
    /// to calculate how much underperformance can be tolerated before the goal that you set
    /// for the SLO is not achieved.
    /// </summary>
    public partial class ServiceLevelObjective
    {
        private string _arn;
        private List<BurnRateConfiguration> _burnRateConfigurations = AWSConfigs.InitializeCollections ? new List<BurnRateConfiguration>() : null;
        private DateTime? _createdTime;
        private string _description;
        private EvaluationType _evaluationType;
        private Goal _goal;
        private DateTime? _lastUpdatedTime;
        private MetricSourceType _metricSourceType;
        private string _name;
        private RequestBasedServiceLevelIndicator _requestBasedSli;
        private ServiceLevelIndicator _sli;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BurnRateConfigurations. 
        /// <para>
        /// Each object in this array defines the length of the look-back window used to calculate
        /// one burn rate metric for this SLO. The burn rate measures how fast the service is
        /// consuming the error budget, relative to the attainment goal of the SLO.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that this SLO was created. When used in a raw HTTP Query API, it
        /// is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you created for this SLO.
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
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Displays whether this is a period-based SLO or a request-based SLO.
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType
        {
            get { return this._evaluationType; }
            set { this._evaluationType = value; }
        }

        // Check to see if EvaluationType property is set
        internal bool IsSetEvaluationType()
        {
            return this._evaluationType != null;
        }

        /// <summary>
        /// Gets and sets the property Goal.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that this SLO was most recently updated. When used in a raw HTTP Query API,
        /// it is formatted as <c>yyyy-MM-dd'T'HH:mm:ss</c>. For example, <c>2019-07-01T23:59:59</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricSourceType. 
        /// <para>
        /// Displays the SLI metric source type for this SLO. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service dependency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch metric
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricSourceType MetricSourceType
        {
            get { return this._metricSourceType; }
            set { this._metricSourceType = value; }
        }

        // Check to see if MetricSourceType property is set
        internal bool IsSetMetricSourceType()
        {
            return this._metricSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this SLO.
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
        /// Gets and sets the property RequestBasedSli. 
        /// <para>
        /// A structure containing information about the performance metric that this SLO monitors,
        /// if this is a request-based SLO.
        /// </para>
        /// </summary>
        public RequestBasedServiceLevelIndicator RequestBasedSli
        {
            get { return this._requestBasedSli; }
            set { this._requestBasedSli = value; }
        }

        // Check to see if RequestBasedSli property is set
        internal bool IsSetRequestBasedSli()
        {
            return this._requestBasedSli != null;
        }

        /// <summary>
        /// Gets and sets the property Sli. 
        /// <para>
        /// A structure containing information about the performance metric that this SLO monitors,
        /// if this is a period-based SLO.
        /// </para>
        /// </summary>
        public ServiceLevelIndicator Sli
        {
            get { return this._sli; }
            set { this._sli = value; }
        }

        // Check to see if Sli property is set
        internal bool IsSetSli()
        {
            return this._sli != null;
        }

    }
}