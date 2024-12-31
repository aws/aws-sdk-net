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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Specifies the frequency for a dashboard refresh schedule. 
    /// 
    ///  
    /// <para>
    ///  For a custom dashboard, you can schedule a refresh for every 1, 6, 12, or 24 hours,
    /// or every day. 
    /// </para>
    /// </summary>
    public partial class RefreshScheduleFrequency
    {
        private RefreshScheduleFrequencyUnit _unit;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit to use for the refresh. 
        /// </para>
        ///  
        /// <para>
        /// For custom dashboards, the unit can be <c>HOURS</c> or <c>DAYS</c>.
        /// </para>
        ///  
        /// <para>
        /// For the Highlights dashboard, the <c>Unit</c> must be <c>HOURS</c>.
        /// </para>
        /// </summary>
        public RefreshScheduleFrequencyUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  The value for the refresh schedule. 
        /// </para>
        ///  
        /// <para>
        ///  For custom dashboards, the following values are valid when the unit is <c>HOURS</c>:
        /// <c>1</c>, <c>6</c>, <c>12</c>, <c>24</c> 
        /// </para>
        ///  
        /// <para>
        /// For custom dashboards, the only valid value when the unit is <c>DAYS</c> is <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// For the Highlights dashboard, the <c>Value</c> must be <c>6</c>.
        /// </para>
        /// </summary>
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}