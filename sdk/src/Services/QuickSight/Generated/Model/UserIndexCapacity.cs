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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _email;
        private int? _kbCount;
        private string _role;
        private int? _spaceCount;
        private long? _totalCapacityBytes;
        private long? _totalkbCapacityBytes;
        private long? _totalSpaceCapacityBytes;
        private string _userArn;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the user.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property KbCount. 
        /// <para>
        /// The number of knowledge bases owned by the user.
        /// </para>
        /// </summary>
        public int? KbCount
        {
            get { return this._kbCount; }
            set { this._kbCount = value; }
        }

        // Check to see if KbCount property is set
        internal bool IsSetKbCount()
        {
            return this._kbCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the user.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceCount. 
        /// <para>
        /// The number of spaces owned by the user.
        /// </para>
        /// </summary>
        public int? SpaceCount
        {
            get { return this._spaceCount; }
            set { this._spaceCount = value; }
        }

        // Check to see if SpaceCount property is set
        internal bool IsSetSpaceCount()
        {
            return this._spaceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user in bytes.
        /// </para>
        /// </summary>
        public long? TotalCapacityBytes
        {
            get { return this._totalCapacityBytes; }
            set { this._totalCapacityBytes = value; }
        }

        // Check to see if TotalCapacityBytes property is set
        internal bool IsSetTotalCapacityBytes()
        {
            return this._totalCapacityBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalKBCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user's knowledge bases in bytes.
        /// </para>
        /// </summary>
        public long? TotalKBCapacityBytes
        {
            get { return this._totalkbCapacityBytes; }
            set { this._totalkbCapacityBytes = value; }
        }

        // Check to see if TotalKBCapacityBytes property is set
        internal bool IsSetTotalKBCapacityBytes()
        {
            return this._totalkbCapacityBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSpaceCapacityBytes. 
        /// <para>
        /// The total index capacity consumed by the user's spaces in bytes.
        /// </para>
        /// </summary>
        public long? TotalSpaceCapacityBytes
        {
            get { return this._totalSpaceCapacityBytes; }
            set { this._totalSpaceCapacityBytes = value; }
        }

        // Check to see if TotalSpaceCapacityBytes property is set
        internal bool IsSetTotalSpaceCapacityBytes()
        {
            return this._totalSpaceCapacityBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of the user.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of the user.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}