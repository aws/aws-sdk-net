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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateApiMapping operation.
    /// </summary>
    public partial class UpdateApiMappingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property ApiMappingId. 
        /// <para>
        /// The API mapping identifier.
        /// </para>
        /// </summary>
        public string ApiMappingId { get; set; }

        /// <summary>
        /// Checks to see if the ApiMappingId property is set.
        /// </summary>
        internal bool IsSetApiMappingId() => this.ApiMappingId != null;

        /// <summary>
        /// Gets and sets the property ApiMappingKey. 
        /// <para>
        /// The API mapping key.
        /// </para>
        /// </summary>
        public string ApiMappingKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiMappingKey property is set.
        /// </summary>
        internal bool IsSetApiMappingKey() => this.ApiMappingKey != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The API stage.
        /// </para>
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
