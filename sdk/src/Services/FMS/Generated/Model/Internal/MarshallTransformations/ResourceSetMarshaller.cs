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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceSet Marshaller
    /// </summary>
    public class ResourceSetMarshaller : IRequestMarshaller<ResourceSet, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceSet requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("Description");
                context.Writer.WriteTextString(requestObject.Description);
            }
            if (requestObject.IsSetId())
            {
                context.Writer.WriteTextString("Id");
                context.Writer.WriteTextString(requestObject.Id);
            }
            if (requestObject.IsSetLastUpdateTime())
            {
                context.Writer.WriteTextString("LastUpdateTime");
                context.Writer.WriteDateTime(requestObject.LastUpdateTime.Value);
            }
            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("Name");
                context.Writer.WriteTextString(requestObject.Name);
            }
            if (requestObject.IsSetResourceSetStatus())
            {
                context.Writer.WriteTextString("ResourceSetStatus");
                context.Writer.WriteTextString(requestObject.ResourceSetStatus);
            }
            if (requestObject.IsSetResourceTypeList())
            {
                context.Writer.WriteTextString("ResourceTypeList");
                context.Writer.WriteStartArray(requestObject.ResourceTypeList.Count);
                foreach(var requestObjectResourceTypeListListValue in requestObject.ResourceTypeList)
                {
                        context.Writer.WriteTextString(requestObjectResourceTypeListListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetUpdateToken())
            {
                context.Writer.WriteTextString("UpdateToken");
                context.Writer.WriteTextString(requestObject.UpdateToken);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceSetMarshaller Instance = new ResourceSetMarshaller();

    }
}