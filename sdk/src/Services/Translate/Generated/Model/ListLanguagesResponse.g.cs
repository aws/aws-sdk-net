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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the ListLanguages operation.
    /// </summary>
    public partial class ListLanguagesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DisplayLanguageCode. 
        /// <para>
        /// The language code passed in with the request.
        /// </para>
        /// </summary>
        public DisplayLanguageCode DisplayLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the DisplayLanguageCode property is set.
        /// </summary>
        internal bool IsSetDisplayLanguageCode() => this.DisplayLanguageCode != null;

        /// <summary>
        /// Gets and sets the property Languages. 
        /// <para>
        /// The list of supported languages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Language> Languages { get; set; } = AWSConfigs.InitializeCollections ? new List<Language>() : null;

        /// <summary>
        /// Checks to see if the Languages property is set.
        /// </summary>
        internal bool IsSetLanguages() => this.Languages != null && (this.Languages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If the response does not include all remaining results, use the NextToken in the
        /// next request to fetch the next group of supported languages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
