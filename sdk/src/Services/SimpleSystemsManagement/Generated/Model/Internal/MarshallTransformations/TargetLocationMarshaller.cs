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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetLocation Marshaller
    /// </summary>
    public class TargetLocationMarshaller : IRequestMarshaller<TargetLocation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TargetLocation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccounts())
            {
                context.Writer.WritePropertyName("Accounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountsListValue in requestObject.Accounts)
                {
                        context.Writer.WriteStringValue(requestObjectAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludeAccounts())
            {
                context.Writer.WritePropertyName("ExcludeAccounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeAccountsListValue in requestObject.ExcludeAccounts)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExecutionRoleName())
            {
                context.Writer.WritePropertyName("ExecutionRoleName");
                context.Writer.WriteStringValue(requestObject.ExecutionRoleName);
            }

            if(requestObject.IsSetIncludeChildOrganizationUnits())
            {
                context.Writer.WritePropertyName("IncludeChildOrganizationUnits");
                context.Writer.WriteBooleanValue(requestObject.IncludeChildOrganizationUnits.Value);
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("Regions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.WriteStringValue(requestObjectRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetLocationAlarmConfiguration())
            {
                context.Writer.WritePropertyName("TargetLocationAlarmConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlarmConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetLocationAlarmConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetLocationMaxConcurrency())
            {
                context.Writer.WritePropertyName("TargetLocationMaxConcurrency");
                context.Writer.WriteStringValue(requestObject.TargetLocationMaxConcurrency);
            }

            if(requestObject.IsSetTargetLocationMaxErrors())
            {
                context.Writer.WritePropertyName("TargetLocationMaxErrors");
                context.Writer.WriteStringValue(requestObject.TargetLocationMaxErrors);
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetsListValue in requestObject.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetsMaxConcurrency())
            {
                context.Writer.WritePropertyName("TargetsMaxConcurrency");
                context.Writer.WriteStringValue(requestObject.TargetsMaxConcurrency);
            }

            if(requestObject.IsSetTargetsMaxErrors())
            {
                context.Writer.WritePropertyName("TargetsMaxErrors");
                context.Writer.WriteStringValue(requestObject.TargetsMaxErrors);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetLocationMarshaller Instance = new TargetLocationMarshaller();

    }
}