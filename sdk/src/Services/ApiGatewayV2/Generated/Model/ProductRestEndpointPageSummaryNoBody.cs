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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// A summary of a product REST endpoint page, without providing the page content.
    /// </summary>
    public partial class ProductRestEndpointPageSummaryNoBody
    {
        private string _endpoint;
        private DateTime? _lastModified;
        private string _operationName;
        private string _productRestEndpointPageArn;
        private string _productRestEndpointPageId;
        private RestEndpointIdentifier _restEndpointIdentifier;
        private Status _status;
        private StatusException _statusException;
        private TryItState _tryItState;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint of the product REST endpoint page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the product REST endpoint page was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// The operation name of the product REST endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductRestEndpointPageArn. 
        /// <para>
        /// The ARN of the product REST endpoint page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProductRestEndpointPageArn
        {
            get { return this._productRestEndpointPageArn; }
            set { this._productRestEndpointPageArn = value; }
        }

        // Check to see if ProductRestEndpointPageArn property is set
        internal bool IsSetProductRestEndpointPageArn()
        {
            return this._productRestEndpointPageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductRestEndpointPageId. 
        /// <para>
        /// The product REST endpoint page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=30)]
        public string ProductRestEndpointPageId
        {
            get { return this._productRestEndpointPageId; }
            set { this._productRestEndpointPageId = value; }
        }

        // Check to see if ProductRestEndpointPageId property is set
        internal bool IsSetProductRestEndpointPageId()
        {
            return this._productRestEndpointPageId != null;
        }

        /// <summary>
        /// Gets and sets the property RestEndpointIdentifier. 
        /// <para>
        /// The REST endpoint identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RestEndpointIdentifier RestEndpointIdentifier
        {
            get { return this._restEndpointIdentifier; }
            set { this._restEndpointIdentifier = value; }
        }

        // Check to see if RestEndpointIdentifier property is set
        internal bool IsSetRestEndpointIdentifier()
        {
            return this._restEndpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusException. 
        /// <para>
        /// The status exception information.
        /// </para>
        /// </summary>
        public StatusException StatusException
        {
            get { return this._statusException; }
            set { this._statusException = value; }
        }

        // Check to see if StatusException property is set
        internal bool IsSetStatusException()
        {
            return this._statusException != null;
        }

        /// <summary>
        /// Gets and sets the property TryItState. 
        /// <para>
        /// The try it state of a product REST endpoint page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TryItState TryItState
        {
            get { return this._tryItState; }
            set { this._tryItState = value; }
        }

        // Check to see if TryItState property is set
        internal bool IsSetTryItState()
        {
            return this._tryItState != null;
        }

    }
}