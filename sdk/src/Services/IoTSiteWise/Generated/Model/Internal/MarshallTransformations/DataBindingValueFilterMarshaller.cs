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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataBindingValueFilter Marshaller
    /// </summary>
    public class DataBindingValueFilterMarshaller : IRequestMarshaller<DataBindingValueFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataBindingValueFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAsset())
            {
                context.Writer.WritePropertyName("asset");
                context.Writer.WriteStartObject();

                var marshaller = AssetBindingValueFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Asset, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAssetModel())
            {
                context.Writer.WritePropertyName("assetModel");
                context.Writer.WriteStartObject();

                var marshaller = AssetModelBindingValueFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AssetModel, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAssetModelProperty())
            {
                context.Writer.WritePropertyName("assetModelProperty");
                context.Writer.WriteStartObject();

                var marshaller = AssetModelPropertyBindingValueFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AssetModelProperty, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAssetProperty())
            {
                context.Writer.WritePropertyName("assetProperty");
                context.Writer.WriteStartObject();

                var marshaller = AssetPropertyBindingValueFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AssetProperty, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataBindingValueFilterMarshaller Instance = new DataBindingValueFilterMarshaller();

    }
}