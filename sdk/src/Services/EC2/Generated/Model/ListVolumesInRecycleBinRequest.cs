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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ListVolumesInRecycleBin operation.
    /// Lists one or more volumes that are currently in the Recycle Bin.
    /// </summary>
    public partial class ListVolumesInRecycleBinRequest : AmazonEC2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid range: 5 - 500
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// The IDs of the volumes to list. Omit this parameter to list all of the volumes that
        /// are in the Recycle Bin.
        /// </para>
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this._volumeIds; }
            set { this._volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this._volumeIds != null && (this._volumeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}