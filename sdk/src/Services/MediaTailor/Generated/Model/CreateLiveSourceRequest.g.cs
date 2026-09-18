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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLiveSource operation. The live source configuration.
    /// </summary>
    public partial class CreateLiveSourceRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property HttpPackageConfigurations. 
        /// <para>
        /// A list of HTTP package configuration parameters for this live source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HttpPackageConfiguration> HttpPackageConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<HttpPackageConfiguration>() : null;

        /// <summary>
        /// Checks to see if the HttpPackageConfigurations property is set.
        /// </summary>
        internal bool IsSetHttpPackageConfigurations() => this.HttpPackageConfigurations != null && (this.HttpPackageConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LiveSourceName. 
        /// <para>
        /// The name of the live source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LiveSourceName { get; set; }

        /// <summary>
        /// Checks to see if the LiveSourceName property is set.
        /// </summary>
        internal bool IsSetLiveSourceName() => this.LiveSourceName != null;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the live source. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
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
