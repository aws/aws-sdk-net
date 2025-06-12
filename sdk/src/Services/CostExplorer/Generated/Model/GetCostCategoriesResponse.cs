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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetCostCategories operation.
    /// </summary>
    public partial class GetCostCategoriesResponse : AmazonWebServiceResponse
    {
        private List<string> _costCategoryNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _costCategoryValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextPageToken;
        private int? _returnSize;
        private int? _totalSize;

        /// <summary>
        /// Gets and sets the property CostCategoryNames. 
        /// <para>
        /// The names of the Cost Categories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CostCategoryNames
        {
            get { return this._costCategoryNames; }
            set { this._costCategoryNames = value; }
        }

        // Check to see if CostCategoryNames property is set
        internal bool IsSetCostCategoryNames()
        {
            return this._costCategoryNames != null && (this._costCategoryNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CostCategoryValues. 
        /// <para>
        /// The Cost Category values.
        /// </para>
        ///  
        /// <para>
        /// If the <c>CostCategoryName</c> key isn't specified in the request, the <c>CostCategoryValues</c>
        /// fields aren't returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CostCategoryValues
        {
            get { return this._costCategoryValues; }
            set { this._costCategoryValues = value; }
        }

        // Check to see if CostCategoryValues property is set
        internal bool IsSetCostCategoryValues()
        {
            return this._costCategoryValues != null && (this._costCategoryValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If the number of objects that are still available for retrieval exceeds the quota,
        /// Amazon Web Services returns a NextPageToken value in the response. To retrieve the
        /// next batch of objects, provide the marker from the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnSize. 
        /// <para>
        /// The number of objects that are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReturnSize
        {
            get { return this._returnSize; }
            set { this._returnSize = value; }
        }

        // Check to see if ReturnSize property is set
        internal bool IsSetReturnSize()
        {
            return this._returnSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSize. 
        /// <para>
        /// The total number of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalSize
        {
            get { return this._totalSize; }
            set { this._totalSize = value; }
        }

        // Check to see if TotalSize property is set
        internal bool IsSetTotalSize()
        {
            return this._totalSize.HasValue; 
        }

    }
}