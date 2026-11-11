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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the AssociateSbomWithPackageVersion operation.
    /// </summary>
    public partial class AssociateSbomWithPackageVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the new software package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PackageName { get; set; }

        /// <summary>
        /// Checks to see if the PackageName property is set.
        /// </summary>
        internal bool IsSetPackageName() => this.PackageName != null;

        /// <summary>
        /// Gets and sets the property Sbom.
        /// </summary>
        public Sbom Sbom { get; set; }

        /// <summary>
        /// Checks to see if the Sbom property is set.
        /// </summary>
        internal bool IsSetSbom() => this.Sbom != null;

        /// <summary>
        /// Gets and sets the property SbomValidationStatus. 
        /// <para>
        /// The status of the initial validation for the software bill of materials against the
        /// Software Package Data Exchange (SPDX) and CycloneDX industry standard formats.
        /// </para>
        /// </summary>
        public SbomValidationStatus SbomValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the SbomValidationStatus property is set.
        /// </summary>
        internal bool IsSetSbomValidationStatus() => this.SbomValidationStatus != null;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the new package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
