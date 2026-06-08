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
    /// A filter for user index capacity queries. Only one filter type can be specified per
    /// request.
    /// </summary>
    public partial class UserIndexCapacityFilter
    {
        private CapacityBytesRangeFilter _totalCapacityBytes;
        private UserNameOrEmailFilter _userNameOrEmail;

        /// <summary>
        /// Gets and sets the property TotalCapacityBytes. 
        /// <para>
        /// Filter users by total capacity range in bytes.
        /// </para>
        /// </summary>
        public CapacityBytesRangeFilter TotalCapacityBytes
        {
            get { return this._totalCapacityBytes; }
            set { this._totalCapacityBytes = value; }
        }

        // Check to see if TotalCapacityBytes property is set
        internal bool IsSetTotalCapacityBytes()
        {
            return this._totalCapacityBytes != null;
        }

        /// <summary>
        /// Gets and sets the property UserNameOrEmail. 
        /// <para>
        /// Filter users by username or email prefix.
        /// </para>
        /// </summary>
        public UserNameOrEmailFilter UserNameOrEmail
        {
            get { return this._userNameOrEmail; }
            set { this._userNameOrEmail = value; }
        }

        // Check to see if UserNameOrEmail property is set
        internal bool IsSetUserNameOrEmail()
        {
            return this._userNameOrEmail != null;
        }

    }
}