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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// The drift status summary of the landing zone. 
    /// 
    ///  
    /// <para>
    /// If the landing zone differs from the expected configuration, it is defined to be in
    /// a state of drift. You can repair this drift by resetting the landing zone.
    /// </para>
    /// </summary>
    public partial class LandingZoneDriftStatusSummary
    {
        private LandingZoneDriftStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The drift status of the landing zone. 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DRIFTED</c>: The landing zone deployed in this configuration does not match the
        /// configuration that Amazon Web Services Control Tower expected. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The landing zone deployed in this configuration matches the configuration
        /// that Amazon Web Services Control Tower expected. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LandingZoneDriftStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}