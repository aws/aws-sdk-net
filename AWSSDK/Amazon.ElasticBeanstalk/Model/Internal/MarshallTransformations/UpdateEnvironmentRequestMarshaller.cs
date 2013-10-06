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
    /// Update Environment Request Marshaller
    /// </summary>       
    public class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest>
    {
        public IRequest Marshall(UpdateEnvironmentRequest updateEnvironmentRequest)
        {
            IRequest request = new DefaultRequest(updateEnvironmentRequest, "AmazonElasticBeanstalk");
            request.Parameters.Add("Action", "UpdateEnvironment");
            request.Parameters.Add("Version", "2010-12-01");
            if (updateEnvironmentRequest != null && updateEnvironmentRequest.IsSetEnvironmentId())
            {
                request.Parameters.Add("EnvironmentId", StringUtils.FromString(updateEnvironmentRequest.EnvironmentId));
            }
            if (updateEnvironmentRequest != null && updateEnvironmentRequest.IsSetEnvironmentName())
            {
                request.Parameters.Add("EnvironmentName", StringUtils.FromString(updateEnvironmentRequest.EnvironmentName));
            }
            if (updateEnvironmentRequest != null && updateEnvironmentRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(updateEnvironmentRequest.VersionLabel));
            }
            if (updateEnvironmentRequest != null && updateEnvironmentRequest.IsSetTemplateName())
            {
                request.Parameters.Add("TemplateName", StringUtils.FromString(updateEnvironmentRequest.TemplateName));
            }
            if (updateEnvironmentRequest != null && updateEnvironmentRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(updateEnvironmentRequest.Description));
            }

            if (updateEnvironmentRequest != null)
            {
                List<ConfigurationOptionSetting> optionSettingsList = updateEnvironmentRequest.OptionSettings;
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

            if (updateEnvironmentRequest != null)
            {
                List<OptionSpecification> optionsToRemoveList = updateEnvironmentRequest.OptionsToRemove;
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
