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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the AssociateSbomWithPackageVersion operation.
    /// </summary>
    public partial class AssociateSbomWithPackageVersionResponse : AmazonWebServiceResponse
    {
        private string _packageName;
        private Sbom _sbom;
        private SbomValidationStatus _sbomValidationStatus;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the new software package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property Sbom.
        /// </summary>
        public Sbom Sbom
        {
            get { return this._sbom; }
            set { this._sbom = value; }
        }

        // Check to see if Sbom property is set
        internal bool IsSetSbom()
        {
            return this._sbom != null;
        }

        /// <summary>
        /// Gets and sets the property SbomValidationStatus. 
        /// <para>
        /// The status of the initial validation for the software bill of materials against the
        /// Software Package Data Exchange (SPDX) and CycloneDX industry standard formats.
        /// </para>
        /// </summary>
        public SbomValidationStatus SbomValidationStatus
        {
            get { return this._sbomValidationStatus; }
            set { this._sbomValidationStatus = value; }
        }

        // Check to see if SbomValidationStatus property is set
        internal bool IsSetSbomValidationStatus()
        {
            return this._sbomValidationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the new package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}