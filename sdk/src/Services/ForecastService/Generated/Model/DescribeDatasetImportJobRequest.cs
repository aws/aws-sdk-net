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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDatasetImportJob operation.
    /// Describes a dataset import job created using the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// In addition to listing the parameters provided in the <c>CreateDatasetImportJob</c>
    /// request, this operation includes the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreationTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastModificationTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DataSize</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FieldStatistics</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Status</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Message</c> - If an error occurred, information about the error.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeDatasetImportJobRequest : AmazonForecastServiceRequest
    {
        private string _datasetImportJobArn;

        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetImportJobArn
        {
            get { return this._datasetImportJobArn; }
            set { this._datasetImportJobArn = value; }
        }

        // Check to see if DatasetImportJobArn property is set
        internal bool IsSetDatasetImportJobArn()
        {
            return this._datasetImportJobArn != null;
        }

    }
}