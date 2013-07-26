/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   OptionSetting Unmarshaller
     /// </summary>
    internal class OptionSettingUnmarshaller : IUnmarshaller<OptionSetting, XmlUnmarshallerContext>, IUnmarshaller<OptionSetting, JsonUnmarshallerContext> 
    {
        public OptionSetting Unmarshall(XmlUnmarshallerContext context) 
        {
            OptionSetting optionSetting = new OptionSetting();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Name", targetDepth))
                    {
                        optionSetting.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Value", targetDepth))
                    {
                        optionSetting.Value = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        optionSetting.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        optionSetting.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ApplyType", targetDepth))
                    {
                        optionSetting.ApplyType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        optionSetting.DataType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        optionSetting.AllowedValues = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        optionSetting.IsModifiable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsCollection", targetDepth))
                    {
                        optionSetting.IsCollection = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return optionSetting;
                }
            }
                        


            return optionSetting;
        }

        public OptionSetting Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionSettingUnmarshaller instance;

        public static OptionSettingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionSettingUnmarshaller();

            return instance;
        }
    }
}
    
