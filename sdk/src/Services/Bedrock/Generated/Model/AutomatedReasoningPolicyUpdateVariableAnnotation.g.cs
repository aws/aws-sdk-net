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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// An annotation for modifying an existing variable in an Automated Reasoning policy.
    /// </summary>
    public partial class AutomatedReasoningPolicyUpdateVariableAnnotation
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description for the variable, replacing the previous description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The current name of the variable to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NewName. 
        /// <para>
        /// The new name for the variable, if you want to rename it. If not provided, the name
        /// remains unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string NewName { get; set; }

        /// <summary>
        /// Checks to see if the NewName property is set.
        /// </summary>
        internal bool IsSetNewName() => this.NewName != null;
    }
}
