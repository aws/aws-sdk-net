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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    public partial class ListPartsRequest : AmazonWebServiceRequest
    {
        private EncodingType encoding;

        /// <summary>
        /// <para>Encoding type used by Amazon S3 to encode the 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html">object keys</a> in 
        /// the response. Responses are encoded only in UTF-8. An object key can contain any Unicode character. 
        /// However, the XML 1.0 parser can't parse certain characters, such as characters with an ASCII value 
        /// from 0 to 10. For characters that aren't supported in XML 1.0, you can add this parameter to request 
        /// that Amazon S3 encode the keys in the response. For more information about characters to avoid in 
        /// object key names, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-guidelines">Object key naming guidelines</a>.
        /// </para> <note> <para>When using the URL encoding type, non-ASCII characters that are used in an 
        /// object's key name will be percent-encoded according to UTF-8 code values. For example, the object 
        /// <code>test_file(3).png</code> will appear as <code>test_file%283%29.png</code>.</para> </note>
        /// </summary>
        public EncodingType Encoding
        {
            get { return this.encoding; }
            set { this.encoding = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetEncoding()
        {
            return this.encoding != null;
        }
    }
}
    
