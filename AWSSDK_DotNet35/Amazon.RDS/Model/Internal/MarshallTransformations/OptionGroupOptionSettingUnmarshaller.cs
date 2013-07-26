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
     ///   OptionGroupOptionSetting Unmarshaller
     /// </summary>
    internal class OptionGroupOptionSettingUnmarshaller : IUnmarshaller<OptionGroupOptionSetting, XmlUnmarshallerContext>, IUnmarshaller<OptionGroupOptionSetting, JsonUnmarshallerContext> 
    {
        public OptionGroupOptionSetting Unmarshall(XmlUnmarshallerContext context) 
        {
            OptionGroupOptionSetting optionGroupOptionSetting = new OptionGroupOptionSetting();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("SettingName", targetDepth))
                    {
                        optionGroupOptionSetting.SettingName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SettingDescription", targetDepth))
                    {
                        optionGroupOptionSetting.SettingDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        optionGroupOptionSetting.DefaultValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ApplyType", targetDepth))
                    {
                        optionGroupOptionSetting.ApplyType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        optionGroupOptionSetting.AllowedValues = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        optionGroupOptionSetting.IsModifiable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return optionGroupOptionSetting;
                }
            }
                        


            return optionGroupOptionSetting;
        }

        public OptionGroupOptionSetting Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionGroupOptionSettingUnmarshaller instance;

        public static OptionGroupOptionSettingUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionGroupOptionSettingUnmarshaller();

            return instance;
        }
    }
}
    
