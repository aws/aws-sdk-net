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
    /// Describes the current CloudFormation limits for your account.
    /// 
    ///  
    /// <para>
    /// CloudFormation has the following limits per account:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Number of concurrent resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Number of stacks
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Number of stack outputs
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cloudformation-limits.html">Understand
    /// CloudFormation quotas</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccountLimit
    {
        private string _name;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account limit.
        /// </para>
        ///  
        /// <para>
        /// Values: <c>ConcurrentResourcesLimit</c> | <c>StackLimit</c> | <c>StackOutputsLimit</c>
        /// 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value that's associated with the account limit name.
        /// </para>
        /// </summary>
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}