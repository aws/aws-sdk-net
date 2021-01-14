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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStorageLensConfiguration operation.
    /// Deletes the Amazon S3 Storage Lens configuration. For more information about S3 Storage
    /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
    /// with Amazon S3 Storage Lens</a> in the <i>Amazon Simple Storage Service Developer
    /// Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// To use this action, you must have permission to perform the <code>s3:DeleteStorageLensConfiguration</code>
    /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
    /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon Simple Storage Service
    /// Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteStorageLensConfigurationRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _configId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the requester.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// The ID of the S3 Storage Lens configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

    }
}