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

using Amazon.Runtime;

namespace Amazon.Route53Domains
{

    /// <summary>
    /// Constants used for properties of type ContactType.
    /// </summary>
    public class ContactType : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATION for ContactType
        /// </summary>
        public static readonly ContactType ASSOCIATION = new ContactType("ASSOCIATION");
        /// <summary>
        /// Constant COMPANY for ContactType
        /// </summary>
        public static readonly ContactType COMPANY = new ContactType("COMPANY");
        /// <summary>
        /// Constant PERSON for ContactType
        /// </summary>
        public static readonly ContactType PERSON = new ContactType("PERSON");
        /// <summary>
        /// Constant PUBLIC_BODY for ContactType
        /// </summary>
        public static readonly ContactType PUBLIC_BODY = new ContactType("PUBLIC_BODY");
        /// <summary>
        /// Constant RESELLER for ContactType
        /// </summary>
        public static readonly ContactType RESELLER = new ContactType("RESELLER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContactType FindValue(string value)
        {
            return FindValue<ContactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CountryCode.
    /// </summary>
    public class CountryCode : ConstantClass
    {

        /// <summary>
        /// Constant AC for CountryCode
        /// </summary>
        public static readonly CountryCode AC = new CountryCode("AC");
        /// <summary>
        /// Constant AD for CountryCode
        /// </summary>
        public static readonly CountryCode AD = new CountryCode("AD");
        /// <summary>
        /// Constant AE for CountryCode
        /// </summary>
        public static readonly CountryCode AE = new CountryCode("AE");
        /// <summary>
        /// Constant AF for CountryCode
        /// </summary>
        public static readonly CountryCode AF = new CountryCode("AF");
        /// <summary>
        /// Constant AG for CountryCode
        /// </summary>
        public static readonly CountryCode AG = new CountryCode("AG");
        /// <summary>
        /// Constant AI for CountryCode
        /// </summary>
        public static readonly CountryCode AI = new CountryCode("AI");
        /// <summary>
        /// Constant AL for CountryCode
        /// </summary>
        public static readonly CountryCode AL = new CountryCode("AL");
        /// <summary>
        /// Constant AM for CountryCode
        /// </summary>
        public static readonly CountryCode AM = new CountryCode("AM");
        /// <summary>
        /// Constant AN for CountryCode
        /// </summary>
        public static readonly CountryCode AN = new CountryCode("AN");
        /// <summary>
        /// Constant AO for CountryCode
        /// </summary>
        public static readonly CountryCode AO = new CountryCode("AO");
        /// <summary>
        /// Constant AQ for CountryCode
        /// </summary>
        public static readonly CountryCode AQ = new CountryCode("AQ");
        /// <summary>
        /// Constant AR for CountryCode
        /// </summary>
        public static readonly CountryCode AR = new CountryCode("AR");
        /// <summary>
        /// Constant AS for CountryCode
        /// </summary>
        public static readonly CountryCode AS = new CountryCode("AS");
        /// <summary>
        /// Constant AT for CountryCode
        /// </summary>
        public static readonly CountryCode AT = new CountryCode("AT");
        /// <summary>
        /// Constant AU for CountryCode
        /// </summary>
        public static readonly CountryCode AU = new CountryCode("AU");
        /// <summary>
        /// Constant AW for CountryCode
        /// </summary>
        public static readonly CountryCode AW = new CountryCode("AW");
        /// <summary>
        /// Constant AX for CountryCode
        /// </summary>
        public static readonly CountryCode AX = new CountryCode("AX");
        /// <summary>
        /// Constant AZ for CountryCode
        /// </summary>
        public static readonly CountryCode AZ = new CountryCode("AZ");
        /// <summary>
        /// Constant BA for CountryCode
        /// </summary>
        public static readonly CountryCode BA = new CountryCode("BA");
        /// <summary>
        /// Constant BB for CountryCode
        /// </summary>
        public static readonly CountryCode BB = new CountryCode("BB");
        /// <summary>
        /// Constant BD for CountryCode
        /// </summary>
        public static readonly CountryCode BD = new CountryCode("BD");
        /// <summary>
        /// Constant BE for CountryCode
        /// </summary>
        public static readonly CountryCode BE = new CountryCode("BE");
        /// <summary>
        /// Constant BF for CountryCode
        /// </summary>
        public static readonly CountryCode BF = new CountryCode("BF");
        /// <summary>
        /// Constant BG for CountryCode
        /// </summary>
        public static readonly CountryCode BG = new CountryCode("BG");
        /// <summary>
        /// Constant BH for CountryCode
        /// </summary>
        public static readonly CountryCode BH = new CountryCode("BH");
        /// <summary>
        /// Constant BI for CountryCode
        /// </summary>
        public static readonly CountryCode BI = new CountryCode("BI");
        /// <summary>
        /// Constant BJ for CountryCode
        /// </summary>
        public static readonly CountryCode BJ = new CountryCode("BJ");
        /// <summary>
        /// Constant BL for CountryCode
        /// </summary>
        public static readonly CountryCode BL = new CountryCode("BL");
        /// <summary>
        /// Constant BM for CountryCode
        /// </summary>
        public static readonly CountryCode BM = new CountryCode("BM");
        /// <summary>
        /// Constant BN for CountryCode
        /// </summary>
        public static readonly CountryCode BN = new CountryCode("BN");
        /// <summary>
        /// Constant BO for CountryCode
        /// </summary>
        public static readonly CountryCode BO = new CountryCode("BO");
        /// <summary>
        /// Constant BQ for CountryCode
        /// </summary>
        public static readonly CountryCode BQ = new CountryCode("BQ");
        /// <summary>
        /// Constant BR for CountryCode
        /// </summary>
        public static readonly CountryCode BR = new CountryCode("BR");
        /// <summary>
        /// Constant BS for CountryCode
        /// </summary>
        public static readonly CountryCode BS = new CountryCode("BS");
        /// <summary>
        /// Constant BT for CountryCode
        /// </summary>
        public static readonly CountryCode BT = new CountryCode("BT");
        /// <summary>
        /// Constant BV for CountryCode
        /// </summary>
        public static readonly CountryCode BV = new CountryCode("BV");
        /// <summary>
        /// Constant BW for CountryCode
        /// </summary>
        public static readonly CountryCode BW = new CountryCode("BW");
        /// <summary>
        /// Constant BY for CountryCode
        /// </summary>
        public static readonly CountryCode BY = new CountryCode("BY");
        /// <summary>
        /// Constant BZ for CountryCode
        /// </summary>
        public static readonly CountryCode BZ = new CountryCode("BZ");
        /// <summary>
        /// Constant CA for CountryCode
        /// </summary>
        public static readonly CountryCode CA = new CountryCode("CA");
        /// <summary>
        /// Constant CC for CountryCode
        /// </summary>
        public static readonly CountryCode CC = new CountryCode("CC");
        /// <summary>
        /// Constant CD for CountryCode
        /// </summary>
        public static readonly CountryCode CD = new CountryCode("CD");
        /// <summary>
        /// Constant CF for CountryCode
        /// </summary>
        public static readonly CountryCode CF = new CountryCode("CF");
        /// <summary>
        /// Constant CG for CountryCode
        /// </summary>
        public static readonly CountryCode CG = new CountryCode("CG");
        /// <summary>
        /// Constant CH for CountryCode
        /// </summary>
        public static readonly CountryCode CH = new CountryCode("CH");
        /// <summary>
        /// Constant CI for CountryCode
        /// </summary>
        public static readonly CountryCode CI = new CountryCode("CI");
        /// <summary>
        /// Constant CK for CountryCode
        /// </summary>
        public static readonly CountryCode CK = new CountryCode("CK");
        /// <summary>
        /// Constant CL for CountryCode
        /// </summary>
        public static readonly CountryCode CL = new CountryCode("CL");
        /// <summary>
        /// Constant CM for CountryCode
        /// </summary>
        public static readonly CountryCode CM = new CountryCode("CM");
        /// <summary>
        /// Constant CN for CountryCode
        /// </summary>
        public static readonly CountryCode CN = new CountryCode("CN");
        /// <summary>
        /// Constant CO for CountryCode
        /// </summary>
        public static readonly CountryCode CO = new CountryCode("CO");
        /// <summary>
        /// Constant CR for CountryCode
        /// </summary>
        public static readonly CountryCode CR = new CountryCode("CR");
        /// <summary>
        /// Constant CU for CountryCode
        /// </summary>
        public static readonly CountryCode CU = new CountryCode("CU");
        /// <summary>
        /// Constant CV for CountryCode
        /// </summary>
        public static readonly CountryCode CV = new CountryCode("CV");
        /// <summary>
        /// Constant CW for CountryCode
        /// </summary>
        public static readonly CountryCode CW = new CountryCode("CW");
        /// <summary>
        /// Constant CX for CountryCode
        /// </summary>
        public static readonly CountryCode CX = new CountryCode("CX");
        /// <summary>
        /// Constant CY for CountryCode
        /// </summary>
        public static readonly CountryCode CY = new CountryCode("CY");
        /// <summary>
        /// Constant CZ for CountryCode
        /// </summary>
        public static readonly CountryCode CZ = new CountryCode("CZ");
        /// <summary>
        /// Constant DE for CountryCode
        /// </summary>
        public static readonly CountryCode DE = new CountryCode("DE");
        /// <summary>
        /// Constant DJ for CountryCode
        /// </summary>
        public static readonly CountryCode DJ = new CountryCode("DJ");
        /// <summary>
        /// Constant DK for CountryCode
        /// </summary>
        public static readonly CountryCode DK = new CountryCode("DK");
        /// <summary>
        /// Constant DM for CountryCode
        /// </summary>
        public static readonly CountryCode DM = new CountryCode("DM");
        /// <summary>
        /// Constant DO for CountryCode
        /// </summary>
        public static readonly CountryCode DO = new CountryCode("DO");
        /// <summary>
        /// Constant DZ for CountryCode
        /// </summary>
        public static readonly CountryCode DZ = new CountryCode("DZ");
        /// <summary>
        /// Constant EC for CountryCode
        /// </summary>
        public static readonly CountryCode EC = new CountryCode("EC");
        /// <summary>
        /// Constant EE for CountryCode
        /// </summary>
        public static readonly CountryCode EE = new CountryCode("EE");
        /// <summary>
        /// Constant EG for CountryCode
        /// </summary>
        public static readonly CountryCode EG = new CountryCode("EG");
        /// <summary>
        /// Constant EH for CountryCode
        /// </summary>
        public static readonly CountryCode EH = new CountryCode("EH");
        /// <summary>
        /// Constant ER for CountryCode
        /// </summary>
        public static readonly CountryCode ER = new CountryCode("ER");
        /// <summary>
        /// Constant ES for CountryCode
        /// </summary>
        public static readonly CountryCode ES = new CountryCode("ES");
        /// <summary>
        /// Constant ET for CountryCode
        /// </summary>
        public static readonly CountryCode ET = new CountryCode("ET");
        /// <summary>
        /// Constant FI for CountryCode
        /// </summary>
        public static readonly CountryCode FI = new CountryCode("FI");
        /// <summary>
        /// Constant FJ for CountryCode
        /// </summary>
        public static readonly CountryCode FJ = new CountryCode("FJ");
        /// <summary>
        /// Constant FK for CountryCode
        /// </summary>
        public static readonly CountryCode FK = new CountryCode("FK");
        /// <summary>
        /// Constant FM for CountryCode
        /// </summary>
        public static readonly CountryCode FM = new CountryCode("FM");
        /// <summary>
        /// Constant FO for CountryCode
        /// </summary>
        public static readonly CountryCode FO = new CountryCode("FO");
        /// <summary>
        /// Constant FR for CountryCode
        /// </summary>
        public static readonly CountryCode FR = new CountryCode("FR");
        /// <summary>
        /// Constant GA for CountryCode
        /// </summary>
        public static readonly CountryCode GA = new CountryCode("GA");
        /// <summary>
        /// Constant GB for CountryCode
        /// </summary>
        public static readonly CountryCode GB = new CountryCode("GB");
        /// <summary>
        /// Constant GD for CountryCode
        /// </summary>
        public static readonly CountryCode GD = new CountryCode("GD");
        /// <summary>
        /// Constant GE for CountryCode
        /// </summary>
        public static readonly CountryCode GE = new CountryCode("GE");
        /// <summary>
        /// Constant GF for CountryCode
        /// </summary>
        public static readonly CountryCode GF = new CountryCode("GF");
        /// <summary>
        /// Constant GG for CountryCode
        /// </summary>
        public static readonly CountryCode GG = new CountryCode("GG");
        /// <summary>
        /// Constant GH for CountryCode
        /// </summary>
        public static readonly CountryCode GH = new CountryCode("GH");
        /// <summary>
        /// Constant GI for CountryCode
        /// </summary>
        public static readonly CountryCode GI = new CountryCode("GI");
        /// <summary>
        /// Constant GL for CountryCode
        /// </summary>
        public static readonly CountryCode GL = new CountryCode("GL");
        /// <summary>
        /// Constant GM for CountryCode
        /// </summary>
        public static readonly CountryCode GM = new CountryCode("GM");
        /// <summary>
        /// Constant GN for CountryCode
        /// </summary>
        public static readonly CountryCode GN = new CountryCode("GN");
        /// <summary>
        /// Constant GP for CountryCode
        /// </summary>
        public static readonly CountryCode GP = new CountryCode("GP");
        /// <summary>
        /// Constant GQ for CountryCode
        /// </summary>
        public static readonly CountryCode GQ = new CountryCode("GQ");
        /// <summary>
        /// Constant GR for CountryCode
        /// </summary>
        public static readonly CountryCode GR = new CountryCode("GR");
        /// <summary>
        /// Constant GS for CountryCode
        /// </summary>
        public static readonly CountryCode GS = new CountryCode("GS");
        /// <summary>
        /// Constant GT for CountryCode
        /// </summary>
        public static readonly CountryCode GT = new CountryCode("GT");
        /// <summary>
        /// Constant GU for CountryCode
        /// </summary>
        public static readonly CountryCode GU = new CountryCode("GU");
        /// <summary>
        /// Constant GW for CountryCode
        /// </summary>
        public static readonly CountryCode GW = new CountryCode("GW");
        /// <summary>
        /// Constant GY for CountryCode
        /// </summary>
        public static readonly CountryCode GY = new CountryCode("GY");
        /// <summary>
        /// Constant HK for CountryCode
        /// </summary>
        public static readonly CountryCode HK = new CountryCode("HK");
        /// <summary>
        /// Constant HM for CountryCode
        /// </summary>
        public static readonly CountryCode HM = new CountryCode("HM");
        /// <summary>
        /// Constant HN for CountryCode
        /// </summary>
        public static readonly CountryCode HN = new CountryCode("HN");
        /// <summary>
        /// Constant HR for CountryCode
        /// </summary>
        public static readonly CountryCode HR = new CountryCode("HR");
        /// <summary>
        /// Constant HT for CountryCode
        /// </summary>
        public static readonly CountryCode HT = new CountryCode("HT");
        /// <summary>
        /// Constant HU for CountryCode
        /// </summary>
        public static readonly CountryCode HU = new CountryCode("HU");
        /// <summary>
        /// Constant ID for CountryCode
        /// </summary>
        public static readonly CountryCode ID = new CountryCode("ID");
        /// <summary>
        /// Constant IE for CountryCode
        /// </summary>
        public static readonly CountryCode IE = new CountryCode("IE");
        /// <summary>
        /// Constant IL for CountryCode
        /// </summary>
        public static readonly CountryCode IL = new CountryCode("IL");
        /// <summary>
        /// Constant IM for CountryCode
        /// </summary>
        public static readonly CountryCode IM = new CountryCode("IM");
        /// <summary>
        /// Constant IN for CountryCode
        /// </summary>
        public static readonly CountryCode IN = new CountryCode("IN");
        /// <summary>
        /// Constant IO for CountryCode
        /// </summary>
        public static readonly CountryCode IO = new CountryCode("IO");
        /// <summary>
        /// Constant IQ for CountryCode
        /// </summary>
        public static readonly CountryCode IQ = new CountryCode("IQ");
        /// <summary>
        /// Constant IR for CountryCode
        /// </summary>
        public static readonly CountryCode IR = new CountryCode("IR");
        /// <summary>
        /// Constant IS for CountryCode
        /// </summary>
        public static readonly CountryCode IS = new CountryCode("IS");
        /// <summary>
        /// Constant IT for CountryCode
        /// </summary>
        public static readonly CountryCode IT = new CountryCode("IT");
        /// <summary>
        /// Constant JE for CountryCode
        /// </summary>
        public static readonly CountryCode JE = new CountryCode("JE");
        /// <summary>
        /// Constant JM for CountryCode
        /// </summary>
        public static readonly CountryCode JM = new CountryCode("JM");
        /// <summary>
        /// Constant JO for CountryCode
        /// </summary>
        public static readonly CountryCode JO = new CountryCode("JO");
        /// <summary>
        /// Constant JP for CountryCode
        /// </summary>
        public static readonly CountryCode JP = new CountryCode("JP");
        /// <summary>
        /// Constant KE for CountryCode
        /// </summary>
        public static readonly CountryCode KE = new CountryCode("KE");
        /// <summary>
        /// Constant KG for CountryCode
        /// </summary>
        public static readonly CountryCode KG = new CountryCode("KG");
        /// <summary>
        /// Constant KH for CountryCode
        /// </summary>
        public static readonly CountryCode KH = new CountryCode("KH");
        /// <summary>
        /// Constant KI for CountryCode
        /// </summary>
        public static readonly CountryCode KI = new CountryCode("KI");
        /// <summary>
        /// Constant KM for CountryCode
        /// </summary>
        public static readonly CountryCode KM = new CountryCode("KM");
        /// <summary>
        /// Constant KN for CountryCode
        /// </summary>
        public static readonly CountryCode KN = new CountryCode("KN");
        /// <summary>
        /// Constant KP for CountryCode
        /// </summary>
        public static readonly CountryCode KP = new CountryCode("KP");
        /// <summary>
        /// Constant KR for CountryCode
        /// </summary>
        public static readonly CountryCode KR = new CountryCode("KR");
        /// <summary>
        /// Constant KW for CountryCode
        /// </summary>
        public static readonly CountryCode KW = new CountryCode("KW");
        /// <summary>
        /// Constant KY for CountryCode
        /// </summary>
        public static readonly CountryCode KY = new CountryCode("KY");
        /// <summary>
        /// Constant KZ for CountryCode
        /// </summary>
        public static readonly CountryCode KZ = new CountryCode("KZ");
        /// <summary>
        /// Constant LA for CountryCode
        /// </summary>
        public static readonly CountryCode LA = new CountryCode("LA");
        /// <summary>
        /// Constant LB for CountryCode
        /// </summary>
        public static readonly CountryCode LB = new CountryCode("LB");
        /// <summary>
        /// Constant LC for CountryCode
        /// </summary>
        public static readonly CountryCode LC = new CountryCode("LC");
        /// <summary>
        /// Constant LI for CountryCode
        /// </summary>
        public static readonly CountryCode LI = new CountryCode("LI");
        /// <summary>
        /// Constant LK for CountryCode
        /// </summary>
        public static readonly CountryCode LK = new CountryCode("LK");
        /// <summary>
        /// Constant LR for CountryCode
        /// </summary>
        public static readonly CountryCode LR = new CountryCode("LR");
        /// <summary>
        /// Constant LS for CountryCode
        /// </summary>
        public static readonly CountryCode LS = new CountryCode("LS");
        /// <summary>
        /// Constant LT for CountryCode
        /// </summary>
        public static readonly CountryCode LT = new CountryCode("LT");
        /// <summary>
        /// Constant LU for CountryCode
        /// </summary>
        public static readonly CountryCode LU = new CountryCode("LU");
        /// <summary>
        /// Constant LV for CountryCode
        /// </summary>
        public static readonly CountryCode LV = new CountryCode("LV");
        /// <summary>
        /// Constant LY for CountryCode
        /// </summary>
        public static readonly CountryCode LY = new CountryCode("LY");
        /// <summary>
        /// Constant MA for CountryCode
        /// </summary>
        public static readonly CountryCode MA = new CountryCode("MA");
        /// <summary>
        /// Constant MC for CountryCode
        /// </summary>
        public static readonly CountryCode MC = new CountryCode("MC");
        /// <summary>
        /// Constant MD for CountryCode
        /// </summary>
        public static readonly CountryCode MD = new CountryCode("MD");
        /// <summary>
        /// Constant ME for CountryCode
        /// </summary>
        public static readonly CountryCode ME = new CountryCode("ME");
        /// <summary>
        /// Constant MF for CountryCode
        /// </summary>
        public static readonly CountryCode MF = new CountryCode("MF");
        /// <summary>
        /// Constant MG for CountryCode
        /// </summary>
        public static readonly CountryCode MG = new CountryCode("MG");
        /// <summary>
        /// Constant MH for CountryCode
        /// </summary>
        public static readonly CountryCode MH = new CountryCode("MH");
        /// <summary>
        /// Constant MK for CountryCode
        /// </summary>
        public static readonly CountryCode MK = new CountryCode("MK");
        /// <summary>
        /// Constant ML for CountryCode
        /// </summary>
        public static readonly CountryCode ML = new CountryCode("ML");
        /// <summary>
        /// Constant MM for CountryCode
        /// </summary>
        public static readonly CountryCode MM = new CountryCode("MM");
        /// <summary>
        /// Constant MN for CountryCode
        /// </summary>
        public static readonly CountryCode MN = new CountryCode("MN");
        /// <summary>
        /// Constant MO for CountryCode
        /// </summary>
        public static readonly CountryCode MO = new CountryCode("MO");
        /// <summary>
        /// Constant MP for CountryCode
        /// </summary>
        public static readonly CountryCode MP = new CountryCode("MP");
        /// <summary>
        /// Constant MQ for CountryCode
        /// </summary>
        public static readonly CountryCode MQ = new CountryCode("MQ");
        /// <summary>
        /// Constant MR for CountryCode
        /// </summary>
        public static readonly CountryCode MR = new CountryCode("MR");
        /// <summary>
        /// Constant MS for CountryCode
        /// </summary>
        public static readonly CountryCode MS = new CountryCode("MS");
        /// <summary>
        /// Constant MT for CountryCode
        /// </summary>
        public static readonly CountryCode MT = new CountryCode("MT");
        /// <summary>
        /// Constant MU for CountryCode
        /// </summary>
        public static readonly CountryCode MU = new CountryCode("MU");
        /// <summary>
        /// Constant MV for CountryCode
        /// </summary>
        public static readonly CountryCode MV = new CountryCode("MV");
        /// <summary>
        /// Constant MW for CountryCode
        /// </summary>
        public static readonly CountryCode MW = new CountryCode("MW");
        /// <summary>
        /// Constant MX for CountryCode
        /// </summary>
        public static readonly CountryCode MX = new CountryCode("MX");
        /// <summary>
        /// Constant MY for CountryCode
        /// </summary>
        public static readonly CountryCode MY = new CountryCode("MY");
        /// <summary>
        /// Constant MZ for CountryCode
        /// </summary>
        public static readonly CountryCode MZ = new CountryCode("MZ");
        /// <summary>
        /// Constant NA for CountryCode
        /// </summary>
        public static readonly CountryCode NA = new CountryCode("NA");
        /// <summary>
        /// Constant NC for CountryCode
        /// </summary>
        public static readonly CountryCode NC = new CountryCode("NC");
        /// <summary>
        /// Constant NE for CountryCode
        /// </summary>
        public static readonly CountryCode NE = new CountryCode("NE");
        /// <summary>
        /// Constant NF for CountryCode
        /// </summary>
        public static readonly CountryCode NF = new CountryCode("NF");
        /// <summary>
        /// Constant NG for CountryCode
        /// </summary>
        public static readonly CountryCode NG = new CountryCode("NG");
        /// <summary>
        /// Constant NI for CountryCode
        /// </summary>
        public static readonly CountryCode NI = new CountryCode("NI");
        /// <summary>
        /// Constant NL for CountryCode
        /// </summary>
        public static readonly CountryCode NL = new CountryCode("NL");
        /// <summary>
        /// Constant NO for CountryCode
        /// </summary>
        public static readonly CountryCode NO = new CountryCode("NO");
        /// <summary>
        /// Constant NP for CountryCode
        /// </summary>
        public static readonly CountryCode NP = new CountryCode("NP");
        /// <summary>
        /// Constant NR for CountryCode
        /// </summary>
        public static readonly CountryCode NR = new CountryCode("NR");
        /// <summary>
        /// Constant NU for CountryCode
        /// </summary>
        public static readonly CountryCode NU = new CountryCode("NU");
        /// <summary>
        /// Constant NZ for CountryCode
        /// </summary>
        public static readonly CountryCode NZ = new CountryCode("NZ");
        /// <summary>
        /// Constant OM for CountryCode
        /// </summary>
        public static readonly CountryCode OM = new CountryCode("OM");
        /// <summary>
        /// Constant PA for CountryCode
        /// </summary>
        public static readonly CountryCode PA = new CountryCode("PA");
        /// <summary>
        /// Constant PE for CountryCode
        /// </summary>
        public static readonly CountryCode PE = new CountryCode("PE");
        /// <summary>
        /// Constant PF for CountryCode
        /// </summary>
        public static readonly CountryCode PF = new CountryCode("PF");
        /// <summary>
        /// Constant PG for CountryCode
        /// </summary>
        public static readonly CountryCode PG = new CountryCode("PG");
        /// <summary>
        /// Constant PH for CountryCode
        /// </summary>
        public static readonly CountryCode PH = new CountryCode("PH");
        /// <summary>
        /// Constant PK for CountryCode
        /// </summary>
        public static readonly CountryCode PK = new CountryCode("PK");
        /// <summary>
        /// Constant PL for CountryCode
        /// </summary>
        public static readonly CountryCode PL = new CountryCode("PL");
        /// <summary>
        /// Constant PM for CountryCode
        /// </summary>
        public static readonly CountryCode PM = new CountryCode("PM");
        /// <summary>
        /// Constant PN for CountryCode
        /// </summary>
        public static readonly CountryCode PN = new CountryCode("PN");
        /// <summary>
        /// Constant PR for CountryCode
        /// </summary>
        public static readonly CountryCode PR = new CountryCode("PR");
        /// <summary>
        /// Constant PS for CountryCode
        /// </summary>
        public static readonly CountryCode PS = new CountryCode("PS");
        /// <summary>
        /// Constant PT for CountryCode
        /// </summary>
        public static readonly CountryCode PT = new CountryCode("PT");
        /// <summary>
        /// Constant PW for CountryCode
        /// </summary>
        public static readonly CountryCode PW = new CountryCode("PW");
        /// <summary>
        /// Constant PY for CountryCode
        /// </summary>
        public static readonly CountryCode PY = new CountryCode("PY");
        /// <summary>
        /// Constant QA for CountryCode
        /// </summary>
        public static readonly CountryCode QA = new CountryCode("QA");
        /// <summary>
        /// Constant RE for CountryCode
        /// </summary>
        public static readonly CountryCode RE = new CountryCode("RE");
        /// <summary>
        /// Constant RO for CountryCode
        /// </summary>
        public static readonly CountryCode RO = new CountryCode("RO");
        /// <summary>
        /// Constant RS for CountryCode
        /// </summary>
        public static readonly CountryCode RS = new CountryCode("RS");
        /// <summary>
        /// Constant RU for CountryCode
        /// </summary>
        public static readonly CountryCode RU = new CountryCode("RU");
        /// <summary>
        /// Constant RW for CountryCode
        /// </summary>
        public static readonly CountryCode RW = new CountryCode("RW");
        /// <summary>
        /// Constant SA for CountryCode
        /// </summary>
        public static readonly CountryCode SA = new CountryCode("SA");
        /// <summary>
        /// Constant SB for CountryCode
        /// </summary>
        public static readonly CountryCode SB = new CountryCode("SB");
        /// <summary>
        /// Constant SC for CountryCode
        /// </summary>
        public static readonly CountryCode SC = new CountryCode("SC");
        /// <summary>
        /// Constant SD for CountryCode
        /// </summary>
        public static readonly CountryCode SD = new CountryCode("SD");
        /// <summary>
        /// Constant SE for CountryCode
        /// </summary>
        public static readonly CountryCode SE = new CountryCode("SE");
        /// <summary>
        /// Constant SG for CountryCode
        /// </summary>
        public static readonly CountryCode SG = new CountryCode("SG");
        /// <summary>
        /// Constant SH for CountryCode
        /// </summary>
        public static readonly CountryCode SH = new CountryCode("SH");
        /// <summary>
        /// Constant SI for CountryCode
        /// </summary>
        public static readonly CountryCode SI = new CountryCode("SI");
        /// <summary>
        /// Constant SJ for CountryCode
        /// </summary>
        public static readonly CountryCode SJ = new CountryCode("SJ");
        /// <summary>
        /// Constant SK for CountryCode
        /// </summary>
        public static readonly CountryCode SK = new CountryCode("SK");
        /// <summary>
        /// Constant SL for CountryCode
        /// </summary>
        public static readonly CountryCode SL = new CountryCode("SL");
        /// <summary>
        /// Constant SM for CountryCode
        /// </summary>
        public static readonly CountryCode SM = new CountryCode("SM");
        /// <summary>
        /// Constant SN for CountryCode
        /// </summary>
        public static readonly CountryCode SN = new CountryCode("SN");
        /// <summary>
        /// Constant SO for CountryCode
        /// </summary>
        public static readonly CountryCode SO = new CountryCode("SO");
        /// <summary>
        /// Constant SR for CountryCode
        /// </summary>
        public static readonly CountryCode SR = new CountryCode("SR");
        /// <summary>
        /// Constant SS for CountryCode
        /// </summary>
        public static readonly CountryCode SS = new CountryCode("SS");
        /// <summary>
        /// Constant ST for CountryCode
        /// </summary>
        public static readonly CountryCode ST = new CountryCode("ST");
        /// <summary>
        /// Constant SV for CountryCode
        /// </summary>
        public static readonly CountryCode SV = new CountryCode("SV");
        /// <summary>
        /// Constant SX for CountryCode
        /// </summary>
        public static readonly CountryCode SX = new CountryCode("SX");
        /// <summary>
        /// Constant SY for CountryCode
        /// </summary>
        public static readonly CountryCode SY = new CountryCode("SY");
        /// <summary>
        /// Constant SZ for CountryCode
        /// </summary>
        public static readonly CountryCode SZ = new CountryCode("SZ");
        /// <summary>
        /// Constant TC for CountryCode
        /// </summary>
        public static readonly CountryCode TC = new CountryCode("TC");
        /// <summary>
        /// Constant TD for CountryCode
        /// </summary>
        public static readonly CountryCode TD = new CountryCode("TD");
        /// <summary>
        /// Constant TF for CountryCode
        /// </summary>
        public static readonly CountryCode TF = new CountryCode("TF");
        /// <summary>
        /// Constant TG for CountryCode
        /// </summary>
        public static readonly CountryCode TG = new CountryCode("TG");
        /// <summary>
        /// Constant TH for CountryCode
        /// </summary>
        public static readonly CountryCode TH = new CountryCode("TH");
        /// <summary>
        /// Constant TJ for CountryCode
        /// </summary>
        public static readonly CountryCode TJ = new CountryCode("TJ");
        /// <summary>
        /// Constant TK for CountryCode
        /// </summary>
        public static readonly CountryCode TK = new CountryCode("TK");
        /// <summary>
        /// Constant TL for CountryCode
        /// </summary>
        public static readonly CountryCode TL = new CountryCode("TL");
        /// <summary>
        /// Constant TM for CountryCode
        /// </summary>
        public static readonly CountryCode TM = new CountryCode("TM");
        /// <summary>
        /// Constant TN for CountryCode
        /// </summary>
        public static readonly CountryCode TN = new CountryCode("TN");
        /// <summary>
        /// Constant TO for CountryCode
        /// </summary>
        public static readonly CountryCode TO = new CountryCode("TO");
        /// <summary>
        /// Constant TP for CountryCode
        /// </summary>
        public static readonly CountryCode TP = new CountryCode("TP");
        /// <summary>
        /// Constant TR for CountryCode
        /// </summary>
        public static readonly CountryCode TR = new CountryCode("TR");
        /// <summary>
        /// Constant TT for CountryCode
        /// </summary>
        public static readonly CountryCode TT = new CountryCode("TT");
        /// <summary>
        /// Constant TV for CountryCode
        /// </summary>
        public static readonly CountryCode TV = new CountryCode("TV");
        /// <summary>
        /// Constant TW for CountryCode
        /// </summary>
        public static readonly CountryCode TW = new CountryCode("TW");
        /// <summary>
        /// Constant TZ for CountryCode
        /// </summary>
        public static readonly CountryCode TZ = new CountryCode("TZ");
        /// <summary>
        /// Constant UA for CountryCode
        /// </summary>
        public static readonly CountryCode UA = new CountryCode("UA");
        /// <summary>
        /// Constant UG for CountryCode
        /// </summary>
        public static readonly CountryCode UG = new CountryCode("UG");
        /// <summary>
        /// Constant US for CountryCode
        /// </summary>
        public static readonly CountryCode US = new CountryCode("US");
        /// <summary>
        /// Constant UY for CountryCode
        /// </summary>
        public static readonly CountryCode UY = new CountryCode("UY");
        /// <summary>
        /// Constant UZ for CountryCode
        /// </summary>
        public static readonly CountryCode UZ = new CountryCode("UZ");
        /// <summary>
        /// Constant VA for CountryCode
        /// </summary>
        public static readonly CountryCode VA = new CountryCode("VA");
        /// <summary>
        /// Constant VC for CountryCode
        /// </summary>
        public static readonly CountryCode VC = new CountryCode("VC");
        /// <summary>
        /// Constant VE for CountryCode
        /// </summary>
        public static readonly CountryCode VE = new CountryCode("VE");
        /// <summary>
        /// Constant VG for CountryCode
        /// </summary>
        public static readonly CountryCode VG = new CountryCode("VG");
        /// <summary>
        /// Constant VI for CountryCode
        /// </summary>
        public static readonly CountryCode VI = new CountryCode("VI");
        /// <summary>
        /// Constant VN for CountryCode
        /// </summary>
        public static readonly CountryCode VN = new CountryCode("VN");
        /// <summary>
        /// Constant VU for CountryCode
        /// </summary>
        public static readonly CountryCode VU = new CountryCode("VU");
        /// <summary>
        /// Constant WF for CountryCode
        /// </summary>
        public static readonly CountryCode WF = new CountryCode("WF");
        /// <summary>
        /// Constant WS for CountryCode
        /// </summary>
        public static readonly CountryCode WS = new CountryCode("WS");
        /// <summary>
        /// Constant YE for CountryCode
        /// </summary>
        public static readonly CountryCode YE = new CountryCode("YE");
        /// <summary>
        /// Constant YT for CountryCode
        /// </summary>
        public static readonly CountryCode YT = new CountryCode("YT");
        /// <summary>
        /// Constant ZA for CountryCode
        /// </summary>
        public static readonly CountryCode ZA = new CountryCode("ZA");
        /// <summary>
        /// Constant ZM for CountryCode
        /// </summary>
        public static readonly CountryCode ZM = new CountryCode("ZM");
        /// <summary>
        /// Constant ZW for CountryCode
        /// </summary>
        public static readonly CountryCode ZW = new CountryCode("ZW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CountryCode FindValue(string value)
        {
            return FindValue<CountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainAvailability.
    /// </summary>
    public class DomainAvailability : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability AVAILABLE = new DomainAvailability("AVAILABLE");
        /// <summary>
        /// Constant AVAILABLE_PREORDER for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability AVAILABLE_PREORDER = new DomainAvailability("AVAILABLE_PREORDER");
        /// <summary>
        /// Constant AVAILABLE_RESERVED for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability AVAILABLE_RESERVED = new DomainAvailability("AVAILABLE_RESERVED");
        /// <summary>
        /// Constant DONT_KNOW for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability DONT_KNOW = new DomainAvailability("DONT_KNOW");
        /// <summary>
        /// Constant RESERVED for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability RESERVED = new DomainAvailability("RESERVED");
        /// <summary>
        /// Constant UNAVAILABLE for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability UNAVAILABLE = new DomainAvailability("UNAVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE_PREMIUM for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability UNAVAILABLE_PREMIUM = new DomainAvailability("UNAVAILABLE_PREMIUM");
        /// <summary>
        /// Constant UNAVAILABLE_RESTRICTED for DomainAvailability
        /// </summary>
        public static readonly DomainAvailability UNAVAILABLE_RESTRICTED = new DomainAvailability("UNAVAILABLE_RESTRICTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainAvailability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainAvailability FindValue(string value)
        {
            return FindValue<DomainAvailability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainAvailability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExtraParamName.
    /// </summary>
    public class ExtraParamName : ConstantClass
    {

        /// <summary>
        /// Constant AU_ID_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName AU_ID_NUMBER = new ExtraParamName("AU_ID_NUMBER");
        /// <summary>
        /// Constant AU_ID_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName AU_ID_TYPE = new ExtraParamName("AU_ID_TYPE");
        /// <summary>
        /// Constant AU_PRIORITY_TOKEN for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName AU_PRIORITY_TOKEN = new ExtraParamName("AU_PRIORITY_TOKEN");
        /// <summary>
        /// Constant BIRTH_CITY for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName BIRTH_CITY = new ExtraParamName("BIRTH_CITY");
        /// <summary>
        /// Constant BIRTH_COUNTRY for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName BIRTH_COUNTRY = new ExtraParamName("BIRTH_COUNTRY");
        /// <summary>
        /// Constant BIRTH_DATE_IN_YYYY_MM_DD for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName BIRTH_DATE_IN_YYYY_MM_DD = new ExtraParamName("BIRTH_DATE_IN_YYYY_MM_DD");
        /// <summary>
        /// Constant BIRTH_DEPARTMENT for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName BIRTH_DEPARTMENT = new ExtraParamName("BIRTH_DEPARTMENT");
        /// <summary>
        /// Constant BRAND_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName BRAND_NUMBER = new ExtraParamName("BRAND_NUMBER");
        /// <summary>
        /// Constant CA_BUSINESS_ENTITY_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName CA_BUSINESS_ENTITY_TYPE = new ExtraParamName("CA_BUSINESS_ENTITY_TYPE");
        /// <summary>
        /// Constant CA_LEGAL_REPRESENTATIVE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName CA_LEGAL_REPRESENTATIVE = new ExtraParamName("CA_LEGAL_REPRESENTATIVE");
        /// <summary>
        /// Constant CA_LEGAL_REPRESENTATIVE_CAPACITY for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName CA_LEGAL_REPRESENTATIVE_CAPACITY = new ExtraParamName("CA_LEGAL_REPRESENTATIVE_CAPACITY");
        /// <summary>
        /// Constant CA_LEGAL_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName CA_LEGAL_TYPE = new ExtraParamName("CA_LEGAL_TYPE");
        /// <summary>
        /// Constant DOCUMENT_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName DOCUMENT_NUMBER = new ExtraParamName("DOCUMENT_NUMBER");
        /// <summary>
        /// Constant DUNS_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName DUNS_NUMBER = new ExtraParamName("DUNS_NUMBER");
        /// <summary>
        /// Constant ES_IDENTIFICATION for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName ES_IDENTIFICATION = new ExtraParamName("ES_IDENTIFICATION");
        /// <summary>
        /// Constant ES_IDENTIFICATION_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName ES_IDENTIFICATION_TYPE = new ExtraParamName("ES_IDENTIFICATION_TYPE");
        /// <summary>
        /// Constant ES_LEGAL_FORM for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName ES_LEGAL_FORM = new ExtraParamName("ES_LEGAL_FORM");
        /// <summary>
        /// Constant EU_COUNTRY_OF_CITIZENSHIP for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName EU_COUNTRY_OF_CITIZENSHIP = new ExtraParamName("EU_COUNTRY_OF_CITIZENSHIP");
        /// <summary>
        /// Constant FI_BUSINESS_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName FI_BUSINESS_NUMBER = new ExtraParamName("FI_BUSINESS_NUMBER");
        /// <summary>
        /// Constant FI_ID_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName FI_ID_NUMBER = new ExtraParamName("FI_ID_NUMBER");
        /// <summary>
        /// Constant FI_NATIONALITY for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName FI_NATIONALITY = new ExtraParamName("FI_NATIONALITY");
        /// <summary>
        /// Constant FI_ORGANIZATION_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName FI_ORGANIZATION_TYPE = new ExtraParamName("FI_ORGANIZATION_TYPE");
        /// <summary>
        /// Constant IT_NATIONALITY for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName IT_NATIONALITY = new ExtraParamName("IT_NATIONALITY");
        /// <summary>
        /// Constant IT_PIN for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName IT_PIN = new ExtraParamName("IT_PIN");
        /// <summary>
        /// Constant IT_REGISTRANT_ENTITY_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName IT_REGISTRANT_ENTITY_TYPE = new ExtraParamName("IT_REGISTRANT_ENTITY_TYPE");
        /// <summary>
        /// Constant RU_PASSPORT_DATA for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName RU_PASSPORT_DATA = new ExtraParamName("RU_PASSPORT_DATA");
        /// <summary>
        /// Constant SE_ID_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName SE_ID_NUMBER = new ExtraParamName("SE_ID_NUMBER");
        /// <summary>
        /// Constant SG_ID_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName SG_ID_NUMBER = new ExtraParamName("SG_ID_NUMBER");
        /// <summary>
        /// Constant UK_COMPANY_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName UK_COMPANY_NUMBER = new ExtraParamName("UK_COMPANY_NUMBER");
        /// <summary>
        /// Constant UK_CONTACT_TYPE for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName UK_CONTACT_TYPE = new ExtraParamName("UK_CONTACT_TYPE");
        /// <summary>
        /// Constant VAT_NUMBER for ExtraParamName
        /// </summary>
        public static readonly ExtraParamName VAT_NUMBER = new ExtraParamName("VAT_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExtraParamName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExtraParamName FindValue(string value)
        {
            return FindValue<ExtraParamName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExtraParamName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListDomainsAttributeName.
    /// </summary>
    public class ListDomainsAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant DomainName for ListDomainsAttributeName
        /// </summary>
        public static readonly ListDomainsAttributeName DomainName = new ListDomainsAttributeName("DomainName");
        /// <summary>
        /// Constant Expiry for ListDomainsAttributeName
        /// </summary>
        public static readonly ListDomainsAttributeName Expiry = new ListDomainsAttributeName("Expiry");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListDomainsAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListDomainsAttributeName FindValue(string value)
        {
            return FindValue<ListDomainsAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListDomainsAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListOperationsSortAttributeName.
    /// </summary>
    public class ListOperationsSortAttributeName : ConstantClass
    {

        /// <summary>
        /// Constant SubmittedDate for ListOperationsSortAttributeName
        /// </summary>
        public static readonly ListOperationsSortAttributeName SubmittedDate = new ListOperationsSortAttributeName("SubmittedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListOperationsSortAttributeName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListOperationsSortAttributeName FindValue(string value)
        {
            return FindValue<ListOperationsSortAttributeName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListOperationsSortAttributeName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for OperationStatus
        /// </summary>
        public static readonly OperationStatus ERROR = new OperationStatus("ERROR");
        /// <summary>
        /// Constant FAILED for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAILED = new OperationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus IN_PROGRESS = new OperationStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUBMITTED = new OperationStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCESSFUL for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCESSFUL = new OperationStatus("SUCCESSFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant ADD_DNSSEC for OperationType
        /// </summary>
        public static readonly OperationType ADD_DNSSEC = new OperationType("ADD_DNSSEC");
        /// <summary>
        /// Constant CHANGE_DOMAIN_OWNER for OperationType
        /// </summary>
        public static readonly OperationType CHANGE_DOMAIN_OWNER = new OperationType("CHANGE_DOMAIN_OWNER");
        /// <summary>
        /// Constant CHANGE_PRIVACY_PROTECTION for OperationType
        /// </summary>
        public static readonly OperationType CHANGE_PRIVACY_PROTECTION = new OperationType("CHANGE_PRIVACY_PROTECTION");
        /// <summary>
        /// Constant DELETE_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType DELETE_DOMAIN = new OperationType("DELETE_DOMAIN");
        /// <summary>
        /// Constant DISABLE_AUTORENEW for OperationType
        /// </summary>
        public static readonly OperationType DISABLE_AUTORENEW = new OperationType("DISABLE_AUTORENEW");
        /// <summary>
        /// Constant DOMAIN_LOCK for OperationType
        /// </summary>
        public static readonly OperationType DOMAIN_LOCK = new OperationType("DOMAIN_LOCK");
        /// <summary>
        /// Constant ENABLE_AUTORENEW for OperationType
        /// </summary>
        public static readonly OperationType ENABLE_AUTORENEW = new OperationType("ENABLE_AUTORENEW");
        /// <summary>
        /// Constant EXPIRE_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType EXPIRE_DOMAIN = new OperationType("EXPIRE_DOMAIN");
        /// <summary>
        /// Constant INTERNAL_TRANSFER_IN_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType INTERNAL_TRANSFER_IN_DOMAIN = new OperationType("INTERNAL_TRANSFER_IN_DOMAIN");
        /// <summary>
        /// Constant INTERNAL_TRANSFER_OUT_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType INTERNAL_TRANSFER_OUT_DOMAIN = new OperationType("INTERNAL_TRANSFER_OUT_DOMAIN");
        /// <summary>
        /// Constant PUSH_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType PUSH_DOMAIN = new OperationType("PUSH_DOMAIN");
        /// <summary>
        /// Constant REGISTER_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType REGISTER_DOMAIN = new OperationType("REGISTER_DOMAIN");
        /// <summary>
        /// Constant REMOVE_DNSSEC for OperationType
        /// </summary>
        public static readonly OperationType REMOVE_DNSSEC = new OperationType("REMOVE_DNSSEC");
        /// <summary>
        /// Constant RENEW_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType RENEW_DOMAIN = new OperationType("RENEW_DOMAIN");
        /// <summary>
        /// Constant TRANSFER_IN_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType TRANSFER_IN_DOMAIN = new OperationType("TRANSFER_IN_DOMAIN");
        /// <summary>
        /// Constant TRANSFER_OUT_DOMAIN for OperationType
        /// </summary>
        public static readonly OperationType TRANSFER_OUT_DOMAIN = new OperationType("TRANSFER_OUT_DOMAIN");
        /// <summary>
        /// Constant UPDATE_DOMAIN_CONTACT for OperationType
        /// </summary>
        public static readonly OperationType UPDATE_DOMAIN_CONTACT = new OperationType("UPDATE_DOMAIN_CONTACT");
        /// <summary>
        /// Constant UPDATE_NAMESERVER for OperationType
        /// </summary>
        public static readonly OperationType UPDATE_NAMESERVER = new OperationType("UPDATE_NAMESERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for Operator
        /// </summary>
        public static readonly Operator BEGINS_WITH = new Operator("BEGINS_WITH");
        /// <summary>
        /// Constant GE for Operator
        /// </summary>
        public static readonly Operator GE = new Operator("GE");
        /// <summary>
        /// Constant LE for Operator
        /// </summary>
        public static readonly Operator LE = new Operator("LE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReachabilityStatus.
    /// </summary>
    public class ReachabilityStatus : ConstantClass
    {

        /// <summary>
        /// Constant DONE for ReachabilityStatus
        /// </summary>
        public static readonly ReachabilityStatus DONE = new ReachabilityStatus("DONE");
        /// <summary>
        /// Constant EXPIRED for ReachabilityStatus
        /// </summary>
        public static readonly ReachabilityStatus EXPIRED = new ReachabilityStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for ReachabilityStatus
        /// </summary>
        public static readonly ReachabilityStatus PENDING = new ReachabilityStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReachabilityStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReachabilityStatus FindValue(string value)
        {
            return FindValue<ReachabilityStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReachabilityStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusFlag.
    /// </summary>
    public class StatusFlag : ConstantClass
    {

        /// <summary>
        /// Constant PENDING_ACCEPTANCE for StatusFlag
        /// </summary>
        public static readonly StatusFlag PENDING_ACCEPTANCE = new StatusFlag("PENDING_ACCEPTANCE");
        /// <summary>
        /// Constant PENDING_AUTHORIZATION for StatusFlag
        /// </summary>
        public static readonly StatusFlag PENDING_AUTHORIZATION = new StatusFlag("PENDING_AUTHORIZATION");
        /// <summary>
        /// Constant PENDING_CUSTOMER_ACTION for StatusFlag
        /// </summary>
        public static readonly StatusFlag PENDING_CUSTOMER_ACTION = new StatusFlag("PENDING_CUSTOMER_ACTION");
        /// <summary>
        /// Constant PENDING_PAYMENT_VERIFICATION for StatusFlag
        /// </summary>
        public static readonly StatusFlag PENDING_PAYMENT_VERIFICATION = new StatusFlag("PENDING_PAYMENT_VERIFICATION");
        /// <summary>
        /// Constant PENDING_SUPPORT_CASE for StatusFlag
        /// </summary>
        public static readonly StatusFlag PENDING_SUPPORT_CASE = new StatusFlag("PENDING_SUPPORT_CASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusFlag(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusFlag FindValue(string value)
        {
            return FindValue<StatusFlag>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusFlag(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Transferable.
    /// </summary>
    public class Transferable : ConstantClass
    {

        /// <summary>
        /// Constant DOMAIN_IN_ANOTHER_ACCOUNT for Transferable
        /// </summary>
        public static readonly Transferable DOMAIN_IN_ANOTHER_ACCOUNT = new Transferable("DOMAIN_IN_ANOTHER_ACCOUNT");
        /// <summary>
        /// Constant DOMAIN_IN_OWN_ACCOUNT for Transferable
        /// </summary>
        public static readonly Transferable DOMAIN_IN_OWN_ACCOUNT = new Transferable("DOMAIN_IN_OWN_ACCOUNT");
        /// <summary>
        /// Constant DONT_KNOW for Transferable
        /// </summary>
        public static readonly Transferable DONT_KNOW = new Transferable("DONT_KNOW");
        /// <summary>
        /// Constant PREMIUM_DOMAIN for Transferable
        /// </summary>
        public static readonly Transferable PREMIUM_DOMAIN = new Transferable("PREMIUM_DOMAIN");
        /// <summary>
        /// Constant TRANSFERABLE for Transferable
        /// </summary>
        public static readonly Transferable TRANSFERABLE = new Transferable("TRANSFERABLE");
        /// <summary>
        /// Constant UNTRANSFERABLE for Transferable
        /// </summary>
        public static readonly Transferable UNTRANSFERABLE = new Transferable("UNTRANSFERABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Transferable(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Transferable FindValue(string value)
        {
            return FindValue<Transferable>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Transferable(string value)
        {
            return FindValue(value);
        }
    }

}