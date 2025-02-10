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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
    /// Container for the parameters to the UpdateTerminationProtection operation.
    /// Updates termination protection for the specified stack. If a user attempts to delete
    /// a stack with termination protection enabled, the operation fails and the stack remains
    /// unchanged. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-protect-stacks.html">Protect
    /// a CloudFormation stack from being deleted</a> in the <i>CloudFormation User Guide</i>.
    /// 
    ///  
    /// <para>
    /// For <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-nested-stacks.html">nested
    /// stacks</a>, termination protection is set on the root stack and can't be changed directly
    /// on the nested stack.
    /// </para>
    /// </summary>
    public partial class UpdateTerminationProtectionRequest : AmazonCloudFormationRequest
    {
        private bool? _enableTerminationProtection;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property EnableTerminationProtection. 
        /// <para>
        /// Whether to enable termination protection on the specified stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableTerminationProtection
        {
            get { return this._enableTerminationProtection; }
            set { this._enableTerminationProtection = value; }
        }

        // Check to see if EnableTerminationProtection property is set
        internal bool IsSetEnableTerminationProtection()
        {
            return this._enableTerminationProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or unique ID of the stack for which you want to set termination protection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}