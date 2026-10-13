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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for Dataset Definition inputs. The Dataset Definition input must specify
    /// exactly one of either <c>AthenaDatasetDefinition</c> or <c>RedshiftDatasetDefinition</c>
    /// types.
    /// </summary>
    public partial class DatasetDefinition
    {
        /// <summary>
        /// Gets and sets the property AthenaDatasetDefinition.
        /// </summary>
        public AthenaDatasetDefinition AthenaDatasetDefinition { get; set; }

        /// <summary>
        /// Checks to see if the AthenaDatasetDefinition property is set.
        /// </summary>
        internal bool IsSetAthenaDatasetDefinition() => this.AthenaDatasetDefinition != null;

        /// <summary>
        /// Gets and sets the property DataDistributionType. 
        /// <para>
        /// Whether the generated dataset is <c>FullyReplicated</c> or <c>ShardedByS3Key</c> (default).
        /// </para>
        /// </summary>
        public DataDistributionType DataDistributionType { get; set; }

        /// <summary>
        /// Checks to see if the DataDistributionType property is set.
        /// </summary>
        internal bool IsSetDataDistributionType() => this.DataDistributionType != null;

        /// <summary>
        /// Gets and sets the property InputMode. 
        /// <para>
        /// Whether to use <c>File</c> or <c>Pipe</c> input mode. In <c>File</c> (default) mode,
        /// Amazon SageMaker copies the data from the input source onto the local Amazon Elastic
        /// Block Store (Amazon EBS) volumes before starting your training algorithm. This is
        /// the most commonly used input mode. In <c>Pipe</c> mode, Amazon SageMaker streams input
        /// data from the source directly to your algorithm without using the EBS volume.
        /// </para>
        /// </summary>
        public InputMode InputMode { get; set; }

        /// <summary>
        /// Checks to see if the InputMode property is set.
        /// </summary>
        internal bool IsSetInputMode() => this.InputMode != null;

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// The local path where you want Amazon SageMaker to download the Dataset Definition
        /// inputs to run a processing job. <c>LocalPath</c> is an absolute path to the input
        /// data. This is a required parameter when <c>AppManaged</c> is <c>False</c> (default).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalPath property is set.
        /// </summary>
        internal bool IsSetLocalPath() => this.LocalPath != null;

        /// <summary>
        /// Gets and sets the property RedshiftDatasetDefinition.
        /// </summary>
        public RedshiftDatasetDefinition RedshiftDatasetDefinition { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDatasetDefinition property is set.
        /// </summary>
        internal bool IsSetRedshiftDatasetDefinition() => this.RedshiftDatasetDefinition != null;
    }
}
