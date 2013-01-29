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
    /// <para> Provides details of the <c>WorkflowExecutionSignaled</c> event. </para>
    /// </summary>
    public class WorkflowExecutionSignaledEventAttributes
    {
        
        private string signalName;
        private string input;
        private WorkflowExecution externalWorkflowExecution;
        private long? externalInitiatedEventId;

        /// <summary>
        /// The name of the signal received. The decider can use the signal name and inputs to determine how to the process the signal.
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
        public string SignalName
        {
            get { return this.signalName; }
            set { this.signalName = value; }
        }

        /// <summary>
        /// Sets the SignalName property
        /// </summary>
        /// <param name="signalName">The value to set for the SignalName property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionSignaledEventAttributes WithSignalName(string signalName)
        {
            this.signalName = signalName;
            return this;
        }
            

        // Check to see if SignalName property is set
        internal bool IsSetSignalName()
        {
            return this.signalName != null;
        }

        /// <summary>
        /// Inputs provided with the signal (if any). The decider can use the signal name and inputs to determine how to process the signal.
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
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        /// <summary>
        /// Sets the Input property
        /// </summary>
        /// <param name="input">The value to set for the Input property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionSignaledEventAttributes WithInput(string input)
        {
            this.input = input;
            return this;
        }
            

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }

        /// <summary>
        /// The workflow execution that sent the signal. This is set only of the signal was sent by another workflow execution.
        ///  
        /// </summary>
        public WorkflowExecution ExternalWorkflowExecution
        {
            get { return this.externalWorkflowExecution; }
            set { this.externalWorkflowExecution = value; }
        }

        /// <summary>
        /// Sets the ExternalWorkflowExecution property
        /// </summary>
        /// <param name="externalWorkflowExecution">The value to set for the ExternalWorkflowExecution property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionSignaledEventAttributes WithExternalWorkflowExecution(WorkflowExecution externalWorkflowExecution)
        {
            this.externalWorkflowExecution = externalWorkflowExecution;
            return this;
        }
            

        // Check to see if ExternalWorkflowExecution property is set
        internal bool IsSetExternalWorkflowExecution()
        {
            return this.externalWorkflowExecution != null;
        }

        /// <summary>
        /// The id of the <c>SignalExternalWorkflowExecutionInitiated</c> event corresponding to the <c>SignalExternalWorkflow</c> decision to signal
        /// this workflow execution.The source event with this Id can be found in the history of the source workflow execution. This information can be
        /// useful for diagnosing problems by tracing back the chain of events leading up to this event. This field is set only if the signal was
        /// initiated by another workflow execution.
        ///  
        /// </summary>
        public long ExternalInitiatedEventId
        {
            get { return this.externalInitiatedEventId ?? default(long); }
            set { this.externalInitiatedEventId = value; }
        }

        /// <summary>
        /// Sets the ExternalInitiatedEventId property
        /// </summary>
        /// <param name="externalInitiatedEventId">The value to set for the ExternalInitiatedEventId property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionSignaledEventAttributes WithExternalInitiatedEventId(long externalInitiatedEventId)
        {
            this.externalInitiatedEventId = externalInitiatedEventId;
            return this;
        }
            

        // Check to see if ExternalInitiatedEventId property is set
        internal bool IsSetExternalInitiatedEventId()
        {
            return this.externalInitiatedEventId.HasValue;
        }
    }
}
