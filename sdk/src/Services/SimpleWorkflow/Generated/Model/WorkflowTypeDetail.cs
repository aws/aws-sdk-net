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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains details about a workflow type.
    /// </summary>
    public partial class WorkflowTypeDetail
    {
        private WorkflowTypeConfiguration _configuration;
        private WorkflowTypeInfo _typeInfo;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration settings of the workflow type registered through <a>RegisterWorkflowType</a>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowTypeConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property TypeInfo. 
        /// <para>
        /// General information about the workflow type.
        /// </para>
        ///  
        /// <para>
        /// The status of the workflow type (returned in the WorkflowTypeInfo structure) can be
        /// one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGISTERED</c> – The type is registered and available. Workers supporting this
        /// type should be running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEPRECATED</c> – The type was deprecated using <a>DeprecateWorkflowType</a>, but
        /// is still in use. You should keep workers supporting this type running. You cannot
        /// create new workflow executions of this type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkflowTypeInfo TypeInfo
        {
            get { return this._typeInfo; }
            set { this._typeInfo = value; }
        }

        // Check to see if TypeInfo property is set
        internal bool IsSetTypeInfo()
        {
            return this._typeInfo != null;
        }

    }
}