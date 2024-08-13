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
    /// Container for the parameters to the GetDocumentationParts operation.
    /// Gets documentation parts.
    /// </summary>
    public partial class GetDocumentationPartsRequest : AmazonAPIGatewayRequest
    {
        private int? _limit;
        private LocationStatusType _locationStatus;
        private string _nameQuery;
        private string _path;
        private string _position;
        private string _restApiId;
        private DocumentationPartType _type;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationStatus. 
        /// <para>
        /// The status of the API documentation parts to retrieve. Valid values are <c>DOCUMENTED</c>
        /// for retrieving DocumentationPart resources with content and <c>UNDOCUMENTED</c> for
        /// DocumentationPart resources without content.
        /// </para>
        /// </summary>
        public LocationStatusType LocationStatus
        {
            get { return this._locationStatus; }
            set { this._locationStatus = value; }
        }

        // Check to see if LocationStatus property is set
        internal bool IsSetLocationStatus()
        {
            return this._locationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NameQuery. 
        /// <para>
        /// The name of API entities of the to-be-retrieved documentation parts.
        /// </para>
        /// </summary>
        public string NameQuery
        {
            get { return this._nameQuery; }
            set { this._nameQuery = value; }
        }

        // Check to see if NameQuery property is set
        internal bool IsSetNameQuery()
        {
            return this._nameQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of API entities of the to-be-retrieved documentation parts.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of API entities of the to-be-retrieved documentation parts. 
        /// </para>
        /// </summary>
        public DocumentationPartType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}