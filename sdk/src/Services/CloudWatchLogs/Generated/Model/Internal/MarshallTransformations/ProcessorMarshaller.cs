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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Processor Marshaller
    /// </summary>
    public class ProcessorMarshaller : IRequestMarshaller<Processor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Processor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddKeys())
            {
                context.Writer.WritePropertyName("addKeys");
                context.Writer.WriteObjectStart();

                var marshaller = AddKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.AddKeys, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCopyValue())
            {
                context.Writer.WritePropertyName("copyValue");
                context.Writer.WriteObjectStart();

                var marshaller = CopyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCsv())
            {
                context.Writer.WritePropertyName("csv");
                context.Writer.WriteObjectStart();

                var marshaller = CSVMarshaller.Instance;
                marshaller.Marshall(requestObject.Csv, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDateTimeConverter())
            {
                context.Writer.WritePropertyName("dateTimeConverter");
                context.Writer.WriteObjectStart();

                var marshaller = DateTimeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.DateTimeConverter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeleteKeys())
            {
                context.Writer.WritePropertyName("deleteKeys");
                context.Writer.WriteObjectStart();

                var marshaller = DeleteKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteKeys, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGrok())
            {
                context.Writer.WritePropertyName("grok");
                context.Writer.WriteObjectStart();

                var marshaller = GrokMarshaller.Instance;
                marshaller.Marshall(requestObject.Grok, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetListToMap())
            {
                context.Writer.WritePropertyName("listToMap");
                context.Writer.WriteObjectStart();

                var marshaller = ListToMapMarshaller.Instance;
                marshaller.Marshall(requestObject.ListToMap, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLowerCaseString())
            {
                context.Writer.WritePropertyName("lowerCaseString");
                context.Writer.WriteObjectStart();

                var marshaller = LowerCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.LowerCaseString, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMoveKeys())
            {
                context.Writer.WritePropertyName("moveKeys");
                context.Writer.WriteObjectStart();

                var marshaller = MoveKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.MoveKeys, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseCloudfront())
            {
                context.Writer.WritePropertyName("parseCloudfront");
                context.Writer.WriteObjectStart();

                var marshaller = ParseCloudfrontMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseCloudfront, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseJSON())
            {
                context.Writer.WritePropertyName("parseJSON");
                context.Writer.WriteObjectStart();

                var marshaller = ParseJSONMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseJSON, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseKeyValue())
            {
                context.Writer.WritePropertyName("parseKeyValue");
                context.Writer.WriteObjectStart();

                var marshaller = ParseKeyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseKeyValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParsePostgres())
            {
                context.Writer.WritePropertyName("parsePostgres");
                context.Writer.WriteObjectStart();

                var marshaller = ParsePostgresMarshaller.Instance;
                marshaller.Marshall(requestObject.ParsePostgres, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseRoute53())
            {
                context.Writer.WritePropertyName("parseRoute53");
                context.Writer.WriteObjectStart();

                var marshaller = ParseRoute53Marshaller.Instance;
                marshaller.Marshall(requestObject.ParseRoute53, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseVPC())
            {
                context.Writer.WritePropertyName("parseVPC");
                context.Writer.WriteObjectStart();

                var marshaller = ParseVPCMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseVPC, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParseWAF())
            {
                context.Writer.WritePropertyName("parseWAF");
                context.Writer.WriteObjectStart();

                var marshaller = ParseWAFMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseWAF, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRenameKeys())
            {
                context.Writer.WritePropertyName("renameKeys");
                context.Writer.WriteObjectStart();

                var marshaller = RenameKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameKeys, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSplitString())
            {
                context.Writer.WritePropertyName("splitString");
                context.Writer.WriteObjectStart();

                var marshaller = SplitStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SplitString, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSubstituteString())
            {
                context.Writer.WritePropertyName("substituteString");
                context.Writer.WriteObjectStart();

                var marshaller = SubstituteStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SubstituteString, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTrimString())
            {
                context.Writer.WritePropertyName("trimString");
                context.Writer.WriteObjectStart();

                var marshaller = TrimStringMarshaller.Instance;
                marshaller.Marshall(requestObject.TrimString, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTypeConverter())
            {
                context.Writer.WritePropertyName("typeConverter");
                context.Writer.WriteObjectStart();

                var marshaller = TypeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.TypeConverter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUpperCaseString())
            {
                context.Writer.WritePropertyName("upperCaseString");
                context.Writer.WriteObjectStart();

                var marshaller = UpperCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.UpperCaseString, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProcessorMarshaller Instance = new ProcessorMarshaller();

    }
}