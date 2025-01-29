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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevisionLocation Marshaller
    /// </summary>
    public class RevisionLocationMarshaller : IRequestMarshaller<RevisionLocation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RevisionLocation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppSpecContent())
            {
                context.Writer.WritePropertyName("appSpecContent");
                context.Writer.WriteStartObject();

                var marshaller = AppSpecContentMarshaller.Instance;
                marshaller.Marshall(requestObject.AppSpecContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitHubLocation())
            {
                context.Writer.WritePropertyName("gitHubLocation");
                context.Writer.WriteStartObject();

                var marshaller = GitHubLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.GitHubLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRevisionType())
            {
                context.Writer.WritePropertyName("revisionType");
                context.Writer.WriteStringValue(requestObject.RevisionType);
            }

            if(requestObject.IsSetS3Location())
            {
                context.Writer.WritePropertyName("s3Location");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Location, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetString())
            {
                context.Writer.WritePropertyName("string");
                context.Writer.WriteStartObject();

                var marshaller = RawStringMarshaller.Instance;
                marshaller.Marshall(requestObject.String, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RevisionLocationMarshaller Instance = new RevisionLocationMarshaller();

    }
}