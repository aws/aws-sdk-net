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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Processor Marshaller
    /// </summary>
    public class ProcessorMarshaller : IRequestMarshaller<Processor, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Processor requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAddKeys())
            {
                context.Writer.WriteTextString("addKeys");
                context.Writer.WriteStartMap(null);

                var marshaller = AddKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.AddKeys, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetCopyValue())
            {
                context.Writer.WriteTextString("copyValue");
                context.Writer.WriteStartMap(null);

                var marshaller = CopyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.CopyValue, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetCsv())
            {
                context.Writer.WriteTextString("csv");
                context.Writer.WriteStartMap(null);

                var marshaller = CSVMarshaller.Instance;
                marshaller.Marshall(requestObject.Csv, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDateTimeConverter())
            {
                context.Writer.WriteTextString("dateTimeConverter");
                context.Writer.WriteStartMap(null);

                var marshaller = DateTimeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.DateTimeConverter, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDeleteKeys())
            {
                context.Writer.WriteTextString("deleteKeys");
                context.Writer.WriteStartMap(null);

                var marshaller = DeleteKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteKeys, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetGrok())
            {
                context.Writer.WriteTextString("grok");
                context.Writer.WriteStartMap(null);

                var marshaller = GrokMarshaller.Instance;
                marshaller.Marshall(requestObject.Grok, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetListToMap())
            {
                context.Writer.WriteTextString("listToMap");
                context.Writer.WriteStartMap(null);

                var marshaller = ListToMapMarshaller.Instance;
                marshaller.Marshall(requestObject.ListToMap, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetLowerCaseString())
            {
                context.Writer.WriteTextString("lowerCaseString");
                context.Writer.WriteStartMap(null);

                var marshaller = LowerCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.LowerCaseString, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetMoveKeys())
            {
                context.Writer.WriteTextString("moveKeys");
                context.Writer.WriteStartMap(null);

                var marshaller = MoveKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.MoveKeys, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseCloudfront())
            {
                context.Writer.WriteTextString("parseCloudfront");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseCloudfrontMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseCloudfront, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseJSON())
            {
                context.Writer.WriteTextString("parseJSON");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseJSONMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseJSON, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseKeyValue())
            {
                context.Writer.WriteTextString("parseKeyValue");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseKeyValueMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseKeyValue, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParsePostgres())
            {
                context.Writer.WriteTextString("parsePostgres");
                context.Writer.WriteStartMap(null);

                var marshaller = ParsePostgresMarshaller.Instance;
                marshaller.Marshall(requestObject.ParsePostgres, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseRoute53())
            {
                context.Writer.WriteTextString("parseRoute53");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseRoute53Marshaller.Instance;
                marshaller.Marshall(requestObject.ParseRoute53, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseToOCSF())
            {
                context.Writer.WriteTextString("parseToOCSF");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseToOCSFMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseToOCSF, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseVPC())
            {
                context.Writer.WriteTextString("parseVPC");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseVPCMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseVPC, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetParseWAF())
            {
                context.Writer.WriteTextString("parseWAF");
                context.Writer.WriteStartMap(null);

                var marshaller = ParseWAFMarshaller.Instance;
                marshaller.Marshall(requestObject.ParseWAF, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetRenameKeys())
            {
                context.Writer.WriteTextString("renameKeys");
                context.Writer.WriteStartMap(null);

                var marshaller = RenameKeysMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameKeys, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetSplitString())
            {
                context.Writer.WriteTextString("splitString");
                context.Writer.WriteStartMap(null);

                var marshaller = SplitStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SplitString, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetSubstituteString())
            {
                context.Writer.WriteTextString("substituteString");
                context.Writer.WriteStartMap(null);

                var marshaller = SubstituteStringMarshaller.Instance;
                marshaller.Marshall(requestObject.SubstituteString, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetTrimString())
            {
                context.Writer.WriteTextString("trimString");
                context.Writer.WriteStartMap(null);

                var marshaller = TrimStringMarshaller.Instance;
                marshaller.Marshall(requestObject.TrimString, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetTypeConverter())
            {
                context.Writer.WriteTextString("typeConverter");
                context.Writer.WriteStartMap(null);

                var marshaller = TypeConverterMarshaller.Instance;
                marshaller.Marshall(requestObject.TypeConverter, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetUpperCaseString())
            {
                context.Writer.WriteTextString("upperCaseString");
                context.Writer.WriteStartMap(null);

                var marshaller = UpperCaseStringMarshaller.Instance;
                marshaller.Marshall(requestObject.UpperCaseString, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProcessorMarshaller Instance = new ProcessorMarshaller();

    }
}