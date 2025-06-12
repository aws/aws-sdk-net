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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Information that shows whether a resource is compliant with the effective tag policy,
    /// including details on any noncompliant tag keys.
    /// </summary>
    public partial class ComplianceDetails
    {
        private bool? _complianceStatus;
        private List<string> _keysWithNoncompliantValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _noncompliantKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// Whether a resource is compliant with the effective tag policy.
        /// </para>
        /// </summary>
        public bool? ComplianceStatus
        {
            get { return this._complianceStatus; }
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
        /// These are keys defined in the effective policy that are on the resource with either
        /// incorrect case treatment or noncompliant values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeysWithNoncompliantValues
        {
            get { return this._keysWithNoncompliantValues; }
            set { this._keysWithNoncompliantValues = value; }
        }

        // Check to see if KeysWithNoncompliantValues property is set
        internal bool IsSetKeysWithNoncompliantValues()
        {
            return this._keysWithNoncompliantValues != null && (this._keysWithNoncompliantValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoncompliantKeys. 
        /// <para>
        /// These tag keys on the resource are noncompliant with the effective tag policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NoncompliantKeys
        {
            get { return this._noncompliantKeys; }
            set { this._noncompliantKeys = value; }
        }

        // Check to see if NoncompliantKeys property is set
        internal bool IsSetNoncompliantKeys()
        {
            return this._noncompliantKeys != null && (this._noncompliantKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}