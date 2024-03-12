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
    /// Container for the parameters to the DisableSnapshotBlockPublicAccess operation.
    /// Disables the <i>block public access for snapshots</i> setting at the account level
    /// for the specified Amazon Web Services Region. After you disable block public access
    /// for snapshots in a Region, users can publicly share snapshots in that Region.
    /// 
    ///  
    /// <para>
    /// If block public access is enabled in <c>block-all-sharing</c> mode, and you disable
    /// block public access, all snapshots that were previously publicly shared are no longer
    /// treated as private and they become publicly accessible again.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/block-public-access-snapshots.html">
    /// Block public access for snapshots</a> in the <i>Amazon EBS User Guide</i> .
    /// </para>
    /// </summary>
    public partial class DisableSnapshotBlockPublicAccessRequest : AmazonEC2Request
    {

    }
}