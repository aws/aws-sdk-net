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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// This is the response object from the GetTaxRegistrationDocument operation.
    /// </summary>
    public partial class GetTaxRegistrationDocumentResponse : AmazonWebServiceResponse
    {
        private string _destinationFilePath;
        private string _presigneds3Url;

        /// <summary>
        /// Gets and sets the property DestinationFilePath. 
        /// <para>
        /// The file path of the Amazon S3 bucket where you want to download your tax document
        /// to.
        /// </para>
        /// </summary>
        public string DestinationFilePath
        {
            get { return this._destinationFilePath; }
            set { this._destinationFilePath = value; }
        }

        // Check to see if DestinationFilePath property is set
        internal bool IsSetDestinationFilePath()
        {
            return this._destinationFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedS3Url. 
        /// <para>
        /// The Amazon S3 presigned URL of the tax registration document. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string PresignedS3Url
        {
            get { return this._presigneds3Url; }
            set { this._presigneds3Url = value; }
        }

        // Check to see if PresignedS3Url property is set
        internal bool IsSetPresignedS3Url()
        {
            return this._presigneds3Url != null;
        }

    }
}