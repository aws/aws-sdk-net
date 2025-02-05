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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppRunner.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppRunner.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImageRepository Marshaller
    /// </summary>
    public class ImageRepositoryMarshaller : IRequestMarshaller<ImageRepository, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImageRepository requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetImageConfiguration())
            {
                context.Writer.WritePropertyName("ImageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ImageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetImageIdentifier())
            {
                context.Writer.WritePropertyName("ImageIdentifier");
                context.Writer.WriteStringValue(requestObject.ImageIdentifier);
            }

            if(requestObject.IsSetImageRepositoryType())
            {
                context.Writer.WritePropertyName("ImageRepositoryType");
                context.Writer.WriteStringValue(requestObject.ImageRepositoryType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImageRepositoryMarshaller Instance = new ImageRepositoryMarshaller();

    }
}