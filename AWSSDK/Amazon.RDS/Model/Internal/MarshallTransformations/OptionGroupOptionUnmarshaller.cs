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
     ///   OptionGroupOption Unmarshaller
     /// </summary>
    internal class OptionGroupOptionUnmarshaller : IUnmarshaller<OptionGroupOption, XmlUnmarshallerContext>, IUnmarshaller<OptionGroupOption, JsonUnmarshallerContext> 
    {
        public OptionGroupOption Unmarshall(XmlUnmarshallerContext context) 
        {
            OptionGroupOption optionGroupOption = new OptionGroupOption();
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
                        optionGroupOption.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        optionGroupOption.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EngineName", targetDepth))
                    {
                        optionGroupOption.EngineName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        optionGroupOption.MajorEngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinimumRequiredMinorEngineVersion", targetDepth))
                    {
                        optionGroupOption.MinimumRequiredMinorEngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PortRequired", targetDepth))
                    {
                        optionGroupOption.PortRequired = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DefaultPort", targetDepth))
                    {
                        optionGroupOption.DefaultPort = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionsDependedOn/OptionName", targetDepth))
                    {
                        optionGroupOption.OptionsDependedOn.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Persistent", targetDepth))
                    {
                        optionGroupOption.Persistent = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Permanent", targetDepth))
                    {
                        optionGroupOption.Permanent = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionGroupOptionSettings/OptionGroupOptionSetting", targetDepth))
                    {
                        optionGroupOption.OptionGroupOptionSettings.Add(OptionGroupOptionSettingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return optionGroupOption;
                }
            }
                        


            return optionGroupOption;
        }

        public OptionGroupOption Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionGroupOptionUnmarshaller instance;

        public static OptionGroupOptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionGroupOptionUnmarshaller();

            return instance;
        }
    }
}
    
