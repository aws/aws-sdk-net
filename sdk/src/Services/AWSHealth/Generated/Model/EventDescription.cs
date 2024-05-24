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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// The detailed description of the event. Included in the information returned by the
    /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetails.html">DescribeEventDetails</a>
    /// operation.
    /// </summary>
    public partial class EventDescription
    {
        private string _latestDescription;

        /// <summary>
        /// Gets and sets the property LatestDescription. 
        /// <para>
        /// The most recent description of the event.
        /// </para>
        /// </summary>
        public string LatestDescription
        {
            get { return this._latestDescription; }
            set { this._latestDescription = value; }
        }

        // Check to see if LatestDescription property is set
        internal bool IsSetLatestDescription()
        {
            return this._latestDescription != null;
        }

    }
}