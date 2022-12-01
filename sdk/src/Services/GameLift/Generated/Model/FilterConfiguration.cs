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
    /// A list of fleet locations where a game session queue can place new game sessions.
    /// You can use a filter to temporarily turn off placements for specific locations. For
    /// queues that have multi-location fleets, you can use a filter configuration allow placement
    /// with some, but not all of these locations.
    /// </summary>
    public partial class FilterConfiguration
    {
        private List<string> _allowedLocations = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowedLocations. 
        /// <para>
        ///  A list of locations to allow game session placement in, in the form of Amazon Web
        /// Services Region codes such as <code>us-west-2</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> AllowedLocations
        {
            get { return this._allowedLocations; }
            set { this._allowedLocations = value; }
        }

        // Check to see if AllowedLocations property is set
        internal bool IsSetAllowedLocations()
        {
            return this._allowedLocations != null && this._allowedLocations.Count > 0; 
        }

    }
}