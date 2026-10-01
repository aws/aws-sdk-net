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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// This is the response object from the GetProfile operation.
    /// </summary>
    public partial class GetProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// The content encoding of the profile.
        /// </para>
        /// </summary>
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Checks to see if the ContentEncoding property is set.
        /// </summary>
        internal bool IsSetContentEncoding() => this.ContentEncoding != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the profile in the payload. It is either <c>application/json</c>
        /// or the default <c>application/x-amzn-ion</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// Information about the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream Profile { get; set; }

        /// <summary>
        /// Checks to see if the Profile property is set.
        /// </summary>
        internal bool IsSetProfile() => this.Profile != null;
    }
}
