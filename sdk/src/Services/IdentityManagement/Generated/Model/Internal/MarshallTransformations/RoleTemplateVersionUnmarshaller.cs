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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RoleTemplateVersion Object
    /// </summary>  
    public class RoleTemplateVersionUnmarshaller : IXmlUnmarshaller<RoleTemplateVersion, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RoleTemplateVersion Unmarshall(XmlUnmarshallerContext context)
        {
            RoleTemplateVersion unmarshalledObject = new RoleTemplateVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AssumeRolePolicyDocumentTemplate", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssumeRolePolicyDocumentTemplate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreateTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultMinorVersion", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DefaultMinorVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InlinePolicyTemplates/member", targetDepth))
                    {
                        var unmarshaller = InlinePolicyUnmarshaller.Instance;
                        if (unmarshalledObject.InlinePolicyTemplates == null)
                        {
                            unmarshalledObject.InlinePolicyTemplates = new List<InlinePolicy>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.InlinePolicyTemplates.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MajorVersion", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MajorVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManagedByType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManagedByType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManagedByValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ManagedByValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManagedPolicyArns/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ManagedPolicyArns == null)
                        {
                            unmarshalledObject.ManagedPolicyArns = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ManagedPolicyArns.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MaxSessionDuration", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxSessionDuration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinorVersion", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MinorVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParametersDefinition/member", targetDepth))
                    {
                        var unmarshaller = ParameterDefinitionUnmarshaller.Instance;
                        if (unmarshalledObject.ParametersDefinition == null)
                        {
                            unmarshalledObject.ParametersDefinition = new List<ParameterDefinition>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ParametersDefinition.Add(item);
                        continue;
                    }
                    if (context.TestExpression("PermissionBoundaryArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PermissionBoundaryArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleDescriptionPattern", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RoleDescriptionPattern = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleNamePattern", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RoleNamePattern = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RolePathPattern", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RolePathPattern = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleTagsTemplate/member", targetDepth))
                    {
                        var unmarshaller = TagTemplateUnmarshaller.Instance;
                        if (unmarshalledObject.RoleTagsTemplate == null)
                        {
                            unmarshalledObject.RoleTagsTemplate = new List<TagTemplate>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RoleTagsTemplate.Add(item);
                        continue;
                    }
                    if (context.TestExpression("TemplateArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TemplateArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TemplateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TemplateVersionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdateTimestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateTimestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VersionEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.VersionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static RoleTemplateVersionUnmarshaller _instance = new RoleTemplateVersionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RoleTemplateVersionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}