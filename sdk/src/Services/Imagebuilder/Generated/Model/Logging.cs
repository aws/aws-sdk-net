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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Logging configuration defines where Image Builder uploads your logs.
    /// </summary>
    public partial class Logging
    {
        private S3Logs _s3Logs;

        /// <summary>
        /// Gets and sets the property S3Logs. 
        /// <para>
        /// The Amazon S3 logging configuration.
        /// </para>
        /// </summary>
        public S3Logs S3Logs
        {
            get { return this._s3Logs; }
            set { this._s3Logs = value; }
        }

        // Check to see if S3Logs property is set
        internal bool IsSetS3Logs()
        {
            return this._s3Logs != null;
        }

    }
}