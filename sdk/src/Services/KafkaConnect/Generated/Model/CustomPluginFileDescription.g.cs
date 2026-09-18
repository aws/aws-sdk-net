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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Details about a custom plugin file.
    /// </summary>
    public partial class CustomPluginFileDescription
    {
        /// <summary>
        /// Gets and sets the property FileMd5. 
        /// <para>
        /// The hex-encoded MD5 checksum of the custom plugin file. You can use it to validate
        /// the file.
        /// </para>
        /// </summary>
        public string FileMd5 { get; set; }

        /// <summary>
        /// Checks to see if the FileMd5 property is set.
        /// </summary>
        internal bool IsSetFileMd5() => this.FileMd5 != null;

        /// <summary>
        /// Gets and sets the property FileSize. 
        /// <para>
        /// The size in bytes of the custom plugin file. You can use it to validate the file.
        /// </para>
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        /// Checks to see if the FileSize property is set.
        /// </summary>
        internal bool IsSetFileSize() => this.FileSize.HasValue;
    }
}
