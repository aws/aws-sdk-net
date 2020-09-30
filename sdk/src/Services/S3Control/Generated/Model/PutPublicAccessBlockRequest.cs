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
    /// Container for the parameters to the PutPublicAccessBlock operation.
    /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an AWS account.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
    /// Using Amazon S3 block public access</a>.
    /// 
    ///  
    /// <para>
    /// Related actions include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutPublicAccessBlockRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private PublicAccessBlockConfiguration _publicAccessBlockConfiguration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the AWS account whose <code>PublicAccessBlock</code> configuration
        /// you want to set.
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
        /// Gets and sets the property PublicAccessBlockConfiguration. 
        /// <para>
        /// The <code>PublicAccessBlock</code> configuration that you want to apply to the specified
        /// AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration
        {
            get { return this._publicAccessBlockConfiguration; }
            set { this._publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this._publicAccessBlockConfiguration != null;
        }

    }
}