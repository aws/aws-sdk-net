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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventsourcemapping.html#invocation-eventsourcemapping-provisioned-mode">
    /// provisioned mode</a> configuration for the event source. Use Provisioned Mode to customize
    /// the minimum and maximum number of event pollers for your event source. An event poller
    /// is a compute unit that provides approximately 5 MBps of throughput.
    /// </summary>
    public partial class ProvisionedPollerConfig
    {
        private int? _maximumPollers;
        private int? _minimumPollers;

        /// <summary>
        /// Gets and sets the property MaximumPollers. 
        /// <para>
        /// The maximum number of event pollers this event source can scale up to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public int? MaximumPollers
        {
            get { return this._maximumPollers; }
            set { this._maximumPollers = value; }
        }

        // Check to see if MaximumPollers property is set
        internal bool IsSetMaximumPollers()
        {
            return this._maximumPollers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumPollers. 
        /// <para>
        /// The minimum number of event pollers this event source can scale down to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? MinimumPollers
        {
            get { return this._minimumPollers; }
            set { this._minimumPollers = value; }
        }

        // Check to see if MinimumPollers property is set
        internal bool IsSetMinimumPollers()
        {
            return this._minimumPollers.HasValue; 
        }

    }
}