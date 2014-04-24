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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The <c>AutoScalingNotificationTypes</c> data type.</para>
    /// </summary>
    public partial class DescribeAutoScalingNotificationTypesResult : AmazonWebServiceResponse
    {
        
        private List<string> autoScalingNotificationTypes = new List<string>();


        /// <summary>
        /// Returns a list of all notification types supported by Auto Scaling. They are: <ul> <li><c>autoscaling:EC2_INSTANCE_LAUNCH</c></li>
        /// <li><c>autoscaling:EC2_INSTANCE_LAUNCH_ERROR</c></li> <li><c>autoscaling:EC2_INSTANCE_TERMINATE</c></li>
        /// <li><c>autoscaling:EC2_INSTANCE_TERMINATE_ERROR</c></li> <li><c>autoscaling:TEST_NOTIFICATION</c></li> </ul> <examples>
        /// <queryrequest>https://autoscaling.amazonaws.com/?Version=2011-01-01&amp;Action=DescribeAutoScalingNotificationTypes &amp;AUTHPARAMS
        /// </queryrequest> <queryresponse><DescribeAutoScalingNotificationTypesResponse xmlns="http://autoscaling.amazonaws.com/doc/2011-01-01/">
        /// <DescribeAutoScalingNotificationTypesResult> <AutoScalingNotificationTypes> <member>autoscaling:EC2_INSTANCE_LAUNCH</member>
        /// <member>autoscaling:EC2_INSTANCE_LAUNCH_ERROR</member> <member>autoscaling:EC2_INSTANCE_TERMINATE</member>
        /// <member>autoscaling:EC2_INSTANCE_TERMINATE_ERROR</member> <member>autoscaling:TEST_NOTIFICATION</member> </AutoScalingNotificationTypes>
        /// </DescribeAutoScalingNotificationTypesResult> <ResponseMetadata> <RequestId>42fc6794-bf21-11e2-a1cf-ff3dEXAMPLE</RequestId>
        /// </ResponseMetadata> </DescribeAutoScalingNotificationTypesResponse></queryresponse> </examples>
        ///  
        /// </summary>
        public List<string> AutoScalingNotificationTypes
        {
            get { return this.autoScalingNotificationTypes; }
            set { this.autoScalingNotificationTypes = value; }
        }

        // Check to see if AutoScalingNotificationTypes property is set
        internal bool IsSetAutoScalingNotificationTypes()
        {
            return this.autoScalingNotificationTypes.Count > 0;
        }
    }
}
