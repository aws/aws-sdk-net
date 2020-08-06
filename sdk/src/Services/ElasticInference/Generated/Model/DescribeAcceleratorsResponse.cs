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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccelerators operation.
    /// </summary>
    public partial class DescribeAcceleratorsResponse : AmazonWebServiceResponse
    {
        private List<ElasticInferenceAccelerator> _acceleratorSet = new List<ElasticInferenceAccelerator>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AcceleratorSet. 
        /// <para>
        ///  The details of the Elastic Inference Accelerators. 
        /// </para>
        /// </summary>
        public List<ElasticInferenceAccelerator> AcceleratorSet
        {
            get { return this._acceleratorSet; }
            set { this._acceleratorSet = value; }
        }

        // Check to see if AcceleratorSet property is set
        internal bool IsSetAcceleratorSet()
        {
            return this._acceleratorSet != null && this._acceleratorSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}