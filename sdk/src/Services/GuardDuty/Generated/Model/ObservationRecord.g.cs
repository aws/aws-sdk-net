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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains a fact that GuardDuty noted about your environment during an investigation,
    /// such as the affected resource, the activity on that resource, or your detection coverage.
    /// The record contains at most one of the payload members, the one that matches <c>ObservationType</c>.
    /// <c>Indicators</c> can accompany any observation type.
    /// </summary>
    public partial class ObservationRecord
    {
        /// <summary>
        /// Gets and sets the property AccountOverview. 
        /// <para>
        /// Overview information about an account. Set when <c>ObservationType</c> is <c>ACCOUNT_OVERVIEW</c>.
        /// </para>
        /// </summary>
        public AccountOverview AccountOverview { get; set; }

        /// <summary>
        /// Checks to see if the AccountOverview property is set.
        /// </summary>
        internal bool IsSetAccountOverview() => this.AccountOverview != null;

        /// <summary>
        /// Gets and sets the property DetectionCoverage. 
        /// <para>
        /// Details about your detection coverage. Set when <c>ObservationType</c> is <c>DETECTION_COVERAGE</c>.
        /// </para>
        /// </summary>
        public DetectionCoverage DetectionCoverage { get; set; }

        /// <summary>
        /// Checks to see if the DetectionCoverage property is set.
        /// </summary>
        internal bool IsSetDetectionCoverage() => this.DetectionCoverage != null;

        /// <summary>
        /// Gets and sets the property Distribution. 
        /// <para>
        /// A breakdown of findings along one dimension. Set when <c>ObservationType</c> is <c>DISTRIBUTION</c>.
        /// </para>
        /// </summary>
        public Distribution Distribution { get; set; }

        /// <summary>
        /// Checks to see if the Distribution property is set.
        /// </summary>
        internal bool IsSetDistribution() => this.Distribution != null;

        /// <summary>
        /// Gets and sets the property FindingDetail. 
        /// <para>
        /// Details about a GuardDuty finding. Set when <c>ObservationType</c> is <c>FINDING_DETAIL</c>.
        /// </para>
        /// </summary>
        public FindingDetail FindingDetail { get; set; }

        /// <summary>
        /// Checks to see if the FindingDetail property is set.
        /// </summary>
        internal bool IsSetFindingDetail() => this.FindingDetail != null;

        /// <summary>
        /// Gets and sets the property Indicators. 
        /// <para>
        /// The threat indicators associated with the observation, such as an IP address, a domain,
        /// or a file hash.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<InvestigationIndicator> Indicators { get; set; } = AWSConfigs.InitializeCollections ? new List<InvestigationIndicator>() : null;

        /// <summary>
        /// Checks to see if the Indicators property is set.
        /// </summary>
        internal bool IsSetIndicators() => this.Indicators != null && (this.Indicators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KubernetesActivity. 
        /// <para>
        /// Details about Kubernetes activity. Set when <c>ObservationType</c> is <c>KUBERNETES_ACTIVITY</c>.
        /// </para>
        /// </summary>
        public KubernetesActivity KubernetesActivity { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesActivity property is set.
        /// </summary>
        internal bool IsSetKubernetesActivity() => this.KubernetesActivity != null;

        /// <summary>
        /// Gets and sets the property MalwareScan. 
        /// <para>
        /// Details about a malware scan. Set when <c>ObservationType</c> is <c>MALWARE_SCAN</c>.
        /// </para>
        /// </summary>
        public InvestigationMalwareScan MalwareScan { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScan property is set.
        /// </summary>
        internal bool IsSetMalwareScan() => this.MalwareScan != null;

        /// <summary>
        /// Gets and sets the property NetworkActivity. 
        /// <para>
        /// Details about network activity. Set when <c>ObservationType</c> is <c>NETWORK_ACTIVITY</c>.
        /// </para>
        /// </summary>
        public NetworkActivity NetworkActivity { get; set; }

        /// <summary>
        /// Checks to see if the NetworkActivity property is set.
        /// </summary>
        internal bool IsSetNetworkActivity() => this.NetworkActivity != null;

        /// <summary>
        /// Gets and sets the property ObservationType. 
        /// <para>
        /// The kind of observation. The value identifies the payload member that can be set:
        /// <c>FINDING_DETAIL</c> (<c>FindingDetail</c>), <c>RESOURCE</c> (<c>Resource</c>), <c>NETWORK_ACTIVITY</c>
        /// (<c>NetworkActivity</c>), <c>RDS_LOGIN_ACTIVITY</c> (<c>RdsLoginActivity</c>), <c>S3_ACTIVITY</c>
        /// (<c>S3Activity</c>), <c>KUBERNETES_ACTIVITY</c> (<c>KubernetesActivity</c>), <c>MALWARE_SCAN</c>
        /// (<c>MalwareScan</c>), <c>RELATED_FINDINGS</c> (<c>RelatedFindings</c>), <c>DETECTION_COVERAGE</c>
        /// (<c>DetectionCoverage</c>), <c>ACCOUNT_OVERVIEW</c> (<c>AccountOverview</c>), <c>RECOMMENDATION</c>
        /// (<c>Recommendations</c>), <c>RUNTIME_SIGNALS</c> (<c>RuntimeSignals</c>), <c>DISTRIBUTION</c>
        /// (<c>Distribution</c>), and <c>REPRESENTATIVE_RESOURCE</c> (<c>RepresentativeResources</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObservationType ObservationType { get; set; }

        /// <summary>
        /// Checks to see if the ObservationType property is set.
        /// </summary>
        internal bool IsSetObservationType() => this.ObservationType != null;

        /// <summary>
        /// Gets and sets the property RdsLoginActivity. 
        /// <para>
        /// Details about login activity on an Amazon RDS database. Set when <c>ObservationType</c>
        /// is <c>RDS_LOGIN_ACTIVITY</c>.
        /// </para>
        /// </summary>
        public RdsLoginActivity RdsLoginActivity { get; set; }

        /// <summary>
        /// Checks to see if the RdsLoginActivity property is set.
        /// </summary>
        internal bool IsSetRdsLoginActivity() => this.RdsLoginActivity != null;

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// Recommended actions. Set when <c>ObservationType</c> is <c>RECOMMENDATION</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 25)]
        public List<Recommendation> Recommendations { get; set; } = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Checks to see if the Recommendations property is set.
        /// </summary>
        internal bool IsSetRecommendations() => this.Recommendations != null && (this.Recommendations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedFindings. 
        /// <para>
        /// Details about findings that are related to the investigated activity. Set when <c>ObservationType</c>
        /// is <c>RELATED_FINDINGS</c>.
        /// </para>
        /// </summary>
        public RelatedFindings RelatedFindings { get; set; }

        /// <summary>
        /// Checks to see if the RelatedFindings property is set.
        /// </summary>
        internal bool IsSetRelatedFindings() => this.RelatedFindings != null;

        /// <summary>
        /// Gets and sets the property RepresentativeResources. 
        /// <para>
        /// Representative findings for the affected resources, one finding for each resource.
        /// Set when <c>ObservationType</c> is <c>REPRESENTATIVE_RESOURCE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<RepresentativeFinding> RepresentativeResources { get; set; } = AWSConfigs.InitializeCollections ? new List<RepresentativeFinding>() : null;

        /// <summary>
        /// Checks to see if the RepresentativeResources property is set.
        /// </summary>
        internal bool IsSetRepresentativeResources() => this.RepresentativeResources != null && (this.RepresentativeResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Details about an affected resource. Set when <c>ObservationType</c> is <c>RESOURCE</c>.
        /// </para>
        /// </summary>
        public InvestigationResource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property RuntimeSignals. 
        /// <para>
        /// A summary of runtime signals. Set when <c>ObservationType</c> is <c>RUNTIME_SIGNALS</c>.
        /// </para>
        /// </summary>
        public RuntimeSignals RuntimeSignals { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSignals property is set.
        /// </summary>
        internal bool IsSetRuntimeSignals() => this.RuntimeSignals != null;

        /// <summary>
        /// Gets and sets the property S3Activity. 
        /// <para>
        /// Details about Amazon S3 activity. Set when <c>ObservationType</c> is <c>S3_ACTIVITY</c>.
        /// </para>
        /// </summary>
        public S3Activity S3Activity { get; set; }

        /// <summary>
        /// Checks to see if the S3Activity property is set.
        /// </summary>
        internal bool IsSetS3Activity() => this.S3Activity != null;
    }
}
