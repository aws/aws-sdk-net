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
    /// Update Configuration Template Request Marshaller
    /// </summary>       
    public class UpdateConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, UpdateConfigurationTemplateRequest>
    {
        public IRequest Marshall(UpdateConfigurationTemplateRequest updateConfigurationTemplateRequest)
        {
            IRequest request = new DefaultRequest(updateConfigurationTemplateRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "UpdateConfigurationTemplate");
            request.Parameters.Add("Version", "2010-12-01");
            if (updateConfigurationTemplateRequest != null && updateConfigurationTemplateRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(updateConfigurationTemplateRequest.ApplicationName));
            }
            if (updateConfigurationTemplateRequest != null && updateConfigurationTemplateRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(updateConfigurationTemplateRequest.TemplateName));
            }
            if (updateConfigurationTemplateRequest != null && updateConfigurationTemplateRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(updateConfigurationTemplateRequest.Description));
            }

            if (updateConfigurationTemplateRequest != null)
            {
                List<ConfigurationOptionSetting> optionSettingsList = updateConfigurationTemplateRequest.OptionSettings;
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

            if (updateConfigurationTemplateRequest != null)
            {
                List<OptionSpecification> optionsToRemoveList = updateConfigurationTemplateRequest.OptionsToRemove;
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
