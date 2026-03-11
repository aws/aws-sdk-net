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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the SendDurableExecutionCallbackFailure operation.
    /// Sends a failure response for a callback operation in a durable execution. Use this
    /// API when an external system cannot complete a callback operation successfully.
    /// </summary>
    public partial class SendDurableExecutionCallbackFailureRequest : AmazonLambdaRequest
    {
        private string _callbackId;
        private ErrorObject _error;

        /// <summary>
        /// Gets and sets the property CallbackId. 
        /// <para>
        /// The unique identifier for the callback operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string CallbackId
        {
            get { return this._callbackId; }
            set { this._callbackId = value; }
        }

        // Check to see if CallbackId property is set
        internal bool IsSetCallbackId()
        {
            return this._callbackId != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error details describing why the callback operation failed.
        /// </para>
        /// </summary>
        public ErrorObject Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

    }
}