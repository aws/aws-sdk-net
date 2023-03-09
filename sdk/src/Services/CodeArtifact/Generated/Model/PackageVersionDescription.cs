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
    /// Details about a package version.
    /// </summary>
    public partial class PackageVersionDescription
    {
        private string _displayName;
        private PackageFormat _format;
        private string _homePage;
        private List<LicenseInfo> _licenses = new List<LicenseInfo>();
        private string _awsNamespace;
        private PackageVersionOrigin _origin;
        private string _packageName;
        private DateTime? _publishedTime;
        private string _revision;
        private string _sourceCodeRepository;
        private PackageVersionStatus _status;
        private string _summary;
        private string _version;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The name of the package that is displayed. The <code>displayName</code> varies depending
        /// on the package version's format. For example, if an npm package is named <code>ui</code>,
        /// is in the namespace <code>vue</code>, and has the format <code>npm</code>, then the
        /// <code>displayName</code> is <code>@vue/ui</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package version. 
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
        /// Gets and sets the property HomePage. 
        /// <para>
        ///  The homepage associated with the package. 
        /// </para>
        /// </summary>
        public string HomePage
        {
            get { return this._homePage; }
            set { this._homePage = value; }
        }

        // Check to see if HomePage property is set
        internal bool IsSetHomePage()
        {
            return this._homePage != null;
        }

        /// <summary>
        /// Gets and sets the property Licenses. 
        /// <para>
        ///  Information about licenses associated with the package version. 
        /// </para>
        /// </summary>
        public List<LicenseInfo> Licenses
        {
            get { return this._licenses; }
            set { this._licenses = value; }
        }

        // Check to see if Licenses property is set
        internal bool IsSetLicenses()
        {
            return this._licenses != null && this._licenses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package version. The package version component that specifies
        /// its namespace depends on its type. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The namespace of a Maven package version is its <code>groupId</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of an npm package version is its <code>scope</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Python and NuGet package versions do not contain a corresponding component, package
        /// versions of those formats do not have a namespace. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The namespace of a generic package is it’s <code>namespace</code>. 
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionOrigin.html">PackageVersionOrigin</a>
        /// object that contains information about how the package version was added to the repository.
        /// </para>
        /// </summary>
        public PackageVersionOrigin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        ///  The name of the requested package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PublishedTime. 
        /// <para>
        ///  A timestamp that contains the date and time the package version was published. 
        /// </para>
        /// </summary>
        public DateTime PublishedTime
        {
            get { return this._publishedTime.GetValueOrDefault(); }
            set { this._publishedTime = value; }
        }

        // Check to see if PublishedTime property is set
        internal bool IsSetPublishedTime()
        {
            return this._publishedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        ///  The revision of the package version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeRepository. 
        /// <para>
        ///  The repository for the source code in the package version, or the source code used
        /// to build it. 
        /// </para>
        /// </summary>
        public string SourceCodeRepository
        {
            get { return this._sourceCodeRepository; }
            set { this._sourceCodeRepository = value; }
        }

        // Check to see if SourceCodeRepository property is set
        internal bool IsSetSourceCodeRepository()
        {
            return this._sourceCodeRepository != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  A string that contains the status of the package version. 
        /// </para>
        /// </summary>
        public PackageVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        ///  A summary of the package version. The summary is extracted from the package. The
        /// information in and detail level of the summary depends on the package version's format.
        /// 
        /// </para>
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        ///  The version of the package. 
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

    }
}