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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodegenGenericDataRelationshipType Marshaller
    /// </summary>
    public class CodegenGenericDataRelationshipTypeMarshaller : IRequestMarshaller<CodegenGenericDataRelationshipType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodegenGenericDataRelationshipType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociatedFields())
            {
                context.Writer.WritePropertyName("associatedFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociatedFieldsListValue in requestObject.AssociatedFields)
                {
                        context.Writer.Write(requestObjectAssociatedFieldsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBelongsToFieldOnRelatedModel())
            {
                context.Writer.WritePropertyName("belongsToFieldOnRelatedModel");
                context.Writer.Write(requestObject.BelongsToFieldOnRelatedModel);
            }

            if(requestObject.IsSetCanUnlinkAssociatedModel())
            {
                context.Writer.WritePropertyName("canUnlinkAssociatedModel");
                context.Writer.Write(requestObject.CanUnlinkAssociatedModel);
            }

            if(requestObject.IsSetIsHasManyIndex())
            {
                context.Writer.WritePropertyName("isHasManyIndex");
                context.Writer.Write(requestObject.IsHasManyIndex);
            }

            if(requestObject.IsSetRelatedJoinFieldName())
            {
                context.Writer.WritePropertyName("relatedJoinFieldName");
                context.Writer.Write(requestObject.RelatedJoinFieldName);
            }

            if(requestObject.IsSetRelatedJoinTableName())
            {
                context.Writer.WritePropertyName("relatedJoinTableName");
                context.Writer.Write(requestObject.RelatedJoinTableName);
            }

            if(requestObject.IsSetRelatedModelFields())
            {
                context.Writer.WritePropertyName("relatedModelFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedModelFieldsListValue in requestObject.RelatedModelFields)
                {
                        context.Writer.Write(requestObjectRelatedModelFieldsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRelatedModelName())
            {
                context.Writer.WritePropertyName("relatedModelName");
                context.Writer.Write(requestObject.RelatedModelName);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodegenGenericDataRelationshipTypeMarshaller Instance = new CodegenGenericDataRelationshipTypeMarshaller();

    }
}