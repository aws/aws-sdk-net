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
     ///   OptionGroup Unmarshaller
     /// </summary>
    internal class OptionGroupUnmarshaller : IUnmarshaller<OptionGroup, XmlUnmarshallerContext>, IUnmarshaller<OptionGroup, JsonUnmarshallerContext> 
    {
        public OptionGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            OptionGroup optionGroup = new OptionGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("OptionGroupName", targetDepth))
                    {
                        optionGroup.OptionGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionGroupDescription", targetDepth))
                    {
                        optionGroup.OptionGroupDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EngineName", targetDepth))
                    {
                        optionGroup.EngineName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        optionGroup.MajorEngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Options/Option", targetDepth))
                    {
                        optionGroup.Options.Add(OptionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("AllowsVpcAndNonVpcInstanceMemberships", targetDepth))
                    {
                        optionGroup.AllowsVpcAndNonVpcInstanceMemberships = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        optionGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return optionGroup;
                }
            }
                        


            return optionGroup;
        }

        public OptionGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionGroupUnmarshaller instance;

        public static OptionGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionGroupUnmarshaller();

            return instance;
        }
    }
}
    
