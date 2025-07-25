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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The settings object that holds all supported Audit Manager settings.
    /// </summary>
    public partial class Settings
    {
        private AssessmentReportsDestination _defaultAssessmentReportsDestination;
        private DefaultExportDestination _defaultExportDestination;
        private List<Role> _defaultProcessOwners = AWSConfigs.InitializeCollections ? new List<Role>() : null;
        private DeregistrationPolicy _deregistrationPolicy;
        private EvidenceFinderEnablement _evidenceFinderEnablement;
        private bool? _isAwsOrgEnabled;
        private string _kmsKey;
        private string _snsTopic;

        /// <summary>
        /// Gets and sets the property DefaultAssessmentReportsDestination. 
        /// <para>
        /// The default S3 destination bucket for storing assessment reports.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property DefaultExportDestination. 
        /// <para>
        /// The default S3 destination bucket for storing evidence finder exports.
        /// </para>
        /// </summary>
        public DefaultExportDestination DefaultExportDestination
        {
            get { return this._defaultExportDestination; }
            set { this._defaultExportDestination = value; }
        }

        // Check to see if DefaultExportDestination property is set
        internal bool IsSetDefaultExportDestination()
        {
            return this._defaultExportDestination != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultProcessOwners. 
        /// <para>
        ///  The designated default audit owners. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<Role> DefaultProcessOwners
        {
            get { return this._defaultProcessOwners; }
            set { this._defaultProcessOwners = value; }
        }

        // Check to see if DefaultProcessOwners property is set
        internal bool IsSetDefaultProcessOwners()
        {
            return this._defaultProcessOwners != null && (this._defaultProcessOwners.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property EvidenceFinderEnablement. 
        /// <para>
        /// The current evidence finder status and event data store details.
        /// </para>
        /// </summary>
        public EvidenceFinderEnablement EvidenceFinderEnablement
        {
            get { return this._evidenceFinderEnablement; }
            set { this._evidenceFinderEnablement = value; }
        }

        // Check to see if EvidenceFinderEnablement property is set
        internal bool IsSetEvidenceFinderEnablement()
        {
            return this._evidenceFinderEnablement != null;
        }

        /// <summary>
        /// Gets and sets the property IsAwsOrgEnabled. 
        /// <para>
        ///  Specifies whether Organizations is enabled. 
        /// </para>
        /// </summary>
        public bool? IsAwsOrgEnabled
        {
            get { return this._isAwsOrgEnabled; }
            set { this._isAwsOrgEnabled = value; }
        }

        // Check to see if IsAwsOrgEnabled property is set
        internal bool IsSetIsAwsOrgEnabled()
        {
            return this._isAwsOrgEnabled.HasValue; 
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
        ///  The designated Amazon Simple Notification Service (Amazon SNS) topic. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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