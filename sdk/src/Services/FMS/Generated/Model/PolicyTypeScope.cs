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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Defines the policy types that the specified Firewall Manager administrator can manage.
    /// </summary>
    public partial class PolicyTypeScope
    {
        private bool? _allPolicyTypesEnabled;
        private List<string> _policyTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllPolicyTypesEnabled. 
        /// <para>
        /// Allows the specified Firewall Manager administrator to manage all Firewall Manager
        /// policy types, except for third-party policy types. Third-party policy types can only
        /// be managed by the Firewall Manager default administrator.
        /// </para>
        /// </summary>
        public bool? AllPolicyTypesEnabled
        {
            get { return this._allPolicyTypesEnabled; }
            set { this._allPolicyTypesEnabled = value; }
        }

        // Check to see if AllPolicyTypesEnabled property is set
        internal bool IsSetAllPolicyTypesEnabled()
        {
            return this._allPolicyTypesEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyTypes. 
        /// <para>
        /// The list of policy types that the specified Firewall Manager administrator can manage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<string> PolicyTypes
        {
            get { return this._policyTypes; }
            set { this._policyTypes = value; }
        }

        // Check to see if PolicyTypes property is set
        internal bool IsSetPolicyTypes()
        {
            return this._policyTypes != null && (this._policyTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}