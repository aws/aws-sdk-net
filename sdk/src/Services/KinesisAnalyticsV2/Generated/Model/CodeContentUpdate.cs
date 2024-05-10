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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
        private S3ContentLocationUpdate _s3ContentLocationUpdate;
        private string _textContentUpdate;
        private MemoryStream _zipFileContentUpdate;

        /// <summary>
        /// Gets and sets the property S3ContentLocationUpdate. 
        /// <para>
        /// Describes an update to the location of code for an application.
        /// </para>
        /// </summary>
        public S3ContentLocationUpdate S3ContentLocationUpdate
        {
            get { return this._s3ContentLocationUpdate; }
            set { this._s3ContentLocationUpdate = value; }
        }

        // Check to see if S3ContentLocationUpdate property is set
        internal bool IsSetS3ContentLocationUpdate()
        {
            return this._s3ContentLocationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property TextContentUpdate. 
        /// <para>
        /// Describes an update to the text code for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=102400)]
        public string TextContentUpdate
        {
            get { return this._textContentUpdate; }
            set { this._textContentUpdate = value; }
        }

        // Check to see if TextContentUpdate property is set
        internal bool IsSetTextContentUpdate()
        {
            return this._textContentUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFileContentUpdate. 
        /// <para>
        /// Describes an update to the zipped code for an application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=52428800)]
        public MemoryStream ZipFileContentUpdate
        {
            get { return this._zipFileContentUpdate; }
            set { this._zipFileContentUpdate = value; }
        }

        // Check to see if ZipFileContentUpdate property is set
        internal bool IsSetZipFileContentUpdate()
        {
            return this._zipFileContentUpdate != null;
        }

    }
}