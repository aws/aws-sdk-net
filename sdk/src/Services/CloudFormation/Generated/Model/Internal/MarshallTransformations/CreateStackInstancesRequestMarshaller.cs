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
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateStackInstances Request Marshaller
    /// </summary>       
    public class CreateStackInstancesRequestMarshaller : IMarshaller<IRequest, CreateStackInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateStackInstancesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateStackInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "CreateStackInstances");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccounts())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Accounts)
                    {
                        request.Parameters.Add("Accounts" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCallAs())
                {
                    request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDeploymentTargets())
                {
                    if(publicRequest.DeploymentTargets.IsSetAccountFilterType())
                    {
                        request.Parameters.Add("DeploymentTargets" + "." + "AccountFilterType", StringUtils.FromString(publicRequest.DeploymentTargets.AccountFilterType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DeploymentTargets.IsSetAccounts())
                    {
                        int publicRequestDeploymentTargetslistValueIndex = 1;
                        foreach(var publicRequestDeploymentTargetslistValue in publicRequest.DeploymentTargets.Accounts)
                        {
                            request.Parameters.Add("DeploymentTargets" + "." + "Accounts" + "." + "member" + "." + publicRequestDeploymentTargetslistValueIndex, StringUtils.FromString(publicRequestDeploymentTargetslistValue));
                            publicRequestDeploymentTargetslistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DeploymentTargets.IsSetAccountsUrl())
                    {
                        request.Parameters.Add("DeploymentTargets" + "." + "AccountsUrl", StringUtils.FromString(publicRequest.DeploymentTargets.AccountsUrl));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.DeploymentTargets.IsSetOrganizationalUnitIds())
                    {
                        int publicRequestDeploymentTargetslistValueIndex = 1;
                        foreach(var publicRequestDeploymentTargetslistValue in publicRequest.DeploymentTargets.OrganizationalUnitIds)
                        {
                            request.Parameters.Add("DeploymentTargets" + "." + "OrganizationalUnitIds" + "." + "member" + "." + publicRequestDeploymentTargetslistValueIndex, StringUtils.FromString(publicRequestDeploymentTargetslistValue));
                            publicRequestDeploymentTargetslistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOperationId())
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
                }
                else if(!(publicRequest.IsSetOperationId()))
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOperationPreferences())
                {
                    if(publicRequest.OperationPreferences.IsSetConcurrencyMode())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "ConcurrencyMode", StringUtils.FromString(publicRequest.OperationPreferences.ConcurrencyMode));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetFailureToleranceCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureToleranceCount", StringUtils.FromInt(publicRequest.OperationPreferences.FailureToleranceCount));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetFailureTolerancePercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureTolerancePercentage", StringUtils.FromInt(publicRequest.OperationPreferences.FailureTolerancePercentage));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentCount", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentCount));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentPercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentPercentage", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentPercentage));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetRegionConcurrencyType())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "RegionConcurrencyType", StringUtils.FromString(publicRequest.OperationPreferences.RegionConcurrencyType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OperationPreferences.IsSetRegionOrder())
                    {
                        int publicRequestOperationPreferenceslistValueIndex = 1;
                        foreach(var publicRequestOperationPreferenceslistValue in publicRequest.OperationPreferences.RegionOrder)
                        {
                            request.Parameters.Add("OperationPreferences" + "." + "RegionOrder" + "." + "member" + "." + publicRequestOperationPreferenceslistValueIndex, StringUtils.FromString(publicRequestOperationPreferenceslistValue));
                            publicRequestOperationPreferenceslistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetParameterOverrides())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ParameterOverrides)
                    {
                        if(publicRequestlistValue.IsSetParameterKey())
                        {
                            request.Parameters.Add("ParameterOverrides" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterKey", StringUtils.FromString(publicRequestlistValue.ParameterKey));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetParameterValue())
                        {
                            request.Parameters.Add("ParameterOverrides" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ParameterValue", StringUtils.FromString(publicRequestlistValue.ParameterValue));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetResolvedValue())
                        {
                            request.Parameters.Add("ParameterOverrides" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResolvedValue", StringUtils.FromString(publicRequestlistValue.ResolvedValue));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetUsePreviousValue())
                        {
                            request.Parameters.Add("ParameterOverrides" + "." + "member" + "." + publicRequestlistValueIndex + "." + "UsePreviousValue", StringUtils.FromBool(publicRequestlistValue.UsePreviousValue));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetRegions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Regions)
                    {
                        request.Parameters.Add("Regions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStackSetName())
                {
                    request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateStackInstancesRequestMarshaller _instance = new CreateStackInstancesRequestMarshaller();        

        internal static CreateStackInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateStackInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}