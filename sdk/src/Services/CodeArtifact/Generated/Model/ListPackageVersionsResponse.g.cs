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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the ListPackageVersions operation.
    /// </summary>
    public partial class ListPackageVersionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DefaultDisplayVersion. 
        /// <para>
        ///  The default package version to display. This depends on the package format: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For Maven and PyPI packages, it's the most recently published package version. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  For npm packages, it's the version referenced by the <c>latest</c> tag. If the <c>latest</c>
        /// tag is not set, it's the most recently published package version. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DefaultDisplayVersion { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDisplayVersion property is set.
        /// </summary>
        internal bool IsSetDefaultDisplayVersion() => this.DefaultDisplayVersion != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  A format of the package. 
        /// </para>
        /// </summary>
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package that contains the requested package versions. The package
        /// component that specifies its namespace depends on its type. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package version is its <c>groupId</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm or Swift package version is its <c>scope</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The namespace of a generic package is its <c>namespace</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python, NuGet, Ruby, and Cargo package versions do not contain a corresponding component,
        /// package versions of those formats do not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If there are additional results, this is the token for the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        ///  The returned list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionSummary.html">PackageVersionSummary</a>
        /// objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageVersionSummary> Versions { get; set; } = AWSConfigs.InitializeCollections ? new List<PackageVersionSummary>() : null;

        /// <summary>
        /// Checks to see if the Versions property is set.
        /// </summary>
        internal bool IsSetVersions() => this.Versions != null && (this.Versions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
