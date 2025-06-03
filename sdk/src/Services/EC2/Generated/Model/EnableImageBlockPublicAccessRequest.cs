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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableImageBlockPublicAccess operation.
    /// Enables <i>block public access for AMIs</i> at the account level in the specified
    /// Amazon Web Services Region. This prevents the public sharing of your AMIs. However,
    /// if you already have public AMIs, they will remain publicly available.
    /// 
    ///  
    /// <para>
    /// The API can take up to 10 minutes to configure this setting. During this time, if
    /// you run <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetImageBlockPublicAccessState.html">GetImageBlockPublicAccessState</a>,
    /// the response will be <c>unblocked</c>. When the API has completed the configuration,
    /// the response will be <c>block-new-sharing</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-public-access-to-amis.html">Block
    /// public access to your AMIs</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableImageBlockPublicAccessRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private ImageBlockPublicAccessEnabledState _imageBlockPublicAccessState;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageBlockPublicAccessState. 
        /// <para>
        /// Specify <c>block-new-sharing</c> to enable block public access for AMIs at the account
        /// level in the specified Region. This will block any attempt to publicly share your
        /// AMIs in the specified Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageBlockPublicAccessEnabledState ImageBlockPublicAccessState
        {
            get { return this._imageBlockPublicAccessState; }
            set { this._imageBlockPublicAccessState = value; }
        }

        // Check to see if ImageBlockPublicAccessState property is set
        internal bool IsSetImageBlockPublicAccessState()
        {
            return this._imageBlockPublicAccessState != null;
        }

    }
}