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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetAutomatedDiscoveryConfiguration operation.
    /// </summary>
    public partial class GetAutomatedDiscoveryConfigurationResponse : AmazonWebServiceResponse
    {
        private string _classificationScopeId;
        private DateTime? _disabledAt;
        private DateTime? _firstEnabledAt;
        private DateTime? _lastUpdatedAt;
        private string _sensitivityInspectionTemplateId;
        private AutomatedDiscoveryStatus _status;

        /// <summary>
        /// Gets and sets the property ClassificationScopeId. 
        /// <para>
        /// The unique identifier for the classification scope that's used when performing automated
        /// sensitive data discovery for the account. The classification scope specifies S3 buckets
        /// to exclude from automated sensitive data discovery.
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
        /// discovery was most recently disabled for the account. This value is null if automated
        /// sensitive data discovery wasn't enabled and subsequently disabled for the account.
        /// </para>
        /// </summary>
        public DateTime DisabledAt
        {
            get { return this._disabledAt.GetValueOrDefault(); }
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
        /// discovery was initially enabled for the account. This value is null if automated sensitive
        /// data discovery has never been enabled for the account.
        /// </para>
        /// </summary>
        public DateTime FirstEnabledAt
        {
            get { return this._firstEnabledAt.GetValueOrDefault(); }
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
        /// The date and time, in UTC and extended ISO 8601 format, when automated sensitive data
        /// discovery was most recently enabled or disabled for the account.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
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
        /// automated sensitive data discovery for the account. The template specifies which allow
        /// lists, custom data identifiers, and managed data identifiers to use when analyzing
        /// data.
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
        /// The current status of the automated sensitive data discovery configuration for the
        /// account. Possible values are: ENABLED, use the specified settings to perform automated
        /// sensitive data discovery activities for the account; and, DISABLED, don't perform
        /// automated sensitive data discovery activities for the account.
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