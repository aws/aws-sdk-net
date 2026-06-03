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
    /// Required attribution to display.
    /// </summary>
    public partial class RouteAttribution
    {
        private RouteAttributionType _attributionType;
        private RouteWebLink _webLink;

        /// <summary>
        /// Gets and sets the property AttributionType. 
        /// <para>
        /// The type of the attribution link.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteAttributionType AttributionType
        {
            get { return this._attributionType; }
            set { this._attributionType = value; }
        }

        // Check to see if AttributionType property is set
        internal bool IsSetAttributionType()
        {
            return this._attributionType != null;
        }

        /// <summary>
        /// Gets and sets the property WebLink. 
        /// <para>
        /// The URL to an external resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteWebLink WebLink
        {
            get { return this._webLink; }
            set { this._webLink = value; }
        }

        // Check to see if WebLink property is set
        internal bool IsSetWebLink()
        {
            return this._webLink != null;
        }

    }
}