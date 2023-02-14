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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// This is the response object from the BatchGetSchema operation.
    /// </summary>
    public partial class BatchGetSchemaResponse : AmazonWebServiceResponse
    {
        private List<BatchGetSchemaError> _errors = new List<BatchGetSchemaError>();
        private List<Schema> _schemas = new List<Schema>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Error reasons for schemas that could not be retrieved. One error is returned for every
        /// schema that could not be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<BatchGetSchemaError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Schemas. 
        /// <para>
        /// The retrieved list of schemas.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<Schema> Schemas
        {
            get { return this._schemas; }
            set { this._schemas = value; }
        }

        // Check to see if Schemas property is set
        internal bool IsSetSchemas()
        {
            return this._schemas != null && this._schemas.Count > 0; 
        }

    }
}