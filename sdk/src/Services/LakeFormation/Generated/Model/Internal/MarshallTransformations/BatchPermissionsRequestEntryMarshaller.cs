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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchPermissionsRequestEntry Marshaller
    /// </summary>
    public class BatchPermissionsRequestEntryMarshaller : IRequestMarshaller<BatchPermissionsRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchPermissionsRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCondition())
            {
                context.Writer.WritePropertyName("Condition");
                context.Writer.WriteStartObject();

                var marshaller = ConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.Condition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetPermissions())
            {
                context.Writer.WritePropertyName("Permissions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPermissionsListValue in requestObject.Permissions)
                {
                        context.Writer.WriteStringValue(requestObjectPermissionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPermissionsWithGrantOption())
            {
                context.Writer.WritePropertyName("PermissionsWithGrantOption");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPermissionsWithGrantOptionListValue in requestObject.PermissionsWithGrantOption)
                {
                        context.Writer.WriteStringValue(requestObjectPermissionsWithGrantOptionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrincipal())
            {
                context.Writer.WritePropertyName("Principal");
                context.Writer.WriteStartObject();

                var marshaller = DataLakePrincipalMarshaller.Instance;
                marshaller.Marshall(requestObject.Principal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResource())
            {
                context.Writer.WritePropertyName("Resource");
                context.Writer.WriteStartObject();

                var marshaller = ResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Resource, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchPermissionsRequestEntryMarshaller Instance = new BatchPermissionsRequestEntryMarshaller();

    }
}