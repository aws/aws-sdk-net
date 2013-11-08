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
     ///   DBEngineVersion Unmarshaller
     /// </summary>
    internal class DBEngineVersionUnmarshaller : IUnmarshaller<DBEngineVersion, XmlUnmarshallerContext>, IUnmarshaller<DBEngineVersion, JsonUnmarshallerContext> 
    {
        public DBEngineVersion Unmarshall(XmlUnmarshallerContext context) 
        {
            DBEngineVersion dBEngineVersion = new DBEngineVersion();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        dBEngineVersion.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        dBEngineVersion.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBParameterGroupFamily", targetDepth))
                    {
                        dBEngineVersion.DBParameterGroupFamily = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBEngineDescription", targetDepth))
                    {
                        dBEngineVersion.DBEngineDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersionDescription", targetDepth))
                    {
                        dBEngineVersion.DBEngineVersionDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DefaultCharacterSet", targetDepth))
                    {
                        dBEngineVersion.DefaultCharacterSet = CharacterSetUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SupportedCharacterSets/CharacterSet", targetDepth))
                    {
                        dBEngineVersion.SupportedCharacterSets.Add(CharacterSetUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return dBEngineVersion;
                }
            }
                        


            return dBEngineVersion;
        }

        public DBEngineVersion Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DBEngineVersionUnmarshaller instance;

        public static DBEngineVersionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DBEngineVersionUnmarshaller();

            return instance;
        }
    }
}
    
