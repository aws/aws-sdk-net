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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the dataset entity list for an entity recognizer model.
    /// 
    ///  
    /// <para>
    /// For more information on how the input file is formatted, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/prep-training-data-cer.html">Preparing
    /// training data</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DatasetEntityRecognizerEntityList
    {
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Specifies the Amazon S3 location where the entity list is located.
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