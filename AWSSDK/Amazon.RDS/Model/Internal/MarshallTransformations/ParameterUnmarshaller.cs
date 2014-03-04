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
     ///   Parameter Unmarshaller
     /// </summary>
    internal class ParameterUnmarshaller : IUnmarshaller<Parameter, XmlUnmarshallerContext>, IUnmarshaller<Parameter, JsonUnmarshallerContext> 
    {
        public Parameter Unmarshall(XmlUnmarshallerContext context) 
        {
            Parameter parameter = new Parameter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ParameterName", targetDepth))
                    {
                        parameter.ParameterName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ParameterValue", targetDepth))
                    {
                        parameter.ParameterValue = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        parameter.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Source", targetDepth))
                    {
                        parameter.Source = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplyType", targetDepth))
                    {
                        parameter.ApplyType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        parameter.DataType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        parameter.AllowedValues = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        parameter.IsModifiable = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MinimumEngineVersion", targetDepth))
                    {
                        parameter.MinimumEngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ApplyMethod", targetDepth))
                    {
                        parameter.ApplyMethod = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return parameter;
                }
            }
                        


            return parameter;
        }

        public Parameter Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ParameterUnmarshaller instance;

        public static ParameterUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ParameterUnmarshaller();

            return instance;
        }
    }
}
    
