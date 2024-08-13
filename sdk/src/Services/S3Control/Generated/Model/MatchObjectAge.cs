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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A filter condition that specifies the object age range of included objects in days.
    /// Only integers are supported.
    /// </summary>
    public partial class MatchObjectAge
    {
        private int? _daysGreaterThan;
        private int? _daysLessThan;

        /// <summary>
        /// Gets and sets the property DaysGreaterThan. 
        /// <para>
        ///  Specifies the maximum object age in days. Must be a positive whole number, greater
        /// than the minimum object age and less than or equal to 2,147,483,647. 
        /// </para>
        /// </summary>
        public int? DaysGreaterThan
        {
            get { return this._daysGreaterThan; }
            set { this._daysGreaterThan = value; }
        }

        // Check to see if DaysGreaterThan property is set
        internal bool IsSetDaysGreaterThan()
        {
            return this._daysGreaterThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaysLessThan. 
        /// <para>
        ///  Specifies the minimum object age in days. The value must be a positive whole number,
        /// greater than 0 and less than or equal to 2,147,483,647. 
        /// </para>
        /// </summary>
        public int? DaysLessThan
        {
            get { return this._daysLessThan; }
            set { this._daysLessThan = value; }
        }

        // Check to see if DaysLessThan property is set
        internal bool IsSetDaysLessThan()
        {
            return this._daysLessThan.HasValue; 
        }

    }
}