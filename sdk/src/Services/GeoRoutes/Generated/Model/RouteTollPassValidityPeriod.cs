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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Period for which the pass is valid.
    /// </summary>
    public partial class RouteTollPassValidityPeriod
    {
        private RouteTollPassValidityPeriodType _period;
        private int? _periodCount;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// Validity period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RouteTollPassValidityPeriodType Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodCount. 
        /// <para>
        /// Counts for the validity period.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? PeriodCount
        {
            get { return this._periodCount; }
            set { this._periodCount = value; }
        }

        // Check to see if PeriodCount property is set
        internal bool IsSetPeriodCount()
        {
            return this._periodCount.HasValue; 
        }

    }
}