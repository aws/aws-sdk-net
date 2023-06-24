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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the dataset input data configuration for a document classifier model.
    /// 
    ///  
    /// <para>
    /// For more information on how the input file is formatted, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/prep-classifier-data.html">Preparing
    /// training data</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DatasetDocumentClassifierInputDataConfig
    {
        private string _labelDelimiter;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property LabelDelimiter. 
        /// <para>
        /// Indicates the delimiter used to separate each label for training a multi-label classifier.
        /// The default delimiter between labels is a pipe (|). You can use a different character
        /// as a delimiter (if it's an allowed character) by specifying it under Delimiter for
        /// labels. If the training documents use a delimiter other than the default or the delimiter
        /// you specify, the labels on that line will be combined to make a single unique label,
        /// such as LABELLABELLABEL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string LabelDelimiter
        {
            get { return this._labelDelimiter; }
            set { this._labelDelimiter = value; }
        }

        // Check to see if LabelDelimiter property is set
        internal bool IsSetLabelDelimiter()
        {
            return this._labelDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI for the input data. The S3 bucket must be in the same Region as
        /// the API endpoint that you are calling. The URI can point to a single input file or
        /// it can provide the prefix for a collection of input files.
        /// </para>
        ///  
        /// <para>
        /// For example, if you use the URI <code>S3://bucketName/prefix</code>, if the prefix
        /// is a single file, Amazon Comprehend uses that file as input. If more than one file
        /// begins with the prefix, Amazon Comprehend uses all of them as input.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if you set <code>DataFormat</code> to <code>COMPREHEND_CSV</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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