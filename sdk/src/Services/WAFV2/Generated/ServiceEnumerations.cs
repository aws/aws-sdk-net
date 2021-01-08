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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WAFV2
{

    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQ for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator EQ = new ComparisonOperator("EQ");
        /// <summary>
        /// Constant GE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GE = new ComparisonOperator("GE");
        /// <summary>
        /// Constant GT for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator GT = new ComparisonOperator("GT");
        /// <summary>
        /// Constant LE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LE = new ComparisonOperator("LE");
        /// <summary>
        /// Constant LT for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator LT = new ComparisonOperator("LT");
        /// <summary>
        /// Constant NE for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NE = new ComparisonOperator("NE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonOperator FindValue(string value)
        {
            return FindValue<ComparisonOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonOperator(string value)
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
        /// Constant UM for CountryCode
        /// </summary>
        public static readonly CountryCode UM = new CountryCode("UM");
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
    /// Constants used for properties of type FallbackBehavior.
    /// </summary>
    public class FallbackBehavior : ConstantClass
    {

        /// <summary>
        /// Constant MATCH for FallbackBehavior
        /// </summary>
        public static readonly FallbackBehavior MATCH = new FallbackBehavior("MATCH");
        /// <summary>
        /// Constant NO_MATCH for FallbackBehavior
        /// </summary>
        public static readonly FallbackBehavior NO_MATCH = new FallbackBehavior("NO_MATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FallbackBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FallbackBehavior FindValue(string value)
        {
            return FindValue<FallbackBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FallbackBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ForwardedIPPosition.
    /// </summary>
    public class ForwardedIPPosition : ConstantClass
    {

        /// <summary>
        /// Constant ANY for ForwardedIPPosition
        /// </summary>
        public static readonly ForwardedIPPosition ANY = new ForwardedIPPosition("ANY");
        /// <summary>
        /// Constant FIRST for ForwardedIPPosition
        /// </summary>
        public static readonly ForwardedIPPosition FIRST = new ForwardedIPPosition("FIRST");
        /// <summary>
        /// Constant LAST for ForwardedIPPosition
        /// </summary>
        public static readonly ForwardedIPPosition LAST = new ForwardedIPPosition("LAST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ForwardedIPPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ForwardedIPPosition FindValue(string value)
        {
            return FindValue<ForwardedIPPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ForwardedIPPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IPAddressVersion.
    /// </summary>
    public class IPAddressVersion : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for IPAddressVersion
        /// </summary>
        public static readonly IPAddressVersion IPV4 = new IPAddressVersion("IPV4");
        /// <summary>
        /// Constant IPV6 for IPAddressVersion
        /// </summary>
        public static readonly IPAddressVersion IPV6 = new IPAddressVersion("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IPAddressVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IPAddressVersion FindValue(string value)
        {
            return FindValue<IPAddressVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IPAddressVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterExceptionField.
    /// </summary>
    public class ParameterExceptionField : ConstantClass
    {

        /// <summary>
        /// Constant AND_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField AND_STATEMENT = new ParameterExceptionField("AND_STATEMENT");
        /// <summary>
        /// Constant BYTE_MATCH_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_STATEMENT = new ParameterExceptionField("BYTE_MATCH_STATEMENT");
        /// <summary>
        /// Constant DEFAULT_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField DEFAULT_ACTION = new ParameterExceptionField("DEFAULT_ACTION");
        /// <summary>
        /// Constant ENTITY_LIMIT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField ENTITY_LIMIT = new ParameterExceptionField("ENTITY_LIMIT");
        /// <summary>
        /// Constant EXCLUDED_RULE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField EXCLUDED_RULE = new ParameterExceptionField("EXCLUDED_RULE");
        /// <summary>
        /// Constant FALLBACK_BEHAVIOR for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField FALLBACK_BEHAVIOR = new ParameterExceptionField("FALLBACK_BEHAVIOR");
        /// <summary>
        /// Constant FIELD_TO_MATCH for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField FIELD_TO_MATCH = new ParameterExceptionField("FIELD_TO_MATCH");
        /// <summary>
        /// Constant FIREWALL_MANAGER_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField FIREWALL_MANAGER_STATEMENT = new ParameterExceptionField("FIREWALL_MANAGER_STATEMENT");
        /// <summary>
        /// Constant FORWARDED_IP_CONFIG for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField FORWARDED_IP_CONFIG = new ParameterExceptionField("FORWARDED_IP_CONFIG");
        /// <summary>
        /// Constant GEO_MATCH_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField GEO_MATCH_STATEMENT = new ParameterExceptionField("GEO_MATCH_STATEMENT");
        /// <summary>
        /// Constant HEADER_NAME for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField HEADER_NAME = new ParameterExceptionField("HEADER_NAME");
        /// <summary>
        /// Constant IP_ADDRESS for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IP_ADDRESS = new ParameterExceptionField("IP_ADDRESS");
        /// <summary>
        /// Constant IP_ADDRESS_VERSION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IP_ADDRESS_VERSION = new ParameterExceptionField("IP_ADDRESS_VERSION");
        /// <summary>
        /// Constant IP_SET for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IP_SET = new ParameterExceptionField("IP_SET");
        /// <summary>
        /// Constant IP_SET_FORWARDED_IP_CONFIG for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IP_SET_FORWARDED_IP_CONFIG = new ParameterExceptionField("IP_SET_FORWARDED_IP_CONFIG");
        /// <summary>
        /// Constant IP_SET_REFERENCE_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IP_SET_REFERENCE_STATEMENT = new ParameterExceptionField("IP_SET_REFERENCE_STATEMENT");
        /// <summary>
        /// Constant MANAGED_RULE_SET for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField MANAGED_RULE_SET = new ParameterExceptionField("MANAGED_RULE_SET");
        /// <summary>
        /// Constant MANAGED_RULE_SET_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField MANAGED_RULE_SET_STATEMENT = new ParameterExceptionField("MANAGED_RULE_SET_STATEMENT");
        /// <summary>
        /// Constant METRIC_NAME for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField METRIC_NAME = new ParameterExceptionField("METRIC_NAME");
        /// <summary>
        /// Constant NOT_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField NOT_STATEMENT = new ParameterExceptionField("NOT_STATEMENT");
        /// <summary>
        /// Constant OR_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField OR_STATEMENT = new ParameterExceptionField("OR_STATEMENT");
        /// <summary>
        /// Constant OVERRIDE_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField OVERRIDE_ACTION = new ParameterExceptionField("OVERRIDE_ACTION");
        /// <summary>
        /// Constant POSITION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField POSITION = new ParameterExceptionField("POSITION");
        /// <summary>
        /// Constant RATE_BASED_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RATE_BASED_STATEMENT = new ParameterExceptionField("RATE_BASED_STATEMENT");
        /// <summary>
        /// Constant REGEX_PATTERN_REFERENCE_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField REGEX_PATTERN_REFERENCE_STATEMENT = new ParameterExceptionField("REGEX_PATTERN_REFERENCE_STATEMENT");
        /// <summary>
        /// Constant REGEX_PATTERN_SET for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField REGEX_PATTERN_SET = new ParameterExceptionField("REGEX_PATTERN_SET");
        /// <summary>
        /// Constant RESOURCE_ARN for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RESOURCE_ARN = new ParameterExceptionField("RESOURCE_ARN");
        /// <summary>
        /// Constant RESOURCE_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RESOURCE_TYPE = new ParameterExceptionField("RESOURCE_TYPE");
        /// <summary>
        /// Constant RULE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RULE = new ParameterExceptionField("RULE");
        /// <summary>
        /// Constant RULE_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RULE_ACTION = new ParameterExceptionField("RULE_ACTION");
        /// <summary>
        /// Constant RULE_GROUP for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RULE_GROUP = new ParameterExceptionField("RULE_GROUP");
        /// <summary>
        /// Constant RULE_GROUP_REFERENCE_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RULE_GROUP_REFERENCE_STATEMENT = new ParameterExceptionField("RULE_GROUP_REFERENCE_STATEMENT");
        /// <summary>
        /// Constant SCOPE_VALUE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SCOPE_VALUE = new ParameterExceptionField("SCOPE_VALUE");
        /// <summary>
        /// Constant SINGLE_HEADER for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SINGLE_HEADER = new ParameterExceptionField("SINGLE_HEADER");
        /// <summary>
        /// Constant SINGLE_QUERY_ARGUMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SINGLE_QUERY_ARGUMENT = new ParameterExceptionField("SINGLE_QUERY_ARGUMENT");
        /// <summary>
        /// Constant SIZE_CONSTRAINT_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SIZE_CONSTRAINT_STATEMENT = new ParameterExceptionField("SIZE_CONSTRAINT_STATEMENT");
        /// <summary>
        /// Constant SQLI_MATCH_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SQLI_MATCH_STATEMENT = new ParameterExceptionField("SQLI_MATCH_STATEMENT");
        /// <summary>
        /// Constant STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField STATEMENT = new ParameterExceptionField("STATEMENT");
        /// <summary>
        /// Constant TAG_KEYS for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField TAG_KEYS = new ParameterExceptionField("TAG_KEYS");
        /// <summary>
        /// Constant TAGS for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField TAGS = new ParameterExceptionField("TAGS");
        /// <summary>
        /// Constant TEXT_TRANSFORMATION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField TEXT_TRANSFORMATION = new ParameterExceptionField("TEXT_TRANSFORMATION");
        /// <summary>
        /// Constant WEB_ACL for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField WEB_ACL = new ParameterExceptionField("WEB_ACL");
        /// <summary>
        /// Constant XSS_MATCH_STATEMENT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField XSS_MATCH_STATEMENT = new ParameterExceptionField("XSS_MATCH_STATEMENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterExceptionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterExceptionField FindValue(string value)
        {
            return FindValue<ParameterExceptionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterExceptionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionalConstraint.
    /// </summary>
    public class PositionalConstraint : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint CONTAINS = new PositionalConstraint("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_WORD for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint CONTAINS_WORD = new PositionalConstraint("CONTAINS_WORD");
        /// <summary>
        /// Constant ENDS_WITH for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint ENDS_WITH = new PositionalConstraint("ENDS_WITH");
        /// <summary>
        /// Constant EXACTLY for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint EXACTLY = new PositionalConstraint("EXACTLY");
        /// <summary>
        /// Constant STARTS_WITH for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint STARTS_WITH = new PositionalConstraint("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PositionalConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionalConstraint FindValue(string value)
        {
            return FindValue<PositionalConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionalConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RateBasedStatementAggregateKeyType.
    /// </summary>
    public class RateBasedStatementAggregateKeyType : ConstantClass
    {

        /// <summary>
        /// Constant FORWARDED_IP for RateBasedStatementAggregateKeyType
        /// </summary>
        public static readonly RateBasedStatementAggregateKeyType FORWARDED_IP = new RateBasedStatementAggregateKeyType("FORWARDED_IP");
        /// <summary>
        /// Constant IP for RateBasedStatementAggregateKeyType
        /// </summary>
        public static readonly RateBasedStatementAggregateKeyType IP = new RateBasedStatementAggregateKeyType("IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RateBasedStatementAggregateKeyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RateBasedStatementAggregateKeyType FindValue(string value)
        {
            return FindValue<RateBasedStatementAggregateKeyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RateBasedStatementAggregateKeyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant API_GATEWAY for ResourceType
        /// </summary>
        public static readonly ResourceType API_GATEWAY = new ResourceType("API_GATEWAY");
        /// <summary>
        /// Constant APPLICATION_LOAD_BALANCER for ResourceType
        /// </summary>
        public static readonly ResourceType APPLICATION_LOAD_BALANCER = new ResourceType("APPLICATION_LOAD_BALANCER");
        /// <summary>
        /// Constant APPSYNC for ResourceType
        /// </summary>
        public static readonly ResourceType APPSYNC = new ResourceType("APPSYNC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFRONT for Scope
        /// </summary>
        public static readonly Scope CLOUDFRONT = new Scope("CLOUDFRONT");
        /// <summary>
        /// Constant REGIONAL for Scope
        /// </summary>
        public static readonly Scope REGIONAL = new Scope("REGIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextTransformationType.
    /// </summary>
    public class TextTransformationType : ConstantClass
    {

        /// <summary>
        /// Constant CMD_LINE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType CMD_LINE = new TextTransformationType("CMD_LINE");
        /// <summary>
        /// Constant COMPRESS_WHITE_SPACE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType COMPRESS_WHITE_SPACE = new TextTransformationType("COMPRESS_WHITE_SPACE");
        /// <summary>
        /// Constant HTML_ENTITY_DECODE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType HTML_ENTITY_DECODE = new TextTransformationType("HTML_ENTITY_DECODE");
        /// <summary>
        /// Constant LOWERCASE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType LOWERCASE = new TextTransformationType("LOWERCASE");
        /// <summary>
        /// Constant NONE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType NONE = new TextTransformationType("NONE");
        /// <summary>
        /// Constant URL_DECODE for TextTransformationType
        /// </summary>
        public static readonly TextTransformationType URL_DECODE = new TextTransformationType("URL_DECODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextTransformationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextTransformationType FindValue(string value)
        {
            return FindValue<TextTransformationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextTransformationType(string value)
        {
            return FindValue(value);
        }
    }

}