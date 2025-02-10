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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImportImage operation
    /// </summary>  
    public class ImportImageResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ImportImageResponse response = new ImportImageResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("architecture", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Architecture = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("encrypted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.Encrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hypervisor", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Hypervisor = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("imageId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ImageId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("importTaskId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ImportTaskId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("licenseSpecifications/item", targetDepth))
                    {
                        var unmarshaller = ImportImageLicenseConfigurationResponseUnmarshaller.Instance;
                        if (response.LicenseSpecifications == null)
                        {
                            response.LicenseSpecifications = new List<ImportImageLicenseConfigurationResponse>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.LicenseSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("licenseType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LicenseType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("platform", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Platform = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("progress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Progress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("snapshotDetailSet/item", targetDepth))
                    {
                        var unmarshaller = SnapshotDetailUnmarshaller.Instance;
                        if (response.SnapshotDetails == null)
                        {
                            response.SnapshotDetails = new List<SnapshotDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SnapshotDetails.Add(item);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.StatusMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (response.Tags == null)
                        {
                            response.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("usageOperation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.UsageOperation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static ImportImageResponseUnmarshaller _instance = new ImportImageResponseUnmarshaller();        

        internal static ImportImageResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportImageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}