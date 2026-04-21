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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAutomationRule Request Marshaller
    /// </summary>       
    public class DeleteAutomationRuleRequestMarshaller : IMarshaller<IRequest, DeleteAutomationRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAutomationRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAutomationRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizerAutomation");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/ComputeOptimizerAutomationService/operation/DeleteAutomationRule";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-22";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else if (!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WriteTextString("clientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetRuleArn())
                {
                    context.Writer.WriteTextString("ruleArn");
                    context.Writer.WriteTextString(publicRequest.RuleArn);
                }
                if (publicRequest.IsSetRuleRevision())
                {
                    context.Writer.WriteTextString("ruleRevision");
                    context.Writer.WriteInt64(publicRequest.RuleRevision.Value);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static DeleteAutomationRuleRequestMarshaller _instance = new DeleteAutomationRuleRequestMarshaller();        

        internal static DeleteAutomationRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAutomationRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}