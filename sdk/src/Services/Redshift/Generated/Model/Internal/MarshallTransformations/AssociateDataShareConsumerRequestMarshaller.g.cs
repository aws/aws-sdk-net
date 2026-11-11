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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.Redshift.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateDataShareConsumer Request Marshaller
    /// </summary>
    public partial class AssociateDataShareConsumerRequestMarshaller : IMarshaller<IRequest, AssociateDataShareConsumerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateDataShareConsumerRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateDataShareConsumerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AssociateDataShareConsumer");
            request.Parameters.Add("Version", "2012-12-01");

            if (publicRequest.IsSetAllowWrites())
            {
                request.Parameters.Add("AllowWrites", StringUtils.FromBool(publicRequest.AllowWrites.Value));
            }
            if (publicRequest.IsSetAssociateEntireAccount())
            {
                request.Parameters.Add("AssociateEntireAccount", StringUtils.FromBool(publicRequest.AssociateEntireAccount.Value));
            }
            if (publicRequest.IsSetConsumerArn())
            {
                request.Parameters.Add("ConsumerArn", StringUtils.FromString(publicRequest.ConsumerArn));
            }
            if (publicRequest.IsSetConsumerRegion())
            {
                request.Parameters.Add("ConsumerRegion", StringUtils.FromString(publicRequest.ConsumerRegion));
            }
            if (publicRequest.IsSetDataShareArn())
            {
                request.Parameters.Add("DataShareArn", StringUtils.FromString(publicRequest.DataShareArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AssociateDataShareConsumerRequestMarshaller _instance = new();

        internal static AssociateDataShareConsumerRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateDataShareConsumerRequestMarshaller Instance => _instance;
    }
}
