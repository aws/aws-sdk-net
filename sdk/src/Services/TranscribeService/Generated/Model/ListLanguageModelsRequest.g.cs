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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListLanguageModels operation. Provides a list
    /// of custom language models that match the specified criteria. If no criteria are specified,
    /// all custom language models are returned. <para> To get detailed information about
    /// a specific custom language model, use the operation. </para>
    /// </summary>
    public partial class ListLanguageModelsRequest : AmazonTranscribeServiceRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of custom language models to return in each page of results. If
        /// there are fewer results than the value that you specify, only the actual results are
        /// returned. If you do not specify a value, a default of 5 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Returns only the custom language models that contain the specified string. The search
        /// is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your <c>ListLanguageModels</c> request returns more results than can be displayed,
        /// <c>NextToken</c> is displayed in the response with an associated string. To get the
        /// next page of results, copy this string and repeat your request, including <c>NextToken</c>
        /// with the value of the copied string. Repeat as needed to view all your results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// Returns only custom language models with the specified status. Language models are
        /// ordered by creation date, with the newest model first. If you do not include <c>StatusEquals</c>,
        /// all custom language models are returned.
        /// </para>
        /// </summary>
        public ModelStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
