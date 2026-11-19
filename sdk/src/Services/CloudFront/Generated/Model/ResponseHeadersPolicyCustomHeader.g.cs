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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An HTTP response header name and its value. CloudFront includes this header in HTTP
    /// responses that it sends for requests that match a cache behavior that's associated
    /// with this response headers policy.
    /// </summary>
    public partial class ResponseHeadersPolicyCustomHeader
    {
        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The HTTP response header name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null;

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// A Boolean that determines whether CloudFront overrides a response header with the
        /// same name received from the origin with the header specified here.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Override { get; set; }

        /// <summary>
        /// Checks to see if the Override property is set.
        /// </summary>
        internal bool IsSetOverride() => this.Override.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the HTTP response header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
