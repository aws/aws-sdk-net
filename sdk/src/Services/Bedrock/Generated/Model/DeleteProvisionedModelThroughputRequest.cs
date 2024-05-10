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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteProvisionedModelThroughput operation.
    /// Deletes a Provisioned Throughput. You can't delete a Provisioned Throughput before
    /// the commitment term is over. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
    /// Throughput</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class DeleteProvisionedModelThroughputRequest : AmazonBedrockRequest
    {
        private string _provisionedModelId;

        /// <summary>
        /// Gets and sets the property ProvisionedModelId. 
        /// <para>
        /// The Amazon Resource Name (ARN) or name of the Provisioned Throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProvisionedModelId
        {
            get { return this._provisionedModelId; }
            set { this._provisionedModelId = value; }
        }

        // Check to see if ProvisionedModelId property is set
        internal bool IsSetProvisionedModelId()
        {
            return this._provisionedModelId != null;
        }

    }
}