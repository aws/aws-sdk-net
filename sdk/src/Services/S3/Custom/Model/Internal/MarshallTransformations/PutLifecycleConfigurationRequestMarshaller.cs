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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Custom marshaller for PutLifecycleConfigurationRequest with custom methods
    /// </summary>
    public partial class PutLifecycleConfigurationRequestMarshaller : IMarshaller<IRequest, PutLifecycleConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        void CustomStatusMarshalling(XmlWriter writer, LifecycleRule rule)
        {
            if (rule.IsSetStatus())
            {
                writer.WriteElementString("Status", S3Transforms.ToXmlStringValue(rule.Status));
            }
            else
            {
                writer.WriteElementString("Status", "Disabled");
            }
        }
    }
}
