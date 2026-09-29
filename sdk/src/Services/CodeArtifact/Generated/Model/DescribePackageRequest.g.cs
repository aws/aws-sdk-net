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
    /// Container for the parameters to the DescribePackage operation. Returns a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageDescription.html">PackageDescription</a>
    /// object that contains information about the requested package.
    /// </summary>
    public partial class DescribePackageRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that contains the repository that contains the package.
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
        /// A format that specifies the type of the requested package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PackageFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the requested package. The package component that specifies its namespace
        /// depends on its type. For example:
        /// </para>
        ///  <note> 
        /// <para>
        /// The namespace is required when requesting packages of the following formats:
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
        /// The name of the requested package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Package { get; set; }

        /// <summary>
        /// Checks to see if the Package property is set.
        /// </summary>
        internal bool IsSetPackage() => this.Package != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the repository that contains the requested package. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
