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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// a structure that contains details for the web app.
    /// </summary>
    public partial class ListedWebApp
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoint. 
        /// <para>
        /// The <c>AccessEndpoint</c> is the URL that you provide to your users for them to interact
        /// with the Transfer Family web app. You can specify a custom URL or use the default
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AccessEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AccessEndpoint property is set.
        /// </summary>
        internal bool IsSetAccessEndpoint() => this.AccessEndpoint != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint hosting the web app. Valid values are <c>PUBLIC</c> for publicly
        /// accessible endpoints and <c>VPC</c> for VPC-hosted endpoints.
        /// </para>
        /// </summary>
        public WebAppEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property WebAppEndpoint. 
        /// <para>
        /// The <c>WebAppEndpoint</c> is the unique URL for your Transfer Family web app. This
        /// is the value that you use when you configure <b>Origins</b> on CloudFront.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string WebAppEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the WebAppEndpoint property is set.
        /// </summary>
        internal bool IsSetWebAppEndpoint() => this.WebAppEndpoint != null;

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// The unique identifier for the web app.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 24, Max = 24)]
        public string WebAppId { get; set; }

        /// <summary>
        /// Checks to see if the WebAppId property is set.
        /// </summary>
        internal bool IsSetWebAppId() => this.WebAppId != null;
    }
}
