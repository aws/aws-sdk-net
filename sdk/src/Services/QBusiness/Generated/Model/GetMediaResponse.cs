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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetMedia operation.
    /// </summary>
    public partial class GetMediaResponse : AmazonWebServiceResponse
    {
        private MemoryStream _mediaBytes;
        private string _mediaMimeType;

        /// <summary>
        /// Gets and sets the property MediaBytes. 
        /// <para>
        /// The base64-encoded bytes of the media object.
        /// </para>
        /// </summary>
        public MemoryStream MediaBytes
        {
            get { return this._mediaBytes; }
            set { this._mediaBytes = value; }
        }

        // Check to see if MediaBytes property is set
        internal bool IsSetMediaBytes()
        {
            return this._mediaBytes != null;
        }

        /// <summary>
        /// Gets and sets the property MediaMimeType. 
        /// <para>
        /// The MIME type of the media object (image/png).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MediaMimeType
        {
            get { return this._mediaMimeType; }
            set { this._mediaMimeType = value; }
        }

        // Check to see if MediaMimeType property is set
        internal bool IsSetMediaMimeType()
        {
            return this._mediaMimeType != null;
        }

    }
}