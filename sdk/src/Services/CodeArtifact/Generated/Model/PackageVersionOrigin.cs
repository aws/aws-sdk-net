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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Information about how a package version was added to a repository.
    /// </summary>
    public partial class PackageVersionOrigin
    {
        private DomainEntryPoint _domainEntryPoint;
        private PackageVersionOriginType _originType;

        /// <summary>
        /// Gets and sets the property DomainEntryPoint. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_DomainEntryPoint.html">DomainEntryPoint</a>
        /// object that contains information about from which repository or external connection
        /// the package version was added to the domain.
        /// </para>
        /// </summary>
        public DomainEntryPoint DomainEntryPoint
        {
            get { return this._domainEntryPoint; }
            set { this._domainEntryPoint = value; }
        }

        // Check to see if DomainEntryPoint property is set
        internal bool IsSetDomainEntryPoint()
        {
            return this._domainEntryPoint != null;
        }

        /// <summary>
        /// Gets and sets the property OriginType. 
        /// <para>
        /// Describes how the package version was originally added to the domain. An <c>INTERNAL</c>
        /// origin type means the package version was published directly to a repository in the
        /// domain. An <c>EXTERNAL</c> origin type means the package version was ingested from
        /// an external connection.
        /// </para>
        /// </summary>
        public PackageVersionOriginType OriginType
        {
            get { return this._originType; }
            set { this._originType = value; }
        }

        // Check to see if OriginType property is set
        internal bool IsSetOriginType()
        {
            return this._originType != null;
        }

    }
}