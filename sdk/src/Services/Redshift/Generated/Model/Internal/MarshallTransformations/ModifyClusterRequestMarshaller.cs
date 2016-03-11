/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// ModifyCluster Request Marshaller
    /// </summary>       
    public class ModifyClusterRequestMarshaller : IMarshaller<IRequest, ModifyClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyClusterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "ModifyCluster");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllowVersionUpgrade())
                {
                    request.Parameters.Add("AllowVersionUpgrade", StringUtils.FromBool(publicRequest.AllowVersionUpgrade));
                }
                if(publicRequest.IsSetAutomatedSnapshotRetentionPeriod())
                {
                    request.Parameters.Add("AutomatedSnapshotRetentionPeriod", StringUtils.FromInt(publicRequest.AutomatedSnapshotRetentionPeriod));
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetClusterParameterGroupName())
                {
                    request.Parameters.Add("ClusterParameterGroupName", StringUtils.FromString(publicRequest.ClusterParameterGroupName));
                }
                if(publicRequest.IsSetClusterSecurityGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ClusterSecurityGroups)
                    {
                        request.Parameters.Add("ClusterSecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetClusterType())
                {
                    request.Parameters.Add("ClusterType", StringUtils.FromString(publicRequest.ClusterType));
                }
                if(publicRequest.IsSetClusterVersion())
                {
                    request.Parameters.Add("ClusterVersion", StringUtils.FromString(publicRequest.ClusterVersion));
                }
                if(publicRequest.IsSetElasticIp())
                {
                    request.Parameters.Add("ElasticIp", StringUtils.FromString(publicRequest.ElasticIp));
                }
                if(publicRequest.IsSetHsmClientCertificateIdentifier())
                {
                    request.Parameters.Add("HsmClientCertificateIdentifier", StringUtils.FromString(publicRequest.HsmClientCertificateIdentifier));
                }
                if(publicRequest.IsSetHsmConfigurationIdentifier())
                {
                    request.Parameters.Add("HsmConfigurationIdentifier", StringUtils.FromString(publicRequest.HsmConfigurationIdentifier));
                }
                if(publicRequest.IsSetMasterUserPassword())
                {
                    request.Parameters.Add("MasterUserPassword", StringUtils.FromString(publicRequest.MasterUserPassword));
                }
                if(publicRequest.IsSetNewClusterIdentifier())
                {
                    request.Parameters.Add("NewClusterIdentifier", StringUtils.FromString(publicRequest.NewClusterIdentifier));
                }
                if(publicRequest.IsSetNodeType())
                {
                    request.Parameters.Add("NodeType", StringUtils.FromString(publicRequest.NodeType));
                }
                if(publicRequest.IsSetNumberOfNodes())
                {
                    request.Parameters.Add("NumberOfNodes", StringUtils.FromInt(publicRequest.NumberOfNodes));
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
    }
}