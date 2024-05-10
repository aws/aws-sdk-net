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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the SearchImageSets operation.
    /// </summary>
    public partial class SearchImageSetsResponse : AmazonWebServiceResponse
    {
        private List<ImageSetsMetadataSummary> _imageSetsMetadataSummaries = AWSConfigs.InitializeCollections ? new List<ImageSetsMetadataSummary>() : null;
        private string _nextToken;
        private Sort _sort;

        /// <summary>
        /// Gets and sets the property ImageSetsMetadataSummaries. 
        /// <para>
        /// The model containing the image set results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ImageSetsMetadataSummary> ImageSetsMetadataSummaries
        {
            get { return this._imageSetsMetadataSummaries; }
            set { this._imageSetsMetadataSummaries = value; }
        }

        // Check to see if ImageSetsMetadataSummaries property is set
        internal bool IsSetImageSetsMetadataSummaries()
        {
            return this._imageSetsMetadataSummaries != null && (this._imageSetsMetadataSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for pagination results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort order for image set search results.
        /// </para>
        /// </summary>
        public Sort Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

    }
}