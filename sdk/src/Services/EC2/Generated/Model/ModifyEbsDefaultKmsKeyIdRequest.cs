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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEbsDefaultKmsKeyId operation.
    /// Changes the default customer master key (CMK) for EBS encryption by default for your
    /// account in this Region.
    /// 
    ///  
    /// <para>
    /// AWS creates a unique AWS managed CMK in each Region for use with encryption by default.
    /// If you change the default CMK to a symmetric customer managed CMK, it is used instead
    /// of the AWS managed CMK. To reset the default CMK to the AWS managed CMK for EBS, use
    /// <a>ResetEbsDefaultKmsKeyId</a>. Amazon EBS does not support asymmetric CMKs.
    /// </para>
    ///  
    /// <para>
    /// If you delete or disable the customer managed CMK that you specified for use with
    /// encryption by default, your instances will fail to launch.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyEbsDefaultKmsKeyIdRequest : AmazonEC2Request
    {
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS Key Management Service (AWS KMS) customer master key (CMK)
        /// to use for Amazon EBS encryption. If this parameter is not specified, your AWS managed
        /// CMK for EBS is used. If <code>KmsKeyId</code> is specified, the encrypted state must
        /// be <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the CMK using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID. For example, 1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias. For example, alias/ExampleAlias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN. For example, arn:aws:kms:us-east-1:012345678910:key/1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN. For example, arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS authenticates the CMK asynchronously. Therefore, if you specify an ID, alias,
        /// or ARN that is not valid, the action can appear to complete, but eventually fails.
        /// </para>
        ///  
        /// <para>
        /// Amazon EBS does not support asymmetric CMKs.
        /// </para>
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