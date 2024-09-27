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
    /// UpdateStackSet Request Marshaller
    /// </summary>       
    public class UpdateStackSetRequestMarshaller : IMarshaller<IRequest, UpdateStackSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateStackSetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateStackSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "UpdateStackSet");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccounts())
                {
                    if (publicRequest.Accounts.Count == 0)
                        request.Parameters.Add("Accounts", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Accounts)
                         {
                             request.Parameters.Add("Accounts" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAdministrationRoleARN())
                {
                    request.Parameters.Add("AdministrationRoleARN", StringUtils.FromString(publicRequest.AdministrationRoleARN));
                }
                if(publicRequest.IsSetAutoDeployment())
                {
                    if(publicRequest.AutoDeployment.IsSetEnabled())
                    {
                        request.Parameters.Add("AutoDeployment" + "." + "Enabled", StringUtils.FromBool(publicRequest.AutoDeployment.Enabled));
                    }
                    if(publicRequest.AutoDeployment.IsSetRetainStacksOnAccountRemoval())
                    {
                        request.Parameters.Add("AutoDeployment" + "." + "RetainStacksOnAccountRemoval", StringUtils.FromBool(publicRequest.AutoDeployment.RetainStacksOnAccountRemoval));
                    }
                }
                if(publicRequest.IsSetCallAs())
                {
                    request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
                }
                if(publicRequest.IsSetCapabilities())
                {
                    if (publicRequest.Capabilities.Count == 0)
                        request.Parameters.Add("Capabilities", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Capabilities)
                         {
                             request.Parameters.Add("Capabilities" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDeploymentTargets())
                {
                    if(publicRequest.DeploymentTargets.IsSetAccountFilterType())
                    {
                        request.Parameters.Add("DeploymentTargets" + "." + "AccountFilterType", StringUtils.FromString(publicRequest.DeploymentTargets.AccountFilterType));
                    }
                    if(publicRequest.DeploymentTargets.IsSetAccounts())
                    {
                        if (publicRequest.DeploymentTargets.Accounts.Count == 0)
                            request.Parameters.Add("DeploymentTargets" + "." + "Accounts", "");
                        else
                        {
                             int publicRequestDeploymentTargetslistValueIndex = 1;
                             foreach(var publicRequestDeploymentTargetslistValue in publicRequest.DeploymentTargets.Accounts)
                             {
                                 request.Parameters.Add("DeploymentTargets" + "." + "Accounts" + "." + "member" + "." + publicRequestDeploymentTargetslistValueIndex, StringUtils.FromString(publicRequestDeploymentTargetslistValue));
                                 publicRequestDeploymentTargetslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.DeploymentTargets.IsSetAccountsUrl())
                    {
                        request.Parameters.Add("DeploymentTargets" + "." + "AccountsUrl", StringUtils.FromString(publicRequest.DeploymentTargets.AccountsUrl));
                    }
                    if(publicRequest.DeploymentTargets.IsSetOrganizationalUnitIds())
                    {
                        if (publicRequest.DeploymentTargets.OrganizationalUnitIds.Count == 0)
                            request.Parameters.Add("DeploymentTargets" + "." + "OrganizationalUnitIds", "");
                        else
                        {
                             int publicRequestDeploymentTargetslistValueIndex = 1;
                             foreach(var publicRequestDeploymentTargetslistValue in publicRequest.DeploymentTargets.OrganizationalUnitIds)
                             {
                                 request.Parameters.Add("DeploymentTargets" + "." + "OrganizationalUnitIds" + "." + "member" + "." + publicRequestDeploymentTargetslistValueIndex, StringUtils.FromString(publicRequestDeploymentTargetslistValue));
                                 publicRequestDeploymentTargetslistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetExecutionRoleName())
                {
                    request.Parameters.Add("ExecutionRoleName", StringUtils.FromString(publicRequest.ExecutionRoleName));
                }
                if(publicRequest.IsSetManagedExecution())
                {
                    if(publicRequest.ManagedExecution.IsSetActive())
                    {
                        request.Parameters.Add("ManagedExecution" + "." + "Active", StringUtils.FromBool(publicRequest.ManagedExecution.Active));
                    }
                }
                if(publicRequest.IsSetOperationId())
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
                }
                else if(!(publicRequest.IsSetOperationId()))
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetOperationPreferences())
                {
                    if(publicRequest.OperationPreferences.IsSetConcurrencyMode())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "ConcurrencyMode", StringUtils.FromString(publicRequest.OperationPreferences.ConcurrencyMode));
                    }
                    if(publicRequest.OperationPreferences.IsSetFailureToleranceCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureToleranceCount", StringUtils.FromInt(publicRequest.OperationPreferences.FailureToleranceCount));
                    }
                    if(publicRequest.OperationPreferences.IsSetFailureTolerancePercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "FailureTolerancePercentage", StringUtils.FromInt(publicRequest.OperationPreferences.FailureTolerancePercentage));
                    }
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentCount())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentCount", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentCount));
                    }
                    if(publicRequest.OperationPreferences.IsSetMaxConcurrentPercentage())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "MaxConcurrentPercentage", StringUtils.FromInt(publicRequest.OperationPreferences.MaxConcurrentPercentage));
                    }
                    if(publicRequest.OperationPreferences.IsSetRegionConcurrencyType())
                    {
                        request.Parameters.Add("OperationPreferences" + "." + "RegionConcurrencyType", StringUtils.FromString(publicRequest.OperationPreferences.RegionConcurrencyType));
                    }
                    if(publicRequest.OperationPreferences.IsSetRegionOrder())
                    {
                        if (publicRequest.OperationPreferences.RegionOrder.Count == 0)
                            request.Parameters.Add("OperationPreferences" + "." + "RegionOrder", "");
                        else
                        {
                             int publicRequestOperationPreferenceslistValueIndex = 1;
                             foreach(var publicRequestOperationPreferenceslistValue in publicRequest.OperationPreferences.RegionOrder)
                             {
                                 request.Parameters.Add("OperationPreferences" + "." + "RegionOrder" + "." + "member" + "." + publicRequestOperationPreferenceslistValueIndex, StringUtils.FromString(publicRequestOperationPreferenceslistValue));
                                 publicRequestOperationPreferenceslistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetParameters())
                {
                    if (publicRequest.Parameters.Count == 0)
                        request.Parameters.Add("Parameters", "");
                    else
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
                            if(publicRequestlistValue.IsSetResolvedValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResolvedValue", StringUtils.FromString(publicRequestlistValue.ResolvedValue));
                            }
                            if(publicRequestlistValue.IsSetUsePreviousValue())
                            {
                                request.Parameters.Add("Parameters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "UsePreviousValue", StringUtils.FromBool(publicRequestlistValue.UsePreviousValue));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetPermissionModel())
                {
                    request.Parameters.Add("PermissionModel", StringUtils.FromString(publicRequest.PermissionModel));
                }
                if(publicRequest.IsSetRegions())
                {
                    if (publicRequest.Regions.Count == 0)
                        request.Parameters.Add("Regions", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Regions)
                         {
                             request.Parameters.Add("Regions" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetStackSetName())
                {
                    request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
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
                    private static UpdateStackSetRequestMarshaller _instance = new UpdateStackSetRequestMarshaller();        

        internal static UpdateStackSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateStackSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}