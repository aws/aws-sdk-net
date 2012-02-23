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

using Amazon.Runtime;
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// The results from the ListWorkflowTypes action.
    /// </summary>
    public class ListWorkflowTypesResult
    {
        private WorkflowTypeInfos workflowTypeInfosValue;

        /// <summary>
        /// Gets and sets the ListWorkflowTypesResult property.
        /// Contains the result of a successful invocation of the ListWorkflowTypes
        /// action.
        /// </summary>
        public WorkflowTypeInfos WorkflowTypeInfos
        {
            get { return this.workflowTypeInfosValue; }
            set { this.workflowTypeInfosValue = value; }
        }
    }
}
    
