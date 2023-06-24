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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is a resource filter containing FromDate: DateTime and ToDate: DateTime. Both
    /// values are required. Future DateTime values are not permitted.
    /// 
    ///  
    /// <para>
    /// The date and time are in Unix format and Coordinated Universal Time (UTC), and it
    /// is accurate to milliseconds ((milliseconds are optional). For example, the value 1516925490.087
    /// represents Friday, January 26, 2018 12:11:30.087 AM.
    /// </para>
    /// </summary>
    public partial class DateRange
    {
        private DateTime? _fromDate;
        private DateTime? _toDate;

        /// <summary>
        /// Gets and sets the property FromDate. 
        /// <para>
        /// This value is the beginning date, inclusive.
        /// </para>
        ///  
        /// <para>
        /// The date and time are in Unix format and Coordinated Universal Time (UTC), and it
        /// is accurate to milliseconds (milliseconds are optional).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime FromDate
        {
            get { return this._fromDate.GetValueOrDefault(); }
            set { this._fromDate = value; }
        }

        // Check to see if FromDate property is set
        internal bool IsSetFromDate()
        {
            return this._fromDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ToDate. 
        /// <para>
        /// This value is the end date, inclusive.
        /// </para>
        ///  
        /// <para>
        /// The date and time are in Unix format and Coordinated Universal Time (UTC), and it
        /// is accurate to milliseconds (milliseconds are optional).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ToDate
        {
            get { return this._toDate.GetValueOrDefault(); }
            set { this._toDate = value; }
        }

        // Check to see if ToDate property is set
        internal bool IsSetToDate()
        {
            return this._toDate.HasValue; 
        }

    }
}