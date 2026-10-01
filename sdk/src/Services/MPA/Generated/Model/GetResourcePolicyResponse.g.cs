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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the GetResourcePolicy operation.
    /// </summary>
    public partial class GetResourcePolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Document that contains the contents for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 400000)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property PolicyVersionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the policy version.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string PolicyVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVersionArn property is set.
        /// </summary>
        internal bool IsSetPolicyVersionArn() => this.PolicyVersionArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
