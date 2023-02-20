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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSettings operation.
    /// Updates Audit Manager settings for the current account.
    /// </summary>
    public partial class UpdateSettingsRequest : AmazonAuditManagerRequest
    {
        private AssessmentReportsDestination _defaultAssessmentReportsDestination;
        private List<Role> _defaultProcessOwners = new List<Role>();
        private DeregistrationPolicy _deregistrationPolicy;
        private bool? _evidenceFinderEnabled;
        private string _kmsKey;
        private string _snsTopic;

        /// <summary>
        /// Gets and sets the property DefaultAssessmentReportsDestination. 
        /// <para>
        ///  The default storage destination for assessment reports. 
        /// </para>
        /// </summary>
        public AssessmentReportsDestination DefaultAssessmentReportsDestination
        {
            get { return this._defaultAssessmentReportsDestination; }
            set { this._defaultAssessmentReportsDestination = value; }
        }

        // Check to see if DefaultAssessmentReportsDestination property is set
        internal bool IsSetDefaultAssessmentReportsDestination()
        {
            return this._defaultAssessmentReportsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultProcessOwners. 
        /// <para>
        ///  A list of the default audit owners. 
        /// </para>
        /// </summary>
        public List<Role> DefaultProcessOwners
        {
            get { return this._defaultProcessOwners; }
            set { this._defaultProcessOwners = value; }
        }

        // Check to see if DefaultProcessOwners property is set
        internal bool IsSetDefaultProcessOwners()
        {
            return this._defaultProcessOwners != null && this._defaultProcessOwners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeregistrationPolicy. 
        /// <para>
        /// The deregistration policy for your Audit Manager data. You can use this attribute
        /// to determine how your data is handled when you deregister Audit Manager.
        /// </para>
        /// </summary>
        public DeregistrationPolicy DeregistrationPolicy
        {
            get { return this._deregistrationPolicy; }
            set { this._deregistrationPolicy = value; }
        }

        // Check to see if DeregistrationPolicy property is set
        internal bool IsSetDeregistrationPolicy()
        {
            return this._deregistrationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceFinderEnabled. 
        /// <para>
        /// Specifies whether the evidence finder feature is enabled. Change this attribute to
        /// enable or disable evidence finder.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use this attribute to disable evidence finder, Audit Manager deletes the
        /// event data store that’s used to query your evidence data. As a result, you can’t re-enable
        /// evidence finder and use the feature again. Your only alternative is to <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeregisterAccount.html">deregister</a>
        /// and then <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_RegisterAccount.html">re-register</a>
        /// Audit Manager. 
        /// </para>
        ///  </important>
        /// </summary>
        public bool EvidenceFinderEnabled
        {
            get { return this._evidenceFinderEnabled.GetValueOrDefault(); }
            set { this._evidenceFinderEnabled = value; }
        }

        // Check to see if EvidenceFinderEnabled property is set
        internal bool IsSetEvidenceFinderEnabled()
        {
            return this._evidenceFinderEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The KMS key details. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        ///  The Amazon Simple Notification Service (Amazon SNS) topic that Audit Manager sends
        /// notifications to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=2048)]
        public string SnsTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SnsTopic property is set
        internal bool IsSetSnsTopic()
        {
            return this._snsTopic != null;
        }

    }
}