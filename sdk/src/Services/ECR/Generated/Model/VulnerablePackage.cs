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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
        private string _arch;
        private int? _epoch;
        private string _filePath;
        private string _fixedInVersion;
        private string _name;
        private string _packageManager;
        private string _release;
        private string _sourceLayerHash;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arch. 
        /// <para>
        /// The architecture of the vulnerable package.
        /// </para>
        /// </summary>
        public string Arch
        {
            get { return this._arch; }
            set { this._arch = value; }
        }

        // Check to see if Arch property is set
        internal bool IsSetArch()
        {
            return this._arch != null;
        }

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of the vulnerable package.
        /// </para>
        /// </summary>
        public int Epoch
        {
            get { return this._epoch.GetValueOrDefault(); }
            set { this._epoch = value; }
        }

        // Check to see if Epoch property is set
        internal bool IsSetEpoch()
        {
            return this._epoch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The file path of the vulnerable package.
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property FixedInVersion. 
        /// <para>
        /// The version of the package that contains the vulnerability fix.
        /// </para>
        /// </summary>
        public string FixedInVersion
        {
            get { return this._fixedInVersion; }
            set { this._fixedInVersion = value; }
        }

        // Check to see if FixedInVersion property is set
        internal bool IsSetFixedInVersion()
        {
            return this._fixedInVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the vulnerable package.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PackageManager. 
        /// <para>
        /// The package manager of the vulnerable package.
        /// </para>
        /// </summary>
        public string PackageManager
        {
            get { return this._packageManager; }
            set { this._packageManager = value; }
        }

        // Check to see if PackageManager property is set
        internal bool IsSetPackageManager()
        {
            return this._packageManager != null;
        }

        /// <summary>
        /// Gets and sets the property Release. 
        /// <para>
        /// The release of the vulnerable package.
        /// </para>
        /// </summary>
        public string Release
        {
            get { return this._release; }
            set { this._release = value; }
        }

        // Check to see if Release property is set
        internal bool IsSetRelease()
        {
            return this._release != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLayerHash. 
        /// <para>
        /// The source layer hash of the vulnerable package.
        /// </para>
        /// </summary>
        public string SourceLayerHash
        {
            get { return this._sourceLayerHash; }
            set { this._sourceLayerHash = value; }
        }

        // Check to see if SourceLayerHash property is set
        internal bool IsSetSourceLayerHash()
        {
            return this._sourceLayerHash != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the vulnerable package.
        /// </para>
        /// </summary>
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