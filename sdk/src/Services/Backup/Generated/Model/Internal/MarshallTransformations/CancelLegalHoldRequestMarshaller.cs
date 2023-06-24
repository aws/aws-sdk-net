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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CancelLegalHold Request Marshaller
    /// </summary>       
    public class CancelLegalHoldRequestMarshaller : IMarshaller<IRequest, CancelLegalHoldRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CancelLegalHoldRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CancelLegalHoldRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetLegalHoldId())
                throw new AmazonBackupException("Request object does not have required field LegalHoldId set");
            request.AddPathResource("{legalHoldId}", StringUtils.FromString(publicRequest.LegalHoldId));
            
            if (publicRequest.IsSetCancelDescription())
                request.Parameters.Add("cancelDescription", StringUtils.FromString(publicRequest.CancelDescription));
            
            if (publicRequest.IsSetRetainRecordInDays())
                request.Parameters.Add("retainRecordInDays", StringUtils.FromLong(publicRequest.RetainRecordInDays));
            request.ResourcePath = "/legal-holds/{legalHoldId}";
            request.UseQueryString = true;

            return request;
        }
        private static CancelLegalHoldRequestMarshaller _instance = new CancelLegalHoldRequestMarshaller();        

        internal static CancelLegalHoldRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CancelLegalHoldRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}