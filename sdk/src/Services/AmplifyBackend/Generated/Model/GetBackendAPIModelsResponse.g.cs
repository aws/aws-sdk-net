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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the GetBackendAPIModels operation.
    /// </summary>
    public partial class GetBackendAPIModelsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ModelIntrospectionSchema. 
        /// <para>
        /// Stringified JSON of the model introspection schema for an existing backend API resource.
        /// </para>
        /// </summary>
        public string ModelIntrospectionSchema { get; set; }

        /// <summary>
        /// Checks to see if the ModelIntrospectionSchema property is set.
        /// </summary>
        internal bool IsSetModelIntrospectionSchema() => this.ModelIntrospectionSchema != null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Stringified JSON of the datastore model.
        /// </para>
        /// </summary>
        public string Models { get; set; }

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
