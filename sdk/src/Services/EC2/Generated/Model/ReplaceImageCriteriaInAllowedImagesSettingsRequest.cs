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
    /// Container for the parameters to the ReplaceImageCriteriaInAllowedImagesSettings operation.
    /// Sets or replaces the criteria for Allowed AMIs.
    /// 
    ///  <note> 
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
    public partial class ReplaceImageCriteriaInAllowedImagesSettingsRequest : AmazonEC2Request
    {
        private List<ImageCriterionRequest> _imageCriteria = AWSConfigs.InitializeCollections ? new List<ImageCriterionRequest>() : null;

        /// <summary>
        /// Gets and sets the property ImageCriteria. 
        /// <para>
        /// The list of criteria that are evaluated to determine whether AMIs are discoverable
        /// and usable in the account in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        public List<ImageCriterionRequest> ImageCriteria
        {
            get { return this._imageCriteria; }
            set { this._imageCriteria = value; }
        }

        // Check to see if ImageCriteria property is set
        internal bool IsSetImageCriteria()
        {
            return this._imageCriteria != null && (this._imageCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}