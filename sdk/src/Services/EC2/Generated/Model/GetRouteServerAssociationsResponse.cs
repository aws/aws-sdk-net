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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetRouteServerAssociations operation.
    /// </summary>
    public partial class GetRouteServerAssociationsResponse : AmazonWebServiceResponse
    {
        private List<RouteServerAssociation> _routeServerAssociations = AWSConfigs.InitializeCollections ? new List<RouteServerAssociation>() : null;

        /// <summary>
        /// Gets and sets the property RouteServerAssociations. 
        /// <para>
        /// Information about the associations for the specified route server.
        /// </para>
        /// </summary>
        public List<RouteServerAssociation> RouteServerAssociations
        {
            get { return this._routeServerAssociations; }
            set { this._routeServerAssociations = value; }
        }

        // Check to see if RouteServerAssociations property is set
        internal bool IsSetRouteServerAssociations()
        {
            return this._routeServerAssociations != null && (this._routeServerAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}