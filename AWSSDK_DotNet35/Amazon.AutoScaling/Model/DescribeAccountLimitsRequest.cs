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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountLimits operation.
    /// Returns the limits for the Auto Scaling resources currently allowed for your AWS
    /// account. 
    /// 
    ///  
    /// <para>
    /// Your AWS account comes with default limits on resources for Auto Scaling. There is
    /// a default limit of <code>20</code> Auto Scaling groups and <code>100</code> launch
    /// configurations per region.
    /// </para>
    ///  
    /// <para>
    /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
    /// you can go to the <a href="https://aws.amazon.com/support/">Support Center</a> and
    /// place a request to raise the limits.
    /// </para>
    /// </summary>
    public partial class DescribeAccountLimitsRequest : AmazonAutoScalingRequest
    {

    }
}