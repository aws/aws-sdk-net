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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVpcEncryptionControl Request Marshaller
    /// </summary>       
    public class ModifyVpcEncryptionControlRequestMarshaller : IMarshaller<IRequest, ModifyVpcEncryptionControlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEncryptionControlRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpcEncryptionControlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpcEncryptionControl");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEgressOnlyInternetGatewayExclusion())
                {
                    request.Parameters.Add("EgressOnlyInternetGatewayExclusion", StringUtils.FromString(publicRequest.EgressOnlyInternetGatewayExclusion));
                }
                if(publicRequest.IsSetElasticFileSystemExclusion())
                {
                    request.Parameters.Add("ElasticFileSystemExclusion", StringUtils.FromString(publicRequest.ElasticFileSystemExclusion));
                }
                if(publicRequest.IsSetInternetGatewayExclusion())
                {
                    request.Parameters.Add("InternetGatewayExclusion", StringUtils.FromString(publicRequest.InternetGatewayExclusion));
                }
                if(publicRequest.IsSetLambdaExclusion())
                {
                    request.Parameters.Add("LambdaExclusion", StringUtils.FromString(publicRequest.LambdaExclusion));
                }
                if(publicRequest.IsSetMode())
                {
                    request.Parameters.Add("Mode", StringUtils.FromString(publicRequest.Mode));
                }
                if(publicRequest.IsSetNatGatewayExclusion())
                {
                    request.Parameters.Add("NatGatewayExclusion", StringUtils.FromString(publicRequest.NatGatewayExclusion));
                }
                if(publicRequest.IsSetVirtualPrivateGatewayExclusion())
                {
                    request.Parameters.Add("VirtualPrivateGatewayExclusion", StringUtils.FromString(publicRequest.VirtualPrivateGatewayExclusion));
                }
                if(publicRequest.IsSetVpcEncryptionControlId())
                {
                    request.Parameters.Add("VpcEncryptionControlId", StringUtils.FromString(publicRequest.VpcEncryptionControlId));
                }
                if(publicRequest.IsSetVpcLatticeExclusion())
                {
                    request.Parameters.Add("VpcLatticeExclusion", StringUtils.FromString(publicRequest.VpcLatticeExclusion));
                }
                if(publicRequest.IsSetVpcPeeringExclusion())
                {
                    request.Parameters.Add("VpcPeeringExclusion", StringUtils.FromString(publicRequest.VpcPeeringExclusion));
                }
            }
            return request;
        }
                    private static ModifyVpcEncryptionControlRequestMarshaller _instance = new ModifyVpcEncryptionControlRequestMarshaller();        

        internal static ModifyVpcEncryptionControlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpcEncryptionControlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}