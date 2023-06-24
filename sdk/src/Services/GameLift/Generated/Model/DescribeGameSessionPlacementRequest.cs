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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeGameSessionPlacement operation.
    /// Retrieves information, including current status, about a game session placement request.
    /// 
    /// 
    ///  
    /// <para>
    /// To get game session placement details, specify the placement ID.
    /// </para>
    ///  
    /// <para>
    /// This operation is not designed to be continually called to track game session status.
    /// This practice can cause you to exceed your API limit, which results in errors. Instead,
    /// you must configure configure an Amazon Simple Notification Service (SNS) topic to
    /// receive notifications from FlexMatch or queues. Continuously polling with <code>DescribeGameSessionPlacement</code>
    /// should only be used for games in development with low game session usage. 
    /// </para>
    /// </summary>
    public partial class DescribeGameSessionPlacementRequest : AmazonGameLiftRequest
    {
        private string _placementId;

        /// <summary>
        /// Gets and sets the property PlacementId. 
        /// <para>
        /// A unique identifier for a game session placement to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string PlacementId
        {
            get { return this._placementId; }
            set { this._placementId = value; }
        }

        // Check to see if PlacementId property is set
        internal bool IsSetPlacementId()
        {
            return this._placementId != null;
        }

    }
}