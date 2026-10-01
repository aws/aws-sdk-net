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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a disruption compliance recommendation.
    /// </summary>
    public partial class RecommendationDisruptionCompliance
    {
        /// <summary>
        /// Gets and sets the property ExpectedComplianceStatus. 
        /// <para>
        /// The expected compliance status after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComplianceStatus ExpectedComplianceStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedComplianceStatus property is set.
        /// </summary>
        internal bool IsSetExpectedComplianceStatus() => this.ExpectedComplianceStatus != null;

        /// <summary>
        /// Gets and sets the property ExpectedRpoDescription. 
        /// <para>
        /// The expected Recovery Point Objective (RPO) description after applying the recommended
        /// configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ExpectedRpoDescription { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRpoDescription property is set.
        /// </summary>
        internal bool IsSetExpectedRpoDescription() => this.ExpectedRpoDescription != null;

        /// <summary>
        /// Gets and sets the property ExpectedRpoInSecs. 
        /// <para>
        /// The expected RPO after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ExpectedRpoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRpoInSecs property is set.
        /// </summary>
        internal bool IsSetExpectedRpoInSecs() => this.ExpectedRpoInSecs.HasValue;

        /// <summary>
        /// Gets and sets the property ExpectedRtoDescription. 
        /// <para>
        /// The expected Recovery Time Objective (RTO) description after applying the recommended
        /// configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ExpectedRtoDescription { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRtoDescription property is set.
        /// </summary>
        internal bool IsSetExpectedRtoDescription() => this.ExpectedRtoDescription != null;

        /// <summary>
        /// Gets and sets the property ExpectedRtoInSecs. 
        /// <para>
        /// The expected RTO after applying the recommended configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ExpectedRtoInSecs { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRtoInSecs property is set.
        /// </summary>
        internal bool IsSetExpectedRtoInSecs() => this.ExpectedRtoInSecs.HasValue;
    }
}
