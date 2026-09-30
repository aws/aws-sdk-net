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
    /// Determines which accounts are in scope. Exactly one of <c>includeAll</c>, <c>include</c>,
    /// or <c>exclude</c> is set.
    /// </summary>
    public partial class AccountFilter
    {
        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Excludes the specified accounts and organizational units. All others are in scope.
        /// </para>
        /// </summary>
        public AccountSet Exclude { get; set; }

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Includes only the specified accounts and organizational units.
        /// </para>
        /// </summary>
        public AccountSet Include { get; set; }

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null;

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// Includes all accounts. No account filtering is applied.
        /// </para>
        /// </summary>
        public Unit IncludeAll { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAll property is set.
        /// </summary>
        internal bool IsSetIncludeAll() => this.IncludeAll != null;
    }
}
