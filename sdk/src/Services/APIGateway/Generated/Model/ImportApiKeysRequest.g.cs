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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ImportApiKeys operation. Import API keys from
    /// an external source, such as a CSV-formatted file.
    /// </summary>
    public partial class ImportApiKeysRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The payload of the POST request to import API keys. For the payload format, see API
        /// Key File Format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// A query parameter to indicate whether to rollback ApiKey importation (<c>true</c>)
        /// or not (<c>false</c>) when error is encountered.
        /// </para>
        /// </summary>
        public bool? FailOnWarnings { get; set; }

        /// <summary>
        /// Checks to see if the FailOnWarnings property is set.
        /// </summary>
        internal bool IsSetFailOnWarnings() => this.FailOnWarnings.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// A query parameter to specify the input format to imported API keys. Currently, only
        /// the <c>csv</c> format is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApiKeysFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;
    }
}
