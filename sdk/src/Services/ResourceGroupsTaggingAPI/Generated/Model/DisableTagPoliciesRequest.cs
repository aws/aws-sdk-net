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
    /// Container for the parameters to the DisableTagPolicies operation.
    /// Disables tag policies for your organization and deletes all tag policies.
    /// 
    ///  
    /// <para>
    /// You can call this operation from the organization's master account only and from the
    /// us-east-1 Region only. 
    /// </para>
    ///  <important> 
    /// <para>
    /// Use caution when disabling tag policies, as this is a destructive operation that applies
    /// to your entire organization. You cannot undo this operation.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DisableTagPoliciesRequest : AmazonResourceGroupsTaggingAPIRequest
    {

    }
}