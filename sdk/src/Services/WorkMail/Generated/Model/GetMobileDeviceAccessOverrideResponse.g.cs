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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetMobileDeviceAccessOverride operation.
    /// </summary>
    public partial class GetMobileDeviceAccessOverrideResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date the override was first created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date the description was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Checks to see if the DateModified property is set.
        /// </summary>
        internal bool IsSetDateModified() => this.DateModified.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the override.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device to which the access override applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the override, <c>ALLOW</c> or <c>DENY</c>.
        /// </para>
        /// </summary>
        public MobileDeviceAccessRuleEffect Effect { get; set; }

        /// <summary>
        /// Checks to see if the Effect property is set.
        /// </summary>
        internal bool IsSetEffect() => this.Effect != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The WorkMail user to which the access override applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
