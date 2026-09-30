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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your tax registration number (TRN). Depending
    /// on the TRN for a specific country, you might need to specify this information when
    /// you set your TRN. 
    /// 
    ///  
    /// <para>
    /// You can only specify one of the following parameters and the value can't be empty.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// The parameter that you specify must match the country for the TRN, if available. For
    /// example, if you set a TRN in Canada for specific provinces, you must also specify
    /// the <c>canadaAdditionalInfo</c> parameter.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AdditionalInfoRequest
    {
        /// <summary>
        /// Gets and sets the property BelgiumAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Belgium.
        /// </para>
        /// </summary>
        public BelgiumAdditionalInfo BelgiumAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the BelgiumAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetBelgiumAdditionalInfo() => this.BelgiumAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property CanadaAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Canada.
        /// </para>
        /// </summary>
        public CanadaAdditionalInfo CanadaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the CanadaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetCanadaAdditionalInfo() => this.CanadaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property ChileAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Chile.
        /// </para>
        /// </summary>
        public ChileAdditionalInfo ChileAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the ChileAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetChileAdditionalInfo() => this.ChileAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property EgyptAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Egypt. 
        /// </para>
        /// </summary>
        public EgyptAdditionalInfo EgyptAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the EgyptAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetEgyptAdditionalInfo() => this.EgyptAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property EstoniaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Estonia.
        /// </para>
        /// </summary>
        public EstoniaAdditionalInfo EstoniaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the EstoniaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetEstoniaAdditionalInfo() => this.EstoniaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property FranceAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in France.
        /// </para>
        /// </summary>
        public FranceAdditionalInfo FranceAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the FranceAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetFranceAdditionalInfo() => this.FranceAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property GeorgiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Georgia. 
        /// </para>
        /// </summary>
        public GeorgiaAdditionalInfo GeorgiaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the GeorgiaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetGeorgiaAdditionalInfo() => this.GeorgiaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property GreeceAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Greece.
        /// </para>
        /// </summary>
        public GreeceAdditionalInfo GreeceAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the GreeceAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetGreeceAdditionalInfo() => this.GreeceAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property IndonesiaAdditionalInfo. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public IndonesiaAdditionalInfo IndonesiaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the IndonesiaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetIndonesiaAdditionalInfo() => this.IndonesiaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property IsraelAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Israel.
        /// </para>
        /// </summary>
        public IsraelAdditionalInfo IsraelAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the IsraelAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetIsraelAdditionalInfo() => this.IsraelAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property ItalyAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. 
        /// </para>
        /// </summary>
        public ItalyAdditionalInfo ItalyAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the ItalyAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetItalyAdditionalInfo() => this.ItalyAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property KenyaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Kenya.
        /// </para>
        /// </summary>
        public KenyaAdditionalInfo KenyaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the KenyaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetKenyaAdditionalInfo() => this.KenyaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property MalaysiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Malaysia.
        /// </para>
        /// </summary>
        public MalaysiaAdditionalInfo MalaysiaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the MalaysiaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetMalaysiaAdditionalInfo() => this.MalaysiaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property MonacoAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Monaco.
        /// </para>
        /// </summary>
        public MonacoAdditionalInfo MonacoAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the MonacoAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetMonacoAdditionalInfo() => this.MonacoAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property PhilippinesAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in the Philippines.
        /// </para>
        /// </summary>
        public PhilippinesAdditionalInfo PhilippinesAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the PhilippinesAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetPhilippinesAdditionalInfo() => this.PhilippinesAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property PolandAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Poland. 
        /// </para>
        /// </summary>
        public PolandAdditionalInfo PolandAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the PolandAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetPolandAdditionalInfo() => this.PolandAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property RomaniaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Romania.
        /// </para>
        /// </summary>
        public RomaniaAdditionalInfo RomaniaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the RomaniaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetRomaniaAdditionalInfo() => this.RomaniaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property SaudiArabiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Saudi Arabia. 
        /// </para>
        /// </summary>
        public SaudiArabiaAdditionalInfo SaudiArabiaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the SaudiArabiaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetSaudiArabiaAdditionalInfo() => this.SaudiArabiaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property SouthKoreaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in South Korea.
        /// </para>
        /// </summary>
        public SouthKoreaAdditionalInfo SouthKoreaAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the SouthKoreaAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetSouthKoreaAdditionalInfo() => this.SouthKoreaAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property SpainAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Spain.
        /// </para>
        /// </summary>
        public SpainAdditionalInfo SpainAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the SpainAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetSpainAdditionalInfo() => this.SpainAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property TurkeyAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Turkey.
        /// </para>
        /// </summary>
        public TurkeyAdditionalInfo TurkeyAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the TurkeyAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetTurkeyAdditionalInfo() => this.TurkeyAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property UkraineAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Ukraine. 
        /// </para>
        /// </summary>
        public UkraineAdditionalInfo UkraineAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the UkraineAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetUkraineAdditionalInfo() => this.UkraineAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property UzbekistanAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Uzbekistan. 
        /// </para>
        /// </summary>
        public UzbekistanAdditionalInfo UzbekistanAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the UzbekistanAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetUzbekistanAdditionalInfo() => this.UzbekistanAdditionalInfo != null;

        /// <summary>
        /// Gets and sets the property VietnamAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Vietnam. 
        /// </para>
        /// </summary>
        public VietnamAdditionalInfo VietnamAdditionalInfo { get; set; }

        /// <summary>
        /// Checks to see if the VietnamAdditionalInfo property is set.
        /// </summary>
        internal bool IsSetVietnamAdditionalInfo() => this.VietnamAdditionalInfo != null;
    }
}
