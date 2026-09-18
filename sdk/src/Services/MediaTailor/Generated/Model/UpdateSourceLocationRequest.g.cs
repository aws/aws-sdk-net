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
    /// Container for the parameters to the UpdateSourceLocation operation. Updates a source
    /// location. A source location is a container for sources. For more information about
    /// source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
    /// with source locations</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class UpdateSourceLocationRequest : AmazonMediaTailorRequest
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
        /// Gets and sets the property DefaultSegmentDeliveryConfiguration. 
        /// <para>
        /// The optional configuration for the host server that serves segments.
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
        /// The HTTP configuration for the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HttpConfiguration HttpConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HttpConfiguration property is set.
        /// </summary>
        internal bool IsSetHttpConfiguration() => this.HttpConfiguration != null;

        /// <summary>
        /// Gets and sets the property SegmentDeliveryConfigurations. 
        /// <para>
        /// A list of the segment delivery configurations associated with this resource.
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
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;
    }
}
