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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the DescribeDirectoryConfigs operation.
    /// </summary>
    public partial class DescribeDirectoryConfigsResponse : AmazonWebServiceResponse
    {
        private List<DirectoryConfig> _directoryConfigs = AWSConfigs.InitializeCollections ? new List<DirectoryConfig>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DirectoryConfigs. 
        /// <para>
        /// Information about the directory configurations. Note that although the response syntax
        /// in this topic includes the account password, this password is not returned in the
        /// actual response. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DirectoryConfig> DirectoryConfigs
        {
            get { return this._directoryConfigs; }
            set { this._directoryConfigs = value; }
        }

        // Check to see if DirectoryConfigs property is set
        internal bool IsSetDirectoryConfigs()
        {
            return this._directoryConfigs != null && (this._directoryConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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