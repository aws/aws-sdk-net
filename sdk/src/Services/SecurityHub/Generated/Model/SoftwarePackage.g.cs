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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a software package.
    /// </summary>
    public partial class SoftwarePackage
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture used for the software package.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of the software package.
        /// </para>
        /// </summary>
        public string Epoch { get; set; }

        /// <summary>
        /// Checks to see if the Epoch property is set.
        /// </summary>
        internal bool IsSetEpoch() => this.Epoch != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The file system path to the package manager inventory file.
        /// </para>
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property FixedInVersion. 
        /// <para>
        /// The version of the software package in which the vulnerability has been resolved.
        /// 
        /// </para>
        /// </summary>
        public string FixedInVersion { get; set; }

        /// <summary>
        /// Checks to see if the FixedInVersion property is set.
        /// </summary>
        internal bool IsSetFixedInVersion() => this.FixedInVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the software package.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PackageManager. 
        /// <para>
        /// The source of the package.
        /// </para>
        /// </summary>
        public string PackageManager { get; set; }

        /// <summary>
        /// Checks to see if the PackageManager property is set.
        /// </summary>
        internal bool IsSetPackageManager() => this.PackageManager != null;

        /// <summary>
        /// Gets and sets the property Release. 
        /// <para>
        /// The release of the software package.
        /// </para>
        /// </summary>
        public string Release { get; set; }

        /// <summary>
        /// Checks to see if the Release property is set.
        /// </summary>
        internal bool IsSetRelease() => this.Release != null;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// Describes the actions a customer can take to resolve the vulnerability in the software
        /// package. 
        /// </para>
        /// </summary>
        public string Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property SourceLayerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source layer. 
        /// </para>
        /// </summary>
        public string SourceLayerArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceLayerArn property is set.
        /// </summary>
        internal bool IsSetSourceLayerArn() => this.SourceLayerArn != null;

        /// <summary>
        /// Gets and sets the property SourceLayerHash. 
        /// <para>
        /// The source layer hash of the vulnerable package. 
        /// </para>
        /// </summary>
        public string SourceLayerHash { get; set; }

        /// <summary>
        /// Checks to see if the SourceLayerHash property is set.
        /// </summary>
        internal bool IsSetSourceLayerHash() => this.SourceLayerHash != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the software package.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
