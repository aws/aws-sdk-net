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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobDescriptor Object
    /// </summary>  
    public partial class JobDescriptorUnmarshaller : IXmlUnmarshaller<JobDescriptor, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobDescriptor Unmarshall(XmlUnmarshallerContext context)
        {
            JobDescriptor unmarshalledObject = new JobDescriptor();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ConfirmationRequired", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ConfirmationRequired = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FailureReasons/member", targetDepth))
                    {
                        if (unmarshalledObject.FailureReasons == null)
                        {
                            unmarshalledObject.FailureReasons = new List<JobFailure>();
                        }
                        var unmarshaller = JobFailureUnmarshaller.Instance;
                        unmarshalledObject.FailureReasons.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("GeneratedManifestDescriptor", targetDepth))
                    {
                        var unmarshaller = S3GeneratedManifestDescriptorUnmarshaller.Instance;
                        unmarshalledObject.GeneratedManifestDescriptor = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.JobArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Manifest", targetDepth))
                    {
                        var unmarshaller = JobManifestUnmarshaller.Instance;
                        unmarshalledObject.Manifest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ManifestGenerator", targetDepth))
                    {
                        var unmarshaller = JobManifestGeneratorUnmarshaller.Instance;
                        unmarshalledObject.ManifestGenerator = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Operation", targetDepth))
                    {
                        var unmarshaller = JobOperationUnmarshaller.Instance;
                        unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Priority", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProgressSummary", targetDepth))
                    {
                        var unmarshaller = JobProgressSummaryUnmarshaller.Instance;
                        unmarshalledObject.ProgressSummary = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Report", targetDepth))
                    {
                        var unmarshaller = JobReportUnmarshaller.Instance;
                        unmarshalledObject.Report = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RoleArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusUpdateReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusUpdateReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SuspendedCause", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SuspendedCause = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SuspendedDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.SuspendedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TerminationDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.TerminationDate = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, JobDescriptor unmarshalledObject, int targetDepth);

        private static JobDescriptorUnmarshaller _instance = new JobDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}