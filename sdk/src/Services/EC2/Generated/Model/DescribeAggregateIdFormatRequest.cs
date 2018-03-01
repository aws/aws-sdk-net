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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAggregateIdFormat operation.
    /// Describes the longer ID format settings for all resource types in a specific region.
    /// This request is useful for performing a quick audit to determine whether a specific
    /// region is fully opted in for longer IDs (17-character IDs).
    /// 
    ///  
    /// <para>
    /// This request only returns information about resource types that support longer IDs.
    /// </para>
    ///  
    /// <para>
    /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
    /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
    /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
    /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
    /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
    /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
    /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
    /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
    /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
    /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
    /// | <code>vpn-gateway</code>.
    /// </para>
    /// </summary>
    public partial class DescribeAggregateIdFormatRequest : AmazonEC2Request
    {

    }
}