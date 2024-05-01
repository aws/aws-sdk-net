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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessKeyInfo operation.
    /// Returns the account identifier for the specified access key ID.
    /// 
    ///  
    /// <para>
    /// Access keys consist of two parts: an access key ID (for example, <c>AKIAIOSFODNN7EXAMPLE</c>)
    /// and a secret access key (for example, <c>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</c>).
    /// For more information about access keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html">Managing
    /// Access Keys for IAM Users</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you pass an access key ID to this operation, it returns the ID of the Amazon
    /// Web Services account to which the keys belong. Access key IDs beginning with <c>AKIA</c>
    /// are long-term credentials for an IAM user or the Amazon Web Services account root
    /// user. Access key IDs beginning with <c>ASIA</c> are temporary credentials that are
    /// created using STS operations. If the account in the response belongs to you, you can
    /// sign in as the root user and review your root user access keys. Then, you can pull
    /// a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_getting-report.html">credentials
    /// report</a> to learn which IAM user owns the keys. To learn who requested the temporary
    /// credentials for an <c>ASIA</c> access key, view the STS events in your <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">CloudTrail
    /// logs</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation does not indicate the state of the access key. The key might be active,
    /// inactive, or deleted. Active keys might not have permissions to perform an operation.
    /// Providing a deleted access key might return an error that the key doesn't exist.
    /// </para>
    /// </summary>
    public partial class GetAccessKeyInfoRequest : AmazonSecurityTokenServiceRequest
    {
        private string _accessKeyId;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The identifier of an access key.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its regex pattern) a string of characters that can
        /// consist of any upper- or lowercase letter or digit.
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

    }
}