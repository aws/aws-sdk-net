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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsElasticBeanstalkEnvironmentDetails Marshaller
    /// </summary>       
    public class AwsElasticBeanstalkEnvironmentDetailsMarshaller : IRequestMarshaller<AwsElasticBeanstalkEnvironmentDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsElasticBeanstalkEnvironmentDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApplicationName())
            {
                context.Writer.WritePropertyName("ApplicationName");
                context.Writer.Write(requestObject.ApplicationName);
            }

            if(requestObject.IsSetCname())
            {
                context.Writer.WritePropertyName("Cname");
                context.Writer.Write(requestObject.Cname);
            }

            if(requestObject.IsSetDateCreated())
            {
                context.Writer.WritePropertyName("DateCreated");
                context.Writer.Write(requestObject.DateCreated);
            }

            if(requestObject.IsSetDateUpdated())
            {
                context.Writer.WritePropertyName("DateUpdated");
                context.Writer.Write(requestObject.DateUpdated);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEndpointUrl())
            {
                context.Writer.WritePropertyName("EndpointUrl");
                context.Writer.Write(requestObject.EndpointUrl);
            }

            if(requestObject.IsSetEnvironmentArn())
            {
                context.Writer.WritePropertyName("EnvironmentArn");
                context.Writer.Write(requestObject.EnvironmentArn);
            }

            if(requestObject.IsSetEnvironmentId())
            {
                context.Writer.WritePropertyName("EnvironmentId");
                context.Writer.Write(requestObject.EnvironmentId);
            }

            if(requestObject.IsSetEnvironmentLinks())
            {
                context.Writer.WritePropertyName("EnvironmentLinks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnvironmentLinksListValue in requestObject.EnvironmentLinks)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsElasticBeanstalkEnvironmentEnvironmentLinkMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvironmentLinksListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironmentName())
            {
                context.Writer.WritePropertyName("EnvironmentName");
                context.Writer.Write(requestObject.EnvironmentName);
            }

            if(requestObject.IsSetOptionSettings())
            {
                context.Writer.WritePropertyName("OptionSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOptionSettingsListValue in requestObject.OptionSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsElasticBeanstalkEnvironmentOptionSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectOptionSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlatformArn())
            {
                context.Writer.WritePropertyName("PlatformArn");
                context.Writer.Write(requestObject.PlatformArn);
            }

            if(requestObject.IsSetSolutionStackName())
            {
                context.Writer.WritePropertyName("SolutionStackName");
                context.Writer.Write(requestObject.SolutionStackName);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetTier())
            {
                context.Writer.WritePropertyName("Tier");
                context.Writer.WriteObjectStart();

                var marshaller = AwsElasticBeanstalkEnvironmentTierMarshaller.Instance;
                marshaller.Marshall(requestObject.Tier, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVersionLabel())
            {
                context.Writer.WritePropertyName("VersionLabel");
                context.Writer.Write(requestObject.VersionLabel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsElasticBeanstalkEnvironmentDetailsMarshaller Instance = new AwsElasticBeanstalkEnvironmentDetailsMarshaller();

    }
}