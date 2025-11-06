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
