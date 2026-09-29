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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataset operation. Retrieves information
    /// about a dataset.
    /// </summary>
    public partial class DescribeDatasetRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// The version of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatasetVersion property is set.
        /// </summary>
        internal bool IsSetDatasetVersion() => this.DatasetVersion != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
