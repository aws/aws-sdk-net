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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// A <code>ReplayDestination</code> object that contains details about a replay.
    /// </summary>
    public partial class ReplayDestination
    {
        private string _arn;
        private List<string> _filterArns = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the event bus to replay event to. You can replay events only to the event
        /// bus specified to create the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterArns. 
        /// <para>
        /// A list of ARNs for rules to replay events to.
        /// </para>
        /// </summary>
        public List<string> FilterArns
        {
            get { return this._filterArns; }
            set { this._filterArns = value; }
        }

        // Check to see if FilterArns property is set
        internal bool IsSetFilterArns()
        {
            return this._filterArns != null && this._filterArns.Count > 0; 
        }

    }
}