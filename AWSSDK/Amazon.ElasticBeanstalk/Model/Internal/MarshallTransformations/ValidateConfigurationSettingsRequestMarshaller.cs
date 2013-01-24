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
    /// Validate Configuration Settings Request Marshaller
    /// </summary>       
    public class ValidateConfigurationSettingsRequestMarshaller : IMarshaller<IRequest, ValidateConfigurationSettingsRequest>
    {
        public IRequest Marshall(ValidateConfigurationSettingsRequest validateConfigurationSettingsRequest)
        {
            IRequest request = new DefaultRequest(validateConfigurationSettingsRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "ValidateConfigurationSettings");
            request.Parameters.Add("Version", "2010-12-01");
            if (validateConfigurationSettingsRequest != null && validateConfigurationSettingsRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(validateConfigurationSettingsRequest.ApplicationName));
            }
            if (validateConfigurationSettingsRequest != null && validateConfigurationSettingsRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(validateConfigurationSettingsRequest.TemplateName));
            }
            if (validateConfigurationSettingsRequest != null && validateConfigurationSettingsRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(validateConfigurationSettingsRequest.EnvironmentName));
            }

            if (validateConfigurationSettingsRequest != null)
            {
                List<ConfigurationOptionSetting> optionSettingsList = validateConfigurationSettingsRequest.OptionSettings;
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
