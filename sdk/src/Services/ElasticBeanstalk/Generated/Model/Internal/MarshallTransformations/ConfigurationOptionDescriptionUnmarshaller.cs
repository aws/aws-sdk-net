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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigurationOptionDescription Object
    /// </summary>  
    public class ConfigurationOptionDescriptionUnmarshaller : IUnmarshaller<ConfigurationOptionDescription, XmlUnmarshallerContext>, IUnmarshaller<ConfigurationOptionDescription, JsonUnmarshallerContext>
    {
        public ConfigurationOptionDescription Unmarshall(XmlUnmarshallerContext context)
        {
            ConfigurationOptionDescription unmarshalledObject = new ConfigurationOptionDescription();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ChangeSeverity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChangeSeverity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxLength", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxLength = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxValue", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinValue", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MinValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Regex", targetDepth))
                    {
                        var unmarshaller = OptionRestrictionRegexUnmarshaller.Instance;
                        unmarshalledObject.Regex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UserDefined", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.UserDefined = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ValueOptions/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ValueOptions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ValueType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ValueType = unmarshaller.Unmarshall(context);
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

        public ConfigurationOptionDescription Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ConfigurationOptionDescriptionUnmarshaller _instance = new ConfigurationOptionDescriptionUnmarshaller();        

        public static ConfigurationOptionDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}