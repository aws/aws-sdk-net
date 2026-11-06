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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ObjectLambdaTransformationConfiguration Marshaller
    /// </summary>
    public partial class ObjectLambdaTransformationConfigurationMarshaller : IRequestMarshaller<ObjectLambdaTransformationConfiguration, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ObjectLambdaTransformationConfiguration requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActions())
            {
                var requestObjectActions = requestObject.Actions;
                context.Writer.WriteStartElement("Actions");
                foreach (var requestObjectActionsValue in requestObjectActions)
                {
                    context.Writer.WriteStartElement("Action");
                    context.Writer.WriteValue(requestObjectActionsValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetContentTransformation())
            {
                context.Writer.WriteStartElement("ContentTransformation");
                ObjectLambdaContentTransformationMarshaller.Instance.Marshall(requestObject.ContentTransformation, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ObjectLambdaTransformationConfigurationMarshaller Instance = new ObjectLambdaTransformationConfigurationMarshaller();
    }
}
