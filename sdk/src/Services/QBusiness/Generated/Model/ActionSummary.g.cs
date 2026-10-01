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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Summary information for an Amazon Q Business plugin action.
    /// </summary>
    public partial class ActionSummary
    {
        /// <summary>
        /// Gets and sets the property ActionIdentifier. 
        /// <para>
        /// The identifier of an Amazon Q Business plugin action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ActionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ActionIdentifier property is set.
        /// </summary>
        internal bool IsSetActionIdentifier() => this.ActionIdentifier != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of an Amazon Q Business plugin action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name assigned by Amazon Q Business to a plugin action. You can't modify
        /// this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InstructionExample. 
        /// <para>
        /// An Amazon Q Business suggested prompt and end user can use to invoke a plugin action.
        /// This value can be modified and sent as input to initiate an action. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a Jira task
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a chat assistant task to find the root cause of a specific incident
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string InstructionExample { get; set; }

        /// <summary>
        /// Checks to see if the InstructionExample property is set.
        /// </summary>
        internal bool IsSetInstructionExample() => this.InstructionExample != null;
    }
}
