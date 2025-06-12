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
    /// Container for the parameters to the UpdateVodSource operation.
    /// Updates a VOD source's configuration.
    /// </summary>
    public partial class UpdateVodSourceRequest : AmazonMediaTailorRequest
    {
        private List<HttpPackageConfiguration> _httpPackageConfigurations = AWSConfigs.InitializeCollections ? new List<HttpPackageConfiguration>() : null;
        private string _sourceLocationName;
        private string _vodSourceName;

        /// <summary>
        /// Gets and sets the property HttpPackageConfigurations. 
        /// <para>
        /// A list of HTTP package configurations for the VOD source on this account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HttpPackageConfiguration> HttpPackageConfigurations
        {
            get { return this._httpPackageConfigurations; }
            set { this._httpPackageConfigurations = value; }
        }

        // Check to see if HttpPackageConfigurations property is set
        internal bool IsSetHttpPackageConfigurations()
        {
            return this._httpPackageConfigurations != null && (this._httpPackageConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location associated with this VOD Source.
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

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VodSourceName
        {
            get { return this._vodSourceName; }
            set { this._vodSourceName = value; }
        }

        // Check to see if VodSourceName property is set
        internal bool IsSetVodSourceName()
        {
            return this._vodSourceName != null;
        }

    }
}