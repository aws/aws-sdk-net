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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the GetMapStyleDescriptor operation.
    /// </summary>
    public partial class GetMapStyleDescriptorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// Contains the body of the style descriptor.
        /// </para>
        /// </summary>
        public MemoryStream Blob { get; set; }

        /// <summary>
        /// Checks to see if the Blob property is set.
        /// </summary>
        internal bool IsSetBlob() => this.Blob != null;

        /// <summary>
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// The HTTP Cache-Control directive for the value.
        /// </para>
        /// </summary>
        public string CacheControl { get; set; }

        /// <summary>
        /// Checks to see if the CacheControl property is set.
        /// </summary>
        internal bool IsSetCacheControl() => this.CacheControl != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The style descriptor's content type. For example, <c>application/json</c>.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
