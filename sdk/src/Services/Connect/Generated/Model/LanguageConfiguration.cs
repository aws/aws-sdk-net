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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The language configuration for conversational analytics.
    /// </summary>
    public partial class LanguageConfiguration
    {
        private string _languageLocale;

        /// <summary>
        /// Gets and sets the property LanguageLocale. 
        /// <para>
        /// The language locale setting for conversational analytics.
        /// </para>
        /// </summary>
        public string LanguageLocale
        {
            get { return this._languageLocale; }
            set { this._languageLocale = value; }
        }

        // Check to see if LanguageLocale property is set
        internal bool IsSetLanguageLocale()
        {
            return this._languageLocale != null;
        }

    }
}