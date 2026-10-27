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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataset operation. Retrieves dataset metadata.
    /// Use the <c>datasetVersion</c> query parameter to retrieve a specific version's metadata.
    /// If absent, defaults to DRAFT. For paginated example content, use <c>ListDatasetExamples</c>.
    /// </summary>
    public partial class GetDatasetRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        ///  Version to retrieve: "DRAFT" or a version number. Defaults to DRAFT if absent. 
        /// </para>
        /// </summary>
        public string DatasetVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatasetVersion property is set.
        /// </summary>
        internal bool IsSetDatasetVersion() => this.DatasetVersion != null;
    }
}
