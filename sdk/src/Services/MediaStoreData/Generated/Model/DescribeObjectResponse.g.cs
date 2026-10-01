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

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// This is the response object from the DescribeObject operation.
    /// </summary>
    public partial class DescribeObjectResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// An optional <c>CacheControl</c> header that allows the caller to control the object's
        /// cache behavior. Headers can be passed in as specified in the HTTP at <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9">https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9</a>.
        /// </para>
        ///  
        /// <para>
        /// Headers with a custom user-defined value are also accepted.
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
        /// The content type of the object.
        /// </para>
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag that represents a unique instance of the object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;
    }
}
