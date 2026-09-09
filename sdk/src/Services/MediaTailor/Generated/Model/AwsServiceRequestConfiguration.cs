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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
        private string _body;
        private Dictionary<string, string> _headers = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MethodType _methodType;
        private Dictionary<string, string> _output = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _requestTimeoutMilliseconds;
        private RuntimeType _runtime;
        private string _targetRegion;
        private string _targetService;
        private string _url;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// An expression that evaluates to the request body for the AWS service API call. The
        /// body must conform to the input format that the target service operation expects. Applies
        /// only when the target operation accepts a request body. The maximum size after evaluation
        /// is 64 KB.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// A map of HTTP header names to expression values. MediaTailor evaluates each header
        /// value expression at runtime and includes the result in the outbound request to the
        /// AWS service. Use this to pass any headers required by the target service operation.
        /// You can include a maximum of 50 headers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public MethodType MethodType
        {
            get { return this._methodType; }
            set { this._methodType = value; }
        }

        // Check to see if MethodType property is set
        internal bool IsSetMethodType()
        {
            return this._methodType != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A map of output bindings. Each key is a namespaced output path, such as <c>player_params.device_type</c>.
        /// Each value is an expression that MediaTailor evaluates at runtime and can reference
        /// the <c>response</c> object from the target service. For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-jsonata.html">JSONata
        /// expression reference</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null && (this._output.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequestTimeoutMilliseconds. 
        /// <para>
        /// The maximum time, in milliseconds, that MediaTailor waits for a response from the
        /// AWS service. If the call exceeds this timeout, MediaTailor sets the response status
        /// code to <c>null</c> and proceeds with output expression evaluation. Valid values:
        /// <c>100</c> to <c>2000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RequestTimeoutMilliseconds
        {
            get { return this._requestTimeoutMilliseconds; }
            set { this._requestTimeoutMilliseconds = value; }
        }

        // Check to see if RequestTimeoutMilliseconds property is set
        internal bool IsSetRequestTimeoutMilliseconds()
        {
            return this._requestTimeoutMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// The only supported value is <c>JSONata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeType Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRegion. 
        /// <para>
        /// The AWS Region for the target service. Specify a static Region code (for example,
        /// <c>us-east-1</c>) or a JSONata expression that resolves to a Region code at runtime
        /// (for example, <c>{%inference.region%}</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TargetRegion
        {
            get { return this._targetRegion; }
            set { this._targetRegion = value; }
        }

        // Check to see if TargetRegion property is set
        internal bool IsSetTargetRegion()
        {
            return this._targetRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TargetService. 
        /// <para>
        /// The AWS service to call. Valid value: <c>elemental-inference</c> (AWS Elemental Inference).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TargetService
        {
            get { return this._targetService; }
            set { this._targetService = value; }
        }

        // Check to see if TargetService property is set
        internal bool IsSetTargetService()
        {
            return this._targetService != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// An expression that evaluates to the endpoint URL for the target AWS service API operation.
        /// Use <c>{%...%}</c> delimiters for dynamic expressions. The URL must correspond to
        /// a valid endpoint for the service specified in <c>TargetService</c>. The maximum length
        /// after evaluation is 2,048 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}