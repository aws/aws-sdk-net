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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("accountId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountIdListValue in requestObject.AccountId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeRepositoryProjectName())
            {
                context.Writer.WritePropertyName("codeRepositoryProjectName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoryProjectNameListValue in requestObject.CodeRepositoryProjectName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoryProjectNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeRepositoryProviderType())
            {
                context.Writer.WritePropertyName("codeRepositoryProviderType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoryProviderTypeListValue in requestObject.CodeRepositoryProviderType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoryProviderTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCodeRepositoryProviderTypeVisibility())
            {
                context.Writer.WritePropertyName("codeRepositoryProviderTypeVisibility");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoryProviderTypeVisibilityListValue in requestObject.CodeRepositoryProviderTypeVisibility)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoryProviderTypeVisibilityListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2InstanceTags())
            {
                context.Writer.WritePropertyName("ec2InstanceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2InstanceTagsListValue in requestObject.Ec2InstanceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2InstanceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageInUseCount())
            {
                context.Writer.WritePropertyName("ecrImageInUseCount");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageInUseCountListValue in requestObject.EcrImageInUseCount)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageNumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageInUseCountListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageLastInUseAt())
            {
                context.Writer.WritePropertyName("ecrImageLastInUseAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageLastInUseAtListValue in requestObject.EcrImageLastInUseAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageLastInUseAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrImageTags())
            {
                context.Writer.WritePropertyName("ecrImageTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrImageTagsListValue in requestObject.EcrImageTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrImageTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEcrRepositoryName())
            {
                context.Writer.WritePropertyName("ecrRepositoryName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEcrRepositoryNameListValue in requestObject.EcrRepositoryName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEcrRepositoryNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImagePulledAt())
            {
                context.Writer.WritePropertyName("imagePulledAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImagePulledAtListValue in requestObject.ImagePulledAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImagePulledAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionName())
            {
                context.Writer.WritePropertyName("lambdaFunctionName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionNameListValue in requestObject.LambdaFunctionName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionRuntime())
            {
                context.Writer.WritePropertyName("lambdaFunctionRuntime");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionRuntimeListValue in requestObject.LambdaFunctionRuntime)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionRuntimeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionTags())
            {
                context.Writer.WritePropertyName("lambdaFunctionTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionTagsListValue in requestObject.LambdaFunctionTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageMapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaFunctionTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastScannedAt())
            {
                context.Writer.WritePropertyName("lastScannedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastScannedAtListValue in requestObject.LastScannedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageDateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastScannedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastScannedCommitId())
            {
                context.Writer.WritePropertyName("lastScannedCommitId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastScannedCommitIdListValue in requestObject.LastScannedCommitId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastScannedCommitIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("resourceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanMode())
            {
                context.Writer.WritePropertyName("scanMode");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanModeListValue in requestObject.ScanMode)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanModeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanStatusCode())
            {
                context.Writer.WritePropertyName("scanStatusCode");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanStatusCodeListValue in requestObject.ScanStatusCode)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusCodeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanStatusReason())
            {
                context.Writer.WritePropertyName("scanStatusReason");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanStatusReasonListValue in requestObject.ScanStatusReason)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanStatusReasonListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScanType())
            {
                context.Writer.WritePropertyName("scanType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScanTypeListValue in requestObject.ScanType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CoverageStringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectScanTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CoverageFilterCriteriaMarshaller Instance = new CoverageFilterCriteriaMarshaller();

    }
}