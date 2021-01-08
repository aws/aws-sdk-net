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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIntegrationResponse operation.
    /// Deletes an IntegrationResponses.
    /// </summary>
    public partial class DeleteIntegrationResponseRequest : AmazonApiGatewayV2Request
    {
        private string _apiId;
        private string _integrationId;
        private string _integrationResponseId;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The integration ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationId
        {
            get { return this._integrationId; }
            set { this._integrationId = value; }
        }

        // Check to see if IntegrationId property is set
        internal bool IsSetIntegrationId()
        {
            return this._integrationId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationResponseId. 
        /// <para>
        /// The integration response ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationResponseId
        {
            get { return this._integrationResponseId; }
            set { this._integrationResponseId = value; }
        }

        // Check to see if IntegrationResponseId property is set
        internal bool IsSetIntegrationResponseId()
        {
            return this._integrationResponseId != null;
        }

    }
}