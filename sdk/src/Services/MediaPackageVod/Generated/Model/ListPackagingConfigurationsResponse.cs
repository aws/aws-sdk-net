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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
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
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// This is the response object from the ListPackagingConfigurations operation.
    /// </summary>
    public partial class ListPackagingConfigurationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PackagingConfiguration> _packagingConfigurations = AWSConfigs.InitializeCollections ? new List<PackagingConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. A token that can be used to resume pagination
        /// from the end of the collection.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PackagingConfigurations. A list of MediaPackage VOD PackagingConfiguration
        /// resources.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PackagingConfiguration> PackagingConfigurations
        {
            get { return this._packagingConfigurations; }
            set { this._packagingConfigurations = value; }
        }

        // Check to see if PackagingConfigurations property is set
        internal bool IsSetPackagingConfigurations()
        {
            return this._packagingConfigurations != null && (this._packagingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}