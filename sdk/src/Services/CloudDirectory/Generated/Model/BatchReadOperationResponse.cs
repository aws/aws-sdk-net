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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <c>BatchRead</c> response operation.
    /// </summary>
    public partial class BatchReadOperationResponse
    {
        private BatchReadException _exceptionResponse;
        private BatchReadSuccessfulResponse _successfulResponse;

        /// <summary>
        /// Gets and sets the property ExceptionResponse. 
        /// <para>
        /// Identifies which operation in a batch has failed.
        /// </para>
        /// </summary>
        public BatchReadException ExceptionResponse
        {
            get { return this._exceptionResponse; }
            set { this._exceptionResponse = value; }
        }

        // Check to see if ExceptionResponse property is set
        internal bool IsSetExceptionResponse()
        {
            return this._exceptionResponse != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessfulResponse. 
        /// <para>
        /// Identifies which operation in a batch has succeeded.
        /// </para>
        /// </summary>
        public BatchReadSuccessfulResponse SuccessfulResponse
        {
            get { return this._successfulResponse; }
            set { this._successfulResponse = value; }
        }

        // Check to see if SuccessfulResponse property is set
        internal bool IsSetSuccessfulResponse()
        {
            return this._successfulResponse != null;
        }

    }
}