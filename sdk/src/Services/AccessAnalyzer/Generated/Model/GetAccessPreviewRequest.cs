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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessPreview operation.
    /// Retrieves information about an access preview for the specified analyzer.
    /// </summary>
    public partial class GetAccessPreviewRequest : AmazonAccessAnalyzerRequest
    {
        private string _accessPreviewId;
        private string _analyzerArn;

        /// <summary>
        /// Gets and sets the property AccessPreviewId. 
        /// <para>
        /// The unique ID for the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessPreviewId
        {
            get { return this._accessPreviewId; }
            set { this._accessPreviewId = value; }
        }

        // Check to see if AccessPreviewId property is set
        internal bool IsSetAccessPreviewId()
        {
            return this._accessPreviewId != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-getting-started.html#permission-resources">ARN
        /// of the analyzer</a> used to generate the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnalyzerArn
        {
            get { return this._analyzerArn; }
            set { this._analyzerArn = value; }
        }

        // Check to see if AnalyzerArn property is set
        internal bool IsSetAnalyzerArn()
        {
            return this._analyzerArn != null;
        }

    }
}