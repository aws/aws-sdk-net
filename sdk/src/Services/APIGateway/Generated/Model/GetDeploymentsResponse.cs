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
    /// Represents a collection resource that contains zero or more references to your existing
    /// deployments, and links that guide you on how to interact with your collection. The
    /// collection offers a paginated view of the contained deployments.
    /// 
    ///  <div class="remarks">To create a new deployment of a <a>RestApi</a>, make a <code>POST</code>
    /// request against this resource. To view, update, or delete an existing deployment,
    /// make a <code>GET</code>, <code>PATCH</code>, or <code>DELETE</code> request, respectively,
    /// on a specified <a>Deployment</a> resource.</div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-deploy-api.html">Deploying
    /// an API</a>, <a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/get-deployment.html">AWS
    /// CLI</a>, <a href="https://aws.amazon.com/tools/">AWS SDKs</a> </div>
    /// </summary>
    public partial class GetDeploymentsResponse : AmazonWebServiceResponse
    {
        private List<Deployment> _items = new List<Deployment>();
        private string _position;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The current page of elements from this collection.
        /// </para>
        /// </summary>
        public List<Deployment> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Position.
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

    }
}