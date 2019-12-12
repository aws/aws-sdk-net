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
    /// Information that shows whether a resource is compliant with the effective tag policy,
    /// including details on any noncompliant tag keys.
    /// </summary>
    public partial class ComplianceDetails
    {
        private bool? _complianceStatus;
        private List<string> _keysWithNoncompliantValues = new List<string>();
        private List<string> _noncompliantKeys = new List<string>();

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
        /// Gets and sets the property KeysWithNoncompliantValues. 
        /// <para>
        /// The tag value is noncompliant with the effective tag policy.
        /// </para>
        /// </summary>
        public List<string> KeysWithNoncompliantValues
        {
            get { return this._keysWithNoncompliantValues; }
            set { this._keysWithNoncompliantValues = value; }
        }

        // Check to see if KeysWithNoncompliantValues property is set
        internal bool IsSetKeysWithNoncompliantValues()
        {
            return this._keysWithNoncompliantValues != null && this._keysWithNoncompliantValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NoncompliantKeys. 
        /// <para>
        /// The tag key is noncompliant with the effective tag policy.
        /// </para>
        /// </summary>
        public List<string> NoncompliantKeys
        {
            get { return this._noncompliantKeys; }
            set { this._noncompliantKeys = value; }
        }

        // Check to see if NoncompliantKeys property is set
        internal bool IsSetNoncompliantKeys()
        {
            return this._noncompliantKeys != null && this._noncompliantKeys.Count > 0; 
        }

    }
}