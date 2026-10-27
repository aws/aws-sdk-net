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
    /// This is the response object from the TestInvokeMethod operation.
    /// </summary>
    public partial class TestInvokeMethodResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the HTTP response.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// The headers of the HTTP response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null && (this.Headers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Latency. 
        /// <para>
        /// The execution latency, in ms, of the test invoke request.
        /// </para>
        /// </summary>
        public long? Latency { get; set; }

        /// <summary>
        /// Checks to see if the Latency property is set.
        /// </summary>
        internal bool IsSetLatency() => this.Latency.HasValue;

        /// <summary>
        /// Gets and sets the property Log. 
        /// <para>
        /// The API Gateway execution log for the test invoke request.
        /// </para>
        /// </summary>
        public string Log { get; set; }

        /// <summary>
        /// Checks to see if the Log property is set.
        /// </summary>
        internal bool IsSetLog() => this.Log != null;

        /// <summary>
        /// Gets and sets the property MultiValueHeaders. 
        /// <para>
        /// The headers of the HTTP response as a map from string to list of values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MultiValueHeaders { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the MultiValueHeaders property is set.
        /// </summary>
        internal bool IsSetMultiValueHeaders() => this.MultiValueHeaders != null && (this.MultiValueHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status code.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
