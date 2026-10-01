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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Determines which accounts and organizational units are in an administrator's scope.
    /// This is the reference form, which includes display metadata.
    /// </summary>
    public partial class AdminScopeFilter
    {
        /// <summary>
        /// Gets and sets the property ExcludeOnly. 
        /// <para>
        /// The accounts and organizational units to exclude from the administrator's scope. All
        /// others are in scope.
        /// </para>
        /// </summary>
        public AdminScopeSelection ExcludeOnly { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeOnly property is set.
        /// </summary>
        internal bool IsSetExcludeOnly() => this.ExcludeOnly != null;

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// All accounts and organizational units are in scope.
        /// </para>
        /// </summary>
        public Unit IncludeAll { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAll property is set.
        /// </summary>
        internal bool IsSetIncludeAll() => this.IncludeAll != null;

        /// <summary>
        /// Gets and sets the property IncludeOnly. 
        /// <para>
        /// Only the specified accounts and organizational units are in the administrator's scope.
        /// </para>
        /// </summary>
        public AdminScopeSelection IncludeOnly { get; set; }

        /// <summary>
        /// Checks to see if the IncludeOnly property is set.
        /// </summary>
        internal bool IsSetIncludeOnly() => this.IncludeOnly != null;
    }
}
