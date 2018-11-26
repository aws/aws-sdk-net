/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFleet operation.
    /// Describes a fleet.
    /// </summary>
    public partial class DescribeFleetRequest : AmazonRoboMakerRequest
    {
        private string _fleet;

        /// <summary>
        /// Gets and sets the property Fleet. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
        /// </para>
        /// </summary>
        public string Fleet
        {
            get { return this._fleet; }
            set { this._fleet = value; }
        }

        // Check to see if Fleet property is set
        internal bool IsSetFleet()
        {
            return this._fleet != null;
        }

    }
}