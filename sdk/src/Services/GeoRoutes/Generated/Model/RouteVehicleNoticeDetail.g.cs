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
    /// Additional details of the notice.
    /// </summary>
    public partial class RouteVehicleNoticeDetail
    {
        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The notice title.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property ViolatedConstraints. 
        /// <para>
        /// Any violated constraints.
        /// </para>
        /// </summary>
        public RouteViolatedConstraints ViolatedConstraints { get; set; }

        /// <summary>
        /// Checks to see if the ViolatedConstraints property is set.
        /// </summary>
        internal bool IsSetViolatedConstraints() => this.ViolatedConstraints != null;
    }
}
