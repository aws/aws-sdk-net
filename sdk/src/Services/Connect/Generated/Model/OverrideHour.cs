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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about hours of operation override
    /// </summary>
    public partial class OverrideHour
    {
        private OverrideTimeSlice _end;
        private OperationalStatus _operationalStatus;
        private string _overrideName;
        private OverrideTimeSlice _start;

        /// <summary>
        /// Gets and sets the property End.
        /// </summary>
        public OverrideTimeSlice End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property OperationalStatus. 
        /// <para>
        /// Indicates whether the status is open or closed during the override period. This status
        /// determines how the override modifies the base hours of operation schedule.
        /// </para>
        /// </summary>
        public OperationalStatus OperationalStatus
        {
            get { return this._operationalStatus; }
            set { this._operationalStatus = value; }
        }

        // Check to see if OperationalStatus property is set
        internal bool IsSetOperationalStatus()
        {
            return this._operationalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OverrideName. 
        /// <para>
        /// Unique identifier name for the override.
        /// </para>
        /// </summary>
        public string OverrideName
        {
            get { return this._overrideName; }
            set { this._overrideName = value; }
        }

        // Check to see if OverrideName property is set
        internal bool IsSetOverrideName()
        {
            return this._overrideName != null;
        }

        /// <summary>
        /// Gets and sets the property Start.
        /// </summary>
        public OverrideTimeSlice Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}