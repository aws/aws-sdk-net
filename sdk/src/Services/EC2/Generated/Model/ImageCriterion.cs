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
    /// The list of criteria that are evaluated to determine whch AMIs are discoverable and
    /// usable in the account in the specified Amazon Web Services Region. Currently, the
    /// only criteria that can be specified are AMI providers. 
    /// 
    ///  
    /// <para>
    /// Up to 10 <c>imageCriteria</c> objects can be specified, and up to a total of 200 values
    /// for all <c>imageProviders</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html#allowed-amis-json-configuration">JSON
    /// configuration for the Allowed AMIs criteria</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImageCriterion
    {
        private List<string> _imageProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ImageProviders. 
        /// <para>
        /// A list of AMI providers whose AMIs are discoverable and useable in the account. Up
        /// to a total of 200 values can be specified.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  
        /// <para>
        ///  <c>amazon</c>: Allow AMIs created by Amazon Web Services.
        /// </para>
        ///  
        /// <para>
        ///  <c>aws-marketplace</c>: Allow AMIs created by verified providers in the Amazon Web
        /// Services Marketplace.
        /// </para>
        ///  
        /// <para>
        ///  <c>aws-backup-vault</c>: Allow AMIs created by Amazon Web Services Backup. 
        /// </para>
        ///  
        /// <para>
        /// 12-digit account ID: Allow AMIs created by this account. One or more account IDs can
        /// be specified.
        /// </para>
        ///  
        /// <para>
        ///  <c>none</c>: Allow AMIs created by your own account only.
        /// </para>
        /// </summary>
        public List<string> ImageProviders
        {
            get { return this._imageProviders; }
            set { this._imageProviders = value; }
        }

        // Check to see if ImageProviders property is set
        internal bool IsSetImageProviders()
        {
            return this._imageProviders != null && (this._imageProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}