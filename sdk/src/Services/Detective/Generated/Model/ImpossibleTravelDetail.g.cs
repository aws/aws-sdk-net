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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Contains information on unusual and impossible travel in an account.
    /// </summary>
    public partial class ImpossibleTravelDetail
    {
        /// <summary>
        /// Gets and sets the property EndingIpAddress. 
        /// <para>
        /// IP address where the resource was last used in the impossible travel.
        /// </para>
        /// </summary>
        public string EndingIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the EndingIpAddress property is set.
        /// </summary>
        internal bool IsSetEndingIpAddress() => this.EndingIpAddress != null;

        /// <summary>
        /// Gets and sets the property EndingLocation. 
        /// <para>
        /// Location where the resource was last used in the impossible travel.
        /// </para>
        /// </summary>
        public string EndingLocation { get; set; }

        /// <summary>
        /// Checks to see if the EndingLocation property is set.
        /// </summary>
        internal bool IsSetEndingLocation() => this.EndingLocation != null;

        /// <summary>
        /// Gets and sets the property HourlyTimeDelta. 
        /// <para>
        /// Returns the time difference between the first and last timestamp the resource was
        /// used.
        /// </para>
        /// </summary>
        public int? HourlyTimeDelta { get; set; }

        /// <summary>
        /// Checks to see if the HourlyTimeDelta property is set.
        /// </summary>
        internal bool IsSetHourlyTimeDelta() => this.HourlyTimeDelta.HasValue;

        /// <summary>
        /// Gets and sets the property StartingIpAddress. 
        /// <para>
        /// IP address where the resource was first used in the impossible travel.
        /// </para>
        /// </summary>
        public string StartingIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the StartingIpAddress property is set.
        /// </summary>
        internal bool IsSetStartingIpAddress() => this.StartingIpAddress != null;

        /// <summary>
        /// Gets and sets the property StartingLocation. 
        /// <para>
        /// Location where the resource was first used in the impossible travel.
        /// </para>
        /// </summary>
        public string StartingLocation { get; set; }

        /// <summary>
        /// Checks to see if the StartingLocation property is set.
        /// </summary>
        internal bool IsSetStartingLocation() => this.StartingLocation != null;
    }
}
