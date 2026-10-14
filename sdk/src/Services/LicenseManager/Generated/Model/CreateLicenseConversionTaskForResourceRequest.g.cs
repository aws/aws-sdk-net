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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLicenseConversionTaskForResource operation.
    /// Creates a new license conversion task.
    /// </summary>
    public partial class CreateLicenseConversionTaskForResourceRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationLicenseContext. 
        /// <para>
        /// Information that identifies the license type you are converting to. For the structure
        /// of the destination license, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/conversion-procedures.html#conversion-cli">Convert
        /// a license type using the CLI </a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseConversionContext DestinationLicenseContext { get; set; }

        /// <summary>
        /// Checks to see if the DestinationLicenseContext property is set.
        /// </summary>
        internal bool IsSetDestinationLicenseContext() => this.DestinationLicenseContext != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource you are converting the license type for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceLicenseContext. 
        /// <para>
        /// Information that identifies the license type you are converting from. For the structure
        /// of the source license, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/conversion-procedures.html#conversion-cli">Convert
        /// a license type using the CLI </a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LicenseConversionContext SourceLicenseContext { get; set; }

        /// <summary>
        /// Checks to see if the SourceLicenseContext property is set.
        /// </summary>
        internal bool IsSetSourceLicenseContext() => this.SourceLicenseContext != null;
    }
}
