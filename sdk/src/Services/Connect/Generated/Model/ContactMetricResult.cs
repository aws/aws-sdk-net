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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the result of a requested metric for the contact. This object is returned
    /// as part of the GetContactMetrics response and includes both the metric name and its
    /// calculated value.
    /// </summary>
    public partial class ContactMetricResult
    {
        private ContactMetricName _name;
        private ContactMetricValue _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric that was retrieved. This corresponds to the metric name specified
        /// in the request, such as POSITION_IN_QUEUE or ESTIMATED_WAIT_TIME.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactMetricName Name
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The calculated value for the requested metric. This object contains the numeric result
        /// based on the contact's current state in the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContactMetricValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}