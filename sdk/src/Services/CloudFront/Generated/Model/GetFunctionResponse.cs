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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the GetFunction operation.
    /// </summary>
    public partial class GetFunctionResponse : AmazonWebServiceResponse
    {
        private string _contentType;
        private string _eTag;
        private MemoryStream _functionCode;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type (media type) of the response.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The version identifier for the current version of the CloudFront function.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionCode. 
        /// <para>
        /// The function code of a CloudFront function.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=40960)]
        public MemoryStream FunctionCode
        {
            get { return this._functionCode; }
            set { this._functionCode = value; }
        }

        // Check to see if FunctionCode property is set
        internal bool IsSetFunctionCode()
        {
            return this._functionCode != null;
        }

    }
}