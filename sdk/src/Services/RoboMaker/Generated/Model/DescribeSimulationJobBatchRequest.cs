/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSimulationJobBatch operation.
    /// Describes a simulation job batch.
    /// </summary>
    public partial class DescribeSimulationJobBatchRequest : AmazonRoboMakerRequest
    {
        private string _batch;

        /// <summary>
        /// Gets and sets the property Batch. 
        /// <para>
        /// The id of the batch to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
        public string Batch
        {
            get { return this._batch; }
            set { this._batch = value; }
        }

        // Check to see if Batch property is set
        internal bool IsSetBatch()
        {
            return this._batch != null;
        }

    }
}