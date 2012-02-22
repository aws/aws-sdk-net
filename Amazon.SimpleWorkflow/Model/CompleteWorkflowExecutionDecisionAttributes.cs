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
    /// <para> Provides details of the <c>CompleteWorkflowExecution</c> decision. </para>
    /// </summary>
    public class CompleteWorkflowExecutionDecisionAttributes  
    {
        
        private string result;

        /// <summary>
        /// The result of the workflow execution. The form of the result is implementation defined.
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
        public string Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// Sets the Result property
        /// </summary>
        /// <param name="result">The value to set for the Result property </param>
        /// <returns>this instance</returns>
        public CompleteWorkflowExecutionDecisionAttributes WithResult(string result)
        {
            this.result = result;
            return this;
        }
            

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this.result != null;       
        }
    }
}
