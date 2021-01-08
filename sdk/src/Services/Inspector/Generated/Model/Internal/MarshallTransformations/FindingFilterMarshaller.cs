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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FindingFilter Marshaller
    /// </summary>       
    public class FindingFilterMarshaller : IRequestMarshaller<FindingFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FindingFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAgentIds())
            {
                context.Writer.WritePropertyName("agentIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAgentIdsListValue in requestObject.AgentIds)
                {
                        context.Writer.Write(requestObjectAgentIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAutoScalingGroups())
            {
                context.Writer.WritePropertyName("autoScalingGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAutoScalingGroupsListValue in requestObject.AutoScalingGroups)
                {
                        context.Writer.Write(requestObjectAutoScalingGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreationTimeRange())
            {
                context.Writer.WritePropertyName("creationTimeRange");
                context.Writer.WriteObjectStart();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.CreationTimeRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuleNames())
            {
                context.Writer.WritePropertyName("ruleNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRuleNamesListValue in requestObject.RuleNames)
                {
                        context.Writer.Write(requestObjectRuleNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRulesPackageArns())
            {
                context.Writer.WritePropertyName("rulesPackageArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRulesPackageArnsListValue in requestObject.RulesPackageArns)
                {
                        context.Writer.Write(requestObjectRulesPackageArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverities())
            {
                context.Writer.WritePropertyName("severities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeveritiesListValue in requestObject.Severities)
                {
                        context.Writer.Write(requestObjectSeveritiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserAttributes())
            {
                context.Writer.WritePropertyName("userAttributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserAttributesListValue in requestObject.UserAttributes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserAttributesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FindingFilterMarshaller Instance = new FindingFilterMarshaller();

    }
}