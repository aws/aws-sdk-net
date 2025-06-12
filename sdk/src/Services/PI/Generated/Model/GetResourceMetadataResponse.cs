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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the GetResourceMetadata operation.
    /// </summary>
    public partial class GetResourceMetadataResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, FeatureMetadata> _features = AWSConfigs.InitializeCollections ? new Dictionary<string, FeatureMetadata>() : null;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The metadata for different features. For example, the metadata might indicate that
        /// a feature is turned on or off on a specific DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FeatureMetadata> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique for an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. To use a DB instance
        /// as a data source, specify its <c>DbiResourceId</c> value. For example, specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}