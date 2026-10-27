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
    /// Container for the parameters to the GetIntegrationResponse operation. Gets an IntegrationResponses.
    /// </summary>
    public partial class GetIntegrationResponseRequest : AmazonApiGatewayV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The integration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationResponseId. 
        /// <para>
        /// The integration response ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationResponseId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationResponseId property is set.
        /// </summary>
        internal bool IsSetIntegrationResponseId() => this.IntegrationResponseId != null;
    }
}
