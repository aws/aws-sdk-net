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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Configuration for a migration source environment.
    /// </summary>
    public partial class SourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property SourceEnvironment. 
        /// <para>
        /// The source environment type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceEnvironment SourceEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the SourceEnvironment property is set.
        /// </summary>
        internal bool IsSetSourceEnvironment() => this.SourceEnvironment != null;

        /// <summary>
        /// Gets and sets the property SourceS3Configuration. 
        /// <para>
        /// The S3 configuration for the source data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceS3Configuration SourceS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3Configuration property is set.
        /// </summary>
        internal bool IsSetSourceS3Configuration() => this.SourceS3Configuration != null;
    }
}
