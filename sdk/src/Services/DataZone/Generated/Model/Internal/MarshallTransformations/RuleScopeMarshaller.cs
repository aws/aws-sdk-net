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
    /// RuleScope Marshaller
    /// </summary>
    public class RuleScopeMarshaller : IRequestMarshaller<RuleScope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleScope requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssetType())
            {
                context.Writer.WritePropertyName("assetType");
                context.Writer.WriteStartObject();

                var marshaller = AssetTypesForRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.AssetType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataProduct())
            {
                context.Writer.WritePropertyName("dataProduct");
                context.Writer.WriteBooleanValue(requestObject.DataProduct.Value);
            }

            if(requestObject.IsSetProject())
            {
                context.Writer.WritePropertyName("project");
                context.Writer.WriteStartObject();

                var marshaller = ProjectsForRuleMarshaller.Instance;
                marshaller.Marshall(requestObject.Project, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleScopeMarshaller Instance = new RuleScopeMarshaller();

    }
}