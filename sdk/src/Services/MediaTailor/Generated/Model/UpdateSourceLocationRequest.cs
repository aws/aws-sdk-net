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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
    /// Container for the parameters to the UpdateSourceLocation operation.
    /// Updates a source location. A source location is a container for sources. For more
    /// information about source locations, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-source-locations.html">Working
    /// with source locations</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class UpdateSourceLocationRequest : AmazonMediaTailorRequest
    {
        private AccessConfiguration _accessConfiguration;
        private DefaultSegmentDeliveryConfiguration _defaultSegmentDeliveryConfiguration;
        private HttpConfiguration _httpConfiguration;
        private List<SegmentDeliveryConfiguration> _segmentDeliveryConfigurations = AWSConfigs.InitializeCollections ? new List<SegmentDeliveryConfiguration>() : null;
        private string _sourceLocationName;

        /// <summary>
        /// Gets and sets the property AccessConfiguration. 
        /// <para>
        /// Access configuration parameters. Configures the type of authentication used to access
        /// content from your source location.
        /// </para>
        /// </summary>
        public AccessConfiguration AccessConfiguration
        {
            get { return this._accessConfiguration; }
            set { this._accessConfiguration = value; }
        }

        // Check to see if AccessConfiguration property is set
        internal bool IsSetAccessConfiguration()
        {
            return this._accessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultSegmentDeliveryConfiguration. 
        /// <para>
        /// The optional configuration for the host server that serves segments.
        /// </para>
        /// </summary>
        public DefaultSegmentDeliveryConfiguration DefaultSegmentDeliveryConfiguration
        {
            get { return this._defaultSegmentDeliveryConfiguration; }
            set { this._defaultSegmentDeliveryConfiguration = value; }
        }

        // Check to see if DefaultSegmentDeliveryConfiguration property is set
        internal bool IsSetDefaultSegmentDeliveryConfiguration()
        {
            return this._defaultSegmentDeliveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HttpConfiguration. 
        /// <para>
        /// The HTTP configuration for the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HttpConfiguration HttpConfiguration
        {
            get { return this._httpConfiguration; }
            set { this._httpConfiguration = value; }
        }

        // Check to see if HttpConfiguration property is set
        internal bool IsSetHttpConfiguration()
        {
            return this._httpConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDeliveryConfigurations. 
        /// <para>
        /// A list of the segment delivery configurations associated with this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentDeliveryConfiguration> SegmentDeliveryConfigurations
        {
            get { return this._segmentDeliveryConfigurations; }
            set { this._segmentDeliveryConfigurations = value; }
        }

        // Check to see if SegmentDeliveryConfigurations property is set
        internal bool IsSetSegmentDeliveryConfigurations()
        {
            return this._segmentDeliveryConfigurations != null && (this._segmentDeliveryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceLocationName
        {
            get { return this._sourceLocationName; }
            set { this._sourceLocationName = value; }
        }

        // Check to see if SourceLocationName property is set
        internal bool IsSetSourceLocationName()
        {
            return this._sourceLocationName != null;
        }

    }
}