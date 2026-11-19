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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyValueStore operation. Specifies the key
    /// value store resource to add to your account. In your account, the key value store
    /// names must be unique. You can also import key value store data in JSON format from
    /// an S3 bucket by providing a valid <c>ImportSource</c> that you own.
    /// </summary>
    public partial class CreateKeyValueStoreRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment of the key value store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ImportSource. 
        /// <para>
        /// The S3 bucket that provides the source for the import. The source must be in a valid
        /// JSON format.
        /// </para>
        /// </summary>
        public ImportSource ImportSource { get; set; }

        /// <summary>
        /// Checks to see if the ImportSource property is set.
        /// </summary>
        internal bool IsSetImportSource() => this.ImportSource != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the key value store. The minimum length is 1 character and the maximum
        /// length is 64 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}
