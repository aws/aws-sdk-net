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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a listener. The listener contains the path used to route traffic
    /// that is received from the load balancer to a target group.
    /// </summary>
    public partial class TrafficRoute
    {
        private List<string> _listenerArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ListenerArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of one listener. The listener identifies the route
        /// between a target group and a load balancer. This is an array of strings with a maximum
        /// size of one. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListenerArns
        {
            get { return this._listenerArns; }
            set { this._listenerArns = value; }
        }

        // Check to see if ListenerArns property is set
        internal bool IsSetListenerArns()
        {
            return this._listenerArns != null && (this._listenerArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}