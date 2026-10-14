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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the BatchDetectSyntax operation.
    /// </summary>
    public partial class BatchDetectSyntaxResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorList. 
        /// <para>
        /// A list containing one object for each document that contained an error. The results
        /// are sorted in ascending order by the <c>Index</c> field and match the order of the
        /// documents in the input list. If there are no errors in the batch, the <c>ErrorList</c>
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchItemError> ErrorList { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchItemError>() : null;

        /// <summary>
        /// Checks to see if the ErrorList property is set.
        /// </summary>
        internal bool IsSetErrorList() => this.ErrorList != null && (this.ErrorList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// A list of objects containing the results of the operation. The results are sorted
        /// in ascending order by the <c>Index</c> field and match the order of the documents
        /// in the input list. If all of the documents contain an error, the <c>ResultList</c>
        /// is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchDetectSyntaxItemResult> ResultList { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchDetectSyntaxItemResult>() : null;

        /// <summary>
        /// Checks to see if the ResultList property is set.
        /// </summary>
        internal bool IsSetResultList() => this.ResultList != null && (this.ResultList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
