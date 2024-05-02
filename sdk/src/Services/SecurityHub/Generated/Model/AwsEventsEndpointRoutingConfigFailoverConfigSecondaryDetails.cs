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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The Amazon Web Services Region that events are routed to when failover is triggered
    /// or event replication is enabled.
    /// </summary>
    public partial class AwsEventsEndpointRoutingConfigFailoverConfigSecondaryDetails
    {
        private string _route;

        /// <summary>
        /// Gets and sets the property Route. 
        /// <para>
        ///  Defines the secondary Region.
        /// </para>
        /// </summary>
        public string Route
        {
            get { return this._route; }
            set { this._route = value; }
        }

        // Check to see if Route property is set
        internal bool IsSetRoute()
        {
            return this._route != null;
        }

    }
}