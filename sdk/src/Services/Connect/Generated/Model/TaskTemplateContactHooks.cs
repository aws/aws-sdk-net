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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The event hooks that are set on tasks created by using this template.
    /// </summary>
    public partial class TaskTemplateContactHooks
    {
        private string _wrapUpFlowId;

        /// <summary>
        /// Gets and sets the property WrapUpFlowId. 
        /// <para>
        /// The identifier of the flow module that runs when an agent attempts to disconnect from
        /// a task created by referencing this template. If no agent ever connects to the task,
        /// the flow module runs when the task is terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string WrapUpFlowId
        {
            get { return this._wrapUpFlowId; }
            set { this._wrapUpFlowId = value; }
        }

        // Check to see if WrapUpFlowId property is set
        internal bool IsSetWrapUpFlowId()
        {
            return this._wrapUpFlowId != null;
        }

    }
}