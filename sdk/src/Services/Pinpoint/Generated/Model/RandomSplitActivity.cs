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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a random split activity in a journey. This type of activity
    /// randomly sends specified percentages of participants down one of as many as five paths
    /// in a journey, based on conditions that you specify.
    /// </summary>
    public partial class RandomSplitActivity
    {
        private List<RandomSplitEntry> _branches = new List<RandomSplitEntry>();

        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The paths for the activity, including the percentage of participants to enter each
        /// path and the activity to perform for each path.
        /// </para>
        /// </summary>
        public List<RandomSplitEntry> Branches
        {
            get { return this._branches; }
            set { this._branches = value; }
        }

        // Check to see if Branches property is set
        internal bool IsSetBranches()
        {
            return this._branches != null && this._branches.Count > 0; 
        }

    }
}