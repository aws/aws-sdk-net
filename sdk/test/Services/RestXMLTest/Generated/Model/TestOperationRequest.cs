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
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RestXMLTest.Model
{
    /// <summary>
    /// Container for the parameters to the TestOperation operation.
    /// 
    /// </summary>
    public partial class TestOperationRequest : AmazonRestXMLTestRequest
    {
        private List<string> _contentLanguage = new List<string>();
        private List<string> _contentLanguageEnums = new List<string>();

        /// <summary>
        /// Gets and sets the property ContentLanguage.
        /// </summary>
        public List<string> ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        // Check to see if ContentLanguage property is set
        internal bool IsSetContentLanguage()
        {
            return this._contentLanguage != null && this._contentLanguage.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContentLanguageEnums.
        /// </summary>
        public List<string> ContentLanguageEnums
        {
            get { return this._contentLanguageEnums; }
            set { this._contentLanguageEnums = value; }
        }

        // Check to see if ContentLanguageEnums property is set
        internal bool IsSetContentLanguageEnums()
        {
            return this._contentLanguageEnums != null && this._contentLanguageEnums.Count > 0; 
        }

    }
}