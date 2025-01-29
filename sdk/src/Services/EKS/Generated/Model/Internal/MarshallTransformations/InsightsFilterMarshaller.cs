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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InsightsFilter Marshaller
    /// </summary>
    public class InsightsFilterMarshaller : IRequestMarshaller<InsightsFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InsightsFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategories())
            {
                context.Writer.WritePropertyName("categories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCategoriesListValue in requestObject.Categories)
                {
                        context.Writer.WriteStringValue(requestObjectCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKubernetesVersions())
            {
                context.Writer.WritePropertyName("kubernetesVersions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKubernetesVersionsListValue in requestObject.KubernetesVersions)
                {
                        context.Writer.WriteStringValue(requestObjectKubernetesVersionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatuses())
            {
                context.Writer.WritePropertyName("statuses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusesListValue in requestObject.Statuses)
                {
                        context.Writer.WriteStringValue(requestObjectStatusesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InsightsFilterMarshaller Instance = new InsightsFilterMarshaller();

    }
}