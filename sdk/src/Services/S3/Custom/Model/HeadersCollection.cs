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
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class contains the headers for an S3 object.
    /// </summary>
    public sealed class HeadersCollection
    {
        readonly IDictionary<string, string> _values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Gets and sets headers to set for the object.
        /// </summary>
        /// <param name="name">The name of the header</param>
        /// <returns>The value for the header</returns>
        public string this[string name]
        {
            get
            {
                string value;
                if (_values.TryGetValue(name, out value))
                    return value;

                return null;
            }
            set
            {
                if (value != null)
                {
                    _values[name] = value;
                }
                else if (_values.ContainsKey(name))
                {
                    _values.Remove(name);
                }
            }
        }

        /// <summary>
        /// Gets the count of headers.
        /// </summary>
        public int Count
        {
            get { return this._values.Count; }
        }

        /// <summary>
        /// Gets the names of the headers set.
        /// </summary>
        public ICollection<string> Keys
        {
            get { return _values.Keys; }
        }

        /// <summary>
        /// Specifies caching behavior along the request/reply chain.
        ///  
        /// </summary>
        public string CacheControl
        {
            get { return this["Cache-Control"]; }
            set { this["Cache-Control"] = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies presentational information for the object. For more information, see <a
        /// href="https://www.rfc-editor.org/rfc/rfc6266#section-4">https://www.rfc-editor.org/rfc/rfc6266#section-4</a>.
        /// </para>
        /// </summary>
        public string ContentDisposition
        {
            get { return this["Content-Disposition"]; }
            set { this["Content-Disposition"] = value; }
        }

        /// <summary>
        /// <para>
        /// Specifies what content encodings have been applied to the object and thus what decoding
        /// mechanisms must be applied to obtain the media-type referenced by the Content-Type
        /// header field. For more information, see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#field.content-encoding">https://www.rfc-editor.org/rfc/rfc9110.html#field.content-encoding</a>.
        /// </para>
        /// </summary>
        public string ContentEncoding
        {
            get { return this["Content-Encoding"]; }
            set { this["Content-Encoding"] = value; }
        }

        /// <summary>
        /// <para>
        /// Size of the body in bytes. This parameter is useful when the size of the body cannot
        /// be determined automatically. For more information, see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-content-length">https://www.rfc-editor.org/rfc/rfc9110.html#name-content-length</a>.
        /// </para>
        /// </summary>
        public long ContentLength
        {
            get
            {
                string str = this["Content-Length"];
                if (string.IsNullOrEmpty(str))
                    return -1;
                return long.Parse(str, CultureInfo.InvariantCulture);
            }
            set
            {
                this["Content-Length"] = value.ToString(CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// The base64-encoded 128-bit MD5 digest of the message (without the headers) according to RFC 1864. This 
        /// header can be used as a message integrity check to verify that the data is the same data that was originally sent.
        /// </summary>
        public string ContentMD5
        {
            get { return this["Content-MD5"]; }
            set { this["Content-MD5"] = value; }
        }

        /// <summary>
        /// <para>
        /// A standard MIME type describing the format of the contents. For more information,
        /// see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-content-type">https://www.rfc-editor.org/rfc/rfc9110.html#name-content-type</a>.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this["Content-Type"]; }
            set { this["Content-Type"] = value; }
        }

        internal bool IsSetContentType()
        {
            return !string.IsNullOrEmpty(this.ContentType);
        }

        /// <summary>
        /// <para>
        /// The date and time at which the object is no longer cacheable. For more information,
        /// see <a href="https://www.rfc-editor.org/rfc/rfc7234#section-5.3">https://www.rfc-editor.org/rfc/rfc7234#section-5.3</a>.
        /// </para>
        /// </summary>
        /// 
        public DateTime? ExpiresUtc
        {
            get 
            {
                if (this["Expires"] == null)
                    return null;

                return DateTime.Parse(this["Expires"], CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal); 
            }
            set 
            {
                if (value == null)
                    this["Expires"] = null;

                this["Expires"] = value.GetValueOrDefault().ToUniversalTime().ToString(Amazon.Util.AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture); 
            }
        }

        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. Use ExpiresUtc instead.", false)]
        public DateTime? Expires
        {
            get { return ExpiresUtc?.ToLocalTime(); }
            set { ExpiresUtc = value == null ? (DateTime?)null : new DateTime(value.Value.Ticks, DateTimeKind.Utc); }
        }
    }
}
