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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// This is the response object from the ListInstalledComponents operation.
    /// </summary>
    public partial class ListInstalledComponentsResponse : AmazonWebServiceResponse
    {
        private List<InstalledComponent> _installedComponents = AWSConfigs.InitializeCollections ? new List<InstalledComponent>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InstalledComponents. 
        /// <para>
        /// A list that summarizes each component on the core device.
        /// </para>
        ///  <note> 
        /// <para>
        /// Greengrass nucleus v2.7.0 or later is required to get an accurate <c>lastStatusChangeTimestamp</c>
        /// response. This response can be inaccurate in earlier Greengrass nucleus versions.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Greengrass nucleus v2.8.0 or later is required to get an accurate <c>lastInstallationSource</c>
        /// and <c>lastReportedTimestamp</c> response. This response can be inaccurate or null
        /// in earlier Greengrass nucleus versions.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstalledComponent> InstalledComponents
        {
            get { return this._installedComponents; }
            set { this._installedComponents = value; }
        }

        // Check to see if InstalledComponents property is set
        internal bool IsSetInstalledComponents()
        {
            return this._installedComponents != null && (this._installedComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
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

    }
}