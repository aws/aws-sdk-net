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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies configuration properties for a labeling set generation task run.
    /// </summary>
    public partial class LabelingSetGenerationTaskRunProperties
    {
        private string _outputS3Path;

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path where you will generate the labeling
        /// set.
        /// </para>
        /// </summary>
        public string OutputS3Path
        {
            get { return this._outputS3Path; }
            set { this._outputS3Path = value; }
        }

        // Check to see if OutputS3Path property is set
        internal bool IsSetOutputS3Path()
        {
            return this._outputS3Path != null;
        }

    }
}