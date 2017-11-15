/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainName Object
    /// </summary>  
    public class DomainNameUnmarshaller : IUnmarshaller<DomainName, XmlUnmarshallerContext>, IUnmarshaller<DomainName, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DomainName IUnmarshaller<DomainName, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DomainName Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DomainName unmarshalledObject = new DomainName();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("certificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CertificateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("certificateUploadDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CertificateUploadDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distributionDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DistributionDomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distributionHostedZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DistributionHostedZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endpointConfiguration", targetDepth))
                {
                    var unmarshaller = EndpointConfigurationUnmarshaller.Instance;
                    unmarshalledObject.EndpointConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalCertificateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionalCertificateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalCertificateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionalCertificateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalDomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionalDomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("regionalHostedZoneId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegionalHostedZoneId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DomainNameUnmarshaller _instance = new DomainNameUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainNameUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}