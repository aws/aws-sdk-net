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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This output contains the description of the cluster step.
    /// </summary>
    public partial class DescribeStepResponse : AmazonWebServiceResponse
    {
        private Step _step;

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The step details for the requested step identifier.
        /// </para>
        /// </summary>
        public Step Step
        {
            get { return this._step; }
            set { this._step = value; }
        }

        // Check to see if Step property is set
        internal bool IsSetStep()
        {
            return this._step != null;
        }

    }
}