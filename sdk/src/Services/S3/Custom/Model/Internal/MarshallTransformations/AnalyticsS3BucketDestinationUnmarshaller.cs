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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Custom unmarshaller for AnalyticsS3BucketDestination Object
    /// </summary>
    public partial class AnalyticsS3BucketDestinationUnmarshaller : IXmlUnmarshaller<AnalyticsS3BucketDestination, XmlUnmarshallerContext>
    {
        void FormatCustomUnmarshall(XmlUnmarshallerContext context, AnalyticsS3BucketDestination unmarshalledObject)
        {
            unmarshalledObject.Format = AnalyticsS3ExportFileFormat.FindValue(StringUnmarshaller.Instance.Unmarshall(context));
        }
    }
}
