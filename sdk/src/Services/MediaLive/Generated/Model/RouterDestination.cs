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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for RouterDestination
    /// </summary>
    public partial class RouterDestination
    {
        private string _availabilityZoneName;
        private string _routerOutputArn;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. The Availability Zone (AZ) names
        /// of the AZs this destination is created in.
        /// </summary>
        public string AvailabilityZoneName
        {
            get { return this._availabilityZoneName; }
            set { this._availabilityZoneName = value; }
        }

        // Check to see if AvailabilityZoneName property is set
        internal bool IsSetAvailabilityZoneName()
        {
            return this._availabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property RouterOutputArn. ARN of the output from MediaConnect Router
        /// currently connected to this input.
        /// </summary>
        public string RouterOutputArn
        {
            get { return this._routerOutputArn; }
            set { this._routerOutputArn = value; }
        }

        // Check to see if RouterOutputArn property is set
        internal bool IsSetRouterOutputArn()
        {
            return this._routerOutputArn != null;
        }

    }
}