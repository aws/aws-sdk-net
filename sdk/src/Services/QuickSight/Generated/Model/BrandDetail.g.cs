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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The details of the brand.
    /// </summary>
    public partial class BrandDetail
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the brand.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BrandId. 
        /// <para>
        /// The ID of the Quick brand.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string BrandId { get; set; }

        /// <summary>
        /// Checks to see if the BrandId property is set.
        /// </summary>
        internal bool IsSetBrandId() => this.BrandId != null;

        /// <summary>
        /// Gets and sets the property BrandStatus. 
        /// <para>
        /// The status of the brand.
        /// </para>
        /// </summary>
        public BrandStatus BrandStatus { get; set; }

        /// <summary>
        /// Checks to see if the BrandStatus property is set.
        /// </summary>
        internal bool IsSetBrandStatus() => this.BrandStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the brand was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors that occurred during the most recent brand operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time the brand was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Logo. 
        /// <para>
        /// The logo details.
        /// </para>
        /// </summary>
        public Logo Logo { get; set; }

        /// <summary>
        /// Checks to see if the Logo property is set.
        /// </summary>
        internal bool IsSetLogo() => this.Logo != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// The status of the version.
        /// </para>
        /// </summary>
        public BrandVersionStatus VersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the VersionStatus property is set.
        /// </summary>
        internal bool IsSetVersionStatus() => this.VersionStatus != null;
    }
}
