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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the DescribeInstanceAttribute operation.
    /// Describes the specified attribute of the specified instance. You can specify only
    /// one attribute at a time. Valid attribute values are: <code>instanceType</code> | <code>kernel</code>
    /// | <code>ramdisk</code> | <code>userData</code> | <code>disableApiTermination</code>
    /// | <code>instanceInitiatedShutdownBehavior</code> | <code>rootDeviceName</code> | <code>blockDeviceMapping</code>
    /// | <code>productCodes</code> | <code>sourceDestCheck</code> | <code>groupSet</code>
    /// | <code>ebsOptimized</code> | <code>sriovNetSupport</code>
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
        /// <param name="attribute">The instance attribute.</param>
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
        /// </summary>
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