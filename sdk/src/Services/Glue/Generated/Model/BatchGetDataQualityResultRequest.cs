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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetDataQualityResult operation.
    /// Retrieves a list of data quality results for the specified result IDs.
    /// </summary>
    public partial class BatchGetDataQualityResultRequest : AmazonGlueRequest
    {
        private List<string> _resultIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ResultIds. 
        /// <para>
        /// A list of unique result IDs for the data quality results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ResultIds
        {
            get { return this._resultIds; }
            set { this._resultIds = value; }
        }

        // Check to see if ResultIds property is set
        internal bool IsSetResultIds()
        {
            return this._resultIds != null && this._resultIds.Count > 0; 
        }

    }
}