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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
    /// Container for the parameters to the CreateBillOfMaterialsImportJob operation.
    /// CreateBillOfMaterialsImportJob creates an import job for the Product Bill Of Materials
    /// (BOM) entity. For information on the product_bom entity, see the AWS Supply Chain
    /// User Guide.
    /// 
    ///  
    /// <para>
    /// The CSV file must be located in an Amazon S3 location accessible to AWS Supply Chain.
    /// It is recommended to use the same Amazon S3 bucket created during your AWS Supply
    /// Chain instance creation.
    /// </para>
    /// </summary>
    public partial class CreateBillOfMaterialsImportJobRequest : AmazonSupplyChainRequest
    {
        private string _clientToken;
        private string _instanceId;
        private string _s3uri;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// An idempotency token ensures the API request is only completed no more than once.
        /// This way, retrying the request will not trigger the operation multiple times. A client
        /// token is a unique, case-sensitive string of 33 to 128 ASCII characters. To make an
        /// idempotent API request, specify a client token in the request. You should not reuse
        /// the same client token for other requests. If you retry a successful request with the
        /// same client token, the request will succeed with no further actions being taken, and
        /// you will receive the same API response as the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=126)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property S3uri. 
        /// <para>
        /// The S3 URI of the CSV file to be imported. The bucket must grant permissions for AWS
        /// Supply Chain to read the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10)]
        public string S3uri
        {
            get { return this._s3uri; }
            set { this._s3uri = value; }
        }

        // Check to see if S3uri property is set
        internal bool IsSetS3uri()
        {
            return this._s3uri != null;
        }

    }
}