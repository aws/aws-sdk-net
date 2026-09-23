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
    /// Defines which resources of a given type are in scope. Exactly one of <c>includeAll</c>,
    /// <c>include</c>, or <c>exclude</c> is set.
    /// </summary>
    public partial class ResourceScope
    {
        private ResourceSet _exclude;
        private ResourceSet _include;
        private bool? _includeAll;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Excludes the resources that match the specified criteria or explicit ARNs.
        /// </para>
        /// </summary>
        public ResourceSet Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null;
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Includes the resources that match the specified criteria or explicit ARNs.
        /// </para>
        /// </summary>
        public ResourceSet Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// Includes all resources of the resource type.
        /// </para>
        /// </summary>
        public bool? IncludeAll
        {
            get { return this._includeAll; }
            set { this._includeAll = value; }
        }

        // Check to see if IncludeAll property is set
        internal bool IsSetIncludeAll()
        {
            return this._includeAll.HasValue; 
        }

    }
}