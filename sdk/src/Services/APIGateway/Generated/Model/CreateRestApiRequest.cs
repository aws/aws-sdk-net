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
    /// Container for the parameters to the CreateRestApi operation.
    /// Creates a new <a>RestApi</a> resource.
    /// </summary>
    public partial class CreateRestApiRequest : AmazonAPIGatewayRequest
    {
        private string _cloneFrom;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property CloneFrom. 
        /// <para>
        /// The name of the <a>RestApi</a> that you want to clone from.
        /// </para>
        /// </summary>
        public string CloneFrom
        {
            get { return this._cloneFrom; }
            set { this._cloneFrom = value; }
        }

        // Check to see if CloneFrom property is set
        internal bool IsSetCloneFrom()
        {
            return this._cloneFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}