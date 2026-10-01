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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A summary of a user's index capacity consumption.
    /// </summary>
    public partial class UserIndexCapacity
    {
        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the user.
        /// </para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property KbCount. 
        /// <para>
        /// The number of knowledge bases owned by the user.
        /// </para>
        /// </summary>
        public int? KbCount { get; set; }

        /// <summary>
        /// Checks to see if the KbCount property is set.
        /// </summary>
        internal bool IsSetKbCount() => this.KbCount.HasValue;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the user.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SpaceCount. 
        /// <para>
        /// The number of spaces owned by the user.
        /// </para>
        /// </summary>
        public int? SpaceCount { get; set; }

        /// <summary>
        /// Checks to see if the SpaceCount property is set.
        /// </summary>
        internal bool IsSetSpaceCount() => this.SpaceCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user in bytes.
        /// </para>
        /// </summary>
        public long? TotalCapacityBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalCapacityBytes property is set.
        /// </summary>
        internal bool IsSetTotalCapacityBytes() => this.TotalCapacityBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalKBCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user's knowledge bases in bytes.
        /// </para>
        /// </summary>
        public long? TotalKBCapacityBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalKBCapacityBytes property is set.
        /// </summary>
        internal bool IsSetTotalKBCapacityBytes() => this.TotalKBCapacityBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalSpaceCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user's spaces in bytes.
        /// </para>
        /// </summary>
        public long? TotalSpaceCapacityBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalSpaceCapacityBytes property is set.
        /// </summary>
        internal bool IsSetTotalSpaceCapacityBytes() => this.TotalSpaceCapacityBytes.HasValue;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of the user.
        /// </para>
        /// </summary>
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of the user.
        /// </para>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
