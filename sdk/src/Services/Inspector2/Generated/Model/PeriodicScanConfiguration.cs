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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Configuration settings for periodic scans that run on a scheduled basis.
    /// </summary>
    public partial class PeriodicScanConfiguration
    {
        private PeriodicScanFrequency _frequency;
        private string _frequencyExpression;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The frequency at which periodic scans are performed (such as weekly or monthly).
        /// </para>
        ///  
        /// <para>
        /// If you don't provide the <c>frequencyExpression</c> Amazon Inspector chooses day for
        /// the scan to run. If you provide the <c>frequencyExpression</c>, the schedule must
        /// match the specified <c>frequency</c>.
        /// </para>
        /// </summary>
        public PeriodicScanFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

        /// <summary>
        /// Gets and sets the property FrequencyExpression. 
        /// <para>
        /// The schedule expression for periodic scans, in cron format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FrequencyExpression
        {
            get { return this._frequencyExpression; }
            set { this._frequencyExpression = value; }
        }

        // Check to see if FrequencyExpression property is set
        internal bool IsSetFrequencyExpression()
        {
            return this._frequencyExpression != null;
        }

    }
}