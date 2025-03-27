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
    /// Container for the parameters to the DescribeStacks operation.
    /// Returns the description for the specified stack; if no stack name was specified, then
    /// it returns the description for all the stacks created. For more information about
    /// a stack's event history, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stack-resource-configuration-complete.html">Understand
    /// CloudFormation stack creation events</a> in the <i>CloudFormation User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// If the stack doesn't exist, a <c>ValidationError</c> is returned.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeStacksRequest : AmazonCloudFormationRequest
    {
        private string _nextToken;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string that identifies the next page of stacks that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. <note> 
        /// <para>
        /// If you don't pass a parameter to <c>StackName</c>, the API returns a response that
        /// describes all resources in the account, which can impact performance. This requires
        /// <c>ListStacks</c> and <c>DescribeStacks</c> permissions.
        /// </para>
        ///  
        /// <para>
        /// Consider using the <a>ListStacks</a> API if you're not passing a parameter to <c>StackName</c>.
        /// </para>
        ///  
        /// <para>
        /// The IAM policy below can be added to IAM policies when you want to limit resource-level
        /// permissions and avoid returning a response when no parameter is sent in the request:
        /// </para>
        ///  
        /// <para>
        /// { "Version": "2012-10-17", "Statement": [{ "Effect": "Deny", "Action": "cloudformation:DescribeStacks",
        /// "NotResource": "arn:aws:cloudformation:*:*:stack/*/*" }] }
        /// </para>
        ///  </note> 
        /// <para>
        /// The name or the unique stack ID that's associated with the stack, which aren't always
        /// interchangeable:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Running stacks: You can specify either the stack's name or its unique stack ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted stacks: You must specify the unique stack ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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