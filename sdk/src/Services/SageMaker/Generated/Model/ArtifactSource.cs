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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A structure describing the source of an artifact.
    /// </summary>
    public partial class ArtifactSource
    {
        private List<ArtifactSourceType> _sourceTypes = AWSConfigs.InitializeCollections ? new List<ArtifactSourceType>() : null;
        private string _sourceUri;

        /// <summary>
        /// Gets and sets the property SourceTypes. 
        /// <para>
        /// A list of source types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ArtifactSourceType> SourceTypes
        {
            get { return this._sourceTypes; }
            set { this._sourceTypes = value; }
        }

        // Check to see if SourceTypes property is set
        internal bool IsSetSourceTypes()
        {
            return this._sourceTypes != null && (this._sourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceUri. 
        /// <para>
        /// The URI of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SourceUri
        {
            get { return this._sourceUri; }
            set { this._sourceUri = value; }
        }

        // Check to see if SourceUri property is set
        internal bool IsSetSourceUri()
        {
            return this._sourceUri != null;
        }

    }
}