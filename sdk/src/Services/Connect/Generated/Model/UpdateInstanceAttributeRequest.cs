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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstanceAttribute operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Updates the value for the specified attribute type.
    /// </para>
    /// </summary>
    public partial class UpdateInstanceAttributeRequest : AmazonConnectRequest
    {
        private InstanceAttributeType _attributeType;
        private string _instanceId;
        private string _value;

        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of attribute.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only allowlisted customers can consume USE_CUSTOM_TTS_VOICES. To access this feature,
        /// contact Amazon Web Services Support for allowlisting.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceAttributeType AttributeType
        {
            get { return this._attributeType; }
            set { this._attributeType = value; }
        }

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this._attributeType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the attribute. Maximum character limit is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}