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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// CreateVaultResultUnmarshaller 
      /// </summary> 
      internal class CreateVaultResultUnmarshaller : IUnmarshaller<CreateVaultResult, XmlUnmarshallerContext>, IUnmarshaller<CreateVaultResult, JsonUnmarshallerContext> 
      { 
        CreateVaultResult IUnmarshaller<CreateVaultResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CreateVaultResult Unmarshall(JsonUnmarshallerContext context) 
        {
            CreateVaultResult createVaultResult = new CreateVaultResult();
          

            if (context.Headers["Location"] != null)
                createVaultResult.Location = context.Headers["Location"];
          
            return createVaultResult; 
        } 
        
        private static CreateVaultResultUnmarshaller instance; 
        public static CreateVaultResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new CreateVaultResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
