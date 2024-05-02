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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutRegistryPolicy operation.
    /// Creates or updates the permissions policy for your registry.
    /// 
    ///  
    /// <para>
    /// A registry policy is used to specify permissions for another Amazon Web Services account
    /// and is used when configuring cross-account replication. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/registry-permissions.html">Registry
    /// permissions</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutRegistryPolicyRequest : AmazonECRRequest
    {
        private string _policyText;

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The JSON policy text to apply to your registry. The policy text follows the same format
        /// as IAM policy text. For more information, see <a href="https://docs.aws.amazon.com/AmazonECR/latest/userguide/registry-permissions.html">Registry
        /// permissions</a> in the <i>Amazon Elastic Container Registry User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10240)]
        public string PolicyText
        {
            get { return this._policyText; }
            set { this._policyText = value; }
        }

        // Check to see if PolicyText property is set
        internal bool IsSetPolicyText()
        {
            return this._policyText != null;
        }

    }
}