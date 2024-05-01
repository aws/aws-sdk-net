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
    /// Container for the parameters to the CreateResource operation.
    /// Creates a Resource resource.
    /// </summary>
    public partial class CreateResourceRequest : AmazonAPIGatewayRequest
    {
        private string _parentId;
        private string _pathPart;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The parent resource's identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

        /// <summary>
        /// Gets and sets the property PathPart. 
        /// <para>
        /// The last path segment for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PathPart
        {
            get { return this._pathPart; }
            set { this._pathPart = value; }
        }

        // Check to see if PathPart property is set
        internal bool IsSetPathPart()
        {
            return this._pathPart != null;
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