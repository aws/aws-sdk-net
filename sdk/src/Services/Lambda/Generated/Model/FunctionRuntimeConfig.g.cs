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
    /// The customer-managed runtime configuration for your function. Specifies the customer-managed
    /// runtime and the runtime alias that your function uses.
    /// </summary>
    public partial class FunctionRuntimeConfig
    {
        /// <summary>
        /// Gets and sets the property RuntimeAlias. 
        /// <para>
        /// The name of the customer-managed runtime alias that your function uses. A runtime
        /// alias is a name that points to a runtime version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RuntimeAlias { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeAlias property is set.
        /// </summary>
        internal bool IsSetRuntimeAlias() => this.RuntimeAlias != null;

        /// <summary>
        /// Gets and sets the property RuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer-managed runtime that your function
        /// uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 2048)]
        public string RuntimeArn { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeArn property is set.
        /// </summary>
        internal bool IsSetRuntimeArn() => this.RuntimeArn != null;
    }
}
