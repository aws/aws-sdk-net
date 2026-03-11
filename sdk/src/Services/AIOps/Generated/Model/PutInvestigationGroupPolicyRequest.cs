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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
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
namespace Amazon.AIOps.Model
{
    /// <summary>
    /// Container for the parameters to the PutInvestigationGroupPolicy operation.
    /// Creates an IAM resource policy and assigns it to the specified investigation group.
    /// 
    ///  
    /// <para>
    /// If you create your investigation group with <c>CreateInvestigationGroup</c> and you
    /// want to enable CloudWatch alarms to create investigations and add events to investigations,
    /// you must use this operation to create a policy similar to this example.
    /// </para>
    ///  
    /// <para>
    ///  <c> { "Version": "2008-10-17", "Statement": [ { "Effect": "Allow", "Principal": {
    /// "Service": "aiops.alarms.cloudwatch.amazonaws.com" }, "Action": [ "aiops:CreateInvestigation",
    /// "aiops:CreateInvestigationEvent" ], "Resource": "*", "Condition": { "StringEquals":
    /// { "aws:SourceAccount": "account-id" }, "ArnLike": { "aws:SourceArn": "arn:aws:cloudwatch:region:account-id:alarm:*"
    /// } } } ] } </c> 
    /// </para>
    /// </summary>
    public partial class PutInvestigationGroupPolicyRequest : AmazonAIOpsRequest
    {
        private string _identifier;
        private string _policy;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Specify either the name or the ARN of the investigation group that you want to assign
        /// the policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}