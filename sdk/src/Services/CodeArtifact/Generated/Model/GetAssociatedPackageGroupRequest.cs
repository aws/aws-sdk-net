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
    /// Container for the parameters to the GetAssociatedPackageGroup operation.
    /// Returns the most closely associated package group to the specified package. This API
    /// does not require that the package exist in any repository in the domain. As such,
    /// <c>GetAssociatedPackageGroup</c> can be used to see which package group's origin configuration
    /// applies to a package before that package is in a repository. This can be helpful to
    /// check if public packages are blocked without ingesting them.
    /// 
    ///  
    /// <para>
    /// For information package group association and matching, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/package-group-definition-syntax-matching-behavior.html">Package
    /// group definition syntax and matching behavior</a> in the <i>CodeArtifact User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetAssociatedPackageGroupRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private PackageFormat _format;
        private string _awsNamespace;
        private string _package;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the package from which to get the associated
        /// package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package from which to get the associated package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The namespace of the package from which to get the associated package group. The package
        /// component that specifies its namespace depends on its type. For example:
        /// </para>
        ///  <note> 
        /// <para>
        /// The namespace is required when getting associated package groups from packages of
        /// the following formats:
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
        ///  The package from which to get the associated package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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

    }
}