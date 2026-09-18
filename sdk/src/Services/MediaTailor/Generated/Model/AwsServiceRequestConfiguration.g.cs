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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for an <c>AWS_SERVICE_REQUEST</c> function. Contains the target
    /// service, target Region, and request parameters that the function uses to call an AWS
    /// service API. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-types-aws-service-request.html">AWS_SERVICE_REQUEST</a>
    /// in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class AwsServiceRequestConfiguration
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// An expression that evaluates to the request body for the AWS service API call. The
        /// body must conform to the input format that the target service operation expects. Applies
        /// only when the target operation accepts a request body. The maximum size after evaluation
        /// is 64 KB.
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
        /// A map of HTTP header names to expression values. MediaTailor evaluates each header
        /// value expression at runtime and includes the result in the outbound request to the
        /// AWS service. Use this to pass any headers required by the target service operation.
        /// You can include a maximum of 50 headers.
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
        /// Gets and sets the property MethodType. 
        /// <para>
        /// Specifies how the function sends the request to the target service. The value must
        /// match what the target service operation requires. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GET</c> – Retrieves data from the target service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POST</c> – Submits a request body to the target service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MethodType MethodType { get; set; }

        /// <summary>
        /// Checks to see if the MethodType property is set.
        /// </summary>
        internal bool IsSetMethodType() => this.MethodType != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A map of output bindings. Each key is a namespaced output path, such as <c>player_params.device_type</c>.
        /// Each value is an expression that MediaTailor evaluates at runtime and can reference
        /// the <c>response</c> object from the target service. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-jsonata.html">JSONata
        /// expression reference</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null && (this.Output.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a response from the
        /// AWS service. If the call exceeds this timeout, MediaTailor sets the response status
        /// code to <c>null</c> and proceeds with output expression evaluation. Valid values:
        /// <c>100</c> to <c>2000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? RequestTimeoutMilliseconds { get; set; }

        /// <summary>
        /// Checks to see if the RequestTimeoutMilliseconds property is set.
        /// </summary>
        internal bool IsSetRequestTimeoutMilliseconds() => this.RequestTimeoutMilliseconds.HasValue;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// The only supported value is <c>JSONata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeType Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The AWS Region for the target service. Specify a static Region code (for example,
        /// <c>us-east-1</c>) or a JSONata expression that resolves to a Region code at runtime
        /// (for example, <c>{%inference.region%}</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TargetRegion { get; set; }

        /// <summary>
        /// Checks to see if the TargetRegion property is set.
        /// </summary>
        internal bool IsSetTargetRegion() => this.TargetRegion != null;

        /// <summary>
        /// Gets and sets the property TargetService. 
        /// <para>
        /// The AWS service to call. Valid value: <c>elemental-inference</c> (AWS Elemental Inference).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TargetService { get; set; }

        /// <summary>
        /// Checks to see if the TargetService property is set.
        /// </summary>
        internal bool IsSetTargetService() => this.TargetService != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// An expression that evaluates to the endpoint URL for the target AWS service API operation.
        /// Use <c>{%...%}</c> delimiters for dynamic expressions. The URL must correspond to
        /// a valid endpoint for the service specified in <c>TargetService</c>. The maximum length
        /// after evaluation is 2,048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
