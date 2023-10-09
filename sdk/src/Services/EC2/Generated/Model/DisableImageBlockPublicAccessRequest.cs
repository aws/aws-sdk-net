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
    /// Container for the parameters to the DisableImageBlockPublicAccess operation.
    /// Disables <i>block public access for AMIs</i> at the account level in the specified
    /// Amazon Web Services Region. This removes the <i>block public access</i> restriction
    /// from your account. With the restriction removed, you can publicly share your AMIs
    /// in the specified Amazon Web Services Region.
    /// 
    ///  
    /// <para>
    /// The API can take up to 10 minutes to configure this setting. During this time, if
    /// you run <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetImageBlockPublicAccessState.html">GetImageBlockPublicAccessState</a>,
    /// the response will be <code>block-new-sharing</code>. When the API has completed the
    /// configuration, the response will be <code>unblocked</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/sharingamis-intro.html#block-public-access-to-amis">Block
    /// public access to your AMIs</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DisableImageBlockPublicAccessRequest : AmazonEC2Request
    {

    }
}