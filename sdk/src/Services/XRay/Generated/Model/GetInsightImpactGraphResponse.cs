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
    /// This is the response object from the GetInsightImpactGraph operation.
    /// </summary>
    public partial class GetInsightImpactGraphResponse : AmazonWebServiceResponse
    {
        private DateTime? _endTime;
        private string _insightId;
        private string _nextToken;
        private DateTime? _serviceGraphEndTime;
        private DateTime? _serviceGraphStartTime;
        private List<InsightImpactGraphService> _services = AWSConfigs.InitializeCollections ? new List<InsightImpactGraphService>() : null;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The provided end time. 
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
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The insight's unique identifier.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceGraphEndTime. 
        /// <para>
        /// The time, in Unix seconds, at which the service graph ended.
        /// </para>
        /// </summary>
        public DateTime? ServiceGraphEndTime
        {
            get { return this._serviceGraphEndTime; }
            set { this._serviceGraphEndTime = value; }
        }

        // Check to see if ServiceGraphEndTime property is set
        internal bool IsSetServiceGraphEndTime()
        {
            return this._serviceGraphEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceGraphStartTime. 
        /// <para>
        /// The time, in Unix seconds, at which the service graph started.
        /// </para>
        /// </summary>
        public DateTime? ServiceGraphStartTime
        {
            get { return this._serviceGraphStartTime; }
            set { this._serviceGraphStartTime = value; }
        }

        // Check to see if ServiceGraphStartTime property is set
        internal bool IsSetServiceGraphStartTime()
        {
            return this._serviceGraphStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The Amazon Web Services instrumented services related to the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightImpactGraphService> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The provided start time.
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

    }
}