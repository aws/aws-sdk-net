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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the SetAlias operation. Assigns an alias to an existing
    /// stack. An alias is an alternative name for a stack that can be used in place of the
    /// stack name in any CloudFormation API call that accepts the <c>StackName</c> parameter.
    /// This enables you to effectively rename a stack without recreating it. <para> After
    /// setting an alias, both the original stack name and the alias resolve to the same stack.
    /// Setting an alias does not change the stack's ARN, physical resource IDs, or any deployed
    /// resources. </para> <note> <para> Each stack can have at most one alias. To change
    /// a stack's alias, first remove the existing alias using <a>RemoveAlias</a>, then set
    /// a new one. </para> </note>
    /// </summary>
    public partial class SetAliasRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias to assign to the stack. The alias can then be used in place of the stack
        /// name in any API call that accepts <c>StackName</c>.
        /// </para>
        ///  
        /// <para>
        /// The name must be unique within the same account and Region. It cannot match an existing
        /// stack name or another active alias.
        /// </para>
        ///  <note> 
        /// <para>
        /// An alias name can contain only alphanumeric characters (case-sensitive) and hyphens.
        /// It must start with an alphabetic character and can't be longer than 128 characters.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or unique stack ID of the stack to assign an alias to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;
    }
}
