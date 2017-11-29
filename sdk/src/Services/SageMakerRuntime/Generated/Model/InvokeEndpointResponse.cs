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
    /// This is the response object from the InvokeEndpoint operation.
    /// </summary>
    public partial class InvokeEndpointResponse : AmazonWebServiceResponse
    {
        private MemoryStream _body;
        private string _contentType;
        private string _invokedProductionVariant;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Includes the inference provided by the model.
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
        /// The MIME type of the inference returned in the response body.
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
        /// Gets and sets the property InvokedProductionVariant. 
        /// <para>
        /// Identifies the production variant that was invoked.
        /// </para>
        /// </summary>
        public string InvokedProductionVariant
        {
            get { return this._invokedProductionVariant; }
            set { this._invokedProductionVariant = value; }
        }

        // Check to see if InvokedProductionVariant property is set
        internal bool IsSetInvokedProductionVariant()
        {
            return this._invokedProductionVariant != null;
        }

    }
}