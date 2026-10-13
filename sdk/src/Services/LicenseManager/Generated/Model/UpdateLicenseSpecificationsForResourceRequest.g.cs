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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLicenseSpecificationsForResource operation.
    /// Adds or removes the specified license configurations for the specified Amazon Web
    /// Services resource. <para> You can update the license specifications of AMIs, instances,
    /// and hosts. You cannot update the license specifications for launch templates and CloudFormation
    /// templates, as they send license configurations to the operation that creates the resource.
    /// </para>
    /// </summary>
    public partial class UpdateLicenseSpecificationsForResourceRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AddLicenseSpecifications. 
        /// <para>
        /// ARNs of the license configurations to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseSpecification> AddLicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseSpecification>() : null;

        /// <summary>
        /// Checks to see if the AddLicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetAddLicenseSpecifications() => this.AddLicenseSpecifications != null && (this.AddLicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveLicenseSpecifications. 
        /// <para>
        /// ARNs of the license configurations to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseSpecification> RemoveLicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseSpecification>() : null;

        /// <summary>
        /// Checks to see if the RemoveLicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetRemoveLicenseSpecifications() => this.RemoveLicenseSpecifications != null && (this.RemoveLicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
