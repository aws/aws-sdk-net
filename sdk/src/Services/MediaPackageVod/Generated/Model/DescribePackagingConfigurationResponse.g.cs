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

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// This is the response object from the DescribePackagingConfiguration operation.
    /// </summary>
    public partial class DescribePackagingConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The ARN of the PackagingConfiguration.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CmafPackage.
        /// </summary>
        public CmafPackage CmafPackage { get; set; }

        /// <summary>
        /// Checks to see if the CmafPackage property is set.
        /// </summary>
        internal bool IsSetCmafPackage() => this.CmafPackage != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time the PackagingConfiguration was created.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property DashPackage.
        /// </summary>
        public DashPackage DashPackage { get; set; }

        /// <summary>
        /// Checks to see if the DashPackage property is set.
        /// </summary>
        internal bool IsSetDashPackage() => this.DashPackage != null;

        /// <summary>
        /// Gets and sets the property HlsPackage.
        /// </summary>
        public HlsPackage HlsPackage { get; set; }

        /// <summary>
        /// Checks to see if the HlsPackage property is set.
        /// </summary>
        internal bool IsSetHlsPackage() => this.HlsPackage != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the PackagingConfiguration.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MssPackage.
        /// </summary>
        public MssPackage MssPackage { get; set; }

        /// <summary>
        /// Checks to see if the MssPackage property is set.
        /// </summary>
        internal bool IsSetMssPackage() => this.MssPackage != null;

        /// <summary>
        /// Gets and sets the property PackagingGroupId. The ID of a PackagingGroup.
        /// </summary>
        public string PackagingGroupId { get; set; }

        /// <summary>
        /// Checks to see if the PackagingGroupId property is set.
        /// </summary>
        internal bool IsSetPackagingGroupId() => this.PackagingGroupId != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
