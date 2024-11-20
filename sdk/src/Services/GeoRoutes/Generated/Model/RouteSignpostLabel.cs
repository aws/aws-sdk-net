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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Labels presented on the sign post.
    /// </summary>
    public partial class RouteSignpostLabel
    {
        private RouteNumber _routeNumber;
        private LocalizedString _text;

        /// <summary>
        /// Gets and sets the property RouteNumber. 
        /// <para>
        /// Route number of the road.
        /// </para>
        /// </summary>
        public RouteNumber RouteNumber
        {
            get { return this._routeNumber; }
            set { this._routeNumber = value; }
        }

        // Check to see if RouteNumber property is set
        internal bool IsSetRouteNumber()
        {
            return this._routeNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The Signpost text.
        /// </para>
        /// </summary>
        public LocalizedString Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}