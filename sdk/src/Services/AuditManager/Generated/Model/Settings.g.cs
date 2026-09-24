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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The settings object that holds all supported Audit Manager settings.
    /// </summary>
    public partial class Settings
    {
        /// <summary>
        /// Gets and sets the property DefaultAssessmentReportsDestination. 
        /// <para>
        /// The default S3 destination bucket for storing assessment reports.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public AssessmentReportsDestination DefaultAssessmentReportsDestination { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAssessmentReportsDestination property is set.
        /// </summary>
        internal bool IsSetDefaultAssessmentReportsDestination() => this.DefaultAssessmentReportsDestination != null;

        /// <summary>
        /// Gets and sets the property DefaultExportDestination. 
        /// <para>
        /// The default S3 destination bucket for storing evidence finder exports.
        /// </para>
        /// </summary>
        public DefaultExportDestination DefaultExportDestination { get; set; }

        /// <summary>
        /// Checks to see if the DefaultExportDestination property is set.
        /// </summary>
        internal bool IsSetDefaultExportDestination() => this.DefaultExportDestination != null;

        /// <summary>
        /// Gets and sets the property DefaultProcessOwners. 
        /// <para>
        ///  The designated default audit owners. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<Role> DefaultProcessOwners { get; set; } = AWSConfigs.InitializeCollections ? new List<Role>() : null;

        /// <summary>
        /// Checks to see if the DefaultProcessOwners property is set.
        /// </summary>
        internal bool IsSetDefaultProcessOwners() => this.DefaultProcessOwners != null && (this.DefaultProcessOwners.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeregistrationPolicy. 
        /// <para>
        /// The deregistration policy for your Audit Manager data. You can use this attribute
        /// to determine how your data is handled when you deregister Audit Manager.
        /// </para>
        /// </summary>
        public DeregistrationPolicy DeregistrationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DeregistrationPolicy property is set.
        /// </summary>
        internal bool IsSetDeregistrationPolicy() => this.DeregistrationPolicy != null;

        /// <summary>
        /// Gets and sets the property EvidenceFinderEnablement. 
        /// <para>
        /// The current evidence finder status and event data store details.
        /// </para>
        /// </summary>
        public EvidenceFinderEnablement EvidenceFinderEnablement { get; set; }

        /// <summary>
        /// Checks to see if the EvidenceFinderEnablement property is set.
        /// </summary>
        internal bool IsSetEvidenceFinderEnablement() => this.EvidenceFinderEnablement != null;

        /// <summary>
        /// Gets and sets the property IsAwsOrgEnabled. 
        /// <para>
        ///  Specifies whether Organizations is enabled. 
        /// </para>
        /// </summary>
        public bool? IsAwsOrgEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsAwsOrgEnabled property is set.
        /// </summary>
        internal bool IsSetIsAwsOrgEnabled() => this.IsAwsOrgEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The KMS key details. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 2048)]
        public string KmsKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsKey property is set.
        /// </summary>
        internal bool IsSetKmsKey() => this.KmsKey != null;

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        ///  The designated Amazon Simple Notification Service (Amazon SNS) topic. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string SnsTopic { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopic property is set.
        /// </summary>
        internal bool IsSetSnsTopic() => this.SnsTopic != null;
    }
}
