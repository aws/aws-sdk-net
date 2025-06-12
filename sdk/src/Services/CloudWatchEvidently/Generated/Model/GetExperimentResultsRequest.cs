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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the GetExperimentResults operation.
    /// Retrieves the results of a running or completed experiment. No results are available
    /// until there have been 100 events for each variation and at least 10 minutes have passed
    /// since the start of the experiment. To increase the statistical power, Evidently performs
    /// an additional offline p-value analysis at the end of the experiment. Offline p-value
    /// analysis can detect statistical significance in some cases where the anytime p-values
    /// used during the experiment do not find statistical significance.
    /// 
    ///  
    /// <para>
    /// Experiment results are available up to 63 days after the start of the experiment.
    /// They are not available after that because of CloudWatch data retention policies.
    /// </para>
    /// </summary>
    public partial class GetExperimentResultsRequest : AmazonCloudWatchEvidentlyRequest
    {
        private ExperimentBaseStat _baseStat;
        private DateTime? _endTime;
        private string _experiment;
        private List<string> _metricNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _period;
        private string _project;
        private List<string> _reportNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resultStats = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;
        private List<string> _treatmentNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BaseStat. 
        /// <para>
        /// The statistic used to calculate experiment results. Currently the only valid value
        /// is <c>mean</c>, which uses the mean of the collected values as the statistic.
        /// </para>
        /// </summary>
        public ExperimentBaseStat BaseStat
        {
            get { return this._baseStat; }
            set { this._baseStat = value; }
        }

        // Check to see if BaseStat property is set
        internal bool IsSetBaseStat()
        {
            return this._baseStat != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the experiment ended, if it is completed. This must be no longer
        /// than 30 days after the experiment start time.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Experiment. 
        /// <para>
        /// The name of the experiment to retrieve the results of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Experiment
        {
            get { return this._experiment; }
            set { this._experiment = value; }
        }

        // Check to see if Experiment property is set
        internal bool IsSetExperiment()
        {
            return this._experiment != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNames. 
        /// <para>
        /// The names of the experiment metrics that you want to see the results of.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> MetricNames
        {
            get { return this._metricNames; }
            set { this._metricNames = value; }
        }

        // Check to see if MetricNames property is set
        internal bool IsSetMetricNames()
        {
            return this._metricNames != null && (this._metricNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// In seconds, the amount of time to aggregate results together. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=300, Max=90000)]
        public long? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the experiment that you want to see the
        /// results of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property ReportNames. 
        /// <para>
        /// The names of the report types that you want to see. Currently, <c>BayesianInference</c>
        /// is the only valid value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ReportNames
        {
            get { return this._reportNames; }
            set { this._reportNames = value; }
        }

        // Check to see if ReportNames property is set
        internal bool IsSetReportNames()
        {
            return this._reportNames != null && (this._reportNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResultStats. 
        /// <para>
        /// The statistics that you want to see in the returned results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PValue</c> specifies to use p-values for the results. A p-value is used in hypothesis
        /// testing to measure how often you are willing to make a mistake in rejecting the null
        /// hypothesis. A general practice is to reject the null hypothesis and declare that the
        /// results are statistically significant when the p-value is less than 0.05.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfidenceInterval</c> specifies a confidence interval for the results. The confidence
        /// interval represents the range of values for the chosen metric that is likely to contain
        /// the true difference between the <c>baseStat</c> of a variation and the baseline. Evidently
        /// returns the 95% confidence interval. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TreatmentEffect</c> is the difference in the statistic specified by the <c>baseStat</c>
        /// parameter between each variation and the default variation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BaseStat</c> returns the statistical values collected for the metric for each
        /// variation. The statistic uses the same statistic specified in the <c>baseStat</c>
        /// parameter. Therefore, if <c>baseStat</c> is <c>mean</c>, this returns the mean of
        /// the values collected for each variation.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ResultStats
        {
            get { return this._resultStats; }
            set { this._resultStats = value; }
        }

        // Check to see if ResultStats property is set
        internal bool IsSetResultStats()
        {
            return this._resultStats != null && (this._resultStats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time that the experiment started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatmentNames. 
        /// <para>
        /// The names of the experiment treatments that you want to see the results for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> TreatmentNames
        {
            get { return this._treatmentNames; }
            set { this._treatmentNames = value; }
        }

        // Check to see if TreatmentNames property is set
        internal bool IsSetTreatmentNames()
        {
            return this._treatmentNames != null && (this._treatmentNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}