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
    /// Create Configuration Template Request Marshaller
    /// </summary>       
    public class CreateConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, CreateConfigurationTemplateRequest>
    {
        public IRequest Marshall(CreateConfigurationTemplateRequest createConfigurationTemplateRequest)
        {
            IRequest request = new DefaultRequest(createConfigurationTemplateRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "CreateConfigurationTemplate");
            request.Parameters.Add("Version", "2010-12-01");
            if (createConfigurationTemplateRequest != null && createConfigurationTemplateRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(createConfigurationTemplateRequest.ApplicationName));
            }
            if (createConfigurationTemplateRequest != null && createConfigurationTemplateRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(createConfigurationTemplateRequest.TemplateName));
            }
            if (createConfigurationTemplateRequest != null && createConfigurationTemplateRequest.IsSetSolutionStackName())
            {
                request.Parameters.Add("SolutionStackName", StringUtils.FromString(createConfigurationTemplateRequest.SolutionStackName));
            }
            if (createConfigurationTemplateRequest != null)
            {
                SourceConfiguration sourceConfiguration = createConfigurationTemplateRequest.SourceConfiguration;
                if (sourceConfiguration != null && sourceConfiguration.IsSetApplicationName())
                {
                    request.Parameters.Add("SourceConfiguration.ApplicationName", StringUtils.FromString(sourceConfiguration.ApplicationName));
                }
                if (sourceConfiguration != null && sourceConfiguration.IsSetTemplateName())
                {
                    request.Parameters.Add("SourceConfiguration.TemplateName", StringUtils.FromString(sourceConfiguration.TemplateName));
                }
            }
            if (createConfigurationTemplateRequest != null && createConfigurationTemplateRequest.IsSetEnvironmentId())
            {
                request.Parameters.Add("EnvironmentId", StringUtils.FromString(createConfigurationTemplateRequest.EnvironmentId));
            }
            if (createConfigurationTemplateRequest != null && createConfigurationTemplateRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(createConfigurationTemplateRequest.Description));
            }

            if (createConfigurationTemplateRequest != null)
            {
                List<ConfigurationOptionSetting> optionSettingsList = createConfigurationTemplateRequest.OptionSettings;
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

            return request;
        }
    }
}
