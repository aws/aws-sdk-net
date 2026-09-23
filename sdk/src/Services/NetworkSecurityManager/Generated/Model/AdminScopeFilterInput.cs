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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Determines which accounts and organizational units are in an administrator's scope.
    /// This is the input form, which uses account and organizational unit IDs.
    /// </summary>
    public partial class AdminScopeFilterInput
    {
        private AdminScopeSelectionInput _excludeOnly;
        private Unit _includeAll;
        private AdminScopeSelectionInput _includeOnly;

        /// <summary>
        /// Gets and sets the property ExcludeOnly. 
        /// <para>
        /// The accounts and organizational units to exclude from the administrator's scope. All
        /// others are in scope.
        /// </para>
        /// </summary>
        public AdminScopeSelectionInput ExcludeOnly
        {
            get { return this._excludeOnly; }
            set { this._excludeOnly = value; }
        }

        // Check to see if ExcludeOnly property is set
        internal bool IsSetExcludeOnly()
        {
            return this._excludeOnly != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// All accounts and organizational units are in scope.
        /// </para>
        /// </summary>
        public Unit IncludeAll
        {
            get { return this._includeAll; }
            set { this._includeAll = value; }
        }

        // Check to see if IncludeAll property is set
        internal bool IsSetIncludeAll()
        {
            return this._includeAll != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeOnly. 
        /// <para>
        /// Only the specified accounts and organizational units are in the administrator's scope.
        /// </para>
        /// </summary>
        public AdminScopeSelectionInput IncludeOnly
        {
            get { return this._includeOnly; }
            set { this._includeOnly = value; }
        }

        // Check to see if IncludeOnly property is set
        internal bool IsSetIncludeOnly()
        {
            return this._includeOnly != null;
        }

    }
}