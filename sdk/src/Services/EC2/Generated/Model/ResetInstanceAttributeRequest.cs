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
    /// Container for the parameters to the ResetInstanceAttribute operation.
    /// Resets an attribute of an instance to its default value. To reset the <c>kernel</c>
    /// or <c>ramdisk</c>, the instance must be in a stopped state. To reset the <c>sourceDestCheck</c>,
    /// the instance can be either running or stopped.
    /// 
    ///  
    /// <para>
    /// The <c>sourceDestCheck</c> attribute controls whether source/destination checking
    /// is enabled. The default value is <c>true</c>, which means checking is enabled. This
    /// value must be <c>false</c> for a NAT instance to perform NAT. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
    /// instances</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ResetInstanceAttributeRequest : AmazonEC2Request
    {
        private InstanceAttributeName _attribute;
        private bool? _dryRun;
        private string _instanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResetInstanceAttributeRequest() { }

        /// <summary>
        /// Instantiates ResetInstanceAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <param name="attribute">The attribute to reset. <important> You can only reset the following attributes: <c>kernel</c> | <c>ramdisk</c> | <c>sourceDestCheck</c>. </important></param>
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
        ///  <important> 
        /// <para>
        /// You can only reset the following attributes: <c>kernel</c> | <c>ramdisk</c> | <c>sourceDestCheck</c>.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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