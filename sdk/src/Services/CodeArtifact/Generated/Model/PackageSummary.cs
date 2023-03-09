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
    /// Details about a package, including its format, namespace, and name.
    /// </summary>
    public partial class PackageSummary
    {
        private PackageFormat _format;
        private string _awsNamespace;
        private PackageOriginConfiguration _originConfiguration;
        private string _package;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the package. 
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
        /// The namespace of the package. The package component that specifies its namespace depends
        /// on its type. For example:
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
        ///  Python and NuGet packages do not contain a corresponding component, packages of those
        /// formats do not have a namespace. 
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
        /// Gets and sets the property OriginConfiguration. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginConfiguration.html">PackageOriginConfiguration</a>
        /// object that contains a <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_PackageOriginRestrictions.html">PackageOriginRestrictions</a>
        /// object that contains information about the upstream and publish package origin restrictions.
        /// </para>
        /// </summary>
        public PackageOriginConfiguration OriginConfiguration
        {
            get { return this._originConfiguration; }
            set { this._originConfiguration = value; }
        }

        // Check to see if OriginConfiguration property is set
        internal bool IsSetOriginConfiguration()
        {
            return this._originConfiguration != null;
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

    }
}