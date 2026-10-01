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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// This is the response object from the UpdateResourceShare operation.
    /// </summary>
    public partial class UpdateResourceShareResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency identifier associated with this request. If you want to repeat the
        /// same operation in an idempotent manner then you must include this value in the <c>clientToken</c>
        /// request parameter of that later call. All other parameters must also have the same
        /// values that you used in the first call.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ResourceShare. 
        /// <para>
        /// Information about the resource share.
        /// </para>
        /// </summary>
        public ResourceShare ResourceShare { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShare property is set.
        /// </summary>
        internal bool IsSetResourceShare() => this.ResourceShare != null;
    }
}
