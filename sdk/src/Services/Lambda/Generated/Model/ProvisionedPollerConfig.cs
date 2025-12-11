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
    /// the minimum and maximum number of event pollers for your event source.
    /// </summary>
    public partial class ProvisionedPollerConfig
    {
        private int? _maximumPollers;
        private int? _minimumPollers;
        private string _pollerGroupName;

        /// <summary>
        /// Gets and sets the property MaximumPollers. 
        /// <para>
        /// The maximum number of event pollers this event source can scale up to. For Amazon
        /// SQS events source mappings, default is 200, and minimum value allowed is 2. For Amazon
        /// MSK and self-managed Apache Kafka event source mappings, default is 200, and minimum
        /// value allowed is 1.
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
        /// The minimum number of event pollers this event source can scale down to. For Amazon
        /// SQS events source mappings, default is 2, and minimum 2 required. For Amazon MSK and
        /// self-managed Apache Kafka event source mappings, default is 1.
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

        /// <summary>
        /// Gets and sets the property PollerGroupName. 
        /// <para>
        /// (Amazon MSK and self-managed Apache Kafka) The name of the provisioned poller group.
        /// Use this option to group multiple ESMs within the event source's VPC to share Event
        /// Poller Unit (EPU) capacity. You can use this option to optimize Provisioned mode costs
        /// for your ESMs. You can group up to 100 ESMs per poller group and aggregate maximum
        /// pollers across all ESMs in a group cannot exceed 2000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string PollerGroupName
        {
            get { return this._pollerGroupName; }
            set { this._pollerGroupName = value; }
        }

        // Check to see if PollerGroupName property is set
        internal bool IsSetPollerGroupName()
        {
            return this._pollerGroupName != null;
        }

    }
}