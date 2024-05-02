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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataset operation.
    /// Describe an Amazon Lookout for Vision dataset.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:DescribeDataset</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DescribeDatasetRequest : AmazonLookoutforVisionRequest
    {
        private string _datasetType;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of the dataset to describe. Specify <c>train</c> to describe the training
        /// dataset. Specify <c>test</c> to describe the test dataset. If you have a single dataset
        /// project, specify <c>train</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the dataset that you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}