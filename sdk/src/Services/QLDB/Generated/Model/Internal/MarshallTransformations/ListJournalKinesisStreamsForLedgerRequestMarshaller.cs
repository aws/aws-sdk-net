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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QLDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.QLDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJournalKinesisStreamsForLedger Request Marshaller
    /// </summary>       
    public class ListJournalKinesisStreamsForLedgerRequestMarshaller : IMarshaller<IRequest, ListJournalKinesisStreamsForLedgerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJournalKinesisStreamsForLedgerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJournalKinesisStreamsForLedgerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QLDB");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-02";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetLedgerName())
                throw new AmazonQLDBException("Request object does not have required field LedgerName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.LedgerName));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("max_results", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("next_token", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/ledgers/{name}/journal-kinesis-streams";
            request.UseQueryString = true;

            return request;
        }
        private static ListJournalKinesisStreamsForLedgerRequestMarshaller _instance = new ListJournalKinesisStreamsForLedgerRequestMarshaller();        

        internal static ListJournalKinesisStreamsForLedgerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJournalKinesisStreamsForLedgerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}