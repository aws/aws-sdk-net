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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterInstanceEventNotificationAttributes operation.
    /// Registers a set of tag keys to include in scheduled event notifications for your resources.
    /// 
    /// 
    ///  
    /// <para>
    /// To remove tags, use .
    /// </para>
    /// </summary>
    public partial class RegisterInstanceEventNotificationAttributesRequest : AmazonEC2Request
    {
        private RegisterInstanceTagAttributeRequest _instanceTagAttribute;

        /// <summary>
        /// Gets and sets the property InstanceTagAttribute. 
        /// <para>
        /// Information about the tag keys to register.
        /// </para>
        /// </summary>
        public RegisterInstanceTagAttributeRequest InstanceTagAttribute
        {
            get { return this._instanceTagAttribute; }
            set { this._instanceTagAttribute = value; }
        }

        // Check to see if InstanceTagAttribute property is set
        internal bool IsSetInstanceTagAttribute()
        {
            return this._instanceTagAttribute != null;
        }

    }
}