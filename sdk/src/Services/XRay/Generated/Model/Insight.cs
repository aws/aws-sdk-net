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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// When fault rates go outside of the expected range, X-Ray creates an insight. Insights
    /// tracks emergent issues within your applications.
    /// </summary>
    public partial class Insight
    {
        private List<string> _categories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RequestImpactStatistics _clientRequestImpactStatistics;
        private DateTime? _endTime;
        private string _groupARN;
        private string _groupName;
        private string _insightId;
        private ServiceId _rootCauseServiceId;
        private RequestImpactStatistics _rootCauseServiceRequestImpactStatistics;
        private DateTime? _startTime;
        private InsightState _state;
        private string _summary;
        private List<AnomalousService> _topAnomalousServices = AWSConfigs.InitializeCollections ? new List<AnomalousService>() : null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories that label and describe the type of insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestImpactStatistics. 
        /// <para>
        /// The impact statistics of the client side service. This includes the number of requests
        /// to the client service and whether the requests were faults or okay.
        /// </para>
        /// </summary>
        public RequestImpactStatistics ClientRequestImpactStatistics
        {
            get { return this._clientRequestImpactStatistics; }
            set { this._clientRequestImpactStatistics = value; }
        }

        // Check to see if ClientRequestImpactStatistics property is set
        internal bool IsSetClientRequestImpactStatistics()
        {
            return this._clientRequestImpactStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time, in Unix seconds, at which the insight ended.
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
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group that the insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=400)]
        public string GroupARN
        {
            get { return this._groupARN; }
            set { this._groupARN = value; }
        }

        // Check to see if GroupARN property is set
        internal bool IsSetGroupARN()
        {
            return this._groupARN != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group that the insight belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The insights unique identifier. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RootCauseServiceId.
        /// </summary>
        public ServiceId RootCauseServiceId
        {
            get { return this._rootCauseServiceId; }
            set { this._rootCauseServiceId = value; }
        }

        // Check to see if RootCauseServiceId property is set
        internal bool IsSetRootCauseServiceId()
        {
            return this._rootCauseServiceId != null;
        }

        /// <summary>
        /// Gets and sets the property RootCauseServiceRequestImpactStatistics. 
        /// <para>
        /// The impact statistics of the root cause service. This includes the number of requests
        /// to the client service and whether the requests were faults or okay.
        /// </para>
        /// </summary>
        public RequestImpactStatistics RootCauseServiceRequestImpactStatistics
        {
            get { return this._rootCauseServiceRequestImpactStatistics; }
            set { this._rootCauseServiceRequestImpactStatistics = value; }
        }

        // Check to see if RootCauseServiceRequestImpactStatistics property is set
        internal bool IsSetRootCauseServiceRequestImpactStatistics()
        {
            return this._rootCauseServiceRequestImpactStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time, in Unix seconds, at which the insight began.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the insight.
        /// </para>
        /// </summary>
        public InsightState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A brief description of the insight.
        /// </para>
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property TopAnomalousServices. 
        /// <para>
        /// The service within the insight that is most impacted by the incident.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AnomalousService> TopAnomalousServices
        {
            get { return this._topAnomalousServices; }
            set { this._topAnomalousServices = value; }
        }

        // Check to see if TopAnomalousServices property is set
        internal bool IsSetTopAnomalousServices()
        {
            return this._topAnomalousServices != null && (this._topAnomalousServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}