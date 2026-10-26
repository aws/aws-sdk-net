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
    /// The ARN of the runtime and any errors that occured.
    /// </summary>
    public partial class RuntimeVersionConfig
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error response when Lambda is unable to retrieve the runtime version for a function.
        /// </para>
        /// </summary>
        public RuntimeVersionError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersionArn. 
        /// <para>
        /// The ARN of the runtime version you want the function to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 26, Max = 2048)]
        public string RuntimeVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersionArn property is set.
        /// </summary>
        internal bool IsSetRuntimeVersionArn() => this.RuntimeVersionArn != null;
    }
}
