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
    /// Container for the parameters to the ResetEbsDefaultKmsKeyId operation.
    /// Resets the account's default customer master key (CMK) to the account's AWS-managed
    /// default CMK. This default CMK is used to encrypt EBS volumes when you have enabled
    /// EBS encryption by default without specifying a CMK in the API call. If you have not
    /// enabled encryption by default, then this CMK is used when you set the <code>Encrypted</code>
    /// parameter to true without specifying a custom CMK in the API call.
    /// 
    ///  
    /// <para>
    /// Call this API if you have modified the default CMK that is used for encrypting your
    /// EBS volume using <a>ModifyEbsDefaultKmsKeyId</a> and you want to reset it to the AWS-managed
    /// default CMK. After resetting, you can continue to provide a CMK of your choice in
    /// the API call that creates the volume. However, if no CMK is specified, your account
    /// will encrypt the volume to the AWS-managed default CMK.
    /// </para>
    /// </summary>
    public partial class ResetEbsDefaultKmsKeyIdRequest : AmazonEC2Request
    {

    }
}