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
     ///   Option Unmarshaller
     /// </summary>
    internal class OptionUnmarshaller : IUnmarshaller<Option, XmlUnmarshallerContext>, IUnmarshaller<Option, JsonUnmarshallerContext> 
    {
        public Option Unmarshall(XmlUnmarshallerContext context) 
        {
            Option option = new Option();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("OptionName", targetDepth))
                    {
                        option.OptionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("OptionDescription", targetDepth))
                    {
                        option.OptionDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Persistent", targetDepth))
                    {
                        option.Persistent = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Permanent", targetDepth))
                    {
                        option.Permanent = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        option.Port = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("OptionSettings/OptionSetting", targetDepth))
                    {
                        option.OptionSettings.Add(OptionSettingUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("DBSecurityGroupMemberships/DBSecurityGroup", targetDepth))
                    {
                        option.DBSecurityGroupMemberships.Add(DBSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("VpcSecurityGroupMemberships/VpcSecurityGroupMembership", targetDepth))
                    {
                        option.VpcSecurityGroupMemberships.Add(VpcSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return option;
                }
            }
                        


            return option;
        }

        public Option Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionUnmarshaller instance;

        public static OptionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionUnmarshaller();

            return instance;
        }
    }
}
    
