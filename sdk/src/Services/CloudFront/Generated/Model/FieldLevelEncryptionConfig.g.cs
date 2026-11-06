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
    /// A complex data type that includes the profile configurations specified for field-level
    /// encryption.
    /// </summary>
    public partial class FieldLevelEncryptionConfig
    {
        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique number that ensures the request can't be replayed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// An optional comment about the configuration. The comment cannot be longer than 128
        /// characters.
        /// </para>
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ContentTypeProfileConfig. 
        /// <para>
        /// A complex data type that specifies when to forward content if a content type isn't
        /// recognized and profiles to use as by default in a request if a query argument doesn't
        /// specify a profile to use.
        /// </para>
        /// </summary>
        public ContentTypeProfileConfig ContentTypeProfileConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContentTypeProfileConfig property is set.
        /// </summary>
        internal bool IsSetContentTypeProfileConfig() => this.ContentTypeProfileConfig != null;

        /// <summary>
        /// Gets and sets the property QueryArgProfileConfig. 
        /// <para>
        /// A complex data type that specifies when to forward content if a profile isn't found
        /// and the profile that can be provided as a query argument in a request.
        /// </para>
        /// </summary>
        public QueryArgProfileConfig QueryArgProfileConfig { get; set; }

        /// <summary>
        /// Checks to see if the QueryArgProfileConfig property is set.
        /// </summary>
        internal bool IsSetQueryArgProfileConfig() => this.QueryArgProfileConfig != null;
    }
}
