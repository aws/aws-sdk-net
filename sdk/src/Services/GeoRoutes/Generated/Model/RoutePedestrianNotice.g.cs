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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    public partial class RoutePedestrianNotice
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Code corresponding to the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutePedestrianNoticeCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// Impact corresponding to the issue. While Low impact notices can be safely ignored,
        /// High impact notices must be evaluated further to determine the impact.
        /// </para>
        /// </summary>
        public RouteNoticeImpact Impact { get; set; }

        /// <summary>
        /// Checks to see if the Impact property is set.
        /// </summary>
        internal bool IsSetImpact() => this.Impact != null;
    }
}
