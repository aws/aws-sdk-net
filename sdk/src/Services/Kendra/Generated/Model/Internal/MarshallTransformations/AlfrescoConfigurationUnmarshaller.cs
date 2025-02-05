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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AlfrescoConfiguration Object
    /// </summary>  
    public class AlfrescoConfigurationUnmarshaller : IJsonUnmarshaller<AlfrescoConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AlfrescoConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AlfrescoConfiguration unmarshalledObject = new AlfrescoConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BlogFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.BlogFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CrawlComments", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlComments = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CrawlSystemFolders", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlSystemFolders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DocumentLibraryFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.DocumentLibraryFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntityFilter", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EntityFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SiteId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SiteId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SiteUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SiteUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SslCertificateS3Path", targetDepth))
                {
                    var unmarshaller = S3PathUnmarshaller.Instance;
                    unmarshalledObject.SslCertificateS3Path = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WikiFieldMappings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSourceToIndexFieldMapping, DataSourceToIndexFieldMappingUnmarshaller>(DataSourceToIndexFieldMappingUnmarshaller.Instance);
                    unmarshalledObject.WikiFieldMappings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AlfrescoConfigurationUnmarshaller _instance = new AlfrescoConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AlfrescoConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}