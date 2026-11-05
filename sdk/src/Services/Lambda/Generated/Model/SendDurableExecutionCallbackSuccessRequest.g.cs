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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the SendDurableExecutionCallbackSuccess operation.
    /// Sends a successful completion response for a callback operation in a durable execution.
    /// Use this API when an external system has successfully completed a callback operation.
    /// </summary>
    public partial class SendDurableExecutionCallbackSuccessRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CallbackId. 
        /// <para>
        /// The unique identifier for the callback operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string CallbackId { get; set; }

        /// <summary>
        /// Checks to see if the CallbackId property is set.
        /// </summary>
        internal bool IsSetCallbackId() => this.CallbackId != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result data from the successful callback operation. Maximum size is 1 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1048576)]
        public MemoryStream Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;
    }
}
