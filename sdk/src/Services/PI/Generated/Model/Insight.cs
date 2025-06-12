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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// Retrieves the list of performance issues which are identified.
    /// </summary>
    public partial class Insight
    {
        private List<Data> _baselineData = AWSConfigs.InitializeCollections ? new List<Data>() : null;
        private ContextType _context;
        private string _description;
        private DateTime? _endTime;
        private List<Data> _insightData = AWSConfigs.InitializeCollections ? new List<Data>() : null;
        private string _insightId;
        private string _insightType;
        private List<Recommendation> _recommendations = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;
        private Severity _severity;
        private DateTime? _startTime;
        private List<Insight> _supportingInsights = AWSConfigs.InitializeCollections ? new List<Insight>() : null;

        /// <summary>
        /// Gets and sets the property BaselineData. 
        /// <para>
        ///  Metric names and values from the timeframe used as baseline to generate the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Data> BaselineData
        {
            get { return this._baselineData; }
            set { this._baselineData = value; }
        }

        // Check to see if BaselineData property is set
        internal bool IsSetBaselineData()
        {
            return this._baselineData != null && (this._baselineData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Indicates if the insight is causal or correlated insight.
        /// </para>
        /// </summary>
        public ContextType Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the insight. For example: <c>A high severity Insight found between
        /// 02:00 to 02:30, where there was an unusually high DB load 600x above baseline. Likely
        /// performance impact</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8000)]
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the insight. For example, <c>2018-10-30T00:00:00Z</c>.
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
        /// Gets and sets the property InsightData. 
        /// <para>
        /// List of data objects containing metrics and references from the time range while generating
        /// the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Data> InsightData
        {
            get { return this._insightData; }
            set { this._insightData = value; }
        }

        // Check to see if InsightData property is set
        internal bool IsSetInsightData()
        {
            return this._insightData != null && (this._insightData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The unique identifier for the insight. For example, <c>insight-12345678901234567</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string InsightId
        {
            get { return this._insightId; }
            set { this._insightId = value; }
        }

        // Check to see if InsightId property is set
        internal bool IsSetInsightId()
        {
            return this._insightId != null;
        }

        /// <summary>
        /// Gets and sets the property InsightType. 
        /// <para>
        /// The type of insight. For example, <c>HighDBLoad</c>, <c>HighCPU</c>, or <c>DominatingSQLs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string InsightType
        {
            get { return this._insightType; }
            set { this._insightType = value; }
        }

        // Check to see if InsightType property is set
        internal bool IsSetInsightType()
        {
            return this._insightType != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// List of recommendations for the insight. For example, <c>Investigate the following
        /// SQLs that contributed to 100% of the total DBLoad during that time period: sql-id</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Recommendation> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && (this._recommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the insight. The values are: <c>Low</c>, <c>Medium</c>, or <c>High</c>.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the insight. For example, <c>2018-10-30T00:00:00Z</c>.
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
        /// Gets and sets the property SupportingInsights. 
        /// <para>
        /// List of supporting insights that provide additional factors for the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Insight> SupportingInsights
        {
            get { return this._supportingInsights; }
            set { this._supportingInsights = value; }
        }

        // Check to see if SupportingInsights property is set
        internal bool IsSetSupportingInsights()
        {
            return this._supportingInsights != null && (this._supportingInsights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}