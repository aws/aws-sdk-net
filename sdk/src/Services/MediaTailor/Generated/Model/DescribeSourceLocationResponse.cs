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
    /// This is the response object from the DescribeSourceLocation operation.
    /// </summary>
    public partial class DescribeSourceLocationResponse : AmazonWebServiceResponse
    {
        private AccessConfiguration _accessConfiguration;
        private string _arn;
        private DateTime? _creationTime;
        private DefaultSegmentDeliveryConfiguration _defaultSegmentDeliveryConfiguration;
        private HttpConfiguration _httpConfiguration;
        private DateTime? _lastModifiedTime;
        private List<SegmentDeliveryConfiguration> _segmentDeliveryConfigurations = AWSConfigs.InitializeCollections ? new List<SegmentDeliveryConfiguration>() : null;
        private string _sourceLocationName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccessConfiguration. 
        /// <para>
        /// The access configuration for the source location.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the source location.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp that indicates when the source location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultSegmentDeliveryConfiguration. 
        /// <para>
        /// The default segment delivery configuration settings.
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
        /// The HTTP package configuration settings for the source location.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp that indicates when the source location was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the source location. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}