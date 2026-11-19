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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the GetAllowedImagesSettings operation.
    /// </summary>
    public partial class GetAllowedImagesSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageCriteria. 
        /// <para>
        /// The list of criteria for images that are discoverable and usable in the account in
        /// the specified Amazon Web Services Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageCriterion> ImageCriteria { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageCriterion>() : null;

        /// <summary>
        /// Checks to see if the ImageCriteria property is set.
        /// </summary>
        internal bool IsSetImageCriteria() => this.ImageCriteria != null && (this.ImageCriteria.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the Allowed AMIs settings. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The Allowed AMIs settings is managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The Allowed AMIs settings is managed by a declarative
        /// policy and can't be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Allowed AMIs setting at the account level in the specified
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>disabled</c>: All AMIs are allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>audit-mode</c>: All AMIs are allowed, but the <c>ImageAllowed</c> field is set
        /// to <c>true</c> if the AMI would be allowed with the current list of criteria if allowed
        /// AMIs was enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>enabled</c>: Only AMIs matching the image criteria are discoverable and available
        /// for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
