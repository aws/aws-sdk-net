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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateHostedConfigurationVersion Request Marshaller
    /// </summary>       
    public class CreateHostedConfigurationVersionRequestMarshaller : IMarshaller<IRequest, CreateHostedConfigurationVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHostedConfigurationVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHostedConfigurationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonAppConfigException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{ApplicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetConfigurationProfileId())
                throw new AmazonAppConfigException("Request object does not have required field ConfigurationProfileId set");
            request.AddPathResource("{ConfigurationProfileId}", StringUtils.FromString(publicRequest.ConfigurationProfileId));
            request.ResourcePath = "/applications/{ApplicationId}/configurationprofiles/{ConfigurationProfileId}/hostedconfigurationversions";
            request.ContentStream =  publicRequest.Content ?? new MemoryStream();
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream"; 
            if (request.ContentStream != null && request.ContentStream.Length == 0)
            {
                request.Headers.Remove(Amazon.Util.HeaderKeys.ContentTypeHeader);
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }
        
            if (publicRequest.IsSetDescription()) 
            {
                request.Headers["Description"] = publicRequest.Description;
            }
        
            if (publicRequest.IsSetLatestVersionNumber()) 
            {
                request.Headers["Latest-Version-Number"] = StringUtils.FromInt(publicRequest.LatestVersionNumber);
            }
        
            if (publicRequest.IsSetVersionLabel()) 
            {
                request.Headers["VersionLabel"] = publicRequest.VersionLabel;
            }

            return request;
        }
        private static CreateHostedConfigurationVersionRequestMarshaller _instance = new CreateHostedConfigurationVersionRequestMarshaller();        

        internal static CreateHostedConfigurationVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHostedConfigurationVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}