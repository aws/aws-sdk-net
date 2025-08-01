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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The header matching rules for test traffic routing in Amazon ECS blue/green deployments.
    /// These rules determine how incoming requests are matched based on HTTP headers to route
    /// test traffic to the new service revision.
    /// </summary>
    public partial class ServiceConnectTestTrafficHeaderMatchRules
    {
        private string _exact;

        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// The exact value that the HTTP header must match for the test traffic routing rule
        /// to apply. This provides precise control over which requests are routed to the new
        /// service revision during blue/green deployments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Exact
        {
            get { return this._exact; }
            set { this._exact = value; }
        }

        // Check to see if Exact property is set
        internal bool IsSetExact()
        {
            return this._exact != null;
        }

    }
}