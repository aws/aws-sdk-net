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
    /// Notices are additional information returned that indicate issues that occurred during
    /// route calculation.
    /// </summary>
    public partial class RouteVehicleNotice
    {
        private RouteVehicleNoticeCode _code;
        private List<RouteVehicleNoticeDetail> _details = AWSConfigs.InitializeCollections ? new List<RouteVehicleNoticeDetail>() : null;
        private RouteNoticeImpact _impact;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Code corresponding to the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteVehicleNoticeCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details of the notice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RouteVehicleNoticeDetail> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Impact corresponding to the issue. While Low impact notices can be safely ignored,
        /// High impact notices must be evaluated further to determine the impact.
        /// </para>
        /// </summary>
        public RouteNoticeImpact Impact
        {
            get { return this._impact; }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact != null;
        }

    }
}