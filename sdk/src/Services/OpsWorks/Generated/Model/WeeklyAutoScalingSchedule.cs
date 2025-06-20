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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes a time-based instance's auto scaling schedule. The schedule consists of
    /// a set of key-value pairs.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The key is the time period (a UTC hour) and must be an integer from 0 - 23.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The value indicates whether the instance should be online or offline for the specified
    /// period, and must be set to "on" or "off"
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The default setting for all time periods is off, so you use the following parameters
    /// primarily to specify the online periods. You don't have to explicitly specify offline
    /// periods unless you want to change an online period to an offline period.
    /// </para>
    ///  
    /// <para>
    /// The following example specifies that the instance should be online for four hours,
    /// from UTC 1200 - 1600. It will be off for the remainder of the day.
    /// </para>
    ///  
    /// <para>
    ///  <c> { "12":"on", "13":"on", "14":"on", "15":"on" } </c> 
    /// </para>
    /// </summary>
    public partial class WeeklyAutoScalingSchedule
    {
        private Dictionary<string, string> _friday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _monday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _saturday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sunday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _thursday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _tuesday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _wednesday = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Friday. 
        /// <para>
        /// The schedule for Friday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Friday
        {
            get { return this._friday; }
            set { this._friday = value; }
        }

        // Check to see if Friday property is set
        internal bool IsSetFriday()
        {
            return this._friday != null && (this._friday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Monday. 
        /// <para>
        /// The schedule for Monday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Monday
        {
            get { return this._monday; }
            set { this._monday = value; }
        }

        // Check to see if Monday property is set
        internal bool IsSetMonday()
        {
            return this._monday != null && (this._monday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Saturday. 
        /// <para>
        /// The schedule for Saturday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Saturday
        {
            get { return this._saturday; }
            set { this._saturday = value; }
        }

        // Check to see if Saturday property is set
        internal bool IsSetSaturday()
        {
            return this._saturday != null && (this._saturday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sunday. 
        /// <para>
        /// The schedule for Sunday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Sunday
        {
            get { return this._sunday; }
            set { this._sunday = value; }
        }

        // Check to see if Sunday property is set
        internal bool IsSetSunday()
        {
            return this._sunday != null && (this._sunday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Thursday. 
        /// <para>
        /// The schedule for Thursday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Thursday
        {
            get { return this._thursday; }
            set { this._thursday = value; }
        }

        // Check to see if Thursday property is set
        internal bool IsSetThursday()
        {
            return this._thursday != null && (this._thursday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tuesday. 
        /// <para>
        /// The schedule for Tuesday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tuesday
        {
            get { return this._tuesday; }
            set { this._tuesday = value; }
        }

        // Check to see if Tuesday property is set
        internal bool IsSetTuesday()
        {
            return this._tuesday != null && (this._tuesday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Wednesday. 
        /// <para>
        /// The schedule for Wednesday.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Wednesday
        {
            get { return this._wednesday; }
            set { this._wednesday = value; }
        }

        // Check to see if Wednesday property is set
        internal bool IsSetWednesday()
        {
            return this._wednesday != null && (this._wednesday.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}