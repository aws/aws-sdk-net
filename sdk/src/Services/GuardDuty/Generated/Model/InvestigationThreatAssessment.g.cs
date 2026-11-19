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
    /// Contains a threat assessment. The members that are set depend on the <c>AnalysisType</c>
    /// of the record.
    /// </summary>
    public partial class InvestigationThreatAssessment
    {
        /// <summary>
        /// Gets and sets the property Assessment. 
        /// <para>
        /// The assessment of the threat.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Assessment { get; set; }

        /// <summary>
        /// Checks to see if the Assessment property is set.
        /// </summary>
        internal bool IsSetAssessment() => this.Assessment != null;

        /// <summary>
        /// Gets and sets the property AuthenticationContext. 
        /// <para>
        /// Context about how the identity involved in the activity authenticated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string AuthenticationContext { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationContext property is set.
        /// </summary>
        internal bool IsSetAuthenticationContext() => this.AuthenticationContext != null;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the threat.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property CredentialCompromise. 
        /// <para>
        /// An assessment of whether credentials were compromised.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string CredentialCompromise { get; set; }

        /// <summary>
        /// Checks to see if the CredentialCompromise property is set.
        /// </summary>
        internal bool IsSetCredentialCompromise() => this.CredentialCompromise != null;

        /// <summary>
        /// Gets and sets the property IpAccountActivity. 
        /// <para>
        /// An assessment of the activity from the IP address in the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string IpAccountActivity { get; set; }

        /// <summary>
        /// Checks to see if the IpAccountActivity property is set.
        /// </summary>
        internal bool IsSetIpAccountActivity() => this.IpAccountActivity != null;

        /// <summary>
        /// Gets and sets the property RdsControlPlaneActivity. 
        /// <para>
        /// An assessment of Amazon RDS control plane activity that is related to the threat.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string RdsControlPlaneActivity { get; set; }

        /// <summary>
        /// Checks to see if the RdsControlPlaneActivity property is set.
        /// </summary>
        internal bool IsSetRdsControlPlaneActivity() => this.RdsControlPlaneActivity != null;

        /// <summary>
        /// Gets and sets the property Reputation. 
        /// <para>
        /// Reputation information about a threat indicator. Set when <c>AnalysisType</c> is <c>REPUTATION</c>.
        /// </para>
        /// </summary>
        public Reputation Reputation { get; set; }

        /// <summary>
        /// Checks to see if the Reputation property is set.
        /// </summary>
        internal bool IsSetReputation() => this.Reputation != null;

        /// <summary>
        /// Gets and sets the property ThreatConfidence. 
        /// <para>
        /// The confidence in the threat assessment. Possible values are <c>VERY_HIGH</c>, <c>HIGH</c>,
        /// <c>MEDIUM</c>, and <c>LOW</c>.
        /// </para>
        /// </summary>
        public ThreatConfidence ThreatConfidence { get; set; }

        /// <summary>
        /// Checks to see if the ThreatConfidence property is set.
        /// </summary>
        internal bool IsSetThreatConfidence() => this.ThreatConfidence != null;
    }
}
