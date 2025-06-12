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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the GetRecommendationsResponse.
    /// </summary>
    public partial class GetRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<Anomaly> _anomalies = AWSConfigs.InitializeCollections ? new List<Anomaly>() : null;
        private DateTime? _profileEndTime;
        private DateTime? _profileStartTime;
        private string _profilingGroupName;
        private List<Recommendation> _recommendations = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Gets and sets the property Anomalies. 
        /// <para>
        ///  The list of anomalies that the analysis has found for this profile. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Anomaly> Anomalies
        {
            get { return this._anomalies; }
            set { this._anomalies = value; }
        }

        // Check to see if Anomalies property is set
        internal bool IsSetAnomalies()
        {
            return this._anomalies != null && (this._anomalies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfileEndTime. 
        /// <para>
        ///  The end time of the profile the analysis data is about. This is specified using the
        /// ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past
        /// June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ProfileEndTime
        {
            get { return this._profileEndTime; }
            set { this._profileEndTime = value; }
        }

        // Check to see if ProfileEndTime property is set
        internal bool IsSetProfileEndTime()
        {
            return this._profileEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileStartTime. 
        /// <para>
        ///  The start time of the profile the analysis data is about. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ProfileStartTime
        {
            get { return this._profileStartTime; }
            set { this._profileStartTime = value; }
        }

        // Check to see if ProfileStartTime property is set
        internal bool IsSetProfileStartTime()
        {
            return this._profileStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group the analysis data is about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The list of recommendations that the analysis found for this profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}