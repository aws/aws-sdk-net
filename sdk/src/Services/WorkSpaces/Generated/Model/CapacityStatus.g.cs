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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the capacity status for a pool of WorkSpaces.
    /// </summary>
    public partial class CapacityStatus
    {
        /// <summary>
        /// Gets and sets the property ActiveUserSessions. 
        /// <para>
        /// The number of user sessions currently being used for your pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ActiveUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the ActiveUserSessions property is set.
        /// </summary>
        internal bool IsSetActiveUserSessions() => this.ActiveUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property ActualUserSessions. 
        /// <para>
        /// The total number of user sessions that are available for streaming or are currently
        /// streaming in your pool.
        /// </para>
        ///  
        /// <para>
        /// ActualUserSessions = AvailableUserSessions + ActiveUserSessions
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ActualUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the ActualUserSessions property is set.
        /// </summary>
        internal bool IsSetActualUserSessions() => this.ActualUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property AvailableUserSessions. 
        /// <para>
        /// The number of user sessions currently available for streaming from your pool.
        /// </para>
        ///  
        /// <para>
        /// AvailableUserSessions = ActualUserSessions - ActiveUserSessions
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? AvailableUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the AvailableUserSessions property is set.
        /// </summary>
        internal bool IsSetAvailableUserSessions() => this.AvailableUserSessions.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredUserSessions. 
        /// <para>
        /// The total number of sessions slots that are either running or pending. This represents
        /// the total number of concurrent streaming sessions your pool can support in a steady
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? DesiredUserSessions { get; set; }

        /// <summary>
        /// Checks to see if the DesiredUserSessions property is set.
        /// </summary>
        internal bool IsSetDesiredUserSessions() => this.DesiredUserSessions.HasValue;
    }
}
