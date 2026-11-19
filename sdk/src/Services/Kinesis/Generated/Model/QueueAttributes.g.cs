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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The configuration attributes for a queue.
    /// </summary>
    public partial class QueueAttributes
    {
        /// <summary>
        /// Gets and sets the property DeadLetterConfiguration. 
        /// <para>
        /// The dead-letter handling configuration for the queue. If you omit this attribute,
        /// dead-letter handling is enabled with a <c>MaxReceiveCount</c> of 6. If you specify
        /// it with a <c>TargetType</c> of <c>BUILT_IN</c>, you must also specify <c>MaxReceiveCount</c>.
        /// </para>
        /// </summary>
        public DeadLetterConfiguration DeadLetterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfiguration property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfiguration() => this.DeadLetterConfiguration != null;

        /// <summary>
        /// Gets and sets the property VisibilityTimeoutSeconds. 
        /// <para>
        /// The duration, in seconds, that a record is in flight and not visible to any consumer
        /// instance after it is received. A record that is not acknowledged before this duration
        /// elapses becomes visible in the queue again and can be received by any consumer instance.
        /// If you omit this attribute when you create a queue, the queue uses 30 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 43200)]
        public int? VisibilityTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetVisibilityTimeoutSeconds() => this.VisibilityTimeoutSeconds.HasValue;
    }
}
