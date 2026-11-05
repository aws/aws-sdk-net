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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// This is the response object from the GetSdk operation.
    /// </summary>
    public partial class GetSdkResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The binary blob response to GetSdk, which contains the generated SDK.
        /// </para>
        /// </summary>
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// The content-disposition header value in the HTTP response.
        /// </para>
        /// </summary>
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Checks to see if the ContentDisposition property is set.
        /// </summary>
        internal bool IsSetContentDisposition() => this.ContentDisposition != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content-type header value in the HTTP response.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
