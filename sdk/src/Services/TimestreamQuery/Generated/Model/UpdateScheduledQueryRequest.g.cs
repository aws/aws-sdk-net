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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateScheduledQuery operation. Update a scheduled
    /// query.
    /// </summary>
    public partial class UpdateScheduledQueryRequest : AmazonTimestreamQueryRequest
    {
        /// <summary>
        /// Gets and sets the property ScheduledQueryArn. 
        /// <para>
        /// ARN of the scheuled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ScheduledQueryArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledQueryArn property is set.
        /// </summary>
        internal bool IsSetScheduledQueryArn() => this.ScheduledQueryArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduledQueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
