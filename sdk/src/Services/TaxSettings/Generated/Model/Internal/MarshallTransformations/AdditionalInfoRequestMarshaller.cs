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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdditionalInfoRequest Marshaller
    /// </summary>
    public class AdditionalInfoRequestMarshaller : IRequestMarshaller<AdditionalInfoRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AdditionalInfoRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCanadaAdditionalInfo())
            {
                context.Writer.WritePropertyName("canadaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = CanadaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.CanadaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEstoniaAdditionalInfo())
            {
                context.Writer.WritePropertyName("estoniaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = EstoniaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.EstoniaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGeorgiaAdditionalInfo())
            {
                context.Writer.WritePropertyName("georgiaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = GeorgiaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.GeorgiaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIsraelAdditionalInfo())
            {
                context.Writer.WritePropertyName("israelAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = IsraelAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.IsraelAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetItalyAdditionalInfo())
            {
                context.Writer.WritePropertyName("italyAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = ItalyAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ItalyAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKenyaAdditionalInfo())
            {
                context.Writer.WritePropertyName("kenyaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = KenyaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.KenyaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMalaysiaAdditionalInfo())
            {
                context.Writer.WritePropertyName("malaysiaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = MalaysiaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.MalaysiaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPolandAdditionalInfo())
            {
                context.Writer.WritePropertyName("polandAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = PolandAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.PolandAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRomaniaAdditionalInfo())
            {
                context.Writer.WritePropertyName("romaniaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = RomaniaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.RomaniaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSaudiArabiaAdditionalInfo())
            {
                context.Writer.WritePropertyName("saudiArabiaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = SaudiArabiaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.SaudiArabiaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSouthKoreaAdditionalInfo())
            {
                context.Writer.WritePropertyName("southKoreaAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = SouthKoreaAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.SouthKoreaAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSpainAdditionalInfo())
            {
                context.Writer.WritePropertyName("spainAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = SpainAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.SpainAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTurkeyAdditionalInfo())
            {
                context.Writer.WritePropertyName("turkeyAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = TurkeyAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.TurkeyAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUkraineAdditionalInfo())
            {
                context.Writer.WritePropertyName("ukraineAdditionalInfo");
                context.Writer.WriteObjectStart();

                var marshaller = UkraineAdditionalInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.UkraineAdditionalInfo, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AdditionalInfoRequestMarshaller Instance = new AdditionalInfoRequestMarshaller();

    }
}