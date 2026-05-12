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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Content of a goal
    /// </summary>
    public partial class GoalContent
    {
        private string _description;
        private string _objectives;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the goal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Objectives. 
        /// <para>
        /// The objectives to be achieved for this goal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Objectives
        {
            get { return this._objectives; }
            set { this._objectives = value; }
        }

        // Check to see if Objectives property is set
        internal bool IsSetObjectives()
        {
            return this._objectives != null;
        }

    }
}