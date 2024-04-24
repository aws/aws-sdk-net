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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This structure includes the <c>Timezone</c> parameter, which you can use to specify
    /// your time zone so that the labels that are associated with returned metrics display
    /// the correct time for your time zone. 
    /// 
    ///  
    /// <para>
    /// The <c>Timezone</c> value affects a label only if you have a time-based dynamic expression
    /// in the label. For more information about dynamic expressions in labels, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/graph-dynamic-labels.html">Using
    /// Dynamic Labels</a>.
    /// </para>
    /// </summary>
    public partial class LabelOptions
    {
        private string _timezone;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone to use for metric data return in this operation. The format is <c>+</c>
        /// or <c>-</c> followed by four digits. The first two digits indicate the number of hours
        /// ahead or behind of UTC, and the final two digits are the number of minutes. For example,
        /// +0130 indicates a time zone that is 1 hour and 30 minutes ahead of UTC. The default
        /// is +0000. 
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}