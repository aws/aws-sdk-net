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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WAFRegional
{

    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ChangeAction
        /// </summary>
        public static readonly ChangeAction DELETE = new ChangeAction("DELETE");
        /// <summary>
        /// Constant INSERT for ChangeAction
        /// </summary>
        public static readonly ChangeAction INSERT = new ChangeAction("INSERT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeTokenStatus.
    /// </summary>
    public class ChangeTokenStatus : ConstantClass
    {

        /// <summary>
        /// Constant INSYNC for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus INSYNC = new ChangeTokenStatus("INSYNC");
        /// <summary>
        /// Constant PENDING for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus PENDING = new ChangeTokenStatus("PENDING");
        /// <summary>
        /// Constant PROVISIONED for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus PROVISIONED = new ChangeTokenStatus("PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeTokenStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeTokenStatus FindValue(string value)
        {
            return FindValue<ChangeTokenStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeTokenStatus(string value)
        {
            return FindValue(value);
        }
    }


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
    /// Constants used for properties of type GeoMatchConstraintType.
    /// </summary>
    public class GeoMatchConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant Country for GeoMatchConstraintType
        /// </summary>
        public static readonly GeoMatchConstraintType Country = new GeoMatchConstraintType("Country");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoMatchConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoMatchConstraintType FindValue(string value)
        {
            return FindValue<GeoMatchConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoMatchConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeoMatchConstraintValue.
    /// </summary>
    public class GeoMatchConstraintValue : ConstantClass
    {

        /// <summary>
        /// Constant AD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AD = new GeoMatchConstraintValue("AD");
        /// <summary>
        /// Constant AE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AE = new GeoMatchConstraintValue("AE");
        /// <summary>
        /// Constant AF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AF = new GeoMatchConstraintValue("AF");
        /// <summary>
        /// Constant AG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AG = new GeoMatchConstraintValue("AG");
        /// <summary>
        /// Constant AI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AI = new GeoMatchConstraintValue("AI");
        /// <summary>
        /// Constant AL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AL = new GeoMatchConstraintValue("AL");
        /// <summary>
        /// Constant AM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AM = new GeoMatchConstraintValue("AM");
        /// <summary>
        /// Constant AO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AO = new GeoMatchConstraintValue("AO");
        /// <summary>
        /// Constant AQ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AQ = new GeoMatchConstraintValue("AQ");
        /// <summary>
        /// Constant AR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AR = new GeoMatchConstraintValue("AR");
        /// <summary>
        /// Constant AS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AS = new GeoMatchConstraintValue("AS");
        /// <summary>
        /// Constant AT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AT = new GeoMatchConstraintValue("AT");
        /// <summary>
        /// Constant AU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AU = new GeoMatchConstraintValue("AU");
        /// <summary>
        /// Constant AW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AW = new GeoMatchConstraintValue("AW");
        /// <summary>
        /// Constant AX for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AX = new GeoMatchConstraintValue("AX");
        /// <summary>
        /// Constant AZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue AZ = new GeoMatchConstraintValue("AZ");
        /// <summary>
        /// Constant BA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BA = new GeoMatchConstraintValue("BA");
        /// <summary>
        /// Constant BB for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BB = new GeoMatchConstraintValue("BB");
        /// <summary>
        /// Constant BD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BD = new GeoMatchConstraintValue("BD");
        /// <summary>
        /// Constant BE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BE = new GeoMatchConstraintValue("BE");
        /// <summary>
        /// Constant BF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BF = new GeoMatchConstraintValue("BF");
        /// <summary>
        /// Constant BG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BG = new GeoMatchConstraintValue("BG");
        /// <summary>
        /// Constant BH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BH = new GeoMatchConstraintValue("BH");
        /// <summary>
        /// Constant BI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BI = new GeoMatchConstraintValue("BI");
        /// <summary>
        /// Constant BJ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BJ = new GeoMatchConstraintValue("BJ");
        /// <summary>
        /// Constant BL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BL = new GeoMatchConstraintValue("BL");
        /// <summary>
        /// Constant BM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BM = new GeoMatchConstraintValue("BM");
        /// <summary>
        /// Constant BN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BN = new GeoMatchConstraintValue("BN");
        /// <summary>
        /// Constant BO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BO = new GeoMatchConstraintValue("BO");
        /// <summary>
        /// Constant BQ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BQ = new GeoMatchConstraintValue("BQ");
        /// <summary>
        /// Constant BR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BR = new GeoMatchConstraintValue("BR");
        /// <summary>
        /// Constant BS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BS = new GeoMatchConstraintValue("BS");
        /// <summary>
        /// Constant BT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BT = new GeoMatchConstraintValue("BT");
        /// <summary>
        /// Constant BV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BV = new GeoMatchConstraintValue("BV");
        /// <summary>
        /// Constant BW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BW = new GeoMatchConstraintValue("BW");
        /// <summary>
        /// Constant BY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BY = new GeoMatchConstraintValue("BY");
        /// <summary>
        /// Constant BZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue BZ = new GeoMatchConstraintValue("BZ");
        /// <summary>
        /// Constant CA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CA = new GeoMatchConstraintValue("CA");
        /// <summary>
        /// Constant CC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CC = new GeoMatchConstraintValue("CC");
        /// <summary>
        /// Constant CD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CD = new GeoMatchConstraintValue("CD");
        /// <summary>
        /// Constant CF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CF = new GeoMatchConstraintValue("CF");
        /// <summary>
        /// Constant CG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CG = new GeoMatchConstraintValue("CG");
        /// <summary>
        /// Constant CH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CH = new GeoMatchConstraintValue("CH");
        /// <summary>
        /// Constant CI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CI = new GeoMatchConstraintValue("CI");
        /// <summary>
        /// Constant CK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CK = new GeoMatchConstraintValue("CK");
        /// <summary>
        /// Constant CL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CL = new GeoMatchConstraintValue("CL");
        /// <summary>
        /// Constant CM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CM = new GeoMatchConstraintValue("CM");
        /// <summary>
        /// Constant CN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CN = new GeoMatchConstraintValue("CN");
        /// <summary>
        /// Constant CO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CO = new GeoMatchConstraintValue("CO");
        /// <summary>
        /// Constant CR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CR = new GeoMatchConstraintValue("CR");
        /// <summary>
        /// Constant CU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CU = new GeoMatchConstraintValue("CU");
        /// <summary>
        /// Constant CV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CV = new GeoMatchConstraintValue("CV");
        /// <summary>
        /// Constant CW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CW = new GeoMatchConstraintValue("CW");
        /// <summary>
        /// Constant CX for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CX = new GeoMatchConstraintValue("CX");
        /// <summary>
        /// Constant CY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CY = new GeoMatchConstraintValue("CY");
        /// <summary>
        /// Constant CZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue CZ = new GeoMatchConstraintValue("CZ");
        /// <summary>
        /// Constant DE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DE = new GeoMatchConstraintValue("DE");
        /// <summary>
        /// Constant DJ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DJ = new GeoMatchConstraintValue("DJ");
        /// <summary>
        /// Constant DK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DK = new GeoMatchConstraintValue("DK");
        /// <summary>
        /// Constant DM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DM = new GeoMatchConstraintValue("DM");
        /// <summary>
        /// Constant DO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DO = new GeoMatchConstraintValue("DO");
        /// <summary>
        /// Constant DZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue DZ = new GeoMatchConstraintValue("DZ");
        /// <summary>
        /// Constant EC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue EC = new GeoMatchConstraintValue("EC");
        /// <summary>
        /// Constant EE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue EE = new GeoMatchConstraintValue("EE");
        /// <summary>
        /// Constant EG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue EG = new GeoMatchConstraintValue("EG");
        /// <summary>
        /// Constant EH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue EH = new GeoMatchConstraintValue("EH");
        /// <summary>
        /// Constant ER for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ER = new GeoMatchConstraintValue("ER");
        /// <summary>
        /// Constant ES for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ES = new GeoMatchConstraintValue("ES");
        /// <summary>
        /// Constant ET for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ET = new GeoMatchConstraintValue("ET");
        /// <summary>
        /// Constant FI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FI = new GeoMatchConstraintValue("FI");
        /// <summary>
        /// Constant FJ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FJ = new GeoMatchConstraintValue("FJ");
        /// <summary>
        /// Constant FK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FK = new GeoMatchConstraintValue("FK");
        /// <summary>
        /// Constant FM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FM = new GeoMatchConstraintValue("FM");
        /// <summary>
        /// Constant FO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FO = new GeoMatchConstraintValue("FO");
        /// <summary>
        /// Constant FR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue FR = new GeoMatchConstraintValue("FR");
        /// <summary>
        /// Constant GA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GA = new GeoMatchConstraintValue("GA");
        /// <summary>
        /// Constant GB for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GB = new GeoMatchConstraintValue("GB");
        /// <summary>
        /// Constant GD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GD = new GeoMatchConstraintValue("GD");
        /// <summary>
        /// Constant GE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GE = new GeoMatchConstraintValue("GE");
        /// <summary>
        /// Constant GF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GF = new GeoMatchConstraintValue("GF");
        /// <summary>
        /// Constant GG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GG = new GeoMatchConstraintValue("GG");
        /// <summary>
        /// Constant GH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GH = new GeoMatchConstraintValue("GH");
        /// <summary>
        /// Constant GI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GI = new GeoMatchConstraintValue("GI");
        /// <summary>
        /// Constant GL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GL = new GeoMatchConstraintValue("GL");
        /// <summary>
        /// Constant GM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GM = new GeoMatchConstraintValue("GM");
        /// <summary>
        /// Constant GN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GN = new GeoMatchConstraintValue("GN");
        /// <summary>
        /// Constant GP for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GP = new GeoMatchConstraintValue("GP");
        /// <summary>
        /// Constant GQ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GQ = new GeoMatchConstraintValue("GQ");
        /// <summary>
        /// Constant GR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GR = new GeoMatchConstraintValue("GR");
        /// <summary>
        /// Constant GS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GS = new GeoMatchConstraintValue("GS");
        /// <summary>
        /// Constant GT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GT = new GeoMatchConstraintValue("GT");
        /// <summary>
        /// Constant GU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GU = new GeoMatchConstraintValue("GU");
        /// <summary>
        /// Constant GW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GW = new GeoMatchConstraintValue("GW");
        /// <summary>
        /// Constant GY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue GY = new GeoMatchConstraintValue("GY");
        /// <summary>
        /// Constant HK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HK = new GeoMatchConstraintValue("HK");
        /// <summary>
        /// Constant HM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HM = new GeoMatchConstraintValue("HM");
        /// <summary>
        /// Constant HN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HN = new GeoMatchConstraintValue("HN");
        /// <summary>
        /// Constant HR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HR = new GeoMatchConstraintValue("HR");
        /// <summary>
        /// Constant HT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HT = new GeoMatchConstraintValue("HT");
        /// <summary>
        /// Constant HU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue HU = new GeoMatchConstraintValue("HU");
        /// <summary>
        /// Constant ID for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ID = new GeoMatchConstraintValue("ID");
        /// <summary>
        /// Constant IE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IE = new GeoMatchConstraintValue("IE");
        /// <summary>
        /// Constant IL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IL = new GeoMatchConstraintValue("IL");
        /// <summary>
        /// Constant IM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IM = new GeoMatchConstraintValue("IM");
        /// <summary>
        /// Constant IN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IN = new GeoMatchConstraintValue("IN");
        /// <summary>
        /// Constant IO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IO = new GeoMatchConstraintValue("IO");
        /// <summary>
        /// Constant IQ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IQ = new GeoMatchConstraintValue("IQ");
        /// <summary>
        /// Constant IR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IR = new GeoMatchConstraintValue("IR");
        /// <summary>
        /// Constant IS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IS = new GeoMatchConstraintValue("IS");
        /// <summary>
        /// Constant IT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue IT = new GeoMatchConstraintValue("IT");
        /// <summary>
        /// Constant JE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue JE = new GeoMatchConstraintValue("JE");
        /// <summary>
        /// Constant JM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue JM = new GeoMatchConstraintValue("JM");
        /// <summary>
        /// Constant JO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue JO = new GeoMatchConstraintValue("JO");
        /// <summary>
        /// Constant JP for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue JP = new GeoMatchConstraintValue("JP");
        /// <summary>
        /// Constant KE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KE = new GeoMatchConstraintValue("KE");
        /// <summary>
        /// Constant KG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KG = new GeoMatchConstraintValue("KG");
        /// <summary>
        /// Constant KH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KH = new GeoMatchConstraintValue("KH");
        /// <summary>
        /// Constant KI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KI = new GeoMatchConstraintValue("KI");
        /// <summary>
        /// Constant KM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KM = new GeoMatchConstraintValue("KM");
        /// <summary>
        /// Constant KN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KN = new GeoMatchConstraintValue("KN");
        /// <summary>
        /// Constant KP for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KP = new GeoMatchConstraintValue("KP");
        /// <summary>
        /// Constant KR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KR = new GeoMatchConstraintValue("KR");
        /// <summary>
        /// Constant KW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KW = new GeoMatchConstraintValue("KW");
        /// <summary>
        /// Constant KY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KY = new GeoMatchConstraintValue("KY");
        /// <summary>
        /// Constant KZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue KZ = new GeoMatchConstraintValue("KZ");
        /// <summary>
        /// Constant LA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LA = new GeoMatchConstraintValue("LA");
        /// <summary>
        /// Constant LB for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LB = new GeoMatchConstraintValue("LB");
        /// <summary>
        /// Constant LC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LC = new GeoMatchConstraintValue("LC");
        /// <summary>
        /// Constant LI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LI = new GeoMatchConstraintValue("LI");
        /// <summary>
        /// Constant LK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LK = new GeoMatchConstraintValue("LK");
        /// <summary>
        /// Constant LR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LR = new GeoMatchConstraintValue("LR");
        /// <summary>
        /// Constant LS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LS = new GeoMatchConstraintValue("LS");
        /// <summary>
        /// Constant LT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LT = new GeoMatchConstraintValue("LT");
        /// <summary>
        /// Constant LU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LU = new GeoMatchConstraintValue("LU");
        /// <summary>
        /// Constant LV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LV = new GeoMatchConstraintValue("LV");
        /// <summary>
        /// Constant LY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue LY = new GeoMatchConstraintValue("LY");
        /// <summary>
        /// Constant MA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MA = new GeoMatchConstraintValue("MA");
        /// <summary>
        /// Constant MC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MC = new GeoMatchConstraintValue("MC");
        /// <summary>
        /// Constant MD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MD = new GeoMatchConstraintValue("MD");
        /// <summary>
        /// Constant ME for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ME = new GeoMatchConstraintValue("ME");
        /// <summary>
        /// Constant MF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MF = new GeoMatchConstraintValue("MF");
        /// <summary>
        /// Constant MG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MG = new GeoMatchConstraintValue("MG");
        /// <summary>
        /// Constant MH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MH = new GeoMatchConstraintValue("MH");
        /// <summary>
        /// Constant MK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MK = new GeoMatchConstraintValue("MK");
        /// <summary>
        /// Constant ML for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ML = new GeoMatchConstraintValue("ML");
        /// <summary>
        /// Constant MM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MM = new GeoMatchConstraintValue("MM");
        /// <summary>
        /// Constant MN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MN = new GeoMatchConstraintValue("MN");
        /// <summary>
        /// Constant MO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MO = new GeoMatchConstraintValue("MO");
        /// <summary>
        /// Constant MP for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MP = new GeoMatchConstraintValue("MP");
        /// <summary>
        /// Constant MQ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MQ = new GeoMatchConstraintValue("MQ");
        /// <summary>
        /// Constant MR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MR = new GeoMatchConstraintValue("MR");
        /// <summary>
        /// Constant MS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MS = new GeoMatchConstraintValue("MS");
        /// <summary>
        /// Constant MT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MT = new GeoMatchConstraintValue("MT");
        /// <summary>
        /// Constant MU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MU = new GeoMatchConstraintValue("MU");
        /// <summary>
        /// Constant MV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MV = new GeoMatchConstraintValue("MV");
        /// <summary>
        /// Constant MW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MW = new GeoMatchConstraintValue("MW");
        /// <summary>
        /// Constant MX for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MX = new GeoMatchConstraintValue("MX");
        /// <summary>
        /// Constant MY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MY = new GeoMatchConstraintValue("MY");
        /// <summary>
        /// Constant MZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue MZ = new GeoMatchConstraintValue("MZ");
        /// <summary>
        /// Constant NA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NA = new GeoMatchConstraintValue("NA");
        /// <summary>
        /// Constant NC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NC = new GeoMatchConstraintValue("NC");
        /// <summary>
        /// Constant NE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NE = new GeoMatchConstraintValue("NE");
        /// <summary>
        /// Constant NF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NF = new GeoMatchConstraintValue("NF");
        /// <summary>
        /// Constant NG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NG = new GeoMatchConstraintValue("NG");
        /// <summary>
        /// Constant NI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NI = new GeoMatchConstraintValue("NI");
        /// <summary>
        /// Constant NL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NL = new GeoMatchConstraintValue("NL");
        /// <summary>
        /// Constant NO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NO = new GeoMatchConstraintValue("NO");
        /// <summary>
        /// Constant NP for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NP = new GeoMatchConstraintValue("NP");
        /// <summary>
        /// Constant NR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NR = new GeoMatchConstraintValue("NR");
        /// <summary>
        /// Constant NU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NU = new GeoMatchConstraintValue("NU");
        /// <summary>
        /// Constant NZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue NZ = new GeoMatchConstraintValue("NZ");
        /// <summary>
        /// Constant OM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue OM = new GeoMatchConstraintValue("OM");
        /// <summary>
        /// Constant PA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PA = new GeoMatchConstraintValue("PA");
        /// <summary>
        /// Constant PE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PE = new GeoMatchConstraintValue("PE");
        /// <summary>
        /// Constant PF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PF = new GeoMatchConstraintValue("PF");
        /// <summary>
        /// Constant PG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PG = new GeoMatchConstraintValue("PG");
        /// <summary>
        /// Constant PH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PH = new GeoMatchConstraintValue("PH");
        /// <summary>
        /// Constant PK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PK = new GeoMatchConstraintValue("PK");
        /// <summary>
        /// Constant PL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PL = new GeoMatchConstraintValue("PL");
        /// <summary>
        /// Constant PM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PM = new GeoMatchConstraintValue("PM");
        /// <summary>
        /// Constant PN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PN = new GeoMatchConstraintValue("PN");
        /// <summary>
        /// Constant PR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PR = new GeoMatchConstraintValue("PR");
        /// <summary>
        /// Constant PS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PS = new GeoMatchConstraintValue("PS");
        /// <summary>
        /// Constant PT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PT = new GeoMatchConstraintValue("PT");
        /// <summary>
        /// Constant PW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PW = new GeoMatchConstraintValue("PW");
        /// <summary>
        /// Constant PY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue PY = new GeoMatchConstraintValue("PY");
        /// <summary>
        /// Constant QA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue QA = new GeoMatchConstraintValue("QA");
        /// <summary>
        /// Constant RE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue RE = new GeoMatchConstraintValue("RE");
        /// <summary>
        /// Constant RO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue RO = new GeoMatchConstraintValue("RO");
        /// <summary>
        /// Constant RS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue RS = new GeoMatchConstraintValue("RS");
        /// <summary>
        /// Constant RU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue RU = new GeoMatchConstraintValue("RU");
        /// <summary>
        /// Constant RW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue RW = new GeoMatchConstraintValue("RW");
        /// <summary>
        /// Constant SA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SA = new GeoMatchConstraintValue("SA");
        /// <summary>
        /// Constant SB for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SB = new GeoMatchConstraintValue("SB");
        /// <summary>
        /// Constant SC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SC = new GeoMatchConstraintValue("SC");
        /// <summary>
        /// Constant SD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SD = new GeoMatchConstraintValue("SD");
        /// <summary>
        /// Constant SE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SE = new GeoMatchConstraintValue("SE");
        /// <summary>
        /// Constant SG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SG = new GeoMatchConstraintValue("SG");
        /// <summary>
        /// Constant SH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SH = new GeoMatchConstraintValue("SH");
        /// <summary>
        /// Constant SI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SI = new GeoMatchConstraintValue("SI");
        /// <summary>
        /// Constant SJ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SJ = new GeoMatchConstraintValue("SJ");
        /// <summary>
        /// Constant SK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SK = new GeoMatchConstraintValue("SK");
        /// <summary>
        /// Constant SL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SL = new GeoMatchConstraintValue("SL");
        /// <summary>
        /// Constant SM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SM = new GeoMatchConstraintValue("SM");
        /// <summary>
        /// Constant SN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SN = new GeoMatchConstraintValue("SN");
        /// <summary>
        /// Constant SO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SO = new GeoMatchConstraintValue("SO");
        /// <summary>
        /// Constant SR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SR = new GeoMatchConstraintValue("SR");
        /// <summary>
        /// Constant SS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SS = new GeoMatchConstraintValue("SS");
        /// <summary>
        /// Constant ST for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ST = new GeoMatchConstraintValue("ST");
        /// <summary>
        /// Constant SV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SV = new GeoMatchConstraintValue("SV");
        /// <summary>
        /// Constant SX for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SX = new GeoMatchConstraintValue("SX");
        /// <summary>
        /// Constant SY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SY = new GeoMatchConstraintValue("SY");
        /// <summary>
        /// Constant SZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue SZ = new GeoMatchConstraintValue("SZ");
        /// <summary>
        /// Constant TC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TC = new GeoMatchConstraintValue("TC");
        /// <summary>
        /// Constant TD for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TD = new GeoMatchConstraintValue("TD");
        /// <summary>
        /// Constant TF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TF = new GeoMatchConstraintValue("TF");
        /// <summary>
        /// Constant TG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TG = new GeoMatchConstraintValue("TG");
        /// <summary>
        /// Constant TH for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TH = new GeoMatchConstraintValue("TH");
        /// <summary>
        /// Constant TJ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TJ = new GeoMatchConstraintValue("TJ");
        /// <summary>
        /// Constant TK for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TK = new GeoMatchConstraintValue("TK");
        /// <summary>
        /// Constant TL for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TL = new GeoMatchConstraintValue("TL");
        /// <summary>
        /// Constant TM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TM = new GeoMatchConstraintValue("TM");
        /// <summary>
        /// Constant TN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TN = new GeoMatchConstraintValue("TN");
        /// <summary>
        /// Constant TO for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TO = new GeoMatchConstraintValue("TO");
        /// <summary>
        /// Constant TR for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TR = new GeoMatchConstraintValue("TR");
        /// <summary>
        /// Constant TT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TT = new GeoMatchConstraintValue("TT");
        /// <summary>
        /// Constant TV for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TV = new GeoMatchConstraintValue("TV");
        /// <summary>
        /// Constant TW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TW = new GeoMatchConstraintValue("TW");
        /// <summary>
        /// Constant TZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue TZ = new GeoMatchConstraintValue("TZ");
        /// <summary>
        /// Constant UA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue UA = new GeoMatchConstraintValue("UA");
        /// <summary>
        /// Constant UG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue UG = new GeoMatchConstraintValue("UG");
        /// <summary>
        /// Constant UM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue UM = new GeoMatchConstraintValue("UM");
        /// <summary>
        /// Constant US for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue US = new GeoMatchConstraintValue("US");
        /// <summary>
        /// Constant UY for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue UY = new GeoMatchConstraintValue("UY");
        /// <summary>
        /// Constant UZ for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue UZ = new GeoMatchConstraintValue("UZ");
        /// <summary>
        /// Constant VA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VA = new GeoMatchConstraintValue("VA");
        /// <summary>
        /// Constant VC for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VC = new GeoMatchConstraintValue("VC");
        /// <summary>
        /// Constant VE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VE = new GeoMatchConstraintValue("VE");
        /// <summary>
        /// Constant VG for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VG = new GeoMatchConstraintValue("VG");
        /// <summary>
        /// Constant VI for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VI = new GeoMatchConstraintValue("VI");
        /// <summary>
        /// Constant VN for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VN = new GeoMatchConstraintValue("VN");
        /// <summary>
        /// Constant VU for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue VU = new GeoMatchConstraintValue("VU");
        /// <summary>
        /// Constant WF for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue WF = new GeoMatchConstraintValue("WF");
        /// <summary>
        /// Constant WS for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue WS = new GeoMatchConstraintValue("WS");
        /// <summary>
        /// Constant YE for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue YE = new GeoMatchConstraintValue("YE");
        /// <summary>
        /// Constant YT for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue YT = new GeoMatchConstraintValue("YT");
        /// <summary>
        /// Constant ZA for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ZA = new GeoMatchConstraintValue("ZA");
        /// <summary>
        /// Constant ZM for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ZM = new GeoMatchConstraintValue("ZM");
        /// <summary>
        /// Constant ZW for GeoMatchConstraintValue
        /// </summary>
        public static readonly GeoMatchConstraintValue ZW = new GeoMatchConstraintValue("ZW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeoMatchConstraintValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeoMatchConstraintValue FindValue(string value)
        {
            return FindValue<GeoMatchConstraintValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeoMatchConstraintValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IPSetDescriptorType.
    /// </summary>
    public class IPSetDescriptorType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for IPSetDescriptorType
        /// </summary>
        public static readonly IPSetDescriptorType IPV4 = new IPSetDescriptorType("IPV4");
        /// <summary>
        /// Constant IPV6 for IPSetDescriptorType
        /// </summary>
        public static readonly IPSetDescriptorType IPV6 = new IPSetDescriptorType("IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IPSetDescriptorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IPSetDescriptorType FindValue(string value)
        {
            return FindValue<IPSetDescriptorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IPSetDescriptorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchFieldType.
    /// </summary>
    public class MatchFieldType : ConstantClass
    {

        /// <summary>
        /// Constant ALL_QUERY_ARGS for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType ALL_QUERY_ARGS = new MatchFieldType("ALL_QUERY_ARGS");
        /// <summary>
        /// Constant BODY for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType BODY = new MatchFieldType("BODY");
        /// <summary>
        /// Constant HEADER for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType HEADER = new MatchFieldType("HEADER");
        /// <summary>
        /// Constant METHOD for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType METHOD = new MatchFieldType("METHOD");
        /// <summary>
        /// Constant QUERY_STRING for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType QUERY_STRING = new MatchFieldType("QUERY_STRING");
        /// <summary>
        /// Constant SINGLE_QUERY_ARG for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType SINGLE_QUERY_ARG = new MatchFieldType("SINGLE_QUERY_ARG");
        /// <summary>
        /// Constant URI for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType URI = new MatchFieldType("URI");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchFieldType FindValue(string value)
        {
            return FindValue<MatchFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationErrorType.
    /// </summary>
    public class MigrationErrorType : ConstantClass
    {

        /// <summary>
        /// Constant ENTITY_NOT_FOUND for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType ENTITY_NOT_FOUND = new MigrationErrorType("ENTITY_NOT_FOUND");
        /// <summary>
        /// Constant ENTITY_NOT_SUPPORTED for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType ENTITY_NOT_SUPPORTED = new MigrationErrorType("ENTITY_NOT_SUPPORTED");
        /// <summary>
        /// Constant S3_BUCKET_INVALID_REGION for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType S3_BUCKET_INVALID_REGION = new MigrationErrorType("S3_BUCKET_INVALID_REGION");
        /// <summary>
        /// Constant S3_BUCKET_NO_PERMISSION for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType S3_BUCKET_NO_PERMISSION = new MigrationErrorType("S3_BUCKET_NO_PERMISSION");
        /// <summary>
        /// Constant S3_BUCKET_NOT_ACCESSIBLE for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType S3_BUCKET_NOT_ACCESSIBLE = new MigrationErrorType("S3_BUCKET_NOT_ACCESSIBLE");
        /// <summary>
        /// Constant S3_BUCKET_NOT_FOUND for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType S3_BUCKET_NOT_FOUND = new MigrationErrorType("S3_BUCKET_NOT_FOUND");
        /// <summary>
        /// Constant S3_INTERNAL_ERROR for MigrationErrorType
        /// </summary>
        public static readonly MigrationErrorType S3_INTERNAL_ERROR = new MigrationErrorType("S3_INTERNAL_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationErrorType FindValue(string value)
        {
            return FindValue<MigrationErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationErrorType(string value)
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
        /// Constant BYTE_MATCH_FIELD_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_FIELD_TYPE = new ParameterExceptionField("BYTE_MATCH_FIELD_TYPE");
        /// <summary>
        /// Constant BYTE_MATCH_POSITIONAL_CONSTRAINT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_POSITIONAL_CONSTRAINT = new ParameterExceptionField("BYTE_MATCH_POSITIONAL_CONSTRAINT");
        /// <summary>
        /// Constant BYTE_MATCH_TEXT_TRANSFORMATION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_TEXT_TRANSFORMATION = new ParameterExceptionField("BYTE_MATCH_TEXT_TRANSFORMATION");
        /// <summary>
        /// Constant CHANGE_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField CHANGE_ACTION = new ParameterExceptionField("CHANGE_ACTION");
        /// <summary>
        /// Constant GEO_MATCH_LOCATION_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField GEO_MATCH_LOCATION_TYPE = new ParameterExceptionField("GEO_MATCH_LOCATION_TYPE");
        /// <summary>
        /// Constant GEO_MATCH_LOCATION_VALUE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField GEO_MATCH_LOCATION_VALUE = new ParameterExceptionField("GEO_MATCH_LOCATION_VALUE");
        /// <summary>
        /// Constant IPSET_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IPSET_TYPE = new ParameterExceptionField("IPSET_TYPE");
        /// <summary>
        /// Constant NEXT_MARKER for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField NEXT_MARKER = new ParameterExceptionField("NEXT_MARKER");
        /// <summary>
        /// Constant PREDICATE_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField PREDICATE_TYPE = new ParameterExceptionField("PREDICATE_TYPE");
        /// <summary>
        /// Constant RATE_KEY for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RATE_KEY = new ParameterExceptionField("RATE_KEY");
        /// <summary>
        /// Constant RESOURCE_ARN for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RESOURCE_ARN = new ParameterExceptionField("RESOURCE_ARN");
        /// <summary>
        /// Constant RULE_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField RULE_TYPE = new ParameterExceptionField("RULE_TYPE");
        /// <summary>
        /// Constant SIZE_CONSTRAINT_COMPARISON_OPERATOR for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SIZE_CONSTRAINT_COMPARISON_OPERATOR = new ParameterExceptionField("SIZE_CONSTRAINT_COMPARISON_OPERATOR");
        /// <summary>
        /// Constant SQL_INJECTION_MATCH_FIELD_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SQL_INJECTION_MATCH_FIELD_TYPE = new ParameterExceptionField("SQL_INJECTION_MATCH_FIELD_TYPE");
        /// <summary>
        /// Constant TAG_KEYS for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField TAG_KEYS = new ParameterExceptionField("TAG_KEYS");
        /// <summary>
        /// Constant TAGS for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField TAGS = new ParameterExceptionField("TAGS");
        /// <summary>
        /// Constant WAF_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField WAF_ACTION = new ParameterExceptionField("WAF_ACTION");
        /// <summary>
        /// Constant WAF_OVERRIDE_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField WAF_OVERRIDE_ACTION = new ParameterExceptionField("WAF_OVERRIDE_ACTION");

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
    /// Constants used for properties of type ParameterExceptionReason.
    /// </summary>
    public class ParameterExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ILLEGAL_ARGUMENT for ParameterExceptionReason
        /// </summary>
        public static readonly ParameterExceptionReason ILLEGAL_ARGUMENT = new ParameterExceptionReason("ILLEGAL_ARGUMENT");
        /// <summary>
        /// Constant ILLEGAL_COMBINATION for ParameterExceptionReason
        /// </summary>
        public static readonly ParameterExceptionReason ILLEGAL_COMBINATION = new ParameterExceptionReason("ILLEGAL_COMBINATION");
        /// <summary>
        /// Constant INVALID_OPTION for ParameterExceptionReason
        /// </summary>
        public static readonly ParameterExceptionReason INVALID_OPTION = new ParameterExceptionReason("INVALID_OPTION");
        /// <summary>
        /// Constant INVALID_TAG_KEY for ParameterExceptionReason
        /// </summary>
        public static readonly ParameterExceptionReason INVALID_TAG_KEY = new ParameterExceptionReason("INVALID_TAG_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterExceptionReason FindValue(string value)
        {
            return FindValue<ParameterExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterExceptionReason(string value)
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
    /// Constants used for properties of type PredicateType.
    /// </summary>
    public class PredicateType : ConstantClass
    {

        /// <summary>
        /// Constant ByteMatch for PredicateType
        /// </summary>
        public static readonly PredicateType ByteMatch = new PredicateType("ByteMatch");
        /// <summary>
        /// Constant GeoMatch for PredicateType
        /// </summary>
        public static readonly PredicateType GeoMatch = new PredicateType("GeoMatch");
        /// <summary>
        /// Constant IPMatch for PredicateType
        /// </summary>
        public static readonly PredicateType IPMatch = new PredicateType("IPMatch");
        /// <summary>
        /// Constant RegexMatch for PredicateType
        /// </summary>
        public static readonly PredicateType RegexMatch = new PredicateType("RegexMatch");
        /// <summary>
        /// Constant SizeConstraint for PredicateType
        /// </summary>
        public static readonly PredicateType SizeConstraint = new PredicateType("SizeConstraint");
        /// <summary>
        /// Constant SqlInjectionMatch for PredicateType
        /// </summary>
        public static readonly PredicateType SqlInjectionMatch = new PredicateType("SqlInjectionMatch");
        /// <summary>
        /// Constant XssMatch for PredicateType
        /// </summary>
        public static readonly PredicateType XssMatch = new PredicateType("XssMatch");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PredicateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredicateType FindValue(string value)
        {
            return FindValue<PredicateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredicateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RateKey.
    /// </summary>
    public class RateKey : ConstantClass
    {

        /// <summary>
        /// Constant IP for RateKey
        /// </summary>
        public static readonly RateKey IP = new RateKey("IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RateKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RateKey FindValue(string value)
        {
            return FindValue<RateKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RateKey(string value)
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
    /// Constants used for properties of type TextTransformation.
    /// </summary>
    public class TextTransformation : ConstantClass
    {

        /// <summary>
        /// Constant CMD_LINE for TextTransformation
        /// </summary>
        public static readonly TextTransformation CMD_LINE = new TextTransformation("CMD_LINE");
        /// <summary>
        /// Constant COMPRESS_WHITE_SPACE for TextTransformation
        /// </summary>
        public static readonly TextTransformation COMPRESS_WHITE_SPACE = new TextTransformation("COMPRESS_WHITE_SPACE");
        /// <summary>
        /// Constant HTML_ENTITY_DECODE for TextTransformation
        /// </summary>
        public static readonly TextTransformation HTML_ENTITY_DECODE = new TextTransformation("HTML_ENTITY_DECODE");
        /// <summary>
        /// Constant LOWERCASE for TextTransformation
        /// </summary>
        public static readonly TextTransformation LOWERCASE = new TextTransformation("LOWERCASE");
        /// <summary>
        /// Constant NONE for TextTransformation
        /// </summary>
        public static readonly TextTransformation NONE = new TextTransformation("NONE");
        /// <summary>
        /// Constant URL_DECODE for TextTransformation
        /// </summary>
        public static readonly TextTransformation URL_DECODE = new TextTransformation("URL_DECODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextTransformation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextTransformation FindValue(string value)
        {
            return FindValue<TextTransformation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextTransformation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WafActionType.
    /// </summary>
    public class WafActionType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for WafActionType
        /// </summary>
        public static readonly WafActionType ALLOW = new WafActionType("ALLOW");
        /// <summary>
        /// Constant BLOCK for WafActionType
        /// </summary>
        public static readonly WafActionType BLOCK = new WafActionType("BLOCK");
        /// <summary>
        /// Constant COUNT for WafActionType
        /// </summary>
        public static readonly WafActionType COUNT = new WafActionType("COUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WafActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafActionType FindValue(string value)
        {
            return FindValue<WafActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WafOverrideActionType.
    /// </summary>
    public class WafOverrideActionType : ConstantClass
    {

        /// <summary>
        /// Constant COUNT for WafOverrideActionType
        /// </summary>
        public static readonly WafOverrideActionType COUNT = new WafOverrideActionType("COUNT");
        /// <summary>
        /// Constant NONE for WafOverrideActionType
        /// </summary>
        public static readonly WafOverrideActionType NONE = new WafOverrideActionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WafOverrideActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafOverrideActionType FindValue(string value)
        {
            return FindValue<WafOverrideActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafOverrideActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WafRuleType.
    /// </summary>
    public class WafRuleType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for WafRuleType
        /// </summary>
        public static readonly WafRuleType GROUP = new WafRuleType("GROUP");
        /// <summary>
        /// Constant RATE_BASED for WafRuleType
        /// </summary>
        public static readonly WafRuleType RATE_BASED = new WafRuleType("RATE_BASED");
        /// <summary>
        /// Constant REGULAR for WafRuleType
        /// </summary>
        public static readonly WafRuleType REGULAR = new WafRuleType("REGULAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WafRuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafRuleType FindValue(string value)
        {
            return FindValue<WafRuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafRuleType(string value)
        {
            return FindValue(value);
        }
    }

}