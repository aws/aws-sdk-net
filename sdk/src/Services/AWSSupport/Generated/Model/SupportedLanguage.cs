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
    /// A JSON-formatted object that contains the available ISO 639-1 language <c>code</c>,
    /// <c>language</c> name and langauge <c>display</c> value. The language code is what
    /// should be used in the <a>CreateCase</a> call.
    /// </summary>
    public partial class SupportedLanguage
    {
        private string _code;
        private string _display;
        private string _language;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        ///  2 digit ISO 639-1 code. e.g. <c>en</c> 
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        ///  Language display value e.g. <c>ENGLISH</c> 
        /// </para>
        /// </summary>
        public string Display
        {
            get { return this._display; }
            set { this._display = value; }
        }

        // Check to see if Display property is set
        internal bool IsSetDisplay()
        {
            return this._display != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        ///  Full language description e.g. <c>ENGLISH</c> 
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

    }
}