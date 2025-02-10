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
    /// This is the response object from the CreateComputeQuota operation.
    /// </summary>
    public partial class CreateComputeQuotaResponse : AmazonWebServiceResponse
    {
        private string _computeQuotaArn;
        private string _computeQuotaId;

        /// <summary>
        /// Gets and sets the property ComputeQuotaArn. 
        /// <para>
        /// ARN of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string ComputeQuotaArn
        {
            get { return this._computeQuotaArn; }
            set { this._computeQuotaArn = value; }
        }

        // Check to see if ComputeQuotaArn property is set
        internal bool IsSetComputeQuotaArn()
        {
            return this._computeQuotaArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeQuotaId. 
        /// <para>
        /// ID of the compute allocation definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeQuotaId
        {
            get { return this._computeQuotaId; }
            set { this._computeQuotaId = value; }
        }

        // Check to see if ComputeQuotaId property is set
        internal bool IsSetComputeQuotaId()
        {
            return this._computeQuotaId != null;
        }

    }
}