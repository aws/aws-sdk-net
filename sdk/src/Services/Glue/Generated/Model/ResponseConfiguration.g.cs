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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration that defines how to parse JSON responses from REST API calls, including
    /// paths to result data and error information.
    /// </summary>
    public partial class ResponseConfiguration
    {
        /// <summary>
        /// Gets and sets the property ErrorPath. 
        /// <para>
        /// The JSON path expression that identifies where error information is located within
        /// API responses when requests fail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ErrorPath { get; set; }

        /// <summary>
        /// Checks to see if the ErrorPath property is set.
        /// </summary>
        internal bool IsSetErrorPath() => this.ErrorPath != null;

        /// <summary>
        /// Gets and sets the property ResultPath. 
        /// <para>
        /// The JSON path expression that identifies where the actual result data is located within
        /// the API response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ResultPath { get; set; }

        /// <summary>
        /// Checks to see if the ResultPath property is set.
        /// </summary>
        internal bool IsSetResultPath() => this.ResultPath != null;
    }
}
