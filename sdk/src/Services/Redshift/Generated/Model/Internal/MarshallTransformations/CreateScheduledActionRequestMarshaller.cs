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
    /// CreateScheduledAction Request Marshaller
    /// </summary>       
    public class CreateScheduledActionRequestMarshaller : IMarshaller<IRequest, CreateScheduledActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScheduledActionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScheduledActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "CreateScheduledAction");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEnable())
                {
                    request.Parameters.Add("Enable", StringUtils.FromBool(publicRequest.Enable));
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }
                if(publicRequest.IsSetIamRole())
                {
                    request.Parameters.Add("IamRole", StringUtils.FromString(publicRequest.IamRole));
                }
                if(publicRequest.IsSetSchedule())
                {
                    request.Parameters.Add("Schedule", StringUtils.FromString(publicRequest.Schedule));
                }
                if(publicRequest.IsSetScheduledActionDescription())
                {
                    request.Parameters.Add("ScheduledActionDescription", StringUtils.FromString(publicRequest.ScheduledActionDescription));
                }
                if(publicRequest.IsSetScheduledActionName())
                {
                    request.Parameters.Add("ScheduledActionName", StringUtils.FromString(publicRequest.ScheduledActionName));
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
                if(publicRequest.IsSetTargetAction())
                {
                    if(publicRequest.TargetAction.IsSetPauseCluster())
                    {
                        if(publicRequest.TargetAction.PauseCluster.IsSetClusterIdentifier())
                        {
                            request.Parameters.Add("TargetAction" + "." + "PauseCluster" + "." + "ClusterIdentifier", StringUtils.FromString(publicRequest.TargetAction.PauseCluster.ClusterIdentifier));
                        }
                    }
                    if(publicRequest.TargetAction.IsSetResizeCluster())
                    {
                        if(publicRequest.TargetAction.ResizeCluster.IsSetClassic())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "Classic", StringUtils.FromBool(publicRequest.TargetAction.ResizeCluster.Classic));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetClusterIdentifier())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "ClusterIdentifier", StringUtils.FromString(publicRequest.TargetAction.ResizeCluster.ClusterIdentifier));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetClusterType())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "ClusterType", StringUtils.FromString(publicRequest.TargetAction.ResizeCluster.ClusterType));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetNodeType())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "NodeType", StringUtils.FromString(publicRequest.TargetAction.ResizeCluster.NodeType));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetNumberOfNodes())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "NumberOfNodes", StringUtils.FromInt(publicRequest.TargetAction.ResizeCluster.NumberOfNodes));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetReservedNodeId())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "ReservedNodeId", StringUtils.FromString(publicRequest.TargetAction.ResizeCluster.ReservedNodeId));
                        }
                        if(publicRequest.TargetAction.ResizeCluster.IsSetTargetReservedNodeOfferingId())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResizeCluster" + "." + "TargetReservedNodeOfferingId", StringUtils.FromString(publicRequest.TargetAction.ResizeCluster.TargetReservedNodeOfferingId));
                        }
                    }
                    if(publicRequest.TargetAction.IsSetResumeCluster())
                    {
                        if(publicRequest.TargetAction.ResumeCluster.IsSetClusterIdentifier())
                        {
                            request.Parameters.Add("TargetAction" + "." + "ResumeCluster" + "." + "ClusterIdentifier", StringUtils.FromString(publicRequest.TargetAction.ResumeCluster.ClusterIdentifier));
                        }
                    }
                }
            }
            return request;
        }
                    private static CreateScheduledActionRequestMarshaller _instance = new CreateScheduledActionRequestMarshaller();        

        internal static CreateScheduledActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScheduledActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}