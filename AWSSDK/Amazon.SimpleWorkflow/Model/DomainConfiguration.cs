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
    /// <para> Contains the configuration settings of a domain. </para>
    /// </summary>
    public class DomainConfiguration
    {
        
        private string workflowExecutionRetentionPeriodInDays;

        /// <summary>
        /// The retention period for workflow executions in this domain.
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
        public string WorkflowExecutionRetentionPeriodInDays
        {
            get { return this.workflowExecutionRetentionPeriodInDays; }
            set { this.workflowExecutionRetentionPeriodInDays = value; }
        }

        /// <summary>
        /// Sets the WorkflowExecutionRetentionPeriodInDays property
        /// </summary>
        /// <param name="workflowExecutionRetentionPeriodInDays">The value to set for the WorkflowExecutionRetentionPeriodInDays property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainConfiguration WithWorkflowExecutionRetentionPeriodInDays(string workflowExecutionRetentionPeriodInDays)
        {
            this.workflowExecutionRetentionPeriodInDays = workflowExecutionRetentionPeriodInDays;
            return this;
        }
            

        // Check to see if WorkflowExecutionRetentionPeriodInDays property is set
        internal bool IsSetWorkflowExecutionRetentionPeriodInDays()
        {
            return this.workflowExecutionRetentionPeriodInDays != null;
        }
    }
}
