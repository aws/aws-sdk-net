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
        ///  <code>AU_ID_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AU_ID_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ABN</code> (Australian business number)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACN</code> (Australian company number)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TM</code> (Trademark number)
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.ca</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>BRAND_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CA_BUSINESS_ENTITY_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BANK</code> (Bank)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMMERCIAL_COMPANY</code> (Commercial company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPANY</code> (Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COOPERATION</code> (Cooperation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COOPERATIVE</code> (Cooperative)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COOPRIX</code> (Cooprix)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CORP</code> (Corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREDIT_UNION</code> (Credit union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FOMIA</code> (Federation of mutual insurance associations)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INC</code> (Incorporated)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LTD</code> (Limited)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LTEE</code> (Limitée)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LLC</code> (Limited liability corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LLP</code> (Limited liability partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LTE</code> (Lte.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MBA</code> (Mutual benefit association)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MIC</code> (Mutual insurance company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NFP</code> (Not-for-profit corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SA</code> (S.A.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAVINGS_COMPANY</code> (Savings company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAVINGS_UNION</code> (Savings union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SARL</code> (Société à responsabilité limitée)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRUST</code> (Trust)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ULC</code> (Unlimited liability corporation)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>CA_LEGAL_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// When <code>ContactType</code> is <code>PERSON</code>, valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ABO</code> (Aboriginal Peoples indigenous to Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CCT</code> (Canadian citizen)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LGR</code> (Legal Representative of a Canadian Citizen or Permanent Resident)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RES</code> (Permanent resident of Canada)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When <code>ContactType</code> is a value other than <code>PERSON</code>, valid values
        /// include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASS</code> (Canadian unincorporated association)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CCO</code> (Canadian corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EDU</code> (Canadian educational institution)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GOV</code> (Government or government entity in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HOP</code> (Canadian Hospital)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INB</code> (Indian Band recognized by the Indian Act of Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LAM</code> (Canadian Library, Archive, or Museum)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MAJ</code> (Her/His Majesty the Queen/King)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OMK</code> (Official mark registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLT</code> (Canadian Political Party)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PRT</code> (Partnership Registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TDM</code> (Trademark registered in Canada)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRD</code> (Canadian Trade Union)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRS</code> (Trust established in Canada)
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.es</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>ES_IDENTIFICATION</code> 
        /// </para>
        ///  
        /// <para>
        /// The value of <code>ES_IDENTIFICATION</code> depends on the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value of <code>ES_LEGAL_FORM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value of <code>ES_IDENTIFICATION_TYPE</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>If <code>ES_LEGAL_FORM</code> is any value other than <code>INDIVIDUAL</code>:</b>
        /// 
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
        ///  <b>If <code>ES_LEGAL_FORM</code> is <code>INDIVIDUAL</code>, the value that you specify
        /// for <code>ES_IDENTIFICATION</code> depends on the value of <code>ES_IDENTIFICATION_TYPE</code>:</b>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>ES_IDENTIFICATION_TYPE</code> is <code>DNI_AND_NIF</code> (for Spanish contacts):
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
        /// If <code>ES_IDENTIFICATION_TYPE</code> is <code>NIE</code> (for foreigners with legal
        /// residence):
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
        /// If <code>ES_IDENTIFICATION_TYPE</code> is <code>OTHER</code> (for contacts outside
        /// of Spain):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a passport number, drivers license number, or national identity card number
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <code>ES_IDENTIFICATION_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DNI_AND_NIF</code> (For Spanish contacts)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NIE</code> (For foreigners with legal residence)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OTHER</code> (For contacts outside of Spain)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>ES_LEGAL_FORM</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASSOCIATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CENTRAL_GOVERNMENT_BODY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CIVIL_SOCIETY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMMUNITY_OF_OWNERS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMMUNITY_PROPERTY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONSULATE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COOPERATIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESIGNATION_OF_ORIGIN_SUPERVISORY_COUNCIL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ECONOMIC_INTEREST_GROUP</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EMBASSY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENTITY_MANAGING_NATURAL_AREAS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FARM_PARTNERSHIP</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FOUNDATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GENERAL_AND_LIMITED_PARTNERSHIP</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GENERAL_PARTNERSHIP</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INDIVIDUAL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LIMITED_COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCAL_AUTHORITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCAL_PUBLIC_ENTITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MUTUAL_INSURANCE_COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NATIONAL_PUBLIC_ENTITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ORDER_OR_RELIGIOUS_INSTITUTION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OTHERS (Only for contacts outside of Spain)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>POLITICAL_PARTY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROFESSIONAL_ASSOCIATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUBLIC_LAW_ASSOCIATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUBLIC_LIMITED_COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGIONAL_GOVERNMENT_BODY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGIONAL_PUBLIC_ENTITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SAVINGS_BANK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPANISH_OFFICE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPORTS_ASSOCIATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPORTS_FEDERATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPORTS_LIMITED_COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TEMPORARY_ALLIANCE_OF_ENTERPRISES</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRADE_UNION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WORKER_OWNED_COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WORKER_OWNED_LIMITED_COMPANY</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.eu</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code> EU_COUNTRY_OF_CITIZENSHIP</code> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.fi</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>BIRTH_DATE_IN_YYYY_MM_DD</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FI_BUSINESS_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FI_ID_NUMBER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FI_NATIONALITY</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FINNISH</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_FINNISH</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>FI_ORGANIZATION_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COMPANY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CORPORATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GOVERNMENT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTITUTION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>POLITICAL_PARTY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUBLIC_COMMUNITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TOWNSHIP</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.fr</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>BIRTH_CITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BIRTH_COUNTRY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BIRTH_DATE_IN_YYYY_MM_DD</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BIRTH_DEPARTMENT</code>: Specify the INSEE code that corresponds with the department
        /// where the contact was born. If the contact was born somewhere other than France or
        /// its overseas departments, specify <code>99</code>. For more information, including
        /// a list of departments and the corresponding INSEE numbers, see the Wikipedia entry
        /// <a href="https://en.wikipedia.org/wiki/Departments_of_France">Departments of France</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BRAND_NUMBER</code> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.it</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>IT_NATIONALITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IT_PIN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IT_REGISTRANT_ENTITY_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FOREIGNERS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FREELANCE_WORKERS</code> (Freelance workers and professionals)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ITALIAN_COMPANIES</code> (Italian companies and one-person companies)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NON_PROFIT_ORGANIZATIONS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OTHER_SUBJECTS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PUBLIC_ORGANIZATIONS</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>.ru</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>BIRTH_DATE_IN_YYYY_MM_DD</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RU_PASSPORT_DATA</code> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.se</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>BIRTH_COUNTRY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SE_ID_NUMBER</code> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.sg</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>SG_ID_NUMBER</code> 
        /// </para>
        ///  </li> </ul> </dd> <dt>.uk, .co.uk, .me.uk, and .org.uk</dt> <dd> <ul> <li> 
        /// <para>
        ///  <code>UK_CONTACT_TYPE</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CRC</code> (UK Corporation by Royal Charter)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FCORP</code> (Non-UK Corporation)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FIND</code> (Non-UK Individual, representing self)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FOTHER</code> (Non-UK Entity that does not fit into any other category)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GOV</code> (UK Government Body)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IND</code> (UK Individual (representing self))
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IP</code> (UK Industrial/Provident Registered Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LLP</code> (UK Limited Liability Partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LTD</code> (UK Limited Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OTHER</code> (UK Entity that does not fit into any other category)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLC</code> (UK Public Limited Company)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PTNR</code> (UK Partnership)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RCHAR</code> (UK Registered Charity)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SCH</code> (UK School)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STAT</code> (UK Statutory Body)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STRA</code> (UK Sole Trader)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>UK_COMPANY_NUMBER</code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// In addition, many TLDs require a <code>VAT_NUMBER</code>.
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
        [AWSProperty(Required=true, Max=2048)]
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