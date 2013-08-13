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
    /// <para> Contains details about a workflow type. </para>
    /// </summary>
    public class WorkflowTypeDetail
    {
        
        private WorkflowTypeInfo typeInfo;
        private WorkflowTypeConfiguration configuration;

        /// <summary>
        /// General information about the workflow type. The status of the workflow type (returned in the WorkflowTypeInfo structure) can be one of the
        /// following. <ul> <li> <b>REGISTERED</b>: The type is registered and available. Workers supporting this type should be running. </li> <li>
        /// <b>DEPRECATED</b>: The type was deprecated using <a>DeprecateWorkflowType</a>, but is still in use. You should keep workers supporting this
        /// type running. You cannot create new workflow executions of this type. </li> </ul>
        ///  
        /// </summary>
        public WorkflowTypeInfo TypeInfo
        {
            get { return this.typeInfo; }
            set { this.typeInfo = value; }
        }

        /// <summary>
        /// Sets the TypeInfo property
        /// </summary>
        /// <param name="typeInfo">The value to set for the TypeInfo property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeDetail WithTypeInfo(WorkflowTypeInfo typeInfo)
        {
            this.typeInfo = typeInfo;
            return this;
        }
            

        // Check to see if TypeInfo property is set
        internal bool IsSetTypeInfo()
        {
            return this.typeInfo != null;
        }

        /// <summary>
        /// Configuration settings of the workflow type registered through <a>RegisterWorkflowType</a>
        ///  
        /// </summary>
        public WorkflowTypeConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        /// <summary>
        /// Sets the Configuration property
        /// </summary>
        /// <param name="configuration">The value to set for the Configuration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WorkflowTypeDetail WithConfiguration(WorkflowTypeConfiguration configuration)
        {
            this.configuration = configuration;
            return this;
        }
            

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this.configuration != null;
        }
    }
}
