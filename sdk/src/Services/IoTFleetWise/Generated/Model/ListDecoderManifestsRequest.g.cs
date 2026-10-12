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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListDecoderManifests operation. Lists decoder
    /// manifests. <note> <para> This API operation uses pagination. Specify the <c>nextToken</c>
    /// parameter in the request to return more results. </para> </note>
    /// </summary>
    public partial class ListDecoderManifestsRequest : AmazonIoTFleetWiseRequest
    {
        /// <summary>
        /// Gets and sets the property ListResponseScope. 
        /// <para>
        /// When you set the <c>listResponseScope</c> parameter to <c>METADATA_ONLY</c>, the list
        /// response includes: decoder manifest name, Amazon Resource Name (ARN), creation time,
        /// and last modification time.
        /// </para>
        /// </summary>
        public ListResponseScope ListResponseScope { get; set; }

        /// <summary>
        /// Checks to see if the ListResponseScope property is set.
        /// </summary>
        internal bool IsSetListResponseScope() => this.ListResponseScope != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return, between 1 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a vehicle model (model manifest) associated with
        /// the decoder manifest. 
        /// </para>
        /// </summary>
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token for the next set of results.
        /// </para>
        ///  
        /// <para>
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next set of results, reissue the search request and include the returned token. When
        /// all results have been returned, the response does not contain a pagination token value.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
