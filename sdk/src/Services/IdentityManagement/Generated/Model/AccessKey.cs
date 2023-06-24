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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about an Amazon Web Services access key.
    /// 
    ///  
    /// <para>
    ///  This data type is used as a response element in the <a>CreateAccessKey</a> and <a>ListAccessKeys</a>
    /// operations. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>SecretAccessKey</code> value is returned only in response to <a>CreateAccessKey</a>.
    /// You can get a secret access key only when you first create an access key; you cannot
    /// recover the secret access key later. If you lose a secret access key, you must create
    /// a new access key.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AccessKey
    {
        private string _accessKeyId;
        private DateTime? _createDate;
        private string _secretAccessKey;
        private StatusType _status;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AccessKey() { }

        /// <summary>
        /// Instantiates AccessKey with the parameterized properties
        /// </summary>
        /// <param name="userName">The name of the IAM user that the access key is associated with.</param>
        /// <param name="accessKeyId">The ID for this access key.</param>
        /// <param name="status">The status of the access key. <code>Active</code> means that the key is valid for API calls, while <code>Inactive</code> means it is not. </param>
        /// <param name="secretAccessKey">The secret key used to sign requests.</param>
        public AccessKey(string userName, string accessKeyId, StatusType status, string secretAccessKey)
        {
            _userName = userName;
            _accessKeyId = accessKeyId;
            _status = status;
            _secretAccessKey = secretAccessKey;
        }

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID for this access key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=128)]
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
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret key used to sign requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access key. <code>Active</code> means that the key is valid for
        /// API calls, while <code>Inactive</code> means it is not. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The name of the IAM user that the access key is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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