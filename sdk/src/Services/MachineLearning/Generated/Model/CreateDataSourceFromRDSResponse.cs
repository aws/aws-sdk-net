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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of a <code>CreateDataSourceFromRDS</code> operation, and is
    /// an acknowledgement that Amazon ML received the request.
    /// 
    ///  
    /// <para>
    /// The <code>CreateDataSourceFromRDS</code>&gt; operation is asynchronous. You can poll
    /// for updates by using the <code>GetBatchPrediction</code> operation and checking the
    /// <code>Status</code> parameter. You can inspect the <code>Message</code> when <code>Status</code>
    /// shows up as <code>FAILED</code>. You can also check the progress of the copy operation
    /// by going to the <code>DataPipeline</code> console and looking up the pipeline using
    /// the <code>pipelineId </code> from the describe call.
    /// </para>
    /// </summary>
    public partial class CreateDataSourceFromRDSResponse : AmazonWebServiceResponse
    {
        private string _dataSourceId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the datasource. This value should be identical
        /// to the value of the <code>DataSourceID</code> in the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

    }
}