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
    /// Container for the parameters to the DisableEbsEncryptionByDefault operation.
    /// Disables default encryption for EBS volumes that are created in your account in the
    /// current region.
    /// 
    ///  
    /// <para>
    /// Call this API if you have enabled default encryption using <a>EnableEbsEncryptionByDefault</a>
    /// and want to disable default EBS encryption. Once default EBS encryption is disabled,
    /// you can still create an encrypted volume by setting <i>encrypted</i> to <i>true</i>
    /// in the API call that creates the volume. 
    /// </para>
    ///  
    /// <para>
    /// Disabling default EBS encryption will not change the encryption status of any of your
    /// existing volumes.
    /// </para>
    /// </summary>
    public partial class DisableEbsEncryptionByDefaultRequest : AmazonEC2Request
    {

    }
}