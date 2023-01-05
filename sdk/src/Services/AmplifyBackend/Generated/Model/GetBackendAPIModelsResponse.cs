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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// This is the response object from the GetBackendAPIModels operation.
    /// </summary>
    public partial class GetBackendAPIModelsResponse : AmazonWebServiceResponse
    {
        private string _modelIntrospectionSchema;
        private string _models;
        private Status _status;

        /// <summary>
        /// Gets and sets the property ModelIntrospectionSchema. 
        /// <para>
        /// Stringified JSON of the model introspection schema for an existing backend API resource.
        /// </para>
        /// </summary>
        public string ModelIntrospectionSchema
        {
            get { return this._modelIntrospectionSchema; }
            set { this._modelIntrospectionSchema = value; }
        }

        // Check to see if ModelIntrospectionSchema property is set
        internal bool IsSetModelIntrospectionSchema()
        {
            return this._modelIntrospectionSchema != null;
        }

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Stringified JSON of the datastore model.
        /// </para>
        /// </summary>
        public string Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}