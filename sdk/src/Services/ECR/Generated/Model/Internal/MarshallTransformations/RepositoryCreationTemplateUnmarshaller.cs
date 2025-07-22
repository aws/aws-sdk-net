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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECR.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RepositoryCreationTemplate Object
    /// </summary>  
    public class RepositoryCreationTemplateUnmarshaller : IUnmarshaller<RepositoryCreationTemplate, XmlUnmarshallerContext>, IUnmarshaller<RepositoryCreationTemplate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RepositoryCreationTemplate IUnmarshaller<RepositoryCreationTemplate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RepositoryCreationTemplate Unmarshall(JsonUnmarshallerContext context)
        {
            RepositoryCreationTemplate unmarshalledObject = new RepositoryCreationTemplate();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appliedFor", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AppliedFor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionConfiguration", targetDepth))
                {
                    var unmarshaller = EncryptionConfigurationForRepositoryCreationTemplateUnmarshaller.Instance;
                    unmarshalledObject.EncryptionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageTagMutability", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageTagMutability = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageTagMutabilityExclusionFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ImageTagMutabilityExclusionFilter, ImageTagMutabilityExclusionFilterUnmarshaller>(ImageTagMutabilityExclusionFilterUnmarshaller.Instance);
                    unmarshalledObject.ImageTagMutabilityExclusionFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lifecyclePolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LifecyclePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("repositoryPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepositoryPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.ResourceTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RepositoryCreationTemplateUnmarshaller _instance = new RepositoryCreationTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RepositoryCreationTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}