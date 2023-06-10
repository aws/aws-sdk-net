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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLicenseConversionTaskForResource operation.
    /// Creates a new license conversion task.
    /// </summary>
    public partial class CreateLicenseConversionTaskForResourceRequest : AmazonLicenseManagerRequest
    {
        private LicenseConversionContext _destinationLicenseContext;
        private string _resourceArn;
        private LicenseConversionContext _sourceLicenseContext;

        /// <summary>
        /// Gets and sets the property DestinationLicenseContext. 
        /// <para>
        /// Information that identifies the license type you are converting to. For the structure
        /// of the destination license, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/conversion-procedures.html#conversion-cli">Convert
        /// a license type using the CLI </a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LicenseConversionContext DestinationLicenseContext
        {
            get { return this._destinationLicenseContext; }
            set { this._destinationLicenseContext = value; }
        }

        // Check to see if DestinationLicenseContext property is set
        internal bool IsSetDestinationLicenseContext()
        {
            return this._destinationLicenseContext != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource you are converting the license type for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLicenseContext. 
        /// <para>
        /// Information that identifies the license type you are converting from. For the structure
        /// of the source license, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/conversion-procedures.html#conversion-cli">Convert
        /// a license type using the CLI </a> in the <i>License Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LicenseConversionContext SourceLicenseContext
        {
            get { return this._sourceLicenseContext; }
            set { this._sourceLicenseContext = value; }
        }

        // Check to see if SourceLicenseContext property is set
        internal bool IsSetSourceLicenseContext()
        {
            return this._sourceLicenseContext != null;
        }

    }
}