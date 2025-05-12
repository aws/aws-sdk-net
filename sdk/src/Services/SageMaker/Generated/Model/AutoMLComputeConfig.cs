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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// <note> 
    /// <para>
    /// This data type is intended for use exclusively by SageMaker Canvas and cannot be used
    /// in other contexts at the moment.
    /// 
    ///  </note> 
    /// <para>
    /// Specifies the compute configuration for an AutoML job V2.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AutoMLComputeConfig
    {
        private EmrServerlessComputeConfig _emrServerlessComputeConfig;

        /// <summary>
        /// Gets and sets the property EmrServerlessComputeConfig. 
        /// <para>
        /// The configuration for using <a href="https://docs.aws.amazon.com/emr/latest/EMR-Serverless-UserGuide/emr-serverless.html">
        /// EMR Serverless</a> to run the AutoML job V2.
        /// </para>
        ///  
        /// <para>
        /// To allow your AutoML job V2 to automatically initiate a remote job on EMR Serverless
        /// when additional compute resources are needed to process large datasets, you need to
        /// provide an <c>EmrServerlessComputeConfig</c> object, which includes an <c>ExecutionRoleARN</c>
        /// attribute, to the <c>AutoMLComputeConfig</c> of the AutoML job V2 input request.
        /// </para>
        ///  
        /// <para>
        /// By seamlessly transitioning to EMR Serverless when required, the AutoML job can handle
        /// datasets that would otherwise exceed the initially provisioned resources, without
        /// any manual intervention from you. 
        /// </para>
        ///  
        /// <para>
        /// EMR Serverless is available for the tabular and time series problem types. We recommend
        /// setting up this option for tabular datasets larger than 5 GB and time series datasets
        /// larger than 30 GB.
        /// </para>
        /// </summary>
        public EmrServerlessComputeConfig EmrServerlessComputeConfig
        {
            get { return this._emrServerlessComputeConfig; }
            set { this._emrServerlessComputeConfig = value; }
        }

        // Check to see if EmrServerlessComputeConfig property is set
        internal bool IsSetEmrServerlessComputeConfig()
        {
            return this._emrServerlessComputeConfig != null;
        }

    }
}