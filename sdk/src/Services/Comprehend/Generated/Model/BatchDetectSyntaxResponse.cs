/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the BatchDetectSyntax operation.
    /// </summary>
    public partial class BatchDetectSyntaxResponse : AmazonWebServiceResponse
    {
        private List<BatchItemError> _errorList = new List<BatchItemError>();
        private List<BatchDetectSyntaxItemResult> _resultList = new List<BatchDetectSyntaxItemResult>();

        /// <summary>
        /// Gets and sets the property ErrorList. 
        /// <para>
        /// A list containing one object for each document that contained an error. The results
        /// are sorted in ascending order by the <code>Index</code> field and match the order
        /// of the documents in the input list. If there are no errors in the batch, the <code>ErrorList</code>
        /// is empty.
        /// </para>
        /// </summary>
        public List<BatchItemError> ErrorList
        {
            get { return this._errorList; }
            set { this._errorList = value; }
        }

        // Check to see if ErrorList property is set
        internal bool IsSetErrorList()
        {
            return this._errorList != null && this._errorList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// A list of objects containing the results of the operation. The results are sorted
        /// in ascending order by the <code>Index</code> field and match the order of the documents
        /// in the input list. If all of the documents contain an error, the <code>ResultList</code>
        /// is empty.
        /// </para>
        /// </summary>
        public List<BatchDetectSyntaxItemResult> ResultList
        {
            get { return this._resultList; }
            set { this._resultList = value; }
        }

        // Check to see if ResultList property is set
        internal bool IsSetResultList()
        {
            return this._resultList != null && this._resultList.Count > 0; 
        }

    }
}