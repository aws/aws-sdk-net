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
        private CanadaAdditionalInfo _canadaAdditionalInfo;
        private EstoniaAdditionalInfo _estoniaAdditionalInfo;
        private GeorgiaAdditionalInfo _georgiaAdditionalInfo;
        private IsraelAdditionalInfo _israelAdditionalInfo;
        private ItalyAdditionalInfo _italyAdditionalInfo;
        private KenyaAdditionalInfo _kenyaAdditionalInfo;
        private MalaysiaAdditionalInfo _malaysiaAdditionalInfo;
        private PolandAdditionalInfo _polandAdditionalInfo;
        private RomaniaAdditionalInfo _romaniaAdditionalInfo;
        private SaudiArabiaAdditionalInfo _saudiArabiaAdditionalInfo;
        private SouthKoreaAdditionalInfo _southKoreaAdditionalInfo;
        private SpainAdditionalInfo _spainAdditionalInfo;
        private TurkeyAdditionalInfo _turkeyAdditionalInfo;
        private UkraineAdditionalInfo _ukraineAdditionalInfo;

        /// <summary>
        /// Gets and sets the property CanadaAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Canada.
        /// </para>
        /// </summary>
        public CanadaAdditionalInfo CanadaAdditionalInfo
        {
            get { return this._canadaAdditionalInfo; }
            set { this._canadaAdditionalInfo = value; }
        }

        // Check to see if CanadaAdditionalInfo property is set
        internal bool IsSetCanadaAdditionalInfo()
        {
            return this._canadaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EstoniaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Estonia.
        /// </para>
        /// </summary>
        public EstoniaAdditionalInfo EstoniaAdditionalInfo
        {
            get { return this._estoniaAdditionalInfo; }
            set { this._estoniaAdditionalInfo = value; }
        }

        // Check to see if EstoniaAdditionalInfo property is set
        internal bool IsSetEstoniaAdditionalInfo()
        {
            return this._estoniaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property GeorgiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Georgia. 
        /// </para>
        /// </summary>
        public GeorgiaAdditionalInfo GeorgiaAdditionalInfo
        {
            get { return this._georgiaAdditionalInfo; }
            set { this._georgiaAdditionalInfo = value; }
        }

        // Check to see if GeorgiaAdditionalInfo property is set
        internal bool IsSetGeorgiaAdditionalInfo()
        {
            return this._georgiaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property IsraelAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Israel.
        /// </para>
        /// </summary>
        public IsraelAdditionalInfo IsraelAdditionalInfo
        {
            get { return this._israelAdditionalInfo; }
            set { this._israelAdditionalInfo = value; }
        }

        // Check to see if IsraelAdditionalInfo property is set
        internal bool IsSetIsraelAdditionalInfo()
        {
            return this._israelAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ItalyAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. 
        /// </para>
        /// </summary>
        public ItalyAdditionalInfo ItalyAdditionalInfo
        {
            get { return this._italyAdditionalInfo; }
            set { this._italyAdditionalInfo = value; }
        }

        // Check to see if ItalyAdditionalInfo property is set
        internal bool IsSetItalyAdditionalInfo()
        {
            return this._italyAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property KenyaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Kenya.
        /// </para>
        /// </summary>
        public KenyaAdditionalInfo KenyaAdditionalInfo
        {
            get { return this._kenyaAdditionalInfo; }
            set { this._kenyaAdditionalInfo = value; }
        }

        // Check to see if KenyaAdditionalInfo property is set
        internal bool IsSetKenyaAdditionalInfo()
        {
            return this._kenyaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property MalaysiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Malaysia.
        /// </para>
        /// </summary>
        public MalaysiaAdditionalInfo MalaysiaAdditionalInfo
        {
            get { return this._malaysiaAdditionalInfo; }
            set { this._malaysiaAdditionalInfo = value; }
        }

        // Check to see if MalaysiaAdditionalInfo property is set
        internal bool IsSetMalaysiaAdditionalInfo()
        {
            return this._malaysiaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property PolandAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Poland. 
        /// </para>
        /// </summary>
        public PolandAdditionalInfo PolandAdditionalInfo
        {
            get { return this._polandAdditionalInfo; }
            set { this._polandAdditionalInfo = value; }
        }

        // Check to see if PolandAdditionalInfo property is set
        internal bool IsSetPolandAdditionalInfo()
        {
            return this._polandAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RomaniaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Romania.
        /// </para>
        /// </summary>
        public RomaniaAdditionalInfo RomaniaAdditionalInfo
        {
            get { return this._romaniaAdditionalInfo; }
            set { this._romaniaAdditionalInfo = value; }
        }

        // Check to see if RomaniaAdditionalInfo property is set
        internal bool IsSetRomaniaAdditionalInfo()
        {
            return this._romaniaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SaudiArabiaAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Saudi Arabia. 
        /// </para>
        /// </summary>
        public SaudiArabiaAdditionalInfo SaudiArabiaAdditionalInfo
        {
            get { return this._saudiArabiaAdditionalInfo; }
            set { this._saudiArabiaAdditionalInfo = value; }
        }

        // Check to see if SaudiArabiaAdditionalInfo property is set
        internal bool IsSetSaudiArabiaAdditionalInfo()
        {
            return this._saudiArabiaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SouthKoreaAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in South Korea.
        /// </para>
        /// </summary>
        public SouthKoreaAdditionalInfo SouthKoreaAdditionalInfo
        {
            get { return this._southKoreaAdditionalInfo; }
            set { this._southKoreaAdditionalInfo = value; }
        }

        // Check to see if SouthKoreaAdditionalInfo property is set
        internal bool IsSetSouthKoreaAdditionalInfo()
        {
            return this._southKoreaAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property SpainAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Spain.
        /// </para>
        /// </summary>
        public SpainAdditionalInfo SpainAdditionalInfo
        {
            get { return this._spainAdditionalInfo; }
            set { this._spainAdditionalInfo = value; }
        }

        // Check to see if SpainAdditionalInfo property is set
        internal bool IsSetSpainAdditionalInfo()
        {
            return this._spainAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property TurkeyAdditionalInfo. 
        /// <para>
        /// Additional tax information to specify for a TRN in Turkey.
        /// </para>
        /// </summary>
        public TurkeyAdditionalInfo TurkeyAdditionalInfo
        {
            get { return this._turkeyAdditionalInfo; }
            set { this._turkeyAdditionalInfo = value; }
        }

        // Check to see if TurkeyAdditionalInfo property is set
        internal bool IsSetTurkeyAdditionalInfo()
        {
            return this._turkeyAdditionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property UkraineAdditionalInfo. 
        /// <para>
        ///  Additional tax information associated with your TRN in Ukraine. 
        /// </para>
        /// </summary>
        public UkraineAdditionalInfo UkraineAdditionalInfo
        {
            get { return this._ukraineAdditionalInfo; }
            set { this._ukraineAdditionalInfo = value; }
        }

        // Check to see if UkraineAdditionalInfo property is set
        internal bool IsSetUkraineAdditionalInfo()
        {
            return this._ukraineAdditionalInfo != null;
        }

    }
}