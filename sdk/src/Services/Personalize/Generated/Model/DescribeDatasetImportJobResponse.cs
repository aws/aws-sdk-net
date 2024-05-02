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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatasetImportJob operation.
    /// </summary>
    public partial class DescribeDatasetImportJobResponse : AmazonWebServiceResponse
    {
        private DatasetImportJob _datasetImportJob;

        /// <summary>
        /// Gets and sets the property DatasetImportJob. 
        /// <para>
        /// Information about the dataset import job, including the status.
        /// </para>
        ///  
        /// <para>
        /// The status is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE IN_PROGRESS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DatasetImportJob DatasetImportJob
        {
            get { return this._datasetImportJob; }
            set { this._datasetImportJob = value; }
        }

        // Check to see if DatasetImportJob property is set
        internal bool IsSetDatasetImportJob()
        {
            return this._datasetImportJob != null;
        }

    }
}