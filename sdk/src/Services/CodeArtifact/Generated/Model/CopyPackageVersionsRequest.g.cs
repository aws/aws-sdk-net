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
    /// Container for the parameters to the CopyPackageVersions operation. Copies package
    /// versions from one repository to another repository in the same domain. <note> <para>
    /// You must specify <c>versions</c> or <c>versionRevisions</c>. You cannot specify both.
    /// </para> </note>
    /// </summary>
    public partial class CopyPackageVersionsRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property AllowOverwrite. 
        /// <para>
        ///  Set to true to overwrite a package version that already exists in the destination
        /// repository. If set to false and the package version already exists in the destination
        /// repository, the package version is returned in the <c>failedVersions</c> field of
        /// the response with an <c>ALREADY_EXISTS</c> error code. 
        /// </para>
        /// </summary>
        public bool? AllowOverwrite { get; set; }

        /// <summary>
        /// Checks to see if the AllowOverwrite property is set.
        /// </summary>
        internal bool IsSetAllowOverwrite() => this.AllowOverwrite.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationRepository. 
        /// <para>
        ///  The name of the repository into which package versions are copied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string DestinationRepository { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRepository property is set.
        /// </summary>
        internal bool IsSetDestinationRepository() => this.DestinationRepository != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the source and destination repositories. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package versions to be copied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property IncludeFromUpstream. 
        /// <para>
        ///  Set to true to copy packages from repositories that are upstream from the source
        /// repository to the destination repository. The default setting is false. For more information,
        /// see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/repos-upstream.html">Working
        /// with upstream repositories</a>. 
        /// </para>
        /// </summary>
        public bool? IncludeFromUpstream { get; set; }

        /// <summary>
        /// Checks to see if the IncludeFromUpstream property is set.
        /// </summary>
        internal bool IsSetIncludeFromUpstream() => this.IncludeFromUpstream.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the package versions to be copied. The package component that specifies
        /// its namespace depends on its type. For example:
        /// </para>
        ///  <note> 
        /// <para>
        /// The namespace is required when copying package versions of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maven
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Swift
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// generic
        /// </para>
        ///  </li> </ul> </note> <ul> <li> 
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
        /// Gets and sets the property Package. 
        /// <para>
        ///  The name of the package that contains the versions to be copied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property SourceRepository. 
        /// <para>
        ///  The name of the repository that contains the package versions to be copied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string SourceRepository { get; set; }

        /// <summary>
        /// Checks to see if the SourceRepository property is set.
        /// </summary>
        internal bool IsSetSourceRepository() => this.SourceRepository != null;

        /// <summary>
        /// Gets and sets the property VersionRevisions. 
        /// <para>
        ///  A list of key-value pairs. The keys are package versions and the values are package
        /// version revisions. A <c>CopyPackageVersion</c> operation succeeds if the specified
        /// versions in the source repository match the specified package version revision. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must specify <c>versions</c> or <c>versionRevisions</c>. You cannot specify both.
        /// 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> VersionRevisions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the VersionRevisions property is set.
        /// </summary>
        internal bool IsSetVersionRevisions() => this.VersionRevisions != null && (this.VersionRevisions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        ///  The versions of the package to be copied. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You must specify <c>versions</c> or <c>versionRevisions</c>. You cannot specify both.
        /// 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> Versions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Versions property is set.
        /// </summary>
        internal bool IsSetVersions() => this.Versions != null && (this.Versions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
