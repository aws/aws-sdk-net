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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetAutomatedDiscoveryConfiguration operation.
    /// </summary>
    public partial class GetAutomatedDiscoveryConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoEnableOrganizationMembers. 
        /// <para>
        /// Specifies whether automated sensitive data discovery is enabled automatically for
        /// accounts in the organization. Possible values are: ALL, enable it for all existing
        /// accounts and new member accounts; NEW, enable it only for new member accounts; and,
        /// NONE, don't enable it for any accounts.
        /// </para>
        /// </summary>
        public AutoEnableMode AutoEnableOrganizationMembers { get; set; }

        /// <summary>
        /// Checks to see if the AutoEnableOrganizationMembers property is set.
        /// </summary>
        internal bool IsSetAutoEnableOrganizationMembers() => this.AutoEnableOrganizationMembers != null;

        /// <summary>
        /// Gets and sets the property ClassificationScopeId. 
        /// <para>
        /// The unique identifier for the classification scope that's used when performing automated
        /// sensitive data discovery. The classification scope specifies S3 buckets to exclude
        /// from analyses.
        /// </para>
        /// </summary>
        public string ClassificationScopeId { get; set; }

        /// <summary>
        /// Checks to see if the ClassificationScopeId property is set.
        /// </summary>
        internal bool IsSetClassificationScopeId() => this.ClassificationScopeId != null;

        /// <summary>
        /// Gets and sets the property DisabledAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when automated sensitive data
        /// discovery was most recently disabled. This value is null if automated sensitive data
        /// discovery is currently enabled.
        /// </para>
        /// </summary>
        public DateTime? DisabledAt { get; set; }

        /// <summary>
        /// Checks to see if the DisabledAt property is set.
        /// </summary>
        internal bool IsSetDisabledAt() => this.DisabledAt.HasValue;

        /// <summary>
        /// Gets and sets the property FirstEnabledAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when automated sensitive data
        /// discovery was initially enabled. This value is null if automated sensitive data discovery
        /// has never been enabled.
        /// </para>
        /// </summary>
        public DateTime? FirstEnabledAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstEnabledAt property is set.
        /// </summary>
        internal bool IsSetFirstEnabledAt() => this.FirstEnabledAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the configuration settings
        /// or status of automated sensitive data discovery was most recently changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SensitivityInspectionTemplateId. 
        /// <para>
        /// The unique identifier for the sensitivity inspection template that's used when performing
        /// automated sensitive data discovery. The template specifies which allow lists, custom
        /// data identifiers, and managed data identifiers to use when analyzing data.
        /// </para>
        /// </summary>
        public string SensitivityInspectionTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the SensitivityInspectionTemplateId property is set.
        /// </summary>
        internal bool IsSetSensitivityInspectionTemplateId() => this.SensitivityInspectionTemplateId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of automated sensitive data discovery for the organization or account.
        /// Possible values are: ENABLED, use the specified settings to perform automated sensitive
        /// data discovery activities; and, DISABLED, don't perform automated sensitive data discovery
        /// activities.
        /// </para>
        /// </summary>
        public AutomatedDiscoveryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
