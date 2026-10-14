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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the GetFindingMetrics operation.
    /// </summary>
    public partial class GetFindingMetricsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FindingsEscalated. The number of findings escalated during
        /// the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsEscalated { get; set; }

        /// <summary>
        /// Checks to see if the FindingsEscalated property is set.
        /// </summary>
        internal bool IsSetFindingsEscalated() => this.FindingsEscalated.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsEscalatedFalsePositive. The number of escalated
        /// findings that were closed as false positives during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsEscalatedFalsePositive { get; set; }

        /// <summary>
        /// Checks to see if the FindingsEscalatedFalsePositive property is set.
        /// </summary>
        internal bool IsSetFindingsEscalatedFalsePositive() => this.FindingsEscalatedFalsePositive.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsEscalatedInProgress. The number of findings whose
        /// escalation was in progress during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsEscalatedInProgress { get; set; }

        /// <summary>
        /// Checks to see if the FindingsEscalatedInProgress property is set.
        /// </summary>
        internal bool IsSetFindingsEscalatedInProgress() => this.FindingsEscalatedInProgress.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsIngestedGuardDuty. The number of findings ingested
        /// from Amazon GuardDuty during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsIngestedGuardDuty { get; set; }

        /// <summary>
        /// Checks to see if the FindingsIngestedGuardDuty property is set.
        /// </summary>
        internal bool IsSetFindingsIngestedGuardDuty() => this.FindingsIngestedGuardDuty.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsIngestedSecurityHub. The number of findings ingested
        /// from AWS Security Hub during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsIngestedSecurityHub { get; set; }

        /// <summary>
        /// Checks to see if the FindingsIngestedSecurityHub property is set.
        /// </summary>
        internal bool IsSetFindingsIngestedSecurityHub() => this.FindingsIngestedSecurityHub.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsInvestigated. The number of findings investigated
        /// during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsInvestigated { get; set; }

        /// <summary>
        /// Checks to see if the FindingsInvestigated property is set.
        /// </summary>
        internal bool IsSetFindingsInvestigated() => this.FindingsInvestigated.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsInvestigatedFalsePositive. The number of investigated
        /// findings that were closed as false positives during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsInvestigatedFalsePositive { get; set; }

        /// <summary>
        /// Checks to see if the FindingsInvestigatedFalsePositive property is set.
        /// </summary>
        internal bool IsSetFindingsInvestigatedFalsePositive() => this.FindingsInvestigatedFalsePositive.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsInvestigatedInProgress. The number of findings
        /// whose investigation was in progress during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsInvestigatedInProgress { get; set; }

        /// <summary>
        /// Checks to see if the FindingsInvestigatedInProgress property is set.
        /// </summary>
        internal bool IsSetFindingsInvestigatedInProgress() => this.FindingsInvestigatedInProgress.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsTriaged. The number of findings triaged during
        /// the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsTriaged { get; set; }

        /// <summary>
        /// Checks to see if the FindingsTriaged property is set.
        /// </summary>
        internal bool IsSetFindingsTriaged() => this.FindingsTriaged.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsTriagedFalsePositive. The number of triaged findings
        /// that were closed as false positives during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsTriagedFalsePositive { get; set; }

        /// <summary>
        /// Checks to see if the FindingsTriagedFalsePositive property is set.
        /// </summary>
        internal bool IsSetFindingsTriagedFalsePositive() => this.FindingsTriagedFalsePositive.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsTruePositive. The number of findings confirmed
        /// as true positives during the requested date range.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? FindingsTruePositive { get; set; }

        /// <summary>
        /// Checks to see if the FindingsTruePositive property is set.
        /// </summary>
        internal bool IsSetFindingsTruePositive() => this.FindingsTruePositive.HasValue;
    }
}
