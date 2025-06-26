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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The container element for optionally specifying the default Object Lock retention
    /// settings for new objects placed in the specified bucket.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The <c>DefaultRetention</c> settings require both a mode and a period.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>DefaultRetention</c> period can be either <c>Days</c> or <c>Years</c> but you
    /// must select one. You cannot specify <c>Days</c> and <c>Years</c> at the same time.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DefaultRetention
    {
        private int? _days;
        private ObjectLockRetentionMode _mode;
        private int? _years;

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// The number of days that you want to specify for the default retention period. Must
        /// be used with <c>Mode</c>.
        /// </para>
        /// </summary>
        public int? Days
        {
            get { return this._days; }
            set { this._days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this._days.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The default Object Lock retention mode you want to apply to new objects placed in
        /// the specified bucket. Must be used with either <c>Days</c> or <c>Years</c>.
        /// </para>
        /// </summary>
        public ObjectLockRetentionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Years. 
        /// <para>
        /// The number of years that you want to specify for the default retention period. Must
        /// be used with <c>Mode</c>.
        /// </para>
        /// </summary>
        public int? Years
        {
            get { return this._years; }
            set { this._years = value; }
        }

        // Check to see if Years property is set
        internal bool IsSetYears()
        {
            return this._years.HasValue; 
        }

    }
}