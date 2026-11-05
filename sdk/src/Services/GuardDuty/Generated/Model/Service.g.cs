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
    /// Contains additional information about the generated finding.
    /// </summary>
    public partial class Service
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Information about the activity that is described in a finding.
        /// </para>
        /// </summary>
        public Action Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Contains additional information about the generated finding.
        /// </para>
        /// </summary>
        public ServiceAdditionalInfo AdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInfo property is set.
        /// </summary>
        internal bool IsSetAdditionalInfo() => this.AdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property Archived. 
        /// <para>
        /// Indicates whether this finding is archived.
        /// </para>
        /// </summary>
        public bool? Archived { get; set; }

        /// <summary>
        /// Checks to see if the Archived property is set.
        /// </summary>
        internal bool IsSetArchived() => this.Archived.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total count of the occurrences of this finding type.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Detection. 
        /// <para>
        /// Contains information about the detected unusual behavior.
        /// </para>
        /// </summary>
        public Detection Detection { get; set; }

        /// <summary>
        /// Checks to see if the Detection property is set.
        /// </summary>
        internal bool IsSetDetection() => this.Detection != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID for the GuardDuty service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property EbsVolumeScanDetails. 
        /// <para>
        /// Returns details from the malware scan that created a finding.
        /// </para>
        /// </summary>
        public EbsVolumeScanDetails EbsVolumeScanDetails { get; set; }

        /// <summary>
        /// Checks to see if the EbsVolumeScanDetails property is set.
        /// </summary>
        internal bool IsSetEbsVolumeScanDetails() => this.EbsVolumeScanDetails != null;

        /// <summary>
        /// Gets and sets the property EventFirstSeen. 
        /// <para>
        /// The first-seen timestamp of the activity that prompted GuardDuty to generate this
        /// finding.
        /// </para>
        /// </summary>
        public string EventFirstSeen { get; set; }

        /// <summary>
        /// Checks to see if the EventFirstSeen property is set.
        /// </summary>
        internal bool IsSetEventFirstSeen() => this.EventFirstSeen != null;

        /// <summary>
        /// Gets and sets the property EventLastSeen. 
        /// <para>
        /// The last-seen timestamp of the activity that prompted GuardDuty to generate this finding.
        /// </para>
        /// </summary>
        public string EventLastSeen { get; set; }

        /// <summary>
        /// Checks to see if the EventLastSeen property is set.
        /// </summary>
        internal bool IsSetEventLastSeen() => this.EventLastSeen != null;

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// An evidence object associated with the service.
        /// </para>
        /// </summary>
        public Evidence Evidence { get; set; }

        /// <summary>
        /// Checks to see if the Evidence property is set.
        /// </summary>
        internal bool IsSetEvidence() => this.Evidence != null;

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature that generated a finding.
        /// </para>
        /// </summary>
        public string FeatureName { get; set; }

        /// <summary>
        /// Checks to see if the FeatureName property is set.
        /// </summary>
        internal bool IsSetFeatureName() => this.FeatureName != null;

        /// <summary>
        /// Gets and sets the property MalwareScanDetails. 
        /// <para>
        /// Returns details from the malware scan that generated a GuardDuty finding.
        /// </para>
        /// </summary>
        public MalwareScanDetails MalwareScanDetails { get; set; }

        /// <summary>
        /// Checks to see if the MalwareScanDetails property is set.
        /// </summary>
        internal bool IsSetMalwareScanDetails() => this.MalwareScanDetails != null;

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// The resource role information for this finding.
        /// </para>
        /// </summary>
        public string ResourceRole { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRole property is set.
        /// </summary>
        internal bool IsSetResourceRole() => this.ResourceRole != null;

        /// <summary>
        /// Gets and sets the property RuntimeDetails. 
        /// <para>
        /// Information about the process and any required context values for a specific finding
        /// </para>
        /// </summary>
        public RuntimeDetails RuntimeDetails { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeDetails property is set.
        /// </summary>
        internal bool IsSetRuntimeDetails() => this.RuntimeDetails != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service (GuardDuty) that generated a finding.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property UserFeedback. 
        /// <para>
        /// Feedback that was submitted about the finding.
        /// </para>
        /// </summary>
        public string UserFeedback { get; set; }

        /// <summary>
        /// Checks to see if the UserFeedback property is set.
        /// </summary>
        internal bool IsSetUserFeedback() => this.UserFeedback != null;
    }
}
