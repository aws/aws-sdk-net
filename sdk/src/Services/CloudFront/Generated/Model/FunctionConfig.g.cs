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
    /// Contains configuration information about a CloudFront function.
    /// </summary>
    public partial class FunctionConfig
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment to describe the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property KeyValueStoreAssociations. 
        /// <para>
        /// The configuration for the key value store associations.
        /// </para>
        /// </summary>
        public KeyValueStoreAssociations KeyValueStoreAssociations { get; set; }

        /// <summary>
        /// Checks to see if the KeyValueStoreAssociations property is set.
        /// </summary>
        internal bool IsSetKeyValueStoreAssociations() => this.KeyValueStoreAssociations != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The function's runtime environment version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionRuntime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;
    }
}
