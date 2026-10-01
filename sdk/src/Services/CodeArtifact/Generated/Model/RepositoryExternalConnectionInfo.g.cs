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
    /// Contains information about the external connection of a repository.
    /// </summary>
    public partial class RepositoryExternalConnectionInfo
    {
        /// <summary>
        /// Gets and sets the property ExternalConnectionName. 
        /// <para>
        ///  The name of the external connection associated with a repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string ExternalConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ExternalConnectionName property is set.
        /// </summary>
        internal bool IsSetExternalConnectionName() => this.ExternalConnectionName != null;

        /// <summary>
        /// Gets and sets the property PackageFormat. 
        /// <para>
        ///  The package format associated with a repository's external connection. The valid
        /// package formats are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>npm</c>: A Node Package Manager (npm) package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pypi</c>: A Python Package Index (PyPI) package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>maven</c>: A Maven package that contains compiled code in a distributable format,
        /// such as a JAR file. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nuget</c>: A NuGet package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>generic</c>: A generic package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ruby</c>: A Ruby package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>swift</c>: A Swift package. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cargo</c>: A Cargo package. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PackageFormat PackageFormat { get; set; }

        /// <summary>
        /// Checks to see if the PackageFormat property is set.
        /// </summary>
        internal bool IsSetPackageFormat() => this.PackageFormat != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the external connection of a repository. There is one valid value,
        /// <c>Available</c>. 
        /// </para>
        /// </summary>
        public ExternalConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
