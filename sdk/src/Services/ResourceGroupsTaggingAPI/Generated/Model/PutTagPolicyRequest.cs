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
    /// Container for the parameters to the PutTagPolicy operation.
    /// Validates the tag policy and then attaches it to the account or organization root.
    /// This policy determines whether a resource is compliant.
    /// 
    ///  
    /// <para>
    /// Validating the tag policy includes checking that the tag policy document includes
    /// the required components, uses JSON syntax, and has fewer than 5,000 characters (including
    /// spaces). For more information, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies-structure.html">Tag
    /// Policy Structure</a> in the <i>AWS Resource Groups User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// If you later call this operation to attach a tag policy to the same organization root
    /// or account, it overwrites the original call without prompting you to confirm.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can call this operation from the organization's master account only, and from
    /// the us-east-1 Region only. 
    /// </para>
    /// </summary>
    public partial class PutTagPolicyRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _policy;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The tag policy to attach to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=5000)]
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

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The account ID or the root identifier of the organization. If you don't know the root
        /// ID, you can call the AWS Organizations <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_ListRoots.html">ListRoots</a>
        /// API to find it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=68)]
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