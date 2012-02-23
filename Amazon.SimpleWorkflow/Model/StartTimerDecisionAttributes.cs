/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides details of the <c>StartTimer</c> decision. </para>
    /// </summary>
    public class StartTimerDecisionAttributes  
    {
        
        private string timerId;
        private string control;
        private string startToFireTimeout;

        /// <summary>
        /// The unique Id of the timer. This field is required. The specified string must not start or end with whitespace. It must not contain a
        /// <c>:</c> (colon), <c>/</c> (slash), <c>|</c> (vertical bar), or any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not
        /// contain the literal string "arn".
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
        public StartTimerDecisionAttributes WithTimerId(string timerId)
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
        /// Optional data attached to the event that can be used by the decider in subsequent workflow tasks.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Control
        {
            get { return this.control; }
            set { this.control = value; }
        }

        /// <summary>
        /// Sets the Control property
        /// </summary>
        /// <param name="control">The value to set for the Control property </param>
        /// <returns>this instance</returns>
        public StartTimerDecisionAttributes WithControl(string control)
        {
            this.control = control;
            return this;
        }
            

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this.control != null;       
        }

        /// <summary>
        /// The duration to wait before firing the timer. This field is required. The duration is specified in seconds. The valid values are integers
        /// greater than or equal to 0.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 8</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartToFireTimeout
        {
            get { return this.startToFireTimeout; }
            set { this.startToFireTimeout = value; }
        }

        /// <summary>
        /// Sets the StartToFireTimeout property
        /// </summary>
        /// <param name="startToFireTimeout">The value to set for the StartToFireTimeout property </param>
        /// <returns>this instance</returns>
        public StartTimerDecisionAttributes WithStartToFireTimeout(string startToFireTimeout)
        {
            this.startToFireTimeout = startToFireTimeout;
            return this;
        }
            

        // Check to see if StartToFireTimeout property is set
        internal bool IsSetStartToFireTimeout()
        {
            return this.startToFireTimeout != null;       
        }
    }
}
