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
    /// Container for the parameters to the AssociateAccessGrantsIdentityCenter operation.
    /// Associate your S3 Access Grants instance with an Amazon Web Services IAM Identity
    /// Center instance. Use this action if you want to create access grants for users or
    /// groups from your corporate identity directory. First, you must add your corporate
    /// identity directory to Amazon Web Services IAM Identity Center. Then, you can associate
    /// this IAM Identity Center instance with your S3 Access Grants instance.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3:AssociateAccessGrantsIdentityCenter</c> permission to use
    /// this operation. 
    /// </para>
    ///  </dd> <dt>Additional Permissions</dt> <dd> 
    /// <para>
    /// You must also have the following permissions: <c>sso:CreateApplication</c>, <c>sso:PutApplicationGrant</c>,
    /// and <c>sso:PutApplicationAuthenticationMethod</c>. 
    /// </para>
    ///  </dd> </dl> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class AssociateAccessGrantsIdentityCenterRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _identityCenterArn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the S3 Access Grants instance.
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
        /// Gets and sets the property IdentityCenterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services IAM Identity Center instance
        /// that you are associating with your S3 Access Grants instance. An IAM Identity Center
        /// instance is your corporate identity directory that you added to the IAM Identity Center.
        /// You can use the <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListInstances.html">ListInstances</a>
        /// API operation to retrieve a list of your Identity Center instances and their ARNs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string IdentityCenterArn
        {
            get { return this._identityCenterArn; }
            set { this._identityCenterArn = value; }
        }

        // Check to see if IdentityCenterArn property is set
        internal bool IsSetIdentityCenterArn()
        {
            return this._identityCenterArn != null;
        }

    }
}