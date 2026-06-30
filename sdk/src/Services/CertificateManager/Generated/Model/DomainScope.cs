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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Specifies the scope of domain validation.
    /// </summary>
    public partial class DomainScope
    {
        private DomainScopeOption _exactDomain;
        private DomainScopeOption _subdomains;
        private DomainScopeOption _wildcards;

        /// <summary>
        /// Gets and sets the property ExactDomain. 
        /// <para>
        /// Whether validation applies to the exact domain.
        /// </para>
        /// </summary>
        public DomainScopeOption ExactDomain
        {
            get { return this._exactDomain; }
            set { this._exactDomain = value; }
        }

        // Check to see if ExactDomain property is set
        internal bool IsSetExactDomain()
        {
            return this._exactDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Subdomains. 
        /// <para>
        /// Whether validation applies to subdomains.
        /// </para>
        /// </summary>
        public DomainScopeOption Subdomains
        {
            get { return this._subdomains; }
            set { this._subdomains = value; }
        }

        // Check to see if Subdomains property is set
        internal bool IsSetSubdomains()
        {
            return this._subdomains != null;
        }

        /// <summary>
        /// Gets and sets the property Wildcards. 
        /// <para>
        /// Whether validation applies to wildcard domains.
        /// </para>
        /// </summary>
        public DomainScopeOption Wildcards
        {
            get { return this._wildcards; }
            set { this._wildcards = value; }
        }

        // Check to see if Wildcards property is set
        internal bool IsSetWildcards()
        {
            return this._wildcards != null;
        }

    }
}