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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The trigger settings that determine how and when Amazon AppFlow runs the specified
    /// flow.
    /// </summary>
    public partial class TriggerConfig
    {
        /// <summary>
        /// Gets and sets the property TriggerProperties. 
        /// <para>
        ///  Specifies the configuration details of a schedule-triggered flow as defined by the
        /// user. Currently, these settings only apply to the <c>Scheduled</c> trigger type. 
        /// </para>
        /// </summary>
        public TriggerProperties TriggerProperties { get; set; }

        /// <summary>
        /// Checks to see if the TriggerProperties property is set.
        /// </summary>
        internal bool IsSetTriggerProperties() => this.TriggerProperties != null;

        /// <summary>
        /// Gets and sets the property TriggerType. 
        /// <para>
        ///  Specifies the type of flow trigger. This can be <c>OnDemand</c>, <c>Scheduled</c>,
        /// or <c>Event</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerType TriggerType { get; set; }

        /// <summary>
        /// Checks to see if the TriggerType property is set.
        /// </summary>
        internal bool IsSetTriggerType() => this.TriggerType != null;
    }
}
