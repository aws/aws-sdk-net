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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the ImportDocumentationParts operation.
    /// 
    /// </summary>
    public partial class ImportDocumentationPartsRequest : AmazonAPIGatewayRequest
    {
        private MemoryStream _body;
        private bool? _failOnWarnings;
        private PutMode _mode;
        private string _restApiId;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// [Required] Raw byte array representing the to-be-imported documentation parts. To
        /// import from an OpenAPI file, this is a JSON object.
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
        /// Gets and sets the property FailOnWarnings. 
        /// <para>
        /// A query parameter to specify whether to rollback the documentation importation (<code>true</code>)
        /// or not (<code>false</code>) when a warning is encountered. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool FailOnWarnings
        {
            get { return this._failOnWarnings.GetValueOrDefault(); }
            set { this._failOnWarnings = value; }
        }

        // Check to see if FailOnWarnings property is set
        internal bool IsSetFailOnWarnings()
        {
            return this._failOnWarnings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// A query parameter to indicate whether to overwrite (<code>OVERWRITE</code>) any existing
        /// <a>DocumentationParts</a> definition or to merge (<code>MERGE</code>) the new definition
        /// into the existing one. The default value is <code>MERGE</code>.
        /// </para>
        /// </summary>
        public PutMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
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