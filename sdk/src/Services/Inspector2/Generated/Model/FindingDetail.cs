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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private CisaData _cisaData;
        private List<string> _cwes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _epssScore;
        private List<Evidence> _evidences = AWSConfigs.InitializeCollections ? new List<Evidence>() : null;
        private ExploitObserved _exploitObserved;
        private string _findingArn;
        private List<string> _referenceUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _riskScore;
        private List<string> _tools = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ttps = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CisaData. 
        /// <para>
        /// The Cybersecurity and Infrastructure Security Agency (CISA) details for a specific
        /// vulnerability.
        /// </para>
        /// </summary>
        public CisaData CisaData
        {
            get { return this._cisaData; }
            set { this._cisaData = value; }
        }

        // Check to see if CisaData property is set
        internal bool IsSetCisaData()
        {
            return this._cisaData != null;
        }

        /// <summary>
        /// Gets and sets the property Cwes. 
        /// <para>
        /// The Common Weakness Enumerations (CWEs) associated with the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> Cwes
        {
            get { return this._cwes; }
            set { this._cwes = value; }
        }

        // Check to see if Cwes property is set
        internal bool IsSetCwes()
        {
            return this._cwes != null && (this._cwes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EpssScore. 
        /// <para>
        /// The Exploit Prediction Scoring System (EPSS) score of the vulnerability.
        /// </para>
        /// </summary>
        public double? EpssScore
        {
            get { return this._epssScore; }
            set { this._epssScore = value; }
        }

        // Check to see if EpssScore property is set
        internal bool IsSetEpssScore()
        {
            return this._epssScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Evidences. 
        /// <para>
        /// Information on the evidence of the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Evidence> Evidences
        {
            get { return this._evidences; }
            set { this._evidences = value; }
        }

        // Check to see if Evidences property is set
        internal bool IsSetEvidences()
        {
            return this._evidences != null && (this._evidences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExploitObserved. 
        /// <para>
        /// Contains information on when this exploit was observed.
        /// </para>
        /// </summary>
        public ExploitObserved ExploitObserved
        {
            get { return this._exploitObserved; }
            set { this._exploitObserved = value; }
        }

        // Check to see if ExploitObserved property is set
        internal bool IsSetExploitObserved()
        {
            return this._exploitObserved != null;
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The finding ARN that the vulnerability details are associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceUrls. 
        /// <para>
        /// The reference URLs for the vulnerability data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ReferenceUrls
        {
            get { return this._referenceUrls; }
            set { this._referenceUrls = value; }
        }

        // Check to see if ReferenceUrls property is set
        internal bool IsSetReferenceUrls()
        {
            return this._referenceUrls != null && (this._referenceUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// The risk score of the vulnerability.
        /// </para>
        /// </summary>
        public int? RiskScore
        {
            get { return this._riskScore; }
            set { this._riskScore = value; }
        }

        // Check to see if RiskScore property is set
        internal bool IsSetRiskScore()
        {
            return this._riskScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The known malware tools or kits that can exploit the vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        // Check to see if Tools property is set
        internal bool IsSetTools()
        {
            return this._tools != null && (this._tools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ttps. 
        /// <para>
        /// The MITRE adversary tactics, techniques, or procedures (TTPs) associated with the
        /// vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> Ttps
        {
            get { return this._ttps; }
            set { this._ttps = value; }
        }

        // Check to see if Ttps property is set
        internal bool IsSetTtps()
        {
            return this._ttps != null && (this._ttps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}