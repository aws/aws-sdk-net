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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the BatchDetectDominantLanguage operation.
    /// </summary>
    public partial class BatchDetectDominantLanguageResponse : AmazonWebServiceResponse
    {
        private List<BatchItemError> _errorList = AWSConfigs.InitializeCollections ? new List<BatchItemError>() : null;
        private List<BatchDetectDominantLanguageItemResult> _resultList = AWSConfigs.InitializeCollections ? new List<BatchDetectDominantLanguageItemResult>() : null;

        /// <summary>
        /// Gets and sets the property ErrorList. 
        /// <para>
        /// A list containing one object for each document that contained an error. The results
        /// are sorted in ascending order by the <c>Index</c> field and match the order of the
        /// documents in the input list. If there are no errors in the batch, the <c>ErrorList</c>
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchItemError> ErrorList
        {
            get { return this._errorList; }
            set { this._errorList = value; }
        }

        // Check to see if ErrorList property is set
        internal bool IsSetErrorList()
        {
            return this._errorList != null && (this._errorList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// A list of objects containing the results of the operation. The results are sorted
        /// in ascending order by the <c>Index</c> field and match the order of the documents
        /// in the input list. If all of the documents contain an error, the <c>ResultList</c>
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDetectDominantLanguageItemResult> ResultList
        {
            get { return this._resultList; }
            set { this._resultList = value; }
        }

        // Check to see if ResultList property is set
        internal bool IsSetResultList()
        {
            return this._resultList != null && (this._resultList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}