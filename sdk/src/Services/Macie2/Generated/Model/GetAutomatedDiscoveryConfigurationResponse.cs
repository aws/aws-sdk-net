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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
        private AutoEnableMode _autoEnableOrganizationMembers;
        private string _classificationScopeId;
        private DateTime? _disabledAt;
        private DateTime? _firstEnabledAt;
        private DateTime? _lastUpdatedAt;
        private string _sensitivityInspectionTemplateId;
        private AutomatedDiscoveryStatus _status;

        /// <summary>
        /// Gets and sets the property AutoEnableOrganizationMembers. 
        /// <para>
        /// Specifies whether automated sensitive data discovery is enabled automatically for
        /// accounts in the organization. Possible values are: ALL, enable it for all existing
        /// accounts and new member accounts; NEW, enable it only for new member accounts; and,
        /// NONE, don't enable it for any accounts.
        /// </para>
        /// </summary>
        public AutoEnableMode AutoEnableOrganizationMembers
        {
            get { return this._autoEnableOrganizationMembers; }
            set { this._autoEnableOrganizationMembers = value; }
        }

        // Check to see if AutoEnableOrganizationMembers property is set
        internal bool IsSetAutoEnableOrganizationMembers()
        {
            return this._autoEnableOrganizationMembers != null;
        }

        /// <summary>
        /// Gets and sets the property ClassificationScopeId. 
        /// <para>
        /// The unique identifier for the classification scope that's used when performing automated
        /// sensitive data discovery. The classification scope specifies S3 buckets to exclude
        /// from analyses.
        /// </para>
        /// </summary>
        public string ClassificationScopeId
        {
            get { return this._classificationScopeId; }
            set { this._classificationScopeId = value; }
        }

        // Check to see if ClassificationScopeId property is set
        internal bool IsSetClassificationScopeId()
        {
            return this._classificationScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when automated sensitive data
        /// discovery was most recently disabled. This value is null if automated sensitive data
        /// discovery is currently enabled.
        /// </para>
        /// </summary>
        public DateTime? DisabledAt
        {
            get { return this._disabledAt; }
            set { this._disabledAt = value; }
        }

        // Check to see if DisabledAt property is set
        internal bool IsSetDisabledAt()
        {
            return this._disabledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstEnabledAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when automated sensitive data
        /// discovery was initially enabled. This value is null if automated sensitive data discovery
        /// has never been enabled.
        /// </para>
        /// </summary>
        public DateTime? FirstEnabledAt
        {
            get { return this._firstEnabledAt; }
            set { this._firstEnabledAt = value; }
        }

        // Check to see if FirstEnabledAt property is set
        internal bool IsSetFirstEnabledAt()
        {
            return this._firstEnabledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the configuration settings
        /// or status of automated sensitive data discovery was most recently changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SensitivityInspectionTemplateId. 
        /// <para>
        /// The unique identifier for the sensitivity inspection template that's used when performing
        /// automated sensitive data discovery. The template specifies which allow lists, custom
        /// data identifiers, and managed data identifiers to use when analyzing data.
        /// </para>
        /// </summary>
        public string SensitivityInspectionTemplateId
        {
            get { return this._sensitivityInspectionTemplateId; }
            set { this._sensitivityInspectionTemplateId = value; }
        }

        // Check to see if SensitivityInspectionTemplateId property is set
        internal bool IsSetSensitivityInspectionTemplateId()
        {
            return this._sensitivityInspectionTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of automated sensitive data discovery for the organization or account.
        /// Possible values are: ENABLED, use the specified settings to perform automated sensitive
        /// data discovery activities; and, DISABLED, don't perform automated sensitive data discovery
        /// activities.
        /// </para>
        /// </summary>
        public AutomatedDiscoveryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}