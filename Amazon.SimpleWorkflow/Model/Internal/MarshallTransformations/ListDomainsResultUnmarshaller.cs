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
    using System.Collections.Generic;
    using Amazon.Runtime.Internal.Transform; 
    
    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// Result Unmarshaller for ListDomains operation 
      /// </summary> 
      internal class ListDomainsResultUnmarshaller : IUnmarshaller<ListDomainsResult, JsonUnmarshallerContext> 
      { 
        public ListDomainsResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          ListDomainsResult result = new ListDomainsResult();
          result.DomainInfos = DomainInfosUnmarshaller.GetInstance().Unmarshall(context); 
          return result; 
        } 
              
        private static ListDomainsResultUnmarshaller instance; 
        public static ListDomainsResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
          {
            instance = new ListDomainsResultUnmarshaller(); 
          } 
          return instance; 
        } 
      } 
    } 
  
