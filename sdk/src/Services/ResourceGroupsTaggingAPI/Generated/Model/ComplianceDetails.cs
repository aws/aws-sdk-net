/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Details on whether a resource is compliant with the effective tag policy, including
    /// information any noncompliant tag keys.
    /// </summary>
    public partial class ComplianceDetails
    {
        private bool? _complianceStatus;
        private List<string> _invalidKeys = new List<string>();
        private List<string> _invalidValues = new List<string>();
        private List<string> _missingKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Whether a resource is compliant with the effective tag policy.
        /// </para>
        /// </summary>
        public bool ComplianceStatus
        {
            get { return this._complianceStatus.GetValueOrDefault(); }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvalidKeys. 
        /// <para>
        /// The tag key is noncompliant with the effective tag policy.
        /// </para>
        /// </summary>
        public List<string> InvalidKeys
        {
            get { return this._invalidKeys; }
            set { this._invalidKeys = value; }
        }

        // Check to see if InvalidKeys property is set
        internal bool IsSetInvalidKeys()
        {
            return this._invalidKeys != null && this._invalidKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InvalidValues. 
        /// <para>
        /// The tag value is noncompliant with the effective tag policy.
        /// </para>
        /// </summary>
        public List<string> InvalidValues
        {
            get { return this._invalidValues; }
            set { this._invalidValues = value; }
        }

        // Check to see if InvalidValues property is set
        internal bool IsSetInvalidValues()
        {
            return this._invalidValues != null && this._invalidValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MissingKeys. 
        /// <para>
        /// A tag key that is required by the effective tag policy is missing.
        /// </para>
        /// </summary>
        public List<string> MissingKeys
        {
            get { return this._missingKeys; }
            set { this._missingKeys = value; }
        }

        // Check to see if MissingKeys property is set
        internal bool IsSetMissingKeys()
        {
            return this._missingKeys != null && this._missingKeys.Count > 0; 
        }

    }
}