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
    /// Container for the parameters to the UpdateServiceSettings operation. Updates License
    /// Manager settings for the current Region.
    /// </summary>
    public partial class UpdateServiceSettingsRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property EnableCrossAccountsDiscovery. 
        /// <para>
        /// Activates cross-account discovery.
        /// </para>
        /// </summary>
        public bool? EnableCrossAccountsDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the EnableCrossAccountsDiscovery property is set.
        /// </summary>
        internal bool IsSetEnableCrossAccountsDiscovery() => this.EnableCrossAccountsDiscovery.HasValue;

        /// <summary>
        /// Gets and sets the property EnabledDiscoverySourceRegions. 
        /// <para>
        /// Cross region discovery enabled source regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledDiscoverySourceRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EnabledDiscoverySourceRegions property is set.
        /// </summary>
        internal bool IsSetEnabledDiscoverySourceRegions() => this.EnabledDiscoverySourceRegions != null && (this.EnabledDiscoverySourceRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        /// Enables integration with Organizations for cross-account discovery.
        /// </para>
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConfiguration property is set.
        /// </summary>
        internal bool IsSetOrganizationConfiguration() => this.OrganizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon S3 bucket where the License Manager information
        /// is stored.
        /// </para>
        /// </summary>
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon SNS topic used for License Manager alerts.
        /// </para>
        /// </summary>
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;
    }
}
