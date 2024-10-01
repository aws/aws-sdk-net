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
    /// Contains information about the external connection of a repository.
    /// </summary>
    public partial class RepositoryExternalConnectionInfo
    {
        private string _externalConnectionName;
        private PackageFormat _packageFormat;
        private ExternalConnectionStatus _status;

        /// <summary>
        /// Gets and sets the property ExternalConnectionName. 
        /// <para>
        ///  The name of the external connection associated with a repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string ExternalConnectionName
        {
            get { return this._externalConnectionName; }
            set { this._externalConnectionName = value; }
        }

        // Check to see if ExternalConnectionName property is set
        internal bool IsSetExternalConnectionName()
        {
            return this._externalConnectionName != null;
        }

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
        public PackageFormat PackageFormat
        {
            get { return this._packageFormat; }
            set { this._packageFormat = value; }
        }

        // Check to see if PackageFormat property is set
        internal bool IsSetPackageFormat()
        {
            return this._packageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the external connection of a repository. There is one valid value,
        /// <c>Available</c>. 
        /// </para>
        /// </summary>
        public ExternalConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}