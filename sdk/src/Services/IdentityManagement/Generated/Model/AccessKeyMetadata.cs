/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an AWS access key, without its secret key.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>ListAccessKeys</a> operation.
    /// </para>
    /// </summary>
    public partial class AccessKeyMetadata
    {
        private string _accessKeyId;
        private DateTime? _createDate;
        private StatusType _status;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AccessKeyMetadata() { }

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID for this access key.
        /// </para>
        /// </summary>
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the access key was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access key. <code>Active</code> means the key is valid for API calls;
        /// <code>Inactive</code> means it is not.
        /// </para>
        /// </summary>
        public StatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user that the key is associated with.
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