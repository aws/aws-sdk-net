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

namespace Amazon.APIPortal.Model
{
    /// <summary>
    /// Content that replaces the defaults generated for an API page.
    /// </summary>
    public partial class DisplayContentOverrides
    {
        /// <summary>
        /// Gets and sets the property ApiUrl. The invoke URL shown on the page and used for Try-It
        /// and the portal's allowed-domain list: http(s)://host[:port][/path], with no whitespace,
        /// quotes or angle brackets. On this request member only, as ApiEndpoint is also returned
        /// in responses.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ApiUrl { get; set; }

        /// <summary>
        /// Checks to see if the ApiUrl property is set.
        /// </summary>
        internal bool IsSetApiUrl() => this.ApiUrl != null;

        /// <summary>
        /// Gets and sets the property Body. The Markdown body of the page, from 1 to 32,768 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property OperationName. The operation name shown as the page title,
        /// from 1 to 255 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;
    }
}
