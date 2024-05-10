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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents an access log file.
    /// </summary>
    public partial class FileAccessLog
    {
        private LoggingFormat _format;
        private string _path;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The specified format for the logs. The format is either <c>json_format</c> or <c>text_format</c>.
        /// </para>
        /// </summary>
        public LoggingFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The file path to write access logs to. You can use <c>/dev/stdout</c> to send access
        /// logs to standard out and configure your Envoy container to use a log driver, such
        /// as <c>awslogs</c>, to export the access logs to a log storage service such as Amazon
        /// CloudWatch Logs. You can also specify a path in the Envoy container's file system
        /// to write the files to disk.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Envoy process must have write permissions to the path that you specify here. Otherwise,
        /// Envoy fails to bootstrap properly.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}