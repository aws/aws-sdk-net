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
    /// Container for the parameters to the EnableEbsEncryptionByDefault operation.
    /// Enables default encryption for EBS volumes that are created in your account in the
    /// current region.
    /// 
    ///  
    /// <para>
    /// Once encryption is enabled with this action, EBS volumes that are created in your
    /// account will always be encrypted even if encryption is not specified at launch. This
    /// setting overrides the <i>encrypted</i> setting to <i>true</i> in all API calls that
    /// create EBS volumes in your account. A volume will be encrypted even if you specify
    /// <i>encryption</i> to be <i>false</i> in the API call that creates the volume.
    /// </para>
    ///  
    /// <para>
    /// If you do not specify a customer master key (CMK) in the API call that creates the
    /// EBS volume, then the volume is encrypted to your AWS account's default CMK.
    /// </para>
    ///  
    /// <para>
    /// You can specify a default CMK of your choice using <a>ModifyEbsDefaultKmsKeyId</a>.
    /// </para>
    ///  
    /// <para>
    /// Enabling default encryption for EBS volumes has no effect on existing unencrypted
    /// volumes in your account. Encrypting the data in these requires manual action. You
    /// can either create an encrypted snapshot of an unencrypted volume, or encrypt a copy
    /// of an unencrypted snapshot. Any volume restored from an encrypted snapshot is also
    /// encrypted. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
    /// EBS Snapshots</a>.
    /// </para>
    ///  
    /// <para>
    /// Once EBS encryption by default is enabled, you can no longer launch older-generation
    /// instance types that do not support encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
    /// Instance Types</a>.
    /// </para>
    /// </summary>
    public partial class EnableEbsEncryptionByDefaultRequest : AmazonEC2Request
    {

    }
}