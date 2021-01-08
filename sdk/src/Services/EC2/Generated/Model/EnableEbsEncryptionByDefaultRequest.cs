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
    /// Container for the parameters to the EnableEbsEncryptionByDefault operation.
    /// Enables EBS encryption by default for your account in the current Region.
    /// 
    ///  
    /// <para>
    /// After you enable encryption by default, the EBS volumes that you create are are always
    /// encrypted, either using the default CMK or the CMK that you specified when you created
    /// each volume. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
    /// EBS encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can specify the default CMK for encryption by default using <a>ModifyEbsDefaultKmsKeyId</a>
    /// or <a>ResetEbsDefaultKmsKeyId</a>.
    /// </para>
    ///  
    /// <para>
    /// Enabling encryption by default has no effect on the encryption status of your existing
    /// volumes.
    /// </para>
    ///  
    /// <para>
    /// After you enable encryption by default, you can no longer launch instances using instance
    /// types that do not support encryption. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
    /// instance types</a>.
    /// </para>
    /// </summary>
    public partial class EnableEbsEncryptionByDefaultRequest : AmazonEC2Request
    {

    }
}