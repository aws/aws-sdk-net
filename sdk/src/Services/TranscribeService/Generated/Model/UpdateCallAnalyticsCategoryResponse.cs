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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the UpdateCallAnalyticsCategory operation.
    /// </summary>
    public partial class UpdateCallAnalyticsCategoryResponse : AmazonWebServiceResponse
    {
        private CategoryProperties _categoryProperties;

        /// <summary>
        /// Gets and sets the property CategoryProperties. 
        /// <para>
        /// The attributes describing the analytics category. You can see information such as
        /// the rules that you've used to update the category and when the category was originally
        /// created.
        /// </para>
        /// </summary>
        public CategoryProperties CategoryProperties
        {
            get { return this._categoryProperties; }
            set { this._categoryProperties = value; }
        }

        // Check to see if CategoryProperties property is set
        internal bool IsSetCategoryProperties()
        {
            return this._categoryProperties != null;
        }

    }
}