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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container that specifies replication metrics-related settings.
    /// </summary>
    public partial class Metrics
    {
        private ReplicationTimeValue _eventThreshold;
        private MetricsStatus _status;

        /// <summary>
        /// Gets and sets the property EventThreshold. 
        /// <para>
        /// A container that specifies the time threshold for emitting the <code>s3:Replication:OperationMissedThreshold</code>
        /// event. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationTimeValue EventThreshold
        {
            get { return this._eventThreshold; }
            set { this._eventThreshold = value; }
        }

        // Check to see if EventThreshold property is set
        internal bool IsSetEventThreshold()
        {
            return this._eventThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether replication metrics are enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}