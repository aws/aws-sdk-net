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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the StartResourceScan operation.
    /// Immediately starts a scan of the policies applied to the specified resource.
    /// </summary>
    public partial class StartResourceScanRequest : AmazonAccessAnalyzerRequest
    {
        private string _analyzerArn;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The ARN of the analyzer to use to scan the policies applied to the specified resource.
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

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}