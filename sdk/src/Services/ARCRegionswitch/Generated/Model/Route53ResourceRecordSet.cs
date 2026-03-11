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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// The Amazon Route 53 record set.
    /// </summary>
    public partial class Route53ResourceRecordSet
    {
        private string _recordSetIdentifier;
        private string _region;

        /// <summary>
        /// Gets and sets the property RecordSetIdentifier. 
        /// <para>
        /// The Amazon Route 53 record set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RecordSetIdentifier
        {
            get { return this._recordSetIdentifier; }
            set { this._recordSetIdentifier = value; }
        }

        // Check to see if RecordSetIdentifier property is set
        internal bool IsSetRecordSetIdentifier()
        {
            return this._recordSetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Route 53 record set Region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}