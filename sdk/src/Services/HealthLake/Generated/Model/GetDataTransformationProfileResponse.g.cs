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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// This is the response object from the GetDataTransformationProfile operation.
    /// </summary>
    public partial class GetDataTransformationProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// A description of what changed in this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ChangeDescription { get; set; }

        /// <summary>
        /// Checks to see if the ChangeDescription property is set.
        /// </summary>
        internal bool IsSetChangeDescription() => this.ChangeDescription != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when this version was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileDescription. 
        /// <para>
        /// The description of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ProfileDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProfileDescription property is set.
        /// </summary>
        internal bool IsSetProfileDescription() => this.ProfileDescription != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ProfileMapping. 
        /// <para>
        /// The profile content as a map of file paths to content strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500)]
        public Dictionary<string, string> ProfileMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ProfileMapping property is set.
        /// </summary>
        internal bool IsSetProfileMapping() => this.ProfileMapping != null && (this.ProfileMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFormat SourceFormat { get; set; }

        /// <summary>
        /// Checks to see if the SourceFormat property is set.
        /// </summary>
        internal bool IsSetSourceFormat() => this.SourceFormat != null;

        /// <summary>
        /// Gets and sets the property TargetFormat. 
        /// <para>
        /// The target output format of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetFormat TargetFormat { get; set; }

        /// <summary>
        /// Checks to see if the TargetFormat property is set.
        /// </summary>
        internal bool IsSetTargetFormat() => this.TargetFormat != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the retrieved profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 99)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
