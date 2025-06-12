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
    /// This is the response object from the ListPackageVersionDependencies operation.
    /// </summary>
    public partial class ListPackageVersionDependenciesResponse : AmazonWebServiceResponse
    {
        private List<PackageDependency> _dependencies = AWSConfigs.InitializeCollections ? new List<PackageDependency>() : null;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _nextToken;
        private string _package;
        private string _version;
        private string _versionRevision;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        ///  The returned list of <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDependency.html">PackageDependency</a>
        /// objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackageDependency> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  A format that specifies the type of the package that contains the returned dependencies.
        /// 
        /// </para>
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
        /// The namespace of the package version that contains the returned dependencies. The
        /// package component that specifies its namespace depends on its type. For example:
        /// </para>
        ///  <note> 
        /// <para>
        /// The namespace is required when listing dependencies from package versions of the following
        /// formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maven
        /// </para>
        ///  </li> </ul> </note> <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package version is its <c>groupId</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package version is its <c>scope</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python and NuGet package versions do not contain a corresponding component, package
        /// versions of those formats do not have a namespace. 
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
        ///  The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
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
        ///  The name of the package that contains the returned package versions dependencies.
        /// 
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
        /// Gets and sets the property Version. 
        /// <para>
        ///  The version of the package that is specified in the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VersionRevision. 
        /// <para>
        ///  The current revision associated with the package version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string VersionRevision
        {
            get { return this._versionRevision; }
            set { this._versionRevision = value; }
        }

        // Check to see if VersionRevision property is set
        internal bool IsSetVersionRevision()
        {
            return this._versionRevision != null;
        }

    }
}