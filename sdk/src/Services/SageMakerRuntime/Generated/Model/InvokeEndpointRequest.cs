/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeEndpoint operation.
    /// After you deploy a model into production using Amazon SageMaker hosting services,
    /// your client applications use this API to get inferences from the model hosted at the
    /// specified endpoint. 
    /// 
    ///  
    /// <para>
    /// For an overview of Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
    /// It Works</a>. 
    /// </para>
    ///  
    /// <para>
    /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
    /// SageMaker might add additional headers. You should not rely on the behavior of headers
    /// outside those enumerated in the request syntax. 
    /// </para>
    ///  
    /// <para>
    /// Cals to <code>InvokeEndpoint</code> are authenticated by using AWS Signature Version
    /// 4. For information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (AWS Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Endpoints are scoped to an individual account, and are not public. The URL does not
    /// contain the account ID, but Amazon SageMaker determines the account ID from the authentication
    /// token that is supplied by the caller.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InvokeEndpointRequest : AmazonSageMakerRuntimeRequest
    {
        private string _accept;
        private MemoryStream _body;
        private string _contentType;
        private string _customAttributes;
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The desired MIME type of the inference in the response.
        /// </para>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Provides input data, in the format specified in the <code>ContentType</code> request
        /// header. Amazon SageMaker passes all of the data in the body to the model. 
        /// </para>
        ///  
        /// <para>
        /// For information about the format of the request body, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/cdf-inference.html">Common
        /// Data Formats—Inference</a>.
        /// </para>
        /// </summary>
        public MemoryStream Body
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the input data in the request body.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAttributes.
        /// </summary>
        public string CustomAttributes
        {
            get { return this._customAttributes; }
            set { this._customAttributes = value; }
        }

        // Check to see if CustomAttributes property is set
        internal bool IsSetCustomAttributes()
        {
            return this._customAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that you specified when you created the endpoint using the
        /// <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API. 
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

    }
}