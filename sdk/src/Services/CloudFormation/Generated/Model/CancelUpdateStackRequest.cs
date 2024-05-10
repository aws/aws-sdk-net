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
    /// Container for the parameters to the CancelUpdateStack operation.
    /// Cancels an update on the specified stack. If the call completes successfully, the
    /// stack rolls back the update and reverts to the previous stack configuration.
    /// 
    ///  <note> 
    /// <para>
    /// You can cancel only stacks that are in the <c>UPDATE_IN_PROGRESS</c> state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CancelUpdateStackRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>CancelUpdateStack</c> request. Specify this token
        /// if you plan to retry requests so that CloudFormation knows that you're not attempting
        /// to cancel an update on a stack with the same name. You might retry <c>CancelUpdateStack</c>
        /// requests to ensure that CloudFormation successfully received them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. <note> 
        /// <para>
        /// If you don't pass a parameter to <c>StackName</c>, the API returns a response that
        /// describes all resources in the account.
        /// </para>
        ///  
        /// <para>
        /// The IAM policy below can be added to IAM policies when you want to limit resource-level
        /// permissions and avoid returning a response when no parameter is sent in the request:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "Version": "2012-10-17", "Statement": [{ "Effect": "Deny", "Action": "cloudformation:DescribeStacks",
        /// "NotResource": "arn:aws:cloudformation:*:*:stack/*/*" }] }</c> 
        /// </para>
        ///  </note> 
        /// <para>
        /// The name or the unique stack ID that's associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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