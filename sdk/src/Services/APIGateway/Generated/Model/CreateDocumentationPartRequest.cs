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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
    /// Container for the parameters to the CreateDocumentationPart operation.
    /// Creates a documentation part.
    /// </summary>
    public partial class CreateDocumentationPartRequest : AmazonAPIGatewayRequest
    {
        private DocumentationPartLocation _location;
        private string _properties;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the targeted API entity of the to-be-created documentation part.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentationPartLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The new documentation content map of the targeted API entity. Enclosed key-value pairs
        /// are API-specific, but only OpenAPI-compliant key-value pairs can be exported and,
        /// hence, published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

    }
}