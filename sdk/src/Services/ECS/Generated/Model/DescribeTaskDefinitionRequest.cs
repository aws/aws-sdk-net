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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTaskDefinition operation.
    /// Describes a task definition. You can specify a <code>family</code> and <code>revision</code>
    /// to find information about a specific task definition, or you can simply specify the
    /// family to find the latest <code>ACTIVE</code> revision in that family.
    /// 
    ///  <note> 
    /// <para>
    /// You can only describe <code>INACTIVE</code> task definitions while an active task
    /// or service references them.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeTaskDefinitionRequest : AmazonECSRequest
    {
        private List<string> _include = new List<string>();
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies whether to see the resource tags for the task definition. If <code>TAGS</code>
        /// is specified, the tags are included in the response. If this field is omitted, tags
        /// are not included in the response.
        /// </para>
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && this._include.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> for the latest <code>ACTIVE</code> revision, <code>family</code>
        /// and <code>revision</code> (<code>family:revision</code>) for a specific revision in
        /// the family, or full Amazon Resource Name (ARN) of the task definition to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}