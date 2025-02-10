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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResultConfigurationUpdates Marshaller
    /// </summary>
    public class ResultConfigurationUpdatesMarshaller : IRequestMarshaller<ResultConfigurationUpdates, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResultConfigurationUpdates requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAclConfiguration())
            {
                context.Writer.WritePropertyName("AclConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AclConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AclConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExpectedBucketOwner())
            {
                context.Writer.WritePropertyName("ExpectedBucketOwner");
                context.Writer.WriteStringValue(requestObject.ExpectedBucketOwner);
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("OutputLocation");
                context.Writer.WriteStringValue(requestObject.OutputLocation);
            }

            if(requestObject.IsSetRemoveAclConfiguration())
            {
                context.Writer.WritePropertyName("RemoveAclConfiguration");
                context.Writer.WriteBooleanValue(requestObject.RemoveAclConfiguration.Value);
            }

            if(requestObject.IsSetRemoveEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("RemoveEncryptionConfiguration");
                context.Writer.WriteBooleanValue(requestObject.RemoveEncryptionConfiguration.Value);
            }

            if(requestObject.IsSetRemoveExpectedBucketOwner())
            {
                context.Writer.WritePropertyName("RemoveExpectedBucketOwner");
                context.Writer.WriteBooleanValue(requestObject.RemoveExpectedBucketOwner.Value);
            }

            if(requestObject.IsSetRemoveOutputLocation())
            {
                context.Writer.WritePropertyName("RemoveOutputLocation");
                context.Writer.WriteBooleanValue(requestObject.RemoveOutputLocation.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResultConfigurationUpdatesMarshaller Instance = new ResultConfigurationUpdatesMarshaller();

    }
}