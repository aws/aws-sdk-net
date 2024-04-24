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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class S3AccessControlPolicy
    {
        private S3AccessControlList _accessControlList;
        private S3CannedAccessControlList _cannedAccessControlList;

        /// <summary>
        /// Gets and sets the property AccessControlList.
        /// </summary>
        public S3AccessControlList AccessControlList
        {
            get { return this._accessControlList; }
            set { this._accessControlList = value; }
        }

        // Check to see if AccessControlList property is set
        internal bool IsSetAccessControlList()
        {
            return this._accessControlList != null;
        }

        /// <summary>
        /// Gets and sets the property CannedAccessControlList.
        /// </summary>
        public S3CannedAccessControlList CannedAccessControlList
        {
            get { return this._cannedAccessControlList; }
            set { this._cannedAccessControlList = value; }
        }

        // Check to see if CannedAccessControlList property is set
        internal bool IsSetCannedAccessControlList()
        {
            return this._cannedAccessControlList != null;
        }

    }
}