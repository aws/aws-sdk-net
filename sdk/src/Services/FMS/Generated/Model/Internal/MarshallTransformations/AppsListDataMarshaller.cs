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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AppsListData Marshaller
    /// </summary>       
    public class AppsListDataMarshaller : IRequestMarshaller<AppsListData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AppsListData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAppsList())
            {
                context.Writer.WritePropertyName("AppsList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAppsListListValue in requestObject.AppsList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AppMarshaller.Instance;
                    marshaller.Marshall(requestObjectAppsListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreateTime())
            {
                context.Writer.WritePropertyName("CreateTime");
                context.Writer.Write(requestObject.CreateTime);
            }

            if(requestObject.IsSetLastUpdateTime())
            {
                context.Writer.WritePropertyName("LastUpdateTime");
                context.Writer.Write(requestObject.LastUpdateTime);
            }

            if(requestObject.IsSetListId())
            {
                context.Writer.WritePropertyName("ListId");
                context.Writer.Write(requestObject.ListId);
            }

            if(requestObject.IsSetListName())
            {
                context.Writer.WritePropertyName("ListName");
                context.Writer.Write(requestObject.ListName);
            }

            if(requestObject.IsSetListUpdateToken())
            {
                context.Writer.WritePropertyName("ListUpdateToken");
                context.Writer.Write(requestObject.ListUpdateToken);
            }

            if(requestObject.IsSetPreviousAppsList())
            {
                context.Writer.WritePropertyName("PreviousAppsList");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPreviousAppsListKvp in requestObject.PreviousAppsList)
                {
                    context.Writer.WritePropertyName(requestObjectPreviousAppsListKvp.Key);
                    var requestObjectPreviousAppsListValue = requestObjectPreviousAppsListKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectPreviousAppsListValueListValue in requestObjectPreviousAppsListValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AppMarshaller.Instance;
                        marshaller.Marshall(requestObjectPreviousAppsListValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AppsListDataMarshaller Instance = new AppsListDataMarshaller();

    }
}