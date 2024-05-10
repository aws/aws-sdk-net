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
    /// This is the response object from the DetectToxicContent operation.
    /// </summary>
    public partial class DetectToxicContentResponse : AmazonWebServiceResponse
    {
        private List<ToxicLabels> _resultList = AWSConfigs.InitializeCollections ? new List<ToxicLabels>() : null;

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// Results of the content moderation analysis. Each entry in the results list contains
        /// a list of toxic content types identified in the text, along with a confidence score
        /// for each content type. The results list also includes a toxicity score for each entry
        /// in the results list. 
        /// </para>
        /// </summary>
        public List<ToxicLabels> ResultList
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