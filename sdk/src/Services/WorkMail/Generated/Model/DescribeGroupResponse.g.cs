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
    /// This is the response object from the DescribeGroup operation.
    /// </summary>
    public partial class DescribeGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date and time when a user was deregistered from WorkMail, in UNIX epoch time format.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate { get; set; }

        /// <summary>
        /// Checks to see if the DisabledDate property is set.
        /// </summary>
        internal bool IsSetDisabledDate() => this.DisabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the described group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date and time when a user was registered to WorkMail, in UNIX epoch time format.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate { get; set; }

        /// <summary>
        /// Checks to see if the EnabledDate property is set.
        /// </summary>
        internal bool IsSetEnabledDate() => this.EnabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the described group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If the value is set to <i>true</i>, the group is hidden from the address book.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList { get; set; }

        /// <summary>
        /// Checks to see if the HiddenFromGlobalAddressList property is set.
        /// </summary>
        internal bool IsSetHiddenFromGlobalAddressList() => this.HiddenFromGlobalAddressList.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the described group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the user: enabled (registered to WorkMail) or disabled (deregistered
        /// or never registered to WorkMail).
        /// </para>
        /// </summary>
        public EntityState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
