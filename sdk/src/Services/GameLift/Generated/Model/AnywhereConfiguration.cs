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
    /// GameLift Anywhere configuration options for your Anywhere fleets.
    /// </summary>
    public partial class AnywhereConfiguration
    {
        private string _cost;

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost to run your fleet per hour. GameLift uses the provided cost of your fleet
        /// to balance usage in queues. For more information about queues, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">Setting
        /// up queues</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=11)]
        public string Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost != null;
        }

    }
}