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
    /// Container for the parameters to the EnableTagPolicies operation.
    /// Enables tag policies for your organization. To use tag policies, you must be using
    /// AWS Organizations with all features enabled. 
    /// 
    ///  
    /// <para>
    /// You can call this operation from the organization's master account only and from the
    /// us-east-1 Region only. 
    /// </para>
    ///  
    /// <para>
    /// This operation does the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Enables tag policies for the specified organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calls the <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_EnableAWSServiceAccess.html">EnableAWSServiceAccess</a>
    /// API on your behalf to allow service access with the <code>tagpolicies.tag.amazonaws.com</code>
    /// service principal.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Creates a <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">service-linked
    /// role</a> named <code>AWSServiceRoleForTagPolicies</code>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/ARG/latest/userguide/tag-policies.html">Tag
    /// Policies</a> in the <i>AWS Resource Groups User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class EnableTagPoliciesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _rootId;

        /// <summary>
        /// Gets and sets the property RootId. 
        /// <para>
        /// The root identifier of the organization. If you don't know the root ID, you can call
        /// the AWS Organizations <a href="http://docs.aws.amazon.com/organizations/latest/APIReference/API_ListRoots.html">ListRoots</a>
        /// API to find it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=34)]
        public string RootId
        {
            get { return this._rootId; }
            set { this._rootId = value; }
        }

        // Check to see if RootId property is set
        internal bool IsSetRootId()
        {
            return this._rootId != null;
        }

    }
}