/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Environment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest>
    {
        public IRequest Marshall(CreateEnvironmentRequest createEnvironmentRequest)
        {
            IRequest request = new DefaultRequest(createEnvironmentRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "CreateEnvironment");
            request.Parameters.Add("Version", "2010-12-01");
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(createEnvironmentRequest.ApplicationName));
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(createEnvironmentRequest.EnvironmentName));
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createEnvironmentRequest.Description));
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetCNAMEPrefix())
            {
                request.Parameters.Add("CNAMEPrefix", StringUtils.FromString(createEnvironmentRequest.CNAMEPrefix));
            }
            if (createEnvironmentRequest != null)
            {
                EnvironmentTier tier = createEnvironmentRequest.Tier;
                if (tier != null && tier.IsSetName())
                {
                    request.Parameters.Add("Tier.Name", StringUtils.FromString(tier.Name));
                }
                if (tier != null && tier.IsSetType())
                {
                    request.Parameters.Add("Tier.Type", StringUtils.FromString(tier.Type));
                }
                if (tier != null && tier.IsSetVersion())
                {
                    request.Parameters.Add("Tier.Version", StringUtils.FromString(tier.Version));
                }
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(createEnvironmentRequest.VersionLabel));
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(createEnvironmentRequest.TemplateName));
            }
            if (createEnvironmentRequest != null && createEnvironmentRequest.IsSetSolutionStackName())
            {
                request.Parameters.Add("SolutionStackName", StringUtils.FromString(createEnvironmentRequest.SolutionStackName));
            }

            if (createEnvironmentRequest != null)
            {
                List<ConfigurationOptionSetting> optionSettingsList = createEnvironmentRequest.OptionSettings;
                int optionSettingsListIndex = 1;
                foreach (ConfigurationOptionSetting optionSettingsListValue in optionSettingsList)
                {
                    if (optionSettingsListValue != null && optionSettingsListValue.IsSetNamespace())
                    {
                        request.Parameters.Add("OptionSettings.member." + optionSettingsListIndex + ".Namespace", StringUtils.FromString(optionSettingsListValue.Namespace));
                    }
                    if (optionSettingsListValue != null && optionSettingsListValue.IsSetOptionName())
                    {
                        request.Parameters.Add("OptionSettings.member." + optionSettingsListIndex + ".OptionName", StringUtils.FromString(optionSettingsListValue.OptionName));
                    }
                    if (optionSettingsListValue != null && optionSettingsListValue.IsSetValue())
                    {
                        request.Parameters.Add("OptionSettings.member." + optionSettingsListIndex + ".Value", StringUtils.FromString(optionSettingsListValue.Value));
                    }

                    optionSettingsListIndex++;
                }
            }

            if (createEnvironmentRequest != null)
            {
                List<OptionSpecification> optionsToRemoveList = createEnvironmentRequest.OptionsToRemove;
                int optionsToRemoveListIndex = 1;
                foreach (OptionSpecification optionsToRemoveListValue in optionsToRemoveList)
                {
                    if (optionsToRemoveListValue != null && optionsToRemoveListValue.IsSetNamespace())
                    {
                        request.Parameters.Add("OptionsToRemove.member." + optionsToRemoveListIndex + ".Namespace", StringUtils.FromString(optionsToRemoveListValue.Namespace));
                    }
                    if (optionsToRemoveListValue != null && optionsToRemoveListValue.IsSetOptionName())
                    {
                        request.Parameters.Add("OptionsToRemove.member." + optionsToRemoveListIndex + ".OptionName", StringUtils.FromString(optionsToRemoveListValue.OptionName));
                    }

                    optionsToRemoveListIndex++;
                }
            }

            return request;
        }
    }
}
