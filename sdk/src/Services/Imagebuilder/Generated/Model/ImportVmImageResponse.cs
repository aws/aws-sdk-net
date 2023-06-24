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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the ImportVmImage operation.
    /// </summary>
    public partial class ImportVmImageResponse : AmazonWebServiceResponse
    {
        private string _clientToken;
        private string _imageArn;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token that was used for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AMI that was created during the VM import process.
        /// This AMI is used as the base image for the recipe that imported the VM.
        /// </para>
        /// </summary>
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}