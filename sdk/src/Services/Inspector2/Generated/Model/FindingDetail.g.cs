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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details of the vulnerability identified in a finding.
    /// </summary>
    public partial class FindingDetail
    {
        /// <summary>
        /// Gets and sets the property CisaData. 
        /// <para>
        /// The Cybersecurity and Infrastructure Security Agency (CISA) details for a specific
        /// vulnerability.
        /// </para>
        /// </summary>
        public CisaData CisaData { get; set; }

        /// <summary>
        /// Checks to see if the CisaData property is set.
        /// </summary>
        internal bool IsSetCisaData() => this.CisaData != null;

        /// <summary>
        /// Gets and sets the property Cwes. 
        /// <para>
        /// The Common Weakness Enumerations (CWEs) associated with the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<string> Cwes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Cwes property is set.
        /// </summary>
        internal bool IsSetCwes() => this.Cwes != null && (this.Cwes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EpssScore. 
        /// <para>
        /// The Exploit Prediction Scoring System (EPSS) score of the vulnerability.
        /// </para>
        /// </summary>
        public double? EpssScore { get; set; }

        /// <summary>
        /// Checks to see if the EpssScore property is set.
        /// </summary>
        internal bool IsSetEpssScore() => this.EpssScore.HasValue;

        /// <summary>
        /// Gets and sets the property Evidences. 
        /// <para>
        /// Information on the evidence of the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Evidence> Evidences { get; set; } = AWSConfigs.InitializeCollections ? new List<Evidence>() : null;

        /// <summary>
        /// Checks to see if the Evidences property is set.
        /// </summary>
        internal bool IsSetEvidences() => this.Evidences != null && (this.Evidences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExploitObserved. 
        /// <para>
        /// Contains information on when this exploit was observed.
        /// </para>
        /// </summary>
        public ExploitObserved ExploitObserved { get; set; }

        /// <summary>
        /// Checks to see if the ExploitObserved property is set.
        /// </summary>
        internal bool IsSetExploitObserved() => this.ExploitObserved != null;

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The finding ARN that the vulnerability details are associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingArn property is set.
        /// </summary>
        internal bool IsSetFindingArn() => this.FindingArn != null;

        /// <summary>
        /// Gets and sets the property ReferenceUrls. 
        /// <para>
        /// The reference URLs for the vulnerability data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ReferenceUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReferenceUrls property is set.
        /// </summary>
        internal bool IsSetReferenceUrls() => this.ReferenceUrls != null && (this.ReferenceUrls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// The risk score of the vulnerability.
        /// </para>
        /// </summary>
        public int? RiskScore { get; set; }

        /// <summary>
        /// Checks to see if the RiskScore property is set.
        /// </summary>
        internal bool IsSetRiskScore() => this.RiskScore.HasValue;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The known malware tools or kits that can exploit the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ttps. 
        /// <para>
        /// The MITRE adversary tactics, techniques, or procedures (TTPs) associated with the
        /// vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<string> Ttps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ttps property is set.
        /// </summary>
        internal bool IsSetTtps() => this.Ttps != null && (this.Ttps.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
