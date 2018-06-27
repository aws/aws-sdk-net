/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides configuration parameters for the output of topic detection jobs.
    /// </summary>
    public partial class OutputDataConfig
    {
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// When you use the <code>OutputDataConfig</code> object with asynchronous operations,
        /// you specify the Amazon S3 location where you want to write the output data. The URI
        /// must be in the same region as the API endpoint that you are calling. The location
        /// is used as the prefix for the actual location of the output file.
        /// </para>
        ///  
        /// <para>
        /// When the topic detection job is finished, the service creates an output file in a
        /// directory specific to the job. The <code>S3Uri</code> field contains the location
        /// of the output file, called <code>output.tar.gz</code>. It is a compressed archive
        /// that contains the ouput of the operation.
        /// </para>
        /// </summary>
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}