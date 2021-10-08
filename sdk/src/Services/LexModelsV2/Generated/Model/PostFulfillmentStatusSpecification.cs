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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides a setting that determines whether the post-fulfillment response is sent to
    /// the user. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete">https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete</a>
    /// </summary>
    public partial class PostFulfillmentStatusSpecification
    {
        private ResponseSpecification _failureResponse;
        private ResponseSpecification _successResponse;
        private ResponseSpecification _timeoutResponse;

        /// <summary>
        /// Gets and sets the property FailureResponse.
        /// </summary>
        public ResponseSpecification FailureResponse
        {
            get { return this._failureResponse; }
            set { this._failureResponse = value; }
        }

        // Check to see if FailureResponse property is set
        internal bool IsSetFailureResponse()
        {
            return this._failureResponse != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessResponse.
        /// </summary>
        public ResponseSpecification SuccessResponse
        {
            get { return this._successResponse; }
            set { this._successResponse = value; }
        }

        // Check to see if SuccessResponse property is set
        internal bool IsSetSuccessResponse()
        {
            return this._successResponse != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutResponse.
        /// </summary>
        public ResponseSpecification TimeoutResponse
        {
            get { return this._timeoutResponse; }
            set { this._timeoutResponse = value; }
        }

        // Check to see if TimeoutResponse property is set
        internal bool IsSetTimeoutResponse()
        {
            return this._timeoutResponse != null;
        }

    }
}