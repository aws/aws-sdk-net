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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A response confirming that the event stream is complete.
    /// </summary>
    public partial class InvokeWithResponseStreamCompleteEvent
        : IEventStreamEvent
    {
        private string _errorCode;
        private string _errorDetails;
        private string _logResult;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// An error code.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The details of any returned error.
        /// </para>
        /// </summary>
        public string ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LogResult. 
        /// <para>
        /// The last 4 KB of the execution log, which is base64-encoded.
        /// </para>
        /// </summary>
        public string LogResult
        {
            get { return this._logResult; }
            set { this._logResult = value; }
        }

        // Check to see if LogResult property is set
        internal bool IsSetLogResult()
        {
            return this._logResult != null;
        }

    }
}