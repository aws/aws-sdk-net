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
    /// Contains the details of a metric to be retrieved for a contact. Use this object to
    /// specify which contact level metrics you want to include in your GetContactMetrics
    /// request.
    /// </summary>
    public partial class ContactMetricInfo
    {
        private ContactMetricName _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric to retrieve. Supported values are POSITION_IN_QUEUE (returns
        /// the contact's current position in the queue) and ESTIMATED_WAIT_TIME (returns the
        /// predicted wait time in seconds).
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

    }
}