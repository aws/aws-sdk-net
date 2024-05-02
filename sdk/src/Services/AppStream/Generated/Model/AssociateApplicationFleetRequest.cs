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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateApplicationFleet operation.
    /// Associates the specified application with the specified fleet. This is only supported
    /// for Elastic fleets.
    /// </summary>
    public partial class AssociateApplicationFleetRequest : AmazonAppStreamRequest
    {
        private string _applicationArn;
        private string _fleetName;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

    }
}