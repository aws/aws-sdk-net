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
    /// This is the response object from the BatchGetTableOptimizer operation.
    /// </summary>
    public partial class BatchGetTableOptimizerResponse : AmazonWebServiceResponse
    {
        private List<BatchGetTableOptimizerError> _failures = AWSConfigs.InitializeCollections ? new List<BatchGetTableOptimizerError>() : null;
        private List<BatchTableOptimizer> _tableOptimizers = AWSConfigs.InitializeCollections ? new List<BatchTableOptimizer>() : null;

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// A list of errors from the operation.
        /// </para>
        /// </summary>
        public List<BatchGetTableOptimizerError> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableOptimizers. 
        /// <para>
        /// A list of <c>BatchTableOptimizer</c> objects.
        /// </para>
        /// </summary>
        public List<BatchTableOptimizer> TableOptimizers
        {
            get { return this._tableOptimizers; }
            set { this._tableOptimizers = value; }
        }

        // Check to see if TableOptimizers property is set
        internal bool IsSetTableOptimizers()
        {
            return this._tableOptimizers != null && (this._tableOptimizers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}