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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScheduledQuery operation.
    /// Update a scheduled query.
    /// </summary>
    public partial class UpdateScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _scheduledQueryArn;
        private ScheduledQueryState _state;

        /// <summary>
        /// Gets and sets the property ScheduledQueryArn. 
        /// <para>
        /// ARN of the scheuled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ScheduledQueryArn
        {
            get { return this._scheduledQueryArn; }
            set { this._scheduledQueryArn = value; }
        }

        // Check to see if ScheduledQueryArn property is set
        internal bool IsSetScheduledQueryArn()
        {
            return this._scheduledQueryArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledQueryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}