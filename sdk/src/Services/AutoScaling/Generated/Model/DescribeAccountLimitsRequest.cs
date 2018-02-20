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
    /// Describes the current Auto Scaling resource limits for your AWS account.
    /// 
    ///  
    /// <para>
    /// For information about requesting an increase in these limits, see <a href="http://docs.aws.amazon.com/autoscaling/latest/userguide/as-account-limits.html">Auto
    /// Scaling Limits</a> in the <i>Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeAccountLimitsRequest : AmazonAutoScalingRequest
    {

    }
}