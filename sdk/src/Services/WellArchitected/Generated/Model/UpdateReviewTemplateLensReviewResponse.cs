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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the UpdateReviewTemplateLensReview operation.
    /// </summary>
    public partial class UpdateReviewTemplateLensReviewResponse : AmazonWebServiceResponse
    {
        private ReviewTemplateLensReview _lensReview;
        private string _templateArn;

        /// <summary>
        /// Gets and sets the property LensReview. 
        /// <para>
        /// A lens review of a question.
        /// </para>
        /// </summary>
        public ReviewTemplateLensReview LensReview
        {
            get { return this._lensReview; }
            set { this._lensReview = value; }
        }

        // Check to see if LensReview property is set
        internal bool IsSetLensReview()
        {
            return this._lensReview != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=250)]
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

    }
}