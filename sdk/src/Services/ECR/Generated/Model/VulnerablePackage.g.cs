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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Information on the vulnerable package identified by a finding.
    /// </summary>
    public partial class VulnerablePackage
    {
        /// <summary>
        /// Gets and sets the property Arch. 
        /// <para>
        /// The architecture of the vulnerable package.
        /// </para>
        /// </summary>
        public string Arch { get; set; }

        /// <summary>
        /// Checks to see if the Arch property is set.
        /// </summary>
        internal bool IsSetArch() => this.Arch != null;

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of the vulnerable package.
        /// </para>
        /// </summary>
        public int? Epoch { get; set; }

        /// <summary>
        /// Checks to see if the Epoch property is set.
        /// </summary>
        internal bool IsSetEpoch() => this.Epoch.HasValue;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The file path of the vulnerable package.
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
        /// The version of the package that contains the vulnerability fix.
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
        /// The name of the vulnerable package.
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
        /// The package manager of the vulnerable package.
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
        /// The release of the vulnerable package.
        /// </para>
        /// </summary>
        public string Release { get; set; }

        /// <summary>
        /// Checks to see if the Release property is set.
        /// </summary>
        internal bool IsSetRelease() => this.Release != null;

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
        /// The version of the vulnerable package.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
