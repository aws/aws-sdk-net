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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The source information of a flow execution.
    /// </summary>
    public partial class DataIntegrationFlowExecutionSourceInfo
    {
        /// <summary>
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The source details of a flow execution with dataset source.
        /// </para>
        /// </summary>
        public DataIntegrationFlowDatasetSource DatasetSource { get; set; }

        /// <summary>
        /// Checks to see if the DatasetSource property is set.
        /// </summary>
        internal bool IsSetDatasetSource() => this.DatasetSource != null;

        /// <summary>
        /// Gets and sets the property S3Source. 
        /// <para>
        /// The source details of a flow execution with S3 source.
        /// </para>
        /// </summary>
        public DataIntegrationFlowS3Source S3Source { get; set; }

        /// <summary>
        /// Checks to see if the S3Source property is set.
        /// </summary>
        internal bool IsSetS3Source() => this.S3Source != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The data integration flow execution source type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataIntegrationFlowSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
