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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IcebergDestinationDescription Object
    /// </summary>  
    public class IcebergDestinationDescriptionUnmarshaller : IUnmarshaller<IcebergDestinationDescription, XmlUnmarshallerContext>, IUnmarshaller<IcebergDestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IcebergDestinationDescription IUnmarshaller<IcebergDestinationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IcebergDestinationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            IcebergDestinationDescription unmarshalledObject = new IcebergDestinationDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BufferingHints", targetDepth))
                {
                    var unmarshaller = BufferingHintsUnmarshaller.Instance;
                    unmarshalledObject.BufferingHints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogConfiguration", targetDepth))
                {
                    var unmarshaller = CatalogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CatalogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchLoggingOptions", targetDepth))
                {
                    var unmarshaller = CloudWatchLoggingOptionsUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLoggingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DestinationTableConfigurationList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DestinationTableConfiguration, DestinationTableConfigurationUnmarshaller>(DestinationTableConfigurationUnmarshaller.Instance);
                    unmarshalledObject.DestinationTableConfigurationList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = ProcessingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProcessingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryOptions", targetDepth))
                {
                    var unmarshaller = RetryOptionsUnmarshaller.Instance;
                    unmarshalledObject.RetryOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BackupMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BackupMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SchemaEvolutionConfiguration", targetDepth))
                {
                    var unmarshaller = SchemaEvolutionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SchemaEvolutionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableCreationConfiguration", targetDepth))
                {
                    var unmarshaller = TableCreationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TableCreationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IcebergDestinationDescriptionUnmarshaller _instance = new IcebergDestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IcebergDestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}