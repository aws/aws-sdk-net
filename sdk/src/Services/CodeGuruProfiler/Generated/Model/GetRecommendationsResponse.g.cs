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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetRecommendations operation.
    /// </summary>
    public partial class GetRecommendationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Anomalies. 
        /// <para>
        ///  The list of anomalies that the analysis has found for this profile. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Anomaly> Anomalies { get; set; } = AWSConfigs.InitializeCollections ? new List<Anomaly>() : null;

        /// <summary>
        /// Checks to see if the Anomalies property is set.
        /// </summary>
        internal bool IsSetAnomalies() => this.Anomalies != null && (this.Anomalies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfileEndTime. 
        /// <para>
        ///  The end time of the profile the analysis data is about. This is specified using the
        /// ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past
        /// June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ProfileEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ProfileEndTime property is set.
        /// </summary>
        internal bool IsSetProfileEndTime() => this.ProfileEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileStartTime. 
        /// <para>
        ///  The start time of the profile the analysis data is about. This is specified using
        /// the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond
        /// past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ProfileStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ProfileStartTime property is set.
        /// </summary>
        internal bool IsSetProfileStartTime() => this.ProfileStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group the analysis data is about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The list of recommendations that the analysis found for this profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Recommendation> Recommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Checks to see if the Recommendations property is set.
        /// </summary>
        internal bool IsSetRecommendations() => this.Recommendations != null && (this.Recommendations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
