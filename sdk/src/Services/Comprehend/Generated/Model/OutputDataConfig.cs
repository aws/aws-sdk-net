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
        /// The Amazon S3 URI where you want to write the output data. The URI must be in the
        /// same region as the API endpoint that you are calling. 
        /// </para>
        ///  
        /// <para>
        /// The service creates an output file called <code>output.tar.gz</code>. It is a compressed
        /// archive that contains two files, <code>topic-terms.csv</code> that lists the terms
        /// associated with each topic, and <code>doc-topics.csv</code> that lists the documents
        /// associated with each topic. For more information, see <a>topic-modeling</a>.
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