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
    /// Container for the parameters to the ResetInstanceAttribute operation.
    /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
    /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>SourceDestCheck</code>,
    /// the instance can be either running or stopped.
    /// 
    ///  
    /// <para>
    /// The <code>SourceDestCheck</code> attribute controls whether source/destination checking
    /// is enabled. The default value is <code>true</code>, which means checking is enabled.
    /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
    /// information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
    /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ResetInstanceAttributeRequest : AmazonEC2Request
    {
        private InstanceAttributeName _attribute;
        private string _instanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResetInstanceAttributeRequest() { }

        /// <summary>
        /// Instantiates ResetInstanceAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="attribute">The attribute to reset.</param>
        public ResetInstanceAttributeRequest(string instanceId, InstanceAttributeName attribute)
        {
            _instanceId = instanceId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute to reset.
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