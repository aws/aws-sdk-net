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
    /// ModifyAccountVpcEncryptionControl Request Marshaller
    /// </summary>       
    public class ModifyAccountVpcEncryptionControlRequestMarshaller : IMarshaller<IRequest, ModifyAccountVpcEncryptionControlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyAccountVpcEncryptionControlRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyAccountVpcEncryptionControlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyAccountVpcEncryptionControl");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEgressOnlyInternetGateway())
                {
                    request.Parameters.Add("EgressOnlyInternetGateway", StringUtils.FromString(publicRequest.EgressOnlyInternetGateway));
                }
                if(publicRequest.IsSetElasticFileSystem())
                {
                    request.Parameters.Add("ElasticFileSystem", StringUtils.FromString(publicRequest.ElasticFileSystem));
                }
                if(publicRequest.IsSetInternetGateway())
                {
                    request.Parameters.Add("InternetGateway", StringUtils.FromString(publicRequest.InternetGateway));
                }
                if(publicRequest.IsSetLambda())
                {
                    request.Parameters.Add("Lambda", StringUtils.FromString(publicRequest.Lambda));
                }
                if(publicRequest.IsSetMode())
                {
                    request.Parameters.Add("Mode", StringUtils.FromString(publicRequest.Mode));
                }
                if(publicRequest.IsSetNatGateway())
                {
                    request.Parameters.Add("NatGateway", StringUtils.FromString(publicRequest.NatGateway));
                }
                if(publicRequest.IsSetVirtualPrivateGateway())
                {
                    request.Parameters.Add("VirtualPrivateGateway", StringUtils.FromString(publicRequest.VirtualPrivateGateway));
                }
                if(publicRequest.IsSetVpcLattice())
                {
                    request.Parameters.Add("VpcLattice", StringUtils.FromString(publicRequest.VpcLattice));
                }
                if(publicRequest.IsSetVpcPeering())
                {
                    request.Parameters.Add("VpcPeering", StringUtils.FromString(publicRequest.VpcPeering));
                }
            }

            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
            return request;
        }
                    private static ModifyAccountVpcEncryptionControlRequestMarshaller _instance = new ModifyAccountVpcEncryptionControlRequestMarshaller();        

        internal static ModifyAccountVpcEncryptionControlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyAccountVpcEncryptionControlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}