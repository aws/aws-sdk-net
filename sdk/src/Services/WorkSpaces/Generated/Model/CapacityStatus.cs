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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
        private int? _activeUserSessions;
        private int? _actualUserSessions;
        private int? _availableUserSessions;
        private int? _desiredUserSessions;

        /// <summary>
        /// Gets and sets the property ActiveUserSessions. 
        /// <para>
        /// The number of user sessions currently being used for your pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ActiveUserSessions
        {
            get { return this._activeUserSessions; }
            set { this._activeUserSessions = value; }
        }

        // Check to see if ActiveUserSessions property is set
        internal bool IsSetActiveUserSessions()
        {
            return this._activeUserSessions.HasValue; 
        }

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
        [AWSProperty(Required=true, Min=0)]
        public int? ActualUserSessions
        {
            get { return this._actualUserSessions; }
            set { this._actualUserSessions = value; }
        }

        // Check to see if ActualUserSessions property is set
        internal bool IsSetActualUserSessions()
        {
            return this._actualUserSessions.HasValue; 
        }

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
        [AWSProperty(Required=true, Min=0)]
        public int? AvailableUserSessions
        {
            get { return this._availableUserSessions; }
            set { this._availableUserSessions = value; }
        }

        // Check to see if AvailableUserSessions property is set
        internal bool IsSetAvailableUserSessions()
        {
            return this._availableUserSessions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredUserSessions. 
        /// <para>
        /// The total number of sessions slots that are either running or pending. This represents
        /// the total number of concurrent streaming sessions your pool can support in a steady
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? DesiredUserSessions
        {
            get { return this._desiredUserSessions; }
            set { this._desiredUserSessions = value; }
        }

        // Check to see if DesiredUserSessions property is set
        internal bool IsSetDesiredUserSessions()
        {
            return this._desiredUserSessions.HasValue; 
        }

    }
}