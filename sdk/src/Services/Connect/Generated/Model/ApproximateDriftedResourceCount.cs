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
    /// Contains an approximate count of the resources of a given type that are not yet in
    /// sync in a Region, along with the time the count was last calculated.
    /// </summary>
    public partial class ApproximateDriftedResourceCount
    {
        private long? _count;
        private string _region;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The approximate number of resources of the requested type that are not yet in sync
        /// in the Region. A value of zero means the resources are in sync.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that the count applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=31)]
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

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time, in Unix epoch time, when the count was last calculated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}