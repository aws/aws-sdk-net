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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// The compliance posture a finding reports, for the Application Security Posture Finding
    /// class. Absent for a vulnerability finding.
    /// </summary>
    public partial class FindingPosture
    {
        /// <summary>
        /// Gets and sets the property Application. The application the posture was assessed against.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property ApplicationUid.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ApplicationUid { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationUid property is set.
        /// </summary>
        internal bool IsSetApplicationUid() => this.ApplicationUid != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersion.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersion property is set.
        /// </summary>
        internal bool IsSetApplicationVersion() => this.ApplicationVersion != null;

        /// <summary>
        /// Gets and sets the property Checks. The individual checks performed.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<FindingComplianceCheck> Checks { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingComplianceCheck>() : null;

        /// <summary>
        /// Checks to see if the Checks property is set.
        /// </summary>
        internal bool IsSetChecks() => this.Checks != null && (this.Checks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Control. The control assessed, and the producer's description
        /// of it.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Remediation.
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property RemediationReferences.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> RemediationReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemediationReferences property is set.
        /// </summary>
        internal bool IsSetRemediationReferences() => this.RemediationReferences != null && (this.RemediationReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Requirements.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> Requirements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Requirements property is set.
        /// </summary>
        internal bool IsSetRequirements() => this.Requirements != null && (this.Requirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Standards. Standards and requirements the control maps
        /// to.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> Standards { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Standards property is set.
        /// </summary>
        internal bool IsSetStandards() => this.Standards != null && (this.Standards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. The producer's compliance status, and the enum
        /// value behind it.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusId. The producer's numeric enum value for `status`.
        /// </summary>
        public int? StatusId { get; set; }

        /// <summary>
        /// Checks to see if the StatusId property is set.
        /// </summary>
        internal bool IsSetStatusId() => this.StatusId.HasValue;
    }
}
