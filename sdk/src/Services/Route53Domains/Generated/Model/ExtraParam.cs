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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// ExtraParam includes the following elements.
    /// </summary>
    public partial class ExtraParam
    {
        private ExtraParamName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an additional parameter that is required by a top-level domain. Here are
        /// the top-level domains that require additional parameters and the names of the parameters
        /// that they require:
        /// </para>
        ///  <dl> <dt>.com.au and .net.au</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>AU_ID_NUMBER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AU_ID_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ABN</c> (Australian business number)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACN</c> (Australian company number)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TM</c> (Trademark number)
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.ca</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>BRAND_NUMBER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CA_BUSINESS_ENTITY_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BANK</c> (Bank)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMMERCIAL_COMPANY</c> (Commercial company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPANY</c> (Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COOPERATION</c> (Cooperation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COOPERATIVE</c> (Cooperative)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COOPRIX</c> (Cooprix)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CORP</c> (Corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREDIT_UNION</c> (Credit union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOMIA</c> (Federation of mutual insurance associations)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INC</c> (Incorporated)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LTD</c> (Limited)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LTEE</c> (Limitée)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LLC</c> (Limited liability corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LLP</c> (Limited liability partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LTE</c> (Lte.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MBA</c> (Mutual benefit association)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MIC</c> (Mutual insurance company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NFP</c> (Not-for-profit corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SA</c> (S.A.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_COMPANY</c> (Savings company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_UNION</c> (Savings union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SARL</c> (Société à responsabilité limitée)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRUST</c> (Trust)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ULC</c> (Unlimited liability corporation)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CA_LEGAL_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// When <c>ContactType</c> is <c>PERSON</c>, valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ABO</c> (Aboriginal Peoples indigenous to Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CCT</c> (Canadian citizen)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LGR</c> (Legal Representative of a Canadian Citizen or Permanent Resident)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RES</c> (Permanent resident of Canada)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <c>ContactType</c> is a value other than <c>PERSON</c>, valid values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASS</c> (Canadian unincorporated association)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CCO</c> (Canadian corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EDU</c> (Canadian educational institution)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOV</c> (Government or government entity in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOP</c> (Canadian Hospital)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INB</c> (Indian Band recognized by the Indian Act of Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAM</c> (Canadian Library, Archive, or Museum)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAJ</c> (Her/His Majesty the Queen/King)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OMK</c> (Official mark registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLT</c> (Canadian Political Party)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PRT</c> (Partnership Registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TDM</c> (Trademark registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRD</c> (Canadian Trade Union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRS</c> (Trust established in Canada)
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.es</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>ES_IDENTIFICATION</c> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>ES_IDENTIFICATION</c> depends on the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <c>ES_LEGAL_FORM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <c>ES_IDENTIFICATION_TYPE</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>If <c>ES_LEGAL_FORM</c> is any value other than <c>INDIVIDUAL</c>:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify 1 letter + 8 numbers (CIF [Certificado de Identificación Fiscal])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: B12345678
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>If <c>ES_LEGAL_FORM</c> is <c>INDIVIDUAL</c>, the value that you specify for <c>ES_IDENTIFICATION</c>
        /// depends on the value of <c>ES_IDENTIFICATION_TYPE</c>:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>ES_IDENTIFICATION_TYPE</c> is <c>DNI_AND_NIF</c> (for Spanish contacts):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify 8 numbers + 1 letter (DNI [Documento Nacional de Identidad], NIF [Número de
        /// Identificación Fiscal])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: 12345678M
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If <c>ES_IDENTIFICATION_TYPE</c> is <c>NIE</c> (for foreigners with legal residence):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify 1 letter + 7 numbers + 1 letter ( NIE [Número de Identidad de Extranjero])
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: Y1234567X
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If <c>ES_IDENTIFICATION_TYPE</c> is <c>OTHER</c> (for contacts outside of Spain):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a passport number, drivers license number, or national identity card number
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ES_IDENTIFICATION_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DNI_AND_NIF</c> (For Spanish contacts)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NIE</c> (For foreigners with legal residence)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OTHER</c> (For contacts outside of Spain)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ES_LEGAL_FORM</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASSOCIATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CENTRAL_GOVERNMENT_BODY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CIVIL_SOCIETY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMMUNITY_OF_OWNERS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMMUNITY_PROPERTY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONSULATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COOPERATIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESIGNATION_OF_ORIGIN_SUPERVISORY_COUNCIL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ECONOMIC_INTEREST_GROUP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMBASSY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTITY_MANAGING_NATURAL_AREAS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FARM_PARTNERSHIP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOUNDATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GENERAL_AND_LIMITED_PARTNERSHIP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GENERAL_PARTNERSHIP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INDIVIDUAL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LIMITED_COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCAL_AUTHORITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCAL_PUBLIC_ENTITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MUTUAL_INSURANCE_COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NATIONAL_PUBLIC_ENTITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ORDER_OR_RELIGIOUS_INSTITUTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OTHERS (Only for contacts outside of Spain)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POLITICAL_PARTY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROFESSIONAL_ASSOCIATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_LAW_ASSOCIATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_LIMITED_COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGIONAL_GOVERNMENT_BODY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGIONAL_PUBLIC_ENTITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAVINGS_BANK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPANISH_OFFICE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPORTS_ASSOCIATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPORTS_FEDERATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPORTS_LIMITED_COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_ALLIANCE_OF_ENTERPRISES</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRADE_UNION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WORKER_OWNED_COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WORKER_OWNED_LIMITED_COMPANY</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.eu</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c> EU_COUNTRY_OF_CITIZENSHIP</c> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.fi</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>BIRTH_DATE_IN_YYYY_MM_DD</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FI_BUSINESS_NUMBER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FI_ID_NUMBER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FI_NATIONALITY</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FINNISH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_FINNISH</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>FI_ORGANIZATION_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPANY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CORPORATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOVERNMENT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTITUTION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>POLITICAL_PARTY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_COMMUNITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOWNSHIP</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.it</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>IT_NATIONALITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IT_PIN</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IT_REGISTRANT_ENTITY_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FOREIGNERS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FREELANCE_WORKERS</c> (Freelance workers and professionals)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ITALIAN_COMPANIES</c> (Italian companies and one-person companies)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_PROFIT_ORGANIZATIONS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OTHER_SUBJECTS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_ORGANIZATIONS</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.ru</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>BIRTH_DATE_IN_YYYY_MM_DD</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RU_PASSPORT_DATA</c> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.se</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>BIRTH_COUNTRY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SE_ID_NUMBER</c> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.sg</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>SG_ID_NUMBER</c> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.uk, .co.uk, .me.uk, and .org.uk</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>UK_CONTACT_TYPE</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CRC</c> (UK Corporation by Royal Charter)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FCORP</c> (Non-UK Corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIND</c> (Non-UK Individual, representing self)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FOTHER</c> (Non-UK Entity that does not fit into any other category)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOV</c> (UK Government Body)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IND</c> (UK Individual (representing self))
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IP</c> (UK Industrial/Provident Registered Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LLP</c> (UK Limited Liability Partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LTD</c> (UK Limited Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OTHER</c> (UK Entity that does not fit into any other category)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLC</c> (UK Public Limited Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PTNR</c> (UK Partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RCHAR</c> (UK Registered Charity)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCH</c> (UK School)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STAT</c> (UK Statutory Body)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRA</c> (UK Sole Trader)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UK_COMPANY_NUMBER</c> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// In addition, many TLDs require a <c>VAT_NUMBER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtraParamName Name
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
        /// The value that corresponds with the name of an extra parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=2048)]
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