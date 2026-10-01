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
    /// This is the response object from the CreateSourceLocation operation.
    /// </summary>
    public partial class CreateSourceLocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessConfiguration. 
        /// <para>
        /// Access configuration parameters. Configures the type of authentication used to access
        /// content from your source location.
        /// </para>
        /// </summary>
        public AccessConfiguration AccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AccessConfiguration property is set.
        /// </summary>
        internal bool IsSetAccessConfiguration() => this.AccessConfiguration != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN to assign to the source location.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the source location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultSegmentDeliveryConfiguration. 
        /// <para>
        /// The optional configuration for the server that serves segments.
        /// </para>
        /// </summary>
        public DefaultSegmentDeliveryConfiguration DefaultSegmentDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSegmentDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetDefaultSegmentDeliveryConfiguration() => this.DefaultSegmentDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property HttpConfiguration. 
        /// <para>
        /// The source's HTTP package configurations.
        /// </para>
        /// </summary>
        public HttpConfiguration HttpConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HttpConfiguration property is set.
        /// </summary>
        internal bool IsSetHttpConfiguration() => this.HttpConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the source location was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentDeliveryConfigurations. 
        /// <para>
        /// The segment delivery configurations for the source location. For information about
        /// MediaTailor configurations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/configurations.html">Working
        /// with configurations in AWS Elemental MediaTailor</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentDeliveryConfiguration> SegmentDeliveryConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SegmentDeliveryConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SegmentDeliveryConfigurations property is set.
        /// </summary>
        internal bool IsSetSegmentDeliveryConfigurations() => this.SegmentDeliveryConfigurations != null && (this.SegmentDeliveryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name to assign to the source location.
        /// </para>
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the source location. Tags are key-value pairs that you can associate
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
