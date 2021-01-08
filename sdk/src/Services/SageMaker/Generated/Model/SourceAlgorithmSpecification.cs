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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of algorithms that were used to create a model package.
    /// </summary>
    public partial class SourceAlgorithmSpecification
    {
        private List<SourceAlgorithm> _sourceAlgorithms = new List<SourceAlgorithm>();

        /// <summary>
        /// Gets and sets the property SourceAlgorithms. 
        /// <para>
        /// A list of the algorithms that were used to create a model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SourceAlgorithm> SourceAlgorithms
        {
            get { return this._sourceAlgorithms; }
            set { this._sourceAlgorithms = value; }
        }

        // Check to see if SourceAlgorithms property is set
        internal bool IsSetSourceAlgorithms()
        {
            return this._sourceAlgorithms != null && this._sourceAlgorithms.Count > 0; 
        }

    }
}