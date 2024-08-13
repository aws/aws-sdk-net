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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// The fields contained in log events found by a <c>GetLogGroupFields</c> operation,
    /// along with the percentage of queried log events in which each field appears.
    /// </summary>
    public partial class LogGroupField
    {
        private string _name;
        private int? _percent;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a log field.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Percent. 
        /// <para>
        /// The percentage of log events queried that contained the field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Percent
        {
            get { return this._percent; }
            set { this._percent = value; }
        }

        // Check to see if Percent property is set
        internal bool IsSetPercent()
        {
            return this._percent.HasValue; 
        }

    }
}