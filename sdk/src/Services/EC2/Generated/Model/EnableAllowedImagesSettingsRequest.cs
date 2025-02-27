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
    /// Container for the parameters to the EnableAllowedImagesSettings operation.
    /// Enables Allowed AMIs for your account in the specified Amazon Web Services Region.
    /// Two values are accepted:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>enabled</c>: The image criteria in your Allowed AMIs settings are applied. As
    /// a result, only AMIs matching these criteria are discoverable and can be used by your
    /// account to launch instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>audit-mode</c>: The image criteria in your Allowed AMIs settings are not applied.
    /// No restrictions are placed on AMI discoverability or usage. Users in your account
    /// can launch instances using any public AMI or AMI shared with your account.
    /// </para>
    ///  
    /// <para>
    /// The purpose of <c>audit-mode</c> is to indicate which AMIs will be affected when Allowed
    /// AMIs is <c>enabled</c>. In <c>audit-mode</c>, each AMI displays either <c>"ImageAllowed":
    /// true</c> or <c>"ImageAllowed": false</c> to indicate whether the AMI will be discoverable
    /// and available to users in the account when Allowed AMIs is enabled.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The Allowed AMIs feature does not restrict the AMIs owned by your account. Regardless
    /// of the criteria you set, the AMIs created by your account will always be discoverable
    /// and usable by users in your account.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html">Control
    /// the discovery and use of AMIs in Amazon EC2 with Allowed AMIs</a> in <i>Amazon EC2
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableAllowedImagesSettingsRequest : AmazonEC2Request
    {
        private AllowedImagesSettingsEnabledState _allowedImagesSettingsState;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property AllowedImagesSettingsState. 
        /// <para>
        /// Specify <c>enabled</c> to apply the image criteria specified by the Allowed AMIs settings.
        /// Specify <c>audit-mode</c> so that you can check which AMIs will be allowed or not
        /// allowed by the image criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowedImagesSettingsEnabledState AllowedImagesSettingsState
        {
            get { return this._allowedImagesSettingsState; }
            set { this._allowedImagesSettingsState = value; }
        }

        // Check to see if AllowedImagesSettingsState property is set
        internal bool IsSetAllowedImagesSettingsState()
        {
            return this._allowedImagesSettingsState != null;
        }

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

    }
}