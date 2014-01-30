/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ResetInstanceAttribute operation.
    /// <para>Resets an attribute of an instance to its default value. To reset the kernel or RAM disk, the instance must be in a stopped state. To
    /// reset the <c>SourceDestCheck</c> , the instance can be either running or stopped.</para> <para>The <c>SourceDestCheck</c> attribute controls
    /// whether source/destination checking is enabled. The default value is <c>true</c> , which means checking is enabled. This value must be
    /// <c>false</c> for a NAT instance to perform NAT. For more information, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html" >NAT Instances</a> in the <i>Amazon Virtual Private Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class ResetInstanceAttributeRequest : AmazonEC2Request
    {
        private string instanceId;
        private InstanceAttributeName attribute;


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The attribute to reset.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>instanceType, kernel, ramdisk, userData, disableApiTermination, instanceInitiatedShutdownBehavior, rootDeviceName, blockDeviceMapping, productCodes, sourceDestCheck, groupSet, ebsOptimized</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceAttributeName Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

    }
}
    
