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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceFilterCriteria Marshaller
    /// </summary>
    public class ResourceFilterCriteriaMarshaller : IRequestMarshaller<ResourceFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("accountId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdListValue in requestObject.AccountId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2InstanceTags())
            {
                context.Writer.WritePropertyName("ec2InstanceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2InstanceTagsListValue in requestObject.Ec2InstanceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageTags())
            {
                context.Writer.WritePropertyName("ecrImageTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageTagsListValue in requestObject.EcrImageTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrRepositoryName())
            {
                context.Writer.WritePropertyName("ecrRepositoryName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrRepositoryNameListValue in requestObject.EcrRepositoryName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrRepositoryNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionName())
            {
                context.Writer.WritePropertyName("lambdaFunctionName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionNameListValue in requestObject.LambdaFunctionName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionTags())
            {
                context.Writer.WritePropertyName("lambdaFunctionTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionTagsListValue in requestObject.LambdaFunctionTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceFilterCriteriaMarshaller Instance = new ResourceFilterCriteriaMarshaller();

    }
}