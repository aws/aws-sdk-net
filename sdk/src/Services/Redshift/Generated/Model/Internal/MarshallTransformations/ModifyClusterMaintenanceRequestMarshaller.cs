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
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyClusterMaintenance Request Marshaller
    /// </summary>       
    public class ModifyClusterMaintenanceRequestMarshaller : IMarshaller<IRequest, ModifyClusterMaintenanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyClusterMaintenanceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyClusterMaintenanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "ModifyClusterMaintenance");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetDeferMaintenance())
                {
                    request.Parameters.Add("DeferMaintenance", StringUtils.FromBool(publicRequest.DeferMaintenance));
                }
                if(publicRequest.IsSetDeferMaintenanceDuration())
                {
                    request.Parameters.Add("DeferMaintenanceDuration", StringUtils.FromInt(publicRequest.DeferMaintenanceDuration));
                }
                if(publicRequest.IsSetDeferMaintenanceEndTime())
                {
                    request.Parameters.Add("DeferMaintenanceEndTime", StringUtils.FromDateTimeToISO8601(publicRequest.DeferMaintenanceEndTime));
                }
                if(publicRequest.IsSetDeferMaintenanceIdentifier())
                {
                    request.Parameters.Add("DeferMaintenanceIdentifier", StringUtils.FromString(publicRequest.DeferMaintenanceIdentifier));
                }
                if(publicRequest.IsSetDeferMaintenanceStartTime())
                {
                    request.Parameters.Add("DeferMaintenanceStartTime", StringUtils.FromDateTimeToISO8601(publicRequest.DeferMaintenanceStartTime));
                }
            }
            return request;
        }
                    private static ModifyClusterMaintenanceRequestMarshaller _instance = new ModifyClusterMaintenanceRequestMarshaller();        

        internal static ModifyClusterMaintenanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyClusterMaintenanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}