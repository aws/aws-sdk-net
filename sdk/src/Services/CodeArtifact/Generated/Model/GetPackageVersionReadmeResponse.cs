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
    /// This is the response object from the GetPackageVersionReadme operation.
    /// </summary>
    public partial class GetPackageVersionReadmeResponse : AmazonWebServiceResponse
    {
        private PackageFormat _format;
        private string _awsNamespace;
        private string _package;
        private string _readme;
        private string _version;
        private string _versionRevision;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package with the requested readme file. Valid format types are:
        /// 
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
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package that contains the returned readme file. 
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
        /// Gets and sets the property Readme. 
        /// <para>
        ///  The text of the returned readme file. 
        /// </para>
        /// </summary>
        public string Readme
        {
            get { return this._readme; }
            set { this._readme = value; }
        }

        // Check to see if Readme property is set
        internal bool IsSetReadme()
        {
            return this._readme != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        ///  The version of the package with the requested readme file. 
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