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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains configuration details of multi-region endpoint (global-endpoint).
    /// </summary>
    public partial class Details
    {
        private List<RouteDetails> _routesDetails = AWSConfigs.InitializeCollections ? new List<RouteDetails>() : null;

        /// <summary>
        /// Gets and sets the property RoutesDetails. 
        /// <para>
        /// A list of route configuration details. Must contain exactly one route configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteDetails> RoutesDetails
        {
            get { return this._routesDetails; }
            set { this._routesDetails = value; }
        }

        // Check to see if RoutesDetails property is set
        internal bool IsSetRoutesDetails()
        {
            return this._routesDetails != null && (this._routesDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}