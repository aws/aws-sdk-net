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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the <c>Suffix</c> element.
    /// </summary>
    public partial class IndexDocument
    {
        private string _suffix;

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// A suffix that is appended to a request that is for a directory on the website endpoint.
        /// (For example, if the suffix is <c>index.html</c> and you make a request to <c>samplebucket/images/</c>,
        /// the data that is returned will be for the object with the key name <c>images/index.html</c>.)
        /// The suffix must not be empty and must not include a slash character.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Suffix
        {
            get { return this._suffix; }
            set { this._suffix = value; }
        }

        // Check to see if Suffix property is set
        internal bool IsSetSuffix()
        {
            return this._suffix != null;
        }

    }
}