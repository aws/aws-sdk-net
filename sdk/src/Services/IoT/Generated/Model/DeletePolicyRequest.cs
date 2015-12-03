/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePolicy operation.
    /// Deletes the specified policy.
    /// 
    ///  
    /// <para>
    /// A policy cannot be deleted if: 
    /// </para>
    ///  
    /// <para>
    ///  - it has non-default versions
    /// </para>
    ///  
    /// <para>
    ///  - it is attached to any certificate
    /// </para>
    ///  
    /// <para>
    /// To delete a policy:
    /// </para>
    ///  
    /// <para>
    ///  - First delete all the non-default versions of the policy using the <a>DeletePolicyVersion</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    ///  - Detach it from any certificate using the <a>DetachPrincipalPolicy</a> API.
    /// </para>
    ///  
    /// <para>
    /// When a policy is deleted, its default version is deleted with it.
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