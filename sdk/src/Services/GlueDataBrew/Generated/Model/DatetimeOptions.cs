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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents additional options for correct interpretation of datetime parameters used
    /// in the Amazon S3 path of a dataset.
    /// </summary>
    public partial class DatetimeOptions
    {
        private string _format;
        private string _localeCode;
        private string _timezoneOffset;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Required option, that defines the datetime format used for a date parameter in the
        /// Amazon S3 path. Should use only supported datetime specifiers and separation characters,
        /// all literal a-z or A-Z characters should be escaped with single quotes. E.g. "MM.dd.yyyy-'at'-HH:mm".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleCode. 
        /// <para>
        /// Optional value for a non-US locale code, needed for correct interpretation of some
        /// date formats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string LocaleCode
        {
            get { return this._localeCode; }
            set { this._localeCode = value; }
        }

        // Check to see if LocaleCode property is set
        internal bool IsSetLocaleCode()
        {
            return this._localeCode != null;
        }

        /// <summary>
        /// Gets and sets the property TimezoneOffset. 
        /// <para>
        /// Optional value for a timezone offset of the datetime parameter value in the Amazon
        /// S3 path. Shouldn't be used if Format for this parameter includes timezone fields.
        /// If no offset specified, UTC is assumed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public string TimezoneOffset
        {
            get { return this._timezoneOffset; }
            set { this._timezoneOffset = value; }
        }

        // Check to see if TimezoneOffset property is set
        internal bool IsSetTimezoneOffset()
        {
            return this._timezoneOffset != null;
        }

    }
}