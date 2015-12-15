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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateStack Request Marshaller
    /// </summary>       
    public class UpdateStackRequestMarshaller : IMarshaller<IRequest, UpdateStackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackRequest)input);
        }
    
        public IRequest Marshall(UpdateStackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "UpdateStack");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCapabilities())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Capabilities)
                    {
                        request.Parameters.Add("Capabilities" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetNotificationARNs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.NotificationARNs)
                    {
                        request.Parameters.Add("NotificationARNs" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetParameters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Parameters)
                    {
                        if(publicRequestlistValue.IsSetParameterKey())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterKey", StringUtils.FromString(publicRequestlistValue.ParameterKey));
                        }
                        if(publicRequestlistValue.IsSetParameterValue())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                        }
                        if(publicRequestlistValue.IsSetUsePreviousValue())
                        {
                            request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "UsePreviousValue", StringUtils.FromBool(publicRequestlistValue.UsePreviousValue));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetResourceTypes())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ResourceTypes)
                    {
                        request.Parameters.Add("ResourceTypes" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetStackName())
                {
                    request.Parameters.Add("StackName", StringUtils.FromString(publicRequest.StackName));
                }
                if(publicRequest.IsSetStackPolicyBody())
                {
                    request.Parameters.Add("StackPolicyBody", StringUtils.FromString(publicRequest.StackPolicyBody));
                }
                if(publicRequest.IsSetStackPolicyDuringUpdateBody())
                {
                    request.Parameters.Add("StackPolicyDuringUpdateBody", StringUtils.FromString(publicRequest.StackPolicyDuringUpdateBody));
                }
                if(publicRequest.IsSetStackPolicyDuringUpdateURL())
                {
                    request.Parameters.Add("StackPolicyDuringUpdateURL", StringUtils.FromString(publicRequest.StackPolicyDuringUpdateURL));
                }
                if(publicRequest.IsSetStackPolicyURL())
                {
                    request.Parameters.Add("StackPolicyURL", StringUtils.FromString(publicRequest.StackPolicyURL));
                }
                if(publicRequest.IsSetTemplateBody())
                {
                    request.Parameters.Add("TemplateBody", StringUtils.FromString(publicRequest.TemplateBody));
                }
                if(publicRequest.IsSetTemplateURL())
                {
                    request.Parameters.Add("TemplateURL", StringUtils.FromString(publicRequest.TemplateURL));
                }
                if(publicRequest.IsSetUsePreviousTemplate())
                {
                    request.Parameters.Add("UsePreviousTemplate", StringUtils.FromBool(publicRequest.UsePreviousTemplate));
                }
            }
            return request;
        }
    }
}