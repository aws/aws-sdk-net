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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// The number of days your data is kept in the hot tier. By default, your data is kept
    /// indefinitely in the hot tier.
    /// </summary>
    public partial class RetentionPeriod
    {
        private int? _numberOfDays;
        private bool? _unlimited;

        /// <summary>
        /// Gets and sets the property NumberOfDays. 
        /// <para>
        /// The number of days that your data is kept.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specified a value for this parameter, the <c>unlimited</c> parameter must be
        /// <c>false</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public int? NumberOfDays
        {
            get { return this._numberOfDays; }
            set { this._numberOfDays = value; }
        }

        // Check to see if NumberOfDays property is set
        internal bool IsSetNumberOfDays()
        {
            return this._numberOfDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If true, your data is kept indefinitely.
        /// </para>
        ///  <note> 
        /// <para>
        /// If configured to <c>true</c>, you must not specify a value for the <c>numberOfDays</c>
        /// parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Unlimited
        {
            get { return this._unlimited; }
            set { this._unlimited = value; }
        }

        // Check to see if Unlimited property is set
        internal bool IsSetUnlimited()
        {
            return this._unlimited.HasValue; 
        }

    }
}