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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicyVersion operation. Creates a new version
    /// of the specified IoT policy. To update a policy, create a new policy version. A managed
    /// policy can have up to five versions. If the policy has five versions, you must use
    /// <a>DeletePolicyVersion</a> to delete an existing version before you create a new one.
    /// <para> Optionally, you can set the new version as the policy's default version. The
    /// default version is the operative version (that is, the version that is in effect for
    /// the certificates to which the policy is attached). </para> <para> Requires permission
    /// to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicyVersion</a>
    /// action. </para>
    /// </summary>
    public partial class CreatePolicyVersionRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON document that describes the policy. Minimum length of 1. Maximum length of
        /// 2048, excluding whitespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 404600)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The policy name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property SetAsDefault. 
        /// <para>
        /// Specifies whether the policy version is set as the default. When this parameter is
        /// true, the new policy version becomes the operative version (that is, the version that
        /// is in effect for the certificates to which the policy is attached).
        /// </para>
        /// </summary>
        public bool? SetAsDefault { get; set; }

        /// <summary>
        /// Checks to see if the SetAsDefault property is set.
        /// </summary>
        internal bool IsSetSetAsDefault() => this.SetAsDefault.HasValue;
    }
}
