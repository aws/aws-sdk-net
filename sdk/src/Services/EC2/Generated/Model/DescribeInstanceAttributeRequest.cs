/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceAttribute operation.
    /// Describes the specified attribute of the specified instance. You can specify only
    /// one attribute at a time. Valid attribute values are: <c>instanceType</c> | <c>kernel</c>
    /// | <c>ramdisk</c> | <c>userData</c> | <c>disableApiTermination</c> | <c>instanceInitiatedShutdownBehavior</c>
    /// | <c>rootDeviceName</c> | <c>blockDeviceMapping</c> | <c>productCodes</c> | <c>sourceDestCheck</c>
    /// | <c>groupSet</c> | <c>ebsOptimized</c> | <c>sriovNetSupport</c>
    /// </summary>
    public partial class DescribeInstanceAttributeRequest : AmazonEC2Request
    {
        private InstanceAttributeName _attribute;
        private string _instanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeInstanceAttributeRequest() { }

        /// <summary>
        /// Instantiates DescribeInstanceAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="attribute">The instance attribute. Note: The <c>enaSupport</c> attribute is not supported at this time.</param>
        public DescribeInstanceAttributeRequest(string instanceId, InstanceAttributeName attribute)
        {
            _instanceId = instanceId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The instance attribute.
        /// </para>
        ///  
        /// <para>
        /// Note: The <c>enaSupport</c> attribute is not supported at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceAttributeName Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}