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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the DeregisterRobot operation.
    /// </summary>
    public partial class DeregisterRobotResponse : AmazonWebServiceResponse
    {
        private string _fleet;
        private string _robot;

        /// <summary>
        /// Gets and sets the property Fleet. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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

        /// <summary>
        /// Gets and sets the property Robot. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the robot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Robot
        {
            get { return this._robot; }
            set { this._robot = value; }
        }

        // Check to see if Robot property is set
        internal bool IsSetRobot()
        {
            return this._robot != null;
        }

    }
}