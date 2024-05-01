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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of a <c>CreateDataSourceFromS3</c> operation, and is an acknowledgement
    /// that Amazon ML received the request.
    /// 
    ///  
    /// <para>
    /// The <c>CreateDataSourceFromS3</c> operation is asynchronous. You can poll for updates
    /// by using the <c>GetBatchPrediction</c> operation and checking the <c>Status</c> parameter.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateDataSourceFromS3Response : AmazonWebServiceResponse
    {
        private string _dataSourceId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>DataSource</c>. This value should
        /// be identical to the value of the <c>DataSourceID</c> in the request. 
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