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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the DeletePolicy operation.
    /// Deletes the specified policy.
    /// 
    ///  
    /// <para>
    /// A policy cannot be deleted if it has non-default versions or it is attached to any
    /// certificate.
    /// </para>
    ///  
    /// <para>
    /// To delete a policy, use the <a>DeletePolicyVersion</a> action to delete all non-default
    /// versions of the policy; use the <a>DetachPolicy</a> action to detach the policy from
    /// any certificate; and then use the DeletePolicy action to delete the policy.
    /// </para>
    ///  
    /// <para>
    /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
    /// </para>
    ///  <note> 
    /// <para>
    /// Because of the distributed nature of Amazon Web Services, it can take up to five minutes
    /// after a policy is detached before it's ready to be deleted.
    /// </para>
    ///  </note> 
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeletePolicy</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeletePolicyRequest : AmazonIoTRequest
    {
        private string _policyName;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}