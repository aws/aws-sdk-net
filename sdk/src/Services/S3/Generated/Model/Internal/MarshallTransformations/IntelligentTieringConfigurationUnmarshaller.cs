/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IntelligentTieringConfiguration Object
    /// </summary>  
    public partial class IntelligentTieringConfigurationUnmarshaller : IXmlUnmarshaller<IntelligentTieringConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IntelligentTieringConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            IntelligentTieringConfiguration unmarshalledObject = new IntelligentTieringConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        var predicateList = IntelligentTieringPredicateListFilterUnmarshaller.Instance.Unmarshall(context);
                        unmarshalledObject.IntelligentTieringFilter = new IntelligentTieringFilter();
                        unmarshalledObject.IntelligentTieringFilter.IntelligentTieringFilterPredicate = predicateList[0];
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IntelligentTieringId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tiering", targetDepth))
                    {
                        if (unmarshalledObject.Tierings == null)
                        {
                            unmarshalledObject.Tierings = new List<Tiering>();
                        }
                        var unmarshaller = TieringUnmarshaller.Instance;
                        unmarshalledObject.Tierings.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    XmlStructureUnmarshallCustomization(context, unmarshalledObject, targetDepth);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, IntelligentTieringConfiguration unmarshalledObject, int targetDepth);

        private static IntelligentTieringConfigurationUnmarshaller _instance = new IntelligentTieringConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IntelligentTieringConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}