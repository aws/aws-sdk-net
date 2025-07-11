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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Describes an additional dataset. This object is part of the <a>DataConfig</a> object.
    /// Forecast supports the Weather Index and Holidays additional datasets.
    /// 
    ///  
    /// <para>
    ///  <b>Weather Index</b> 
    /// </para>
    ///  
    /// <para>
    /// The Amazon Forecast Weather Index is a built-in dataset that incorporates historical
    /// and projected weather information into your model. The Weather Index supplements your
    /// datasets with over two years of historical weather data and up to 14 days of projected
    /// weather data. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/weather.html">Amazon
    /// Forecast Weather Index</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Holidays</b> 
    /// </para>
    ///  
    /// <para>
    /// Holidays is a built-in dataset that incorporates national holiday information into
    /// your model. It provides native support for the holiday calendars of 66 countries.
    /// To view the holiday calendars, refer to the <a href="http://jollyday.sourceforge.net/data.html">Jollyday</a>
    /// library. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/holidays.html">Holidays
    /// Featurization</a>.
    /// </para>
    /// </summary>
    public partial class AdditionalDataset
    {
        private Dictionary<string, List<string>> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        ///  <b>Weather Index</b> 
        /// </para>
        ///  
        /// <para>
        /// To enable the Weather Index, do not specify a value for <c>Configuration</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Holidays</b> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Holidays</b> 
        /// </para>
        ///  
        /// <para>
        /// To enable Holidays, set <c>CountryCode</c> to one of the following two-letter country
        /// codes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "AL" - ALBANIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "AR" - ARGENTINA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "AT" - AUSTRIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "AU" - AUSTRALIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BA" - BOSNIA HERZEGOVINA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BE" - BELGIUM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BG" - BULGARIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BO" - BOLIVIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BR" - BRAZIL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BY" - BELARUS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CA" - CANADA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CL" - CHILE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CO" - COLOMBIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CR" - COSTA RICA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "HR" - CROATIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CZ" - CZECH REPUBLIC
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "DK" - DENMARK
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "EC" - ECUADOR
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "EE" - ESTONIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ET" - ETHIOPIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "FI" - FINLAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "FR" - FRANCE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "DE" - GERMANY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "GR" - GREECE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "HU" - HUNGARY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IS" - ICELAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IN" - INDIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IE" - IRELAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IT" - ITALY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "JP" - JAPAN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "KZ" - KAZAKHSTAN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "KR" - KOREA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "LV" - LATVIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "LI" - LIECHTENSTEIN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "LT" - LITHUANIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "LU" - LUXEMBOURG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "MK" - MACEDONIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "MT" - MALTA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "MX" - MEXICO
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "MD" - MOLDOVA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ME" - MONTENEGRO
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NL" - NETHERLANDS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NZ" - NEW ZEALAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NI" - NICARAGUA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NG" - NIGERIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NO" - NORWAY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "PA" - PANAMA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "PY" - PARAGUAY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "PE" - PERU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "PL" - POLAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "PT" - PORTUGAL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "RO" - ROMANIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "RU" - RUSSIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "RS" - SERBIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "SK" - SLOVAKIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "SI" - SLOVENIA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ZA" - SOUTH AFRICA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ES" - SPAIN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "SE" - SWEDEN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CH" - SWITZERLAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "UA" - UKRAINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "AE" - UNITED ARAB EMIRATES
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "US" - UNITED STATES
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "UK" - UNITED KINGDOM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "UY" - URUGUAY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "VE" - VENEZUELA
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && (this._configuration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the additional dataset. Valid names: <c>"holiday"</c> and <c>"weather"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}