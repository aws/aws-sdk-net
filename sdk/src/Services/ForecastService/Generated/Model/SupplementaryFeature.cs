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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Describes a supplementary feature of a dataset group. This object is part of the <a>InputDataConfig</a>
    /// object.
    /// 
    ///  
    /// <para>
    /// The only supported feature is a holiday calendar. If you use the calendar, all data
    /// in the datasets should belong to the same country as the calendar. For the holiday
    /// calendar data, see the <a href="http://jollyday.sourceforge.net/data.html">Jollyday</a>
    /// web site.
    /// </para>
    ///  
    /// <para>
    /// India and Korea's holidays are not included in the Jollyday library, but both are
    /// supported by Amazon Forecast. Their holidays are:
    /// </para>
    ///  
    /// <para>
    ///  <b>"IN" - INDIA</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>JANUARY 26 - REPUBLIC DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AUGUST 15 - INDEPENDENCE DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OCTOBER 2 GANDHI'S BIRTHDAY</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>"KR" - KOREA</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>JANUARY 1 - NEW YEAR</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>MARCH 1 - INDEPENDENCE MOVEMENT DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>MAY 5 - CHILDREN'S DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>JUNE 6 - MEMORIAL DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AUGUST 15 - LIBERATION DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OCTOBER 3 - NATIONAL FOUNDATION DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>OCTOBER 9 - HANGEUL DAY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DECEMBER 25 - CHRISTMAS DAY</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SupplementaryFeature
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the feature. This must be "holiday".
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// One of the following 2 letter country codes:
        /// </para>
        ///  <ul> <li> 
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
        /// "BE" - BELGIUM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "BR" - BRAZIL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CA" - CANADA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "CN" - CHINA
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
        /// "HU" - HUNGARY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IE" - IRELAND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "IN" - INDIA
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
        /// "KR" - KOREA
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "LU" - LUXEMBOURG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "MX" - MEXICO
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NL" - NETHERLANDS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "NO" - NORWAY
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
        /// "RU" - RUSSIA
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
        /// "US" - UNITED STATES
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "UK" - UNITED KINGDOM
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}