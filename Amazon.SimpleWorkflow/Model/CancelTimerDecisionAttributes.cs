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
    /// <para> Provides details of the <c>CancelTimer</c> decision. </para>
    /// </summary>
    public class CancelTimerDecisionAttributes  
    {
        
        private string timerId;

        /// <summary>
        /// The unique Id of the timer to cancel. This field is required.
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
        public CancelTimerDecisionAttributes WithTimerId(string timerId)
        {
            this.timerId = timerId;
            return this;
        }
            

        // Check to see if TimerId property is set
        internal bool IsSetTimerId()
        {
            return this.timerId != null;       
        }
    }
}
