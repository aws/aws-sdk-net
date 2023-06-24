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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains additional information about the generated finding.
    /// </summary>
    public partial class Service
    {
        private Action _action;
        private ServiceAdditionalInfo _additionalInfo;
        private bool? _archived;
        private int? _count;
        private string _detectorId;
        private EbsVolumeScanDetails _ebsVolumeScanDetails;
        private string _eventFirstSeen;
        private string _eventLastSeen;
        private Evidence _evidence;
        private string _featureName;
        private string _resourceRole;
        private RuntimeDetails _runtimeDetails;
        private string _serviceName;
        private string _userFeedback;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Information about the activity that is described in a finding.
        /// </para>
        /// </summary>
        public Action Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Contains additional information about the generated finding.
        /// </para>
        /// </summary>
        public ServiceAdditionalInfo AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Archived. 
        /// <para>
        /// Indicates whether this finding is archived.
        /// </para>
        /// </summary>
        public bool Archived
        {
            get { return this._archived.GetValueOrDefault(); }
            set { this._archived = value; }
        }

        // Check to see if Archived property is set
        internal bool IsSetArchived()
        {
            return this._archived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total count of the occurrences of this finding type.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID for the GuardDuty service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property EbsVolumeScanDetails. 
        /// <para>
        /// Returns details from the malware scan that created a finding.
        /// </para>
        /// </summary>
        public EbsVolumeScanDetails EbsVolumeScanDetails
        {
            get { return this._ebsVolumeScanDetails; }
            set { this._ebsVolumeScanDetails = value; }
        }

        // Check to see if EbsVolumeScanDetails property is set
        internal bool IsSetEbsVolumeScanDetails()
        {
            return this._ebsVolumeScanDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EventFirstSeen. 
        /// <para>
        /// The first-seen timestamp of the activity that prompted GuardDuty to generate this
        /// finding.
        /// </para>
        /// </summary>
        public string EventFirstSeen
        {
            get { return this._eventFirstSeen; }
            set { this._eventFirstSeen = value; }
        }

        // Check to see if EventFirstSeen property is set
        internal bool IsSetEventFirstSeen()
        {
            return this._eventFirstSeen != null;
        }

        /// <summary>
        /// Gets and sets the property EventLastSeen. 
        /// <para>
        /// The last-seen timestamp of the activity that prompted GuardDuty to generate this finding.
        /// </para>
        /// </summary>
        public string EventLastSeen
        {
            get { return this._eventLastSeen; }
            set { this._eventLastSeen = value; }
        }

        // Check to see if EventLastSeen property is set
        internal bool IsSetEventLastSeen()
        {
            return this._eventLastSeen != null;
        }

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        /// An evidence object associated with the service.
        /// </para>
        /// </summary>
        public Evidence Evidence
        {
            get { return this._evidence; }
            set { this._evidence = value; }
        }

        // Check to see if Evidence property is set
        internal bool IsSetEvidence()
        {
            return this._evidence != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature that generated a finding.
        /// </para>
        /// </summary>
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRole. 
        /// <para>
        /// The resource role information for this finding.
        /// </para>
        /// </summary>
        public string ResourceRole
        {
            get { return this._resourceRole; }
            set { this._resourceRole = value; }
        }

        // Check to see if ResourceRole property is set
        internal bool IsSetResourceRole()
        {
            return this._resourceRole != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeDetails. 
        /// <para>
        /// Information about the process and any required context values for a specific finding
        /// </para>
        /// </summary>
        public RuntimeDetails RuntimeDetails
        {
            get { return this._runtimeDetails; }
            set { this._runtimeDetails = value; }
        }

        // Check to see if RuntimeDetails property is set
        internal bool IsSetRuntimeDetails()
        {
            return this._runtimeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service (GuardDuty) that generated a finding.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property UserFeedback. 
        /// <para>
        /// Feedback that was submitted about the finding.
        /// </para>
        /// </summary>
        public string UserFeedback
        {
            get { return this._userFeedback; }
            set { this._userFeedback = value; }
        }

        // Check to see if UserFeedback property is set
        internal bool IsSetUserFeedback()
        {
            return this._userFeedback != null;
        }

    }
}