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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the ListModelVersions operation.
    /// </summary>
    public partial class ListModelVersionsResponse : AmazonWebServiceResponse
    {
        private List<ModelVersionSummary> _modelVersionSummaries = AWSConfigs.InitializeCollections ? new List<ModelVersionSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ModelVersionSummaries. 
        /// <para>
        /// Provides information on the specified model version, including the created time, model
        /// and dataset ARNs, and status.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't supply the <c>ModelName</c> request parameter, or if you supply the name
        /// of a model that doesn't exist, <c>ListModelVersions</c> returns an empty array in
        /// <c>ModelVersionSummaries</c>. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModelVersionSummary> ModelVersionSummaries
        {
            get { return this._modelVersionSummaries; }
            set { this._modelVersionSummaries = value; }
        }

        // Check to see if ModelVersionSummaries property is set
        internal bool IsSetModelVersionSummaries()
        {
            return this._modelVersionSummaries != null && (this._modelVersionSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results exceeds the limit that the response can display, the
        /// response returns an opaque pagination token indicating where to continue the listing
        /// of machine learning model versions. Use this token in the <c>NextToken</c> field in
        /// the request to list the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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