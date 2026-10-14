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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes an update to the code of an application. Not supported for Apache Zeppelin.
    /// </summary>
    public partial class CodeContentUpdate
    {
        /// <summary>
        /// Gets and sets the property S3ContentLocationUpdate. 
        /// <para>
        /// Describes an update to the location of code for an application.
        /// </para>
        /// </summary>
        public S3ContentLocationUpdate S3ContentLocationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the S3ContentLocationUpdate property is set.
        /// </summary>
        internal bool IsSetS3ContentLocationUpdate() => this.S3ContentLocationUpdate != null;

        /// <summary>
        /// Gets and sets the property TextContentUpdate. 
        /// <para>
        /// Describes an update to the text code for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string TextContentUpdate { get; set; }

        /// <summary>
        /// Checks to see if the TextContentUpdate property is set.
        /// </summary>
        internal bool IsSetTextContentUpdate() => this.TextContentUpdate != null;

        /// <summary>
        /// Gets and sets the property ZipFileContentUpdate. 
        /// <para>
        /// Describes an update to the zipped code for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 52428800)]
        public MemoryStream ZipFileContentUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ZipFileContentUpdate property is set.
        /// </summary>
        internal bool IsSetZipFileContentUpdate() => this.ZipFileContentUpdate != null;
    }
}
