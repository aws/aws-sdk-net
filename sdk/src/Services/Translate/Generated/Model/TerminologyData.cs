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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The data associated with the custom terminology. For information about the custom
    /// terminology file, see <a href="https://docs.aws.amazon.com/translate/latest/dg/creating-custom-terminology.html">
    /// Creating a Custom Terminology</a>.
    /// </summary>
    public partial class TerminologyData
    {
        private Directionality _directionality;
        private MemoryStream _file;
        private TerminologyDataFormat _format;

        /// <summary>
        /// Gets and sets the property Directionality. 
        /// <para>
        /// The directionality of your terminology resource indicates whether it has one source
        /// language (uni-directional) or multiple (multi-directional).
        /// </para>
        ///  <dl> <dt>UNI</dt> <dd> 
        /// <para>
        /// The terminology resource has one source language (for example, the first column in
        /// a CSV file), and all of its other languages are target languages. 
        /// </para>
        ///  </dd> <dt>MULTI</dt> <dd> 
        /// <para>
        /// Any language in the terminology resource can be the source language or a target language.
        /// A single multi-directional terminology resource can be used for jobs that translate
        /// different language pairs. For example, if the terminology contains English and Spanish
        /// terms, it can be used for jobs that translate English to Spanish and Spanish to English.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// When you create a custom terminology resource without specifying the directionality,
        /// it behaves as uni-directional terminology, although this parameter will have a null
        /// value.
        /// </para>
        /// </summary>
        public Directionality Directionality
        {
            get { return this._directionality; }
            set { this._directionality = value; }
        }

        // Check to see if Directionality property is set
        internal bool IsSetDirectionality()
        {
            return this._directionality != null;
        }

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// The file containing the custom terminology data. Your version of the AWS SDK performs
        /// a Base64-encoding on this field before sending a request to the AWS service. Users
        /// of the SDK should not perform Base64-encoding themselves.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=10485760)]
        public MemoryStream File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The data format of the custom terminology.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TerminologyDataFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

    }
}