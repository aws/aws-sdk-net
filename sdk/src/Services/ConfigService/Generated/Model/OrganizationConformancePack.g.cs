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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An organization conformance pack that has information about conformance packs that
    /// Config creates in member accounts.
    /// </summary>
    public partial class OrganizationConformancePack
    {
        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <c>ConformancePackInputParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;

        /// <summary>
        /// Checks to see if the ConformancePackInputParameters property is set.
        /// </summary>
        internal bool IsSetConformancePackInputParameters() => this.ConformancePackInputParameters != null && (this.ConformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DeliveryS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3Bucket property is set.
        /// </summary>
        internal bool IsSetDeliveryS3Bucket() => this.DeliveryS3Bucket != null;

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// Any folder structure you want to add to an Amazon S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeliveryS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetDeliveryS3KeyPrefix() => this.DeliveryS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts excluded from organization conformance pack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> ExcludedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedAccounts property is set.
        /// </summary>
        internal bool IsSetExcludedAccounts() => this.ExcludedAccounts != null && (this.ExcludedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// Last time when organization conformation pack was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OrganizationConformancePackArn { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConformancePackArn property is set.
        /// </summary>
        internal bool IsSetOrganizationConformancePackArn() => this.OrganizationConformancePackArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// The name you assign to an organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string OrganizationConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConformancePackName property is set.
        /// </summary>
        internal bool IsSetOrganizationConformancePackName() => this.OrganizationConformancePackName != null;
    }
}
