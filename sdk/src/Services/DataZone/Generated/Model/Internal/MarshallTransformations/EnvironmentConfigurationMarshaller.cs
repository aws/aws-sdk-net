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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnvironmentConfiguration Marshaller
    /// </summary>
    public class EnvironmentConfigurationMarshaller : IRequestMarshaller<EnvironmentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EnvironmentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountPools())
            {
                context.Writer.WritePropertyName("accountPools");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountPoolsListValue in requestObject.AccountPools)
                {
                        context.Writer.WriteStringValue(requestObjectAccountPoolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAwsAccount())
            {
                context.Writer.WritePropertyName("awsAccount");
                context.Writer.WriteStartObject();

                var marshaller = AwsAccountMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsAccount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsRegion())
            {
                context.Writer.WritePropertyName("awsRegion");
                context.Writer.WriteStartObject();

                var marshaller = RegionMarshaller.Instance;
                marshaller.Marshall(requestObject.AwsRegion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConfigurationParameters())
            {
                context.Writer.WritePropertyName("configurationParameters");
                context.Writer.WriteStartObject();

                var marshaller = EnvironmentConfigurationParametersDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurationParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeploymentMode())
            {
                context.Writer.WritePropertyName("deploymentMode");
                context.Writer.WriteStringValue(requestObject.DeploymentMode);
            }

            if(requestObject.IsSetDeploymentOrder())
            {
                context.Writer.WritePropertyName("deploymentOrder");
                context.Writer.WriteNumberValue(requestObject.DeploymentOrder.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetEnvironmentBlueprintId())
            {
                context.Writer.WritePropertyName("environmentBlueprintId");
                context.Writer.WriteStringValue(requestObject.EnvironmentBlueprintId);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EnvironmentConfigurationMarshaller Instance = new EnvironmentConfigurationMarshaller();

    }
}