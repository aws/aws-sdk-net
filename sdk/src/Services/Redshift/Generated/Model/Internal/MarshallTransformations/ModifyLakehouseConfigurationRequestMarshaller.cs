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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyLakehouseConfiguration Request Marshaller
    /// </summary>       
    public class ModifyLakehouseConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyLakehouseConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyLakehouseConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyLakehouseConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "ModifyLakehouseConfiguration");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCatalogName())
                {
                    request.Parameters.Add("CatalogName", StringUtils.FromString(publicRequest.CatalogName));
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetLakehouseIdcApplicationArn())
                {
                    request.Parameters.Add("LakehouseIdcApplicationArn", StringUtils.FromString(publicRequest.LakehouseIdcApplicationArn));
                }
                if(publicRequest.IsSetLakehouseIdcRegistration())
                {
                    request.Parameters.Add("LakehouseIdcRegistration", StringUtils.FromString(publicRequest.LakehouseIdcRegistration));
                }
                if(publicRequest.IsSetLakehouseRegistration())
                {
                    request.Parameters.Add("LakehouseRegistration", StringUtils.FromString(publicRequest.LakehouseRegistration));
                }
            }
            return request;
        }
                    private static ModifyLakehouseConfigurationRequestMarshaller _instance = new ModifyLakehouseConfigurationRequestMarshaller();        

        internal static ModifyLakehouseConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyLakehouseConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}