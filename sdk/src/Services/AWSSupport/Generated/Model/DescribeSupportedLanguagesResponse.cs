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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the DescribeSupportedLanguages operation.
    /// </summary>
    public partial class DescribeSupportedLanguagesResponse : AmazonWebServiceResponse
    {
        private List<SupportedLanguage> _supportedLanguages = AWSConfigs.InitializeCollections ? new List<SupportedLanguage>() : null;

        /// <summary>
        /// Gets and sets the property SupportedLanguages. 
        /// <para>
        ///  A JSON-formatted array that contains the available ISO 639-1 language codes. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<SupportedLanguage> SupportedLanguages
        {
            get { return this._supportedLanguages; }
            set { this._supportedLanguages = value; }
        }

        // Check to see if SupportedLanguages property is set
        internal bool IsSetSupportedLanguages()
        {
            return this._supportedLanguages != null && (this._supportedLanguages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}