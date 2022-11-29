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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CoverageFilterCriteria Marshaller
    /// </summary>
    public class CoverageFilterCriteriaMarshaller : IRequestMarshaller<CoverageFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CoverageFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("accountId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountIdListValue in requestObject.AccountId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2InstanceTags())
            {
                context.Writer.WritePropertyName("ec2InstanceTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2InstanceTagsListValue in requestObject.Ec2InstanceTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrImageTags())
            {
                context.Writer.WritePropertyName("ecrImageTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrImageTagsListValue in requestObject.EcrImageTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEcrRepositoryName())
            {
                context.Writer.WritePropertyName("ecrRepositoryName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEcrRepositoryNameListValue in requestObject.EcrRepositoryName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrRepositoryNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionName())
            {
                context.Writer.WritePropertyName("lambdaFunctionName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionNameListValue in requestObject.LambdaFunctionName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionRuntime())
            {
                context.Writer.WritePropertyName("lambdaFunctionRuntime");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionRuntimeListValue in requestObject.LambdaFunctionRuntime)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionRuntimeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLambdaFunctionTags())
            {
                context.Writer.WritePropertyName("lambdaFunctionTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLambdaFunctionTagsListValue in requestObject.LambdaFunctionTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanStatusCode())
            {
                context.Writer.WritePropertyName("scanStatusCode");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanStatusCodeListValue in requestObject.ScanStatusCode)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusCodeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanStatusReason())
            {
                context.Writer.WritePropertyName("scanStatusReason");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanStatusReasonListValue in requestObject.ScanStatusReason)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusReasonListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScanType())
            {
                context.Writer.WritePropertyName("scanType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScanTypeListValue in requestObject.ScanType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CoverageFilterCriteriaMarshaller Instance = new CoverageFilterCriteriaMarshaller();

    }
}