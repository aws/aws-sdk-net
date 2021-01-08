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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the ListPackageVersions operation.
    /// </summary>
    public partial class ListPackageVersionsResponse : AmazonWebServiceResponse
    {
        private string _defaultDisplayVersion;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _nextToken;
        private string _package;
        private List<PackageVersionSummary> _versions = new List<PackageVersionSummary>();

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
        ///  For npm packages, it's the version referenced by the <code>latest</code> tag. If
        /// the <code>latest</code> tag is not set, it's the most recently published package version.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultDisplayVersion
        {
            get { return this._defaultDisplayVersion; }
            set { this._defaultDisplayVersion = value; }
        }

        // Check to see if DefaultDisplayVersion property is set
        internal bool IsSetDefaultDisplayVersion()
        {
            return this._defaultDisplayVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  A format of the package. Valid package format values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>npm</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pypi</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>maven</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>nuget</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PackageFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        ///  The namespace of the package. The package component that specifies its namespace
        /// depends on its type. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package is its <code>groupId</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package is its <code>scope</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A Python package does not contain a corresponding component, so Python packages do
        /// not have a namespace. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A NuGet package does not contain a corresponding component, so NuGet packages do
        /// not have a namespace. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If there are additional results, this is the token for the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Package
        {
            get { return this._package; }
            set { this._package = value; }
        }

        // Check to see if Package property is set
        internal bool IsSetPackage()
        {
            return this._package != null;
        }

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        ///  The returned list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionSummary.html">
        /// <code>PackageVersionSummary</code> </a> objects. 
        /// </para>
        /// </summary>
        public List<PackageVersionSummary> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && this._versions.Count > 0; 
        }

    }
}