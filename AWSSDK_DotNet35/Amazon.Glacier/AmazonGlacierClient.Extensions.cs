/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Glacier.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.Glacier
{
    /// <summary>
    /// Implementation for accessing AmazonGlacier.
    ///  
    /// <para>Amazon Glacier is a storage solution for "cold data."</para> <para>Amazon Glacier is an extremely low-cost storage service that
    /// provides secure, durable, and easy-to-use storage for data backup and archival. With Amazon Glacier, customers can store their data cost
    /// effectively for months, years, or decades. Amazon Glacier also enables customers to offload the administrative burdens of operating and
    /// scaling storage to AWS, so they don't have to worry about capacity planning, hardware provisioning, data replication, hardware failure and
    /// recovery, or time-consuming hardware migrations.</para> <para>Amazon Glacier is a great storage choice when low storage cost is paramount,
    /// your data is rarely retrieved, and retrieval latency of several hours is acceptable. If your application requires fast or frequent access to
    /// your data, consider using Amazon S3. For more information, go to Amazon Simple Storage Service (Amazon S3).</para> <para>You can store any
    /// kind of data in any format. There is no maximum limit on the total amount of data you can store in Amazon Glacier. </para> <para>If you are
    /// a first-time user of Amazon Glacier, we recommend that you begin by reading the following sections in the <i>Amazon Glacier Developer
    /// Guide</i> :</para>
    /// <ul>
    /// <li> <para> What is Amazon Glacier - This section of the Developer Guide describes the underlying data model, the operations it supports,
    /// and the AWS SDKs that you can use to interact with the service.</para> </li>
    /// <li> <para> Getting Started with Amazon Glacier - The Getting Started section walks you through the process of creating a vault, uploading
    /// archives, creating jobs to download archives, retrieving the job output, and deleting archives.</para> </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class AmazonGlacierClient : AmazonWebServiceClient, IAmazonGlacier
    {
        protected override void Initialize()
        {
            this.Config.SetUseNagleIfAvailable(true);
            this.Config.ResignRetries = true;
            base.Initialize();
        }

        /// <summary>
        /// Add API version header
        /// </summary>
        /// <param name="request"></param>
        protected override void ProcessRequestHandlers(IRequest request)
        {
            if (request.ResourcePath != null)
            {
                if (request.ResourcePath.StartsWith("//", StringComparison.Ordinal))
                {
                    request.ResourcePath = "/-" + request.ResourcePath.Substring(1);
                }
            }

            base.ProcessRequestHandlers(request);
            request.Headers["x-amz-glacier-version"] = "2012-06-01";
        }
    }
}
