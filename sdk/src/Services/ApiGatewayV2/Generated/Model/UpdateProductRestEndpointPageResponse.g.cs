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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateProductRestEndpointPage operation.
    /// </summary>
    public partial class UpdateProductRestEndpointPageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DisplayContent. 
        /// <para>
        /// The content of the product REST endpoint page.
        /// </para>
        /// </summary>
        public EndpointDisplayContentResponse DisplayContent { get; set; }

        /// <summary>
        /// Checks to see if the DisplayContent property is set.
        /// </summary>
        internal bool IsSetDisplayContent() => this.DisplayContent != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the product REST endpoint page was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property ProductRestEndpointPageArn. 
        /// <para>
        /// The ARN of the product REST endpoint page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProductRestEndpointPageArn { get; set; }

        /// <summary>
        /// Checks to see if the ProductRestEndpointPageArn property is set.
        /// </summary>
        internal bool IsSetProductRestEndpointPageArn() => this.ProductRestEndpointPageArn != null;

        /// <summary>
        /// Gets and sets the property ProductRestEndpointPageId. 
        /// <para>
        /// The product REST endpoint page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 30)]
        public string ProductRestEndpointPageId { get; set; }

        /// <summary>
        /// Checks to see if the ProductRestEndpointPageId property is set.
        /// </summary>
        internal bool IsSetProductRestEndpointPageId() => this.ProductRestEndpointPageId != null;

        /// <summary>
        /// Gets and sets the property RestEndpointIdentifier. 
        /// <para>
        /// The REST endpoint identifier.
        /// </para>
        /// </summary>
        public RestEndpointIdentifier RestEndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RestEndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetRestEndpointIdentifier() => this.RestEndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusException. 
        /// <para>
        /// The status exception information.
        /// </para>
        /// </summary>
        public StatusException StatusException { get; set; }

        /// <summary>
        /// Checks to see if the StatusException property is set.
        /// </summary>
        internal bool IsSetStatusException() => this.StatusException != null;

        /// <summary>
        /// Gets and sets the property TryItState. 
        /// <para>
        /// The try it state of a product REST endpoint page.
        /// </para>
        /// </summary>
        public TryItState TryItState { get; set; }

        /// <summary>
        /// Checks to see if the TryItState property is set.
        /// </summary>
        internal bool IsSetTryItState() => this.TryItState != null;
    }
}
