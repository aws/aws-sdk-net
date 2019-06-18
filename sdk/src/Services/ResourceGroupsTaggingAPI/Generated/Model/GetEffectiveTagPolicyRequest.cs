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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetEffectiveTagPolicy operation.
    /// Returns the contents of the effective tag policy for the AWS account. Depending on
    /// how you use tag policies, the effective tag policy for an account is one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The tag policy attached to the organization that the account belongs to.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The tag policy attached to the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The combination of both policies if tag policies are attached to the organization
    /// root and account.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetEffectiveTagPolicyRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _targetId;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier of the organization root or account whose tag policy you want
        /// returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=68)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

    }
}