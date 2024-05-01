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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information on the current access control policies for the bucket.
    /// </summary>
    public partial class AccessControlList
    {
        private bool? _allowsPublicReadAccess;
        private bool? _allowsPublicWriteAccess;

        /// <summary>
        /// Gets and sets the property AllowsPublicReadAccess. 
        /// <para>
        /// A value that indicates whether public read access for the bucket is enabled through
        /// an Access Control List (ACL).
        /// </para>
        /// </summary>
        public bool? AllowsPublicReadAccess
        {
            get { return this._allowsPublicReadAccess; }
            set { this._allowsPublicReadAccess = value; }
        }

        // Check to see if AllowsPublicReadAccess property is set
        internal bool IsSetAllowsPublicReadAccess()
        {
            return this._allowsPublicReadAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowsPublicWriteAccess. 
        /// <para>
        /// A value that indicates whether public write access for the bucket is enabled through
        /// an Access Control List (ACL).
        /// </para>
        /// </summary>
        public bool? AllowsPublicWriteAccess
        {
            get { return this._allowsPublicWriteAccess; }
            set { this._allowsPublicWriteAccess = value; }
        }

        // Check to see if AllowsPublicWriteAccess property is set
        internal bool IsSetAllowsPublicWriteAccess()
        {
            return this._allowsPublicWriteAccess.HasValue; 
        }

    }
}