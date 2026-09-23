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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// This is the response object from the GetInsightImpactGraph operation.
    /// </summary>
    public partial class GetInsightImpactGraphResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The provided end time. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The insight's unique identifier.
        /// </para>
        /// </summary>
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceGraphEndTime. 
        /// <para>
        /// The time, in Unix seconds, at which the service graph ended.
        /// </para>
        /// </summary>
        public DateTime? ServiceGraphEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ServiceGraphEndTime property is set.
        /// </summary>
        internal bool IsSetServiceGraphEndTime() => this.ServiceGraphEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceGraphStartTime. 
        /// <para>
        /// The time, in Unix seconds, at which the service graph started.
        /// </para>
        /// </summary>
        public DateTime? ServiceGraphStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ServiceGraphStartTime property is set.
        /// </summary>
        internal bool IsSetServiceGraphStartTime() => this.ServiceGraphStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The Amazon Web Services instrumented services related to the insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightImpactGraphService> Services { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightImpactGraphService>() : null;

        /// <summary>
        /// Checks to see if the Services property is set.
        /// </summary>
        internal bool IsSetServices() => this.Services != null && (this.Services.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The provided start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
