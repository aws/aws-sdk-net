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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Contains information about the output locations for hybrid job checkpoint data.
    /// </summary>
    public partial class JobCheckpointConfig
    {
        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// (Optional) The local directory where checkpoint data is stored. The default directory
        /// is <c>/opt/braket/checkpoints/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalPath property is set.
        /// </summary>
        internal bool IsSetLocalPath() => this.LocalPath != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Identifies the S3 path where you want Amazon Braket to store checkpoint data. For
        /// example, <c>s3://bucket-name/key-name-prefix</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
