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
    /// Describes the capacity for a fleet.
    /// </summary>
    public partial class ComputeCapacity
    {
        private int? _desiredInstances;
        private int? _desiredSessions;

        /// <summary>
        /// Gets and sets the property DesiredInstances. 
        /// <para>
        /// The desired number of streaming instances.
        /// </para>
        /// </summary>
        public int? DesiredInstances
        {
            get { return this._desiredInstances; }
            set { this._desiredInstances = value; }
        }

        // Check to see if DesiredInstances property is set
        internal bool IsSetDesiredInstances()
        {
            return this._desiredInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredSessions. 
        /// <para>
        /// The desired number of user sessions for a multi-session fleet. This is not allowed
        /// for single-session fleets.
        /// </para>
        ///  
        /// <para>
        /// When you create a fleet, you must set either the DesiredSessions or DesiredInstances
        /// attribute, based on the type of fleet you create. You can’t define both attributes
        /// or leave both attributes blank.
        /// </para>
        /// </summary>
        public int? DesiredSessions
        {
            get { return this._desiredSessions; }
            set { this._desiredSessions = value; }
        }

        // Check to see if DesiredSessions property is set
        internal bool IsSetDesiredSessions()
        {
            return this._desiredSessions.HasValue; 
        }

    }
}