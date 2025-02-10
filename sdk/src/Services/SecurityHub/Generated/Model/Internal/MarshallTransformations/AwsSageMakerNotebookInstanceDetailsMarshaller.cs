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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsSageMakerNotebookInstanceDetails Marshaller
    /// </summary>
    public class AwsSageMakerNotebookInstanceDetailsMarshaller : IRequestMarshaller<AwsSageMakerNotebookInstanceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSageMakerNotebookInstanceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("AcceleratorTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorTypesListValue in requestObject.AcceleratorTypes)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAdditionalCodeRepositories())
            {
                context.Writer.WritePropertyName("AdditionalCodeRepositories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalCodeRepositoriesListValue in requestObject.AdditionalCodeRepositories)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalCodeRepositoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDefaultCodeRepository())
            {
                context.Writer.WritePropertyName("DefaultCodeRepository");
                context.Writer.WriteStringValue(requestObject.DefaultCodeRepository);
            }

            if(requestObject.IsSetDirectInternetAccess())
            {
                context.Writer.WritePropertyName("DirectInternetAccess");
                context.Writer.WriteStringValue(requestObject.DirectInternetAccess);
            }

            if(requestObject.IsSetFailureReason())
            {
                context.Writer.WritePropertyName("FailureReason");
                context.Writer.WriteStringValue(requestObject.FailureReason);
            }

            if(requestObject.IsSetInstanceMetadataServiceConfiguration())
            {
                context.Writer.WritePropertyName("InstanceMetadataServiceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsSageMakerNotebookInstanceMetadataServiceConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.InstanceMetadataServiceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.WriteStringValue(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetNotebookInstanceArn())
            {
                context.Writer.WritePropertyName("NotebookInstanceArn");
                context.Writer.WriteStringValue(requestObject.NotebookInstanceArn);
            }

            if(requestObject.IsSetNotebookInstanceLifecycleConfigName())
            {
                context.Writer.WritePropertyName("NotebookInstanceLifecycleConfigName");
                context.Writer.WriteStringValue(requestObject.NotebookInstanceLifecycleConfigName);
            }

            if(requestObject.IsSetNotebookInstanceName())
            {
                context.Writer.WritePropertyName("NotebookInstanceName");
                context.Writer.WriteStringValue(requestObject.NotebookInstanceName);
            }

            if(requestObject.IsSetNotebookInstanceStatus())
            {
                context.Writer.WritePropertyName("NotebookInstanceStatus");
                context.Writer.WriteStringValue(requestObject.NotebookInstanceStatus);
            }

            if(requestObject.IsSetPlatformIdentifier())
            {
                context.Writer.WritePropertyName("PlatformIdentifier");
                context.Writer.WriteStringValue(requestObject.PlatformIdentifier);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetRootAccess())
            {
                context.Writer.WritePropertyName("RootAccess");
                context.Writer.WriteStringValue(requestObject.RootAccess);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.WriteStringValue(requestObject.SubnetId);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

            if(requestObject.IsSetVolumeSizeInGB())
            {
                context.Writer.WritePropertyName("VolumeSizeInGB");
                context.Writer.WriteNumberValue(requestObject.VolumeSizeInGB.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSageMakerNotebookInstanceDetailsMarshaller Instance = new AwsSageMakerNotebookInstanceDetailsMarshaller();

    }
}