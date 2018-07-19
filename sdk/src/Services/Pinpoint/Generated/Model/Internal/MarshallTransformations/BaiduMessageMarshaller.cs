/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BaiduMessage Marshaller
    /// </summary>       
    public class BaiduMessageMarshaller : IRequestMarshaller<BaiduMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BaiduMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.Write(requestObject.Body);
            }

            if(requestObject.IsSetData())
            {
                context.Writer.WritePropertyName("Data");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDataKvp in requestObject.Data)
                {
                    context.Writer.WritePropertyName(requestObjectDataKvp.Key);
                    var requestObjectDataValue = requestObjectDataKvp.Value;

                        context.Writer.Write(requestObjectDataValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIconReference())
            {
                context.Writer.WritePropertyName("IconReference");
                context.Writer.Write(requestObject.IconReference);
            }

            if(requestObject.IsSetImageIconUrl())
            {
                context.Writer.WritePropertyName("ImageIconUrl");
                context.Writer.Write(requestObject.ImageIconUrl);
            }

            if(requestObject.IsSetImageUrl())
            {
                context.Writer.WritePropertyName("ImageUrl");
                context.Writer.Write(requestObject.ImageUrl);
            }

            if(requestObject.IsSetRawContent())
            {
                context.Writer.WritePropertyName("RawContent");
                context.Writer.Write(requestObject.RawContent);
            }

            if(requestObject.IsSetSilentPush())
            {
                context.Writer.WritePropertyName("SilentPush");
                context.Writer.Write(requestObject.SilentPush);
            }

            if(requestObject.IsSetSmallImageIconUrl())
            {
                context.Writer.WritePropertyName("SmallImageIconUrl");
                context.Writer.Write(requestObject.SmallImageIconUrl);
            }

            if(requestObject.IsSetSound())
            {
                context.Writer.WritePropertyName("Sound");
                context.Writer.Write(requestObject.Sound);
            }

            if(requestObject.IsSetSubstitutions())
            {
                context.Writer.WritePropertyName("Substitutions");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSubstitutionsKvp in requestObject.Substitutions)
                {
                    context.Writer.WritePropertyName(requestObjectSubstitutionsKvp.Key);
                    var requestObjectSubstitutionsValue = requestObjectSubstitutionsKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectSubstitutionsValueListValue in requestObjectSubstitutionsValue)
                    {
                            context.Writer.Write(requestObjectSubstitutionsValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeToLive())
            {
                context.Writer.WritePropertyName("TimeToLive");
                context.Writer.Write(requestObject.TimeToLive);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.Write(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BaiduMessageMarshaller Instance = new BaiduMessageMarshaller();

    }
}