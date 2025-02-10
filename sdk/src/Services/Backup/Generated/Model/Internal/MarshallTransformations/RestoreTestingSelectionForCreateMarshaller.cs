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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTestingSelectionForCreate Marshaller
    /// </summary>
    public class RestoreTestingSelectionForCreateMarshaller : IRequestMarshaller<RestoreTestingSelectionForCreate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RestoreTestingSelectionForCreate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(requestObject.IamRoleArn);
            }

            if(requestObject.IsSetProtectedResourceArns())
            {
                context.Writer.WritePropertyName("ProtectedResourceArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProtectedResourceArnsListValue in requestObject.ProtectedResourceArns)
                {
                        context.Writer.WriteStringValue(requestObjectProtectedResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProtectedResourceConditions())
            {
                context.Writer.WritePropertyName("ProtectedResourceConditions");
                context.Writer.WriteStartObject();

                var marshaller = ProtectedResourceConditionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ProtectedResourceConditions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtectedResourceType())
            {
                context.Writer.WritePropertyName("ProtectedResourceType");
                context.Writer.WriteStringValue(requestObject.ProtectedResourceType);
            }

            if(requestObject.IsSetRestoreMetadataOverrides())
            {
                context.Writer.WritePropertyName("RestoreMetadataOverrides");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRestoreMetadataOverridesKvp in requestObject.RestoreMetadataOverrides)
                {
                    context.Writer.WritePropertyName(requestObjectRestoreMetadataOverridesKvp.Key);
                    var requestObjectRestoreMetadataOverridesValue = requestObjectRestoreMetadataOverridesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectRestoreMetadataOverridesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRestoreTestingSelectionName())
            {
                context.Writer.WritePropertyName("RestoreTestingSelectionName");
                context.Writer.WriteStringValue(requestObject.RestoreTestingSelectionName);
            }

            if(requestObject.IsSetValidationWindowHours())
            {
                context.Writer.WritePropertyName("ValidationWindowHours");
                context.Writer.WriteNumberValue(requestObject.ValidationWindowHours.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RestoreTestingSelectionForCreateMarshaller Instance = new RestoreTestingSelectionForCreateMarshaller();

    }
}