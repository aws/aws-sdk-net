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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation. Creates a Dataset in
    /// a Domain and starts building it. A new dataset has the status CREATING. When it's
    /// ready to use, its status changes to ACTIVE, or to CREATE_FAILED if it fails to build.
    /// To check the status, call GetDataset. <para> This operation is idempotent: if you
    /// retry a request with the same clientToken, it returns the dataset that the first request
    /// created. </para> <para> For a medical coding dataset, Amazon Connect Health uses the
    /// coded examples that are in the s3InputPath when you create the dataset, and writes
    /// evaluation scores to the s3OutputPath. Later changes to the s3InputPath don't change
    /// the dataset. To use this operation, you must have s3:GetObject and s3:ListBucket permissions
    /// for the input location and s3:PutObject permission for the output location, and kms:Decrypt
    /// and kms:GenerateDataKey permissions if you encrypt the locations with an AWS KMS key.
    /// </para> <para> Datasets are in preview release and are subject to change. </para>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonConnectHealthRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the operation returns the
        /// dataset that the first request created. If you reuse a clientToken with different
        /// parameters, the request fails with ConflictException. Use a new clientToken for a
        /// request with different parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// The configuration of the dataset. The member that you set determines the dataset type.
        /// You can't change the configuration after you create the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetConfig Config { get; set; }

        /// <summary>
        /// Checks to see if the Config property is set.
        /// </summary>
        internal bool IsSetConfig() => this.Config != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the parent Domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1028)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
