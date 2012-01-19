/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using System;
    using System.Collections.Generic; 
    using Amazon.DynamoDB.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.DynamoDB.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ScanResultUnmarshaller 
      /// </summary> 
      internal class ScanResultUnmarshaller : IUnmarshaller<ScanResult, UnmarshallerContext>, IUnmarshaller<ScanResult, JsonUnmarshallerContext> 
      { 
        ScanResult IUnmarshaller<ScanResult, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ScanResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          ScanResult scanResult = new ScanResult();
          scanResult.Items = null; 
                        
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("Items", targetDepth)) 
              {
                scanResult.Items = new List<Dictionary<string,AttributeValue>>();
                        DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller> unmarshaller = new DictionaryUnmarshaller<string, AttributeValue, StringUnmarshaller, AttributeValueUnmarshaller>(StringUnmarshaller.GetInstance(),AttributeValueUnmarshaller.GetInstance());
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     scanResult.Items.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("Count", targetDepth)) 
              {
                scanResult.Count = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ScannedCount", targetDepth)) 
              {
                scanResult.ScannedCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("LastEvaluatedKey", targetDepth)) 
              {
                scanResult.LastEvaluatedKey = KeyUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConsumedCapacityUnits", targetDepth)) 
              {
                scanResult.ConsumedCapacityUnits = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return scanResult; 
            } 
          } 
          return scanResult; 
        } 
        
        private static ScanResultUnmarshaller instance; 
        public static ScanResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new ScanResultUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
