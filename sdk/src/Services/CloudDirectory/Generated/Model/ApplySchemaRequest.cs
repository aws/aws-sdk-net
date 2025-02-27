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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the ApplySchema operation.
    /// Copies the input published schema, at the specified version, into the <a>Directory</a>
    /// with the same name and version as that of the published schema.
    /// </summary>
    public partial class ApplySchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private string _publishedSchemaArn;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the <a>Directory</a> into which
        /// the schema is copied. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property PublishedSchemaArn. 
        /// <para>
        /// Published schema Amazon Resource Name (ARN) that needs to be copied. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublishedSchemaArn
        {
            get { return this._publishedSchemaArn; }
            set { this._publishedSchemaArn = value; }
        }

        // Check to see if PublishedSchemaArn property is set
        internal bool IsSetPublishedSchemaArn()
        {
            return this._publishedSchemaArn != null;
        }

    }
}