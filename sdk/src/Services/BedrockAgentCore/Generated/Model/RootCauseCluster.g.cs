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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A cluster of similar root causes identified within a failure subcategory.
    /// </summary>
    public partial class RootCauseCluster
    {
        /// <summary>
        /// Gets and sets the property AffectedSessionCount. 
        /// <para>
        /// The number of sessions affected by this root cause.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AffectedSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the AffectedSessionCount property is set.
        /// </summary>
        internal bool IsSetAffectedSessionCount() => this.AffectedSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property AffectedSessions. 
        /// <para>
        /// The list of sessions affected by this root cause.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public List<AffectedSession> AffectedSessions { get; set; } = AWSConfigs.InitializeCollections ? new List<AffectedSession>() : null;

        /// <summary>
        /// Checks to see if the AffectedSessions property is set.
        /// </summary>
        internal bool IsSetAffectedSessions() => this.AffectedSessions != null && (this.AffectedSessions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The unique identifier of the root cause cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the root cause cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommended fix for this root cause.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property RootCause. 
        /// <para>
        /// The root cause explanation for this cluster of failures.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RootCause { get; set; }

        /// <summary>
        /// Checks to see if the RootCause property is set.
        /// </summary>
        internal bool IsSetRootCause() => this.RootCause != null;
    }
}
