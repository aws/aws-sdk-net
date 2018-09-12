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
    /// Container for the parameters to the CreateDefaultVpc operation.
    /// Creates a default VPC with a size <code>/16</code> IPv4 CIDR block and a default subnet
    /// in each Availability Zone. For more information about the components of a default
    /// VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html">Default
    /// VPC and Default Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// You cannot specify the components of the default VPC yourself.
    /// 
    ///  
    /// <para>
    /// If you deleted your previous default VPC, you can create a default VPC. You cannot
    /// have more than one default VPC per Region.
    /// </para>
    ///  
    /// <para>
    /// If your account supports EC2-Classic, you cannot use this action to create a default
    /// VPC in a Region that supports EC2-Classic. If you want a default VPC in a Region that
    /// supports EC2-Classic, see "I really want a default VPC for my existing EC2 account.
    /// Is that possible?" in the <a href="http://aws.amazon.com/vpc/faqs/#Default_VPCs">Default
    /// VPCs FAQ</a>.
    /// </para>
    /// </summary>
    public partial class CreateDefaultVpcRequest : AmazonEC2Request
    {

    }
}