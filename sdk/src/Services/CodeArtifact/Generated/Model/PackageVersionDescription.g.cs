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
    /// Details about a package version.
    /// </summary>
    public partial class PackageVersionDescription
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        ///  The name of the package that is displayed. The <c>displayName</c> varies depending
        /// on the package version's format. For example, if an npm package is named <c>ui</c>,
        /// is in the namespace <c>vue</c>, and has the format <c>npm</c>, then the <c>displayName</c>
        /// is <c>@vue/ui</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package version. 
        /// </para>
        /// </summary>
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property HomePage. 
        /// <para>
        ///  The homepage associated with the package. 
        /// </para>
        /// </summary>
        public string HomePage { get; set; }

        /// <summary>
        /// Checks to see if the HomePage property is set.
        /// </summary>
        internal bool IsSetHomePage() => this.HomePage != null;

        /// <summary>
        /// Gets and sets the property Licenses. 
        /// <para>
        ///  Information about licenses associated with the package version. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseInfo> Licenses { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseInfo>() : null;

        /// <summary>
        /// Checks to see if the Licenses property is set.
        /// </summary>
        internal bool IsSetLicenses() => this.Licenses != null && (this.Licenses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package version. The package component that specifies its namespace
        /// depends on its type. For example:
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageVersionOrigin.html">PackageVersionOrigin</a>
        /// object that contains information about how the package version was added to the repository.
        /// </para>
        /// </summary>
        public PackageVersionOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        ///  The name of the requested package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property PublishedTime. 
        /// <para>
        ///  A timestamp that contains the date and time the package version was published. 
        /// </para>
        /// </summary>
        public DateTime? PublishedTime { get; set; }

        /// <summary>
        /// Checks to see if the PublishedTime property is set.
        /// </summary>
        internal bool IsSetPublishedTime() => this.PublishedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        ///  The revision of the package version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property SourceCodeRepository. 
        /// <para>
        ///  The repository for the source code in the package version, or the source code used
        /// to build it. 
        /// </para>
        /// </summary>
        public string SourceCodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the SourceCodeRepository property is set.
        /// </summary>
        internal bool IsSetSourceCodeRepository() => this.SourceCodeRepository != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  A string that contains the status of the package version. 
        /// </para>
        /// </summary>
        public PackageVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        ///  A summary of the package version. The summary is extracted from the package. The
        /// information in and detail level of the summary depends on the package version's format.
        /// 
        /// </para>
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        ///  The version of the package. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
