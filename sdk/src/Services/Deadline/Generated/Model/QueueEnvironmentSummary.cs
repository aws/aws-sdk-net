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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The summary of a queue environment.
    /// </summary>
    public partial class QueueEnvironmentSummary
    {
        private string _name;
        private int? _priority;
        private string _queueEnvironmentId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the queue environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The queue environment's priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueEnvironmentId. 
        /// <para>
        /// The queue environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueEnvironmentId
        {
            get { return this._queueEnvironmentId; }
            set { this._queueEnvironmentId = value; }
        }

        // Check to see if QueueEnvironmentId property is set
        internal bool IsSetQueueEnvironmentId()
        {
            return this._queueEnvironmentId != null;
        }

    }
}