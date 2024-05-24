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
    /// Information about how a package originally entered the CodeArtifact domain. For packages
    /// published directly to CodeArtifact, the entry point is the repository it was published
    /// to. For packages ingested from an external repository, the entry point is the external
    /// connection that it was ingested from. An external connection is a CodeArtifact repository
    /// that is connected to an external repository such as the npm registry or NuGet gallery.
    /// 
    ///  <note> 
    /// <para>
    /// If a package version exists in a repository and is updated, for example if a package
    /// of the same version is added with additional assets, the package version's <c>DomainEntryPoint</c>
    /// will not change from the original package version's value.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DomainEntryPoint
    {
        private string _externalConnectionName;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ExternalConnectionName. 
        /// <para>
        /// The name of the external connection that a package was ingested from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string ExternalConnectionName
        {
            get { return this._externalConnectionName; }
            set { this._externalConnectionName = value; }
        }

        // Check to see if ExternalConnectionName property is set
        internal bool IsSetExternalConnectionName()
        {
            return this._externalConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that a package was originally published to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}