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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEbsDefaultKmsKeyId operation.
    /// Changes the default customer master key (CMK) that your account uses to encrypt EBS
    /// volumes if you don’t specify a CMK in the API call.
    /// 
    ///  
    /// <para>
    /// Your account has an AWS-managed default CMK that is used for encrypting an EBS volume
    /// when no CMK is specified in the API call that creates the volume. By calling this
    /// API, you can specify a customer-managed CMK to use in place of the AWS-managed default
    /// CMK.
    /// </para>
    ///  
    /// <para>
    /// Note: Deleting or disabling the custom CMK that you have specified to act as your
    /// default CMK will result in instance-launch failures.
    /// </para>
    /// </summary>
    public partial class ModifyEbsDefaultKmsKeyIdRequest : AmazonEC2Request
    {
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An identifier for the AWS Key Management Service (AWS KMS) customer master key (CMK)
        /// to use to encrypt the volume. This parameter is only required if you want to use a
        /// non-default CMK; if this parameter is not specified, the default CMK for EBS is used.
        /// If a <code>KmsKeyId</code> is specified, the <code>Encrypted</code> flag must also
        /// be set. 
        /// </para>
        ///  
        /// <para>
        /// The CMK identifier may be provided in any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <code>arn:aws:kms</code> namespace, followed
        /// by the Region of the CMK, the AWS account ID of the CMK owner, the <code>key</code>
        /// namespace, and then the CMK ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <code>arn:aws:kms</code> namespace,
        /// followed by the Region of the CMK, the AWS account ID of the CMK owner, the <code>alias</code>
        /// namespace, and then the CMK alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

    }
}