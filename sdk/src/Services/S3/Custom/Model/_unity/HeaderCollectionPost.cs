/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// This class contains browser post supported headers for an S3 object.
    /// </summary>
    public sealed class HeadersCollectionPost
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
        /// </summary>
        public string CacheControl
        {
            get { return this["Cache-Control"]; }
            set { this["Cache-Control"] = value; }
        }

        /// <summary>
        /// Specifies presentational information for the object.
        /// </summary>
        public string ContentDisposition
        {
            get { return this["Content-Disposition"]; }
            set { this["Content-Disposition"] = value; }
        }

        /// <summary>
        /// Specifies what content encodings have been applied to the object and thus what decoding mechanisms must be applied to obtain the media-type
        /// </summary>
        public string ContentEncoding
        {
            get { return this["Content-Encoding"]; }
            set { this["Content-Encoding"] = value; }
        }

        /// <summary>
        /// Content type for the uploaded data
        /// </summary>
        /// <remarks>
        /// If this is not set, an attempt will be made to infer it from the extension on Key or Path (in that order), 
        /// otherwise 'application/octet-stream' will be assumed.
        /// </remarks>
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
        /// The date and time at which the object is no longer cacheable.
        /// </summary>
        public DateTime? Expires
        {
            get
            {
                if (this["Expires"] == null)
                    return null;

                return DateTime.Parse(this["Expires"], CultureInfo.InvariantCulture);
            }
            set
            {
                if (value == null)
                    this["Expires"] = null;

                this["Expires"] = value.GetValueOrDefault().ToString(Amazon.Util.AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
            }
        }
    }
}
