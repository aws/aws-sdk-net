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
                context.Writer.WriteStartObject();

                var marshaller = AddKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.AddKeys, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCopyValue())
            {
                context.Writer.WritePropertyName("copyValue");
                context.Writer.WriteStartObject();

                var marshaller = CopyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCsv())
            {
                context.Writer.WritePropertyName("csv");
                context.Writer.WriteStartObject();

                var marshaller = CSVMarshaller.Instance;
                marshaller.Marshall(requestObject.Csv, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDateTimeConverter())
            {
                context.Writer.WritePropertyName("dateTimeConverter");
                context.Writer.WriteStartObject();

                var marshaller = DateTimeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.DateTimeConverter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeleteKeys())
            {
                context.Writer.WritePropertyName("deleteKeys");
                context.Writer.WriteStartObject();

                var marshaller = DeleteKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteKeys, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGrok())
            {
                context.Writer.WritePropertyName("grok");
                context.Writer.WriteStartObject();

                var marshaller = GrokMarshaller.Instance;
                marshaller.Marshall(requestObject.Grok, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListToMap())
            {
                context.Writer.WritePropertyName("listToMap");
                context.Writer.WriteStartObject();

                var marshaller = ListToMapMarshaller.Instance;
                marshaller.Marshall(requestObject.ListToMap, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLowerCaseString())
            {
                context.Writer.WritePropertyName("lowerCaseString");
                context.Writer.WriteStartObject();

                var marshaller = LowerCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.LowerCaseString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMoveKeys())
            {
                context.Writer.WritePropertyName("moveKeys");
                context.Writer.WriteStartObject();

                var marshaller = MoveKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.MoveKeys, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseCloudfront())
            {
                context.Writer.WritePropertyName("parseCloudfront");
                context.Writer.WriteStartObject();

                var marshaller = ParseCloudfrontMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseCloudfront, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseJSON())
            {
                context.Writer.WritePropertyName("parseJSON");
                context.Writer.WriteStartObject();

                var marshaller = ParseJSONMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseJSON, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseKeyValue())
            {
                context.Writer.WritePropertyName("parseKeyValue");
                context.Writer.WriteStartObject();

                var marshaller = ParseKeyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseKeyValue, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParsePostgres())
            {
                context.Writer.WritePropertyName("parsePostgres");
                context.Writer.WriteStartObject();

                var marshaller = ParsePostgresMarshaller.Instance;
                marshaller.Marshall(requestObject.ParsePostgres, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseRoute53())
            {
                context.Writer.WritePropertyName("parseRoute53");
                context.Writer.WriteStartObject();

                var marshaller = ParseRoute53Marshaller.Instance;
                marshaller.Marshall(requestObject.ParseRoute53, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseToOCSF())
            {
                context.Writer.WritePropertyName("parseToOCSF");
                context.Writer.WriteStartObject();

                var marshaller = ParseToOCSFMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseToOCSF, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseVPC())
            {
                context.Writer.WritePropertyName("parseVPC");
                context.Writer.WriteStartObject();

                var marshaller = ParseVPCMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseVPC, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParseWAF())
            {
                context.Writer.WritePropertyName("parseWAF");
                context.Writer.WriteStartObject();

                var marshaller = ParseWAFMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseWAF, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenameKeys())
            {
                context.Writer.WritePropertyName("renameKeys");
                context.Writer.WriteStartObject();

                var marshaller = RenameKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameKeys, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSplitString())
            {
                context.Writer.WritePropertyName("splitString");
                context.Writer.WriteStartObject();

                var marshaller = SplitStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SplitString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSubstituteString())
            {
                context.Writer.WritePropertyName("substituteString");
                context.Writer.WriteStartObject();

                var marshaller = SubstituteStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SubstituteString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTrimString())
            {
                context.Writer.WritePropertyName("trimString");
                context.Writer.WriteStartObject();

                var marshaller = TrimStringMarshaller.Instance;
                marshaller.Marshall(requestObject.TrimString, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTypeConverter())
            {
                context.Writer.WritePropertyName("typeConverter");
                context.Writer.WriteStartObject();

                var marshaller = TypeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.TypeConverter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpperCaseString())
            {
                context.Writer.WritePropertyName("upperCaseString");
                context.Writer.WriteStartObject();

                var marshaller = UpperCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.UpperCaseString, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProcessorMarshaller Instance = new ProcessorMarshaller();

    }
}