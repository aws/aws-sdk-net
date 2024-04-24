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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the CreateRecommendationTemplate operation.
    /// </summary>
    public partial class CreateRecommendationTemplateResponse : AmazonWebServiceResponse
    {
        private RecommendationTemplate _recommendationTemplate;

        /// <summary>
        /// Gets and sets the property RecommendationTemplate. 
        /// <para>
        /// The newly created recommendation template, returned as an object. This object includes
        /// the template's name, format, status, tags, Amazon S3 bucket location, and more.
        /// </para>
        /// </summary>
        public RecommendationTemplate RecommendationTemplate
        {
            get { return this._recommendationTemplate; }
            set { this._recommendationTemplate = value; }
        }

        // Check to see if RecommendationTemplate property is set
        internal bool IsSetRecommendationTemplate()
        {
            return this._recommendationTemplate != null;
        }

    }
}