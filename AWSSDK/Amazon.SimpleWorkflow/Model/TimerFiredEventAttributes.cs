/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>TimerFired</c> event. </para>
    /// </summary>
    public class TimerFiredEventAttributes
    {
        
        private string timerId;
        private long? startedEventId;

        /// <summary>
        /// The unique Id of the timer that fired.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TimerId
        {
            get { return this.timerId; }
            set { this.timerId = value; }
        }

        /// <summary>
        /// Sets the TimerId property
        /// </summary>
        /// <param name="timerId">The value to set for the TimerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TimerFiredEventAttributes WithTimerId(string timerId)
        {
            this.timerId = timerId;
            return this;
        }
            

        // Check to see if TimerId property is set
        internal bool IsSetTimerId()
        {
            return this.timerId != null;
        }

        /// <summary>
        /// The id of the <c>TimerStarted</c> event that was recorded when this timer was started. This information can be useful for diagnosing
        /// problems by tracing back the chain of events leading up to this event.
        ///  
        /// </summary>
        public long StartedEventId
        {
            get { return this.startedEventId ?? default(long); }
            set { this.startedEventId = value; }
        }

        /// <summary>
        /// Sets the StartedEventId property
        /// </summary>
        /// <param name="startedEventId">The value to set for the StartedEventId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TimerFiredEventAttributes WithStartedEventId(long startedEventId)
        {
            this.startedEventId = startedEventId;
            return this;
        }
            

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this.startedEventId.HasValue;
        }
    }
}
