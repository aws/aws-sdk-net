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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The timeout configuration for a notebook run in Amazon DataZone.
    /// </summary>
    public partial class TimeoutConfig
    {
        private int? _runTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property RunTimeoutInMinutes. 
        /// <para>
        /// The timeout for the notebook run, in minutes. The minimum value is 60 minutes (1 hour),
        /// the maximum value is 1440 minutes (24 hours), and the default value is 720 minutes
        /// (12 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=1440)]
        public int? RunTimeoutInMinutes
        {
            get { return this._runTimeoutInMinutes; }
            set { this._runTimeoutInMinutes = value; }
        }

        // Check to see if RunTimeoutInMinutes property is set
        internal bool IsSetRunTimeoutInMinutes()
        {
            return this._runTimeoutInMinutes.HasValue; 
        }

    }
}