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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains vulnerability counts for a specific image pipeline.
    /// </summary>
    public partial class ImagePipelineAggregation
    {
        private string _imagePipelineArn;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property ImagePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the image pipeline for this aggregation.
        /// </para>
        /// </summary>
        public string ImagePipelineArn
        {
            get { return this._imagePipelineArn; }
            set { this._imagePipelineArn = value; }
        }

        // Check to see if ImagePipelineArn property is set
        internal bool IsSetImagePipelineArn()
        {
            return this._imagePipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// Counts by severity level for medium severity and higher level findings, plus a total
        /// for all of the findings for the specified image pipeline.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}