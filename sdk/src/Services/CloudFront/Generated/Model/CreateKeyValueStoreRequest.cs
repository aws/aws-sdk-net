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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyValueStore operation.
    /// Specifies the Key Value Store resource to add to your account. In your account, the
    /// Key Value Store names must be unique. You can also import Key Value Store data in
    /// JSON format from an S3 bucket by providing a valid <code>ImportSource</code> that
    /// you own.
    /// </summary>
    public partial class CreateKeyValueStoreRequest : AmazonCloudFrontRequest
    {
        private string _comment;
        private ImportSource _importSource;
        private string _name;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment of the Key Value Store.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ImportSource. 
        /// <para>
        /// The S3 bucket that provides the source for the import. The source must be in a valid
        /// JSON format.
        /// </para>
        /// </summary>
        public ImportSource ImportSource
        {
            get { return this._importSource; }
            set { this._importSource = value; }
        }

        // Check to see if ImportSource property is set
        internal bool IsSetImportSource()
        {
            return this._importSource != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Key Value Store. The maximum length of the name is 32 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}