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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
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
namespace Amazon.MWAA.Model
{
    /// <summary>
    /// This is the response object from the InvokeRestApi operation.
    /// </summary>
    public partial class InvokeRestApiResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _restApiResponse;
        private int? _restApiStatusCode;

        /// <summary>
        /// Gets and sets the property RestApiResponse. 
        /// <para>
        /// The response data from the Apache Airflow REST API call, provided as a JSON object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Amazon.Runtime.Documents.Document RestApiResponse
        {
            get { return this._restApiResponse; }
            set { this._restApiResponse = value; }
        }

        // Check to see if RestApiResponse property is set
        internal bool IsSetRestApiResponse()
        {
            return !this._restApiResponse.IsNull();
        }

        /// <summary>
        /// Gets and sets the property RestApiStatusCode. 
        /// <para>
        /// The HTTP status code returned by the Apache Airflow REST API call.
        /// </para>
        /// </summary>
        public int? RestApiStatusCode
        {
            get { return this._restApiStatusCode; }
            set { this._restApiStatusCode = value; }
        }

        // Check to see if RestApiStatusCode property is set
        internal bool IsSetRestApiStatusCode()
        {
            return this._restApiStatusCode.HasValue; 
        }

    }
}