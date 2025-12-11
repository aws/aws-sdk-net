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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PartnerCentralBenefits
{

    /// <summary>
    /// Constants used for properties of type BenefitAllocationStatus.
    /// </summary>
    public class BenefitAllocationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BenefitAllocationStatus
        /// </summary>
        public static readonly BenefitAllocationStatus ACTIVE = new BenefitAllocationStatus("ACTIVE");
        /// <summary>
        /// Constant FULFILLED for BenefitAllocationStatus
        /// </summary>
        public static readonly BenefitAllocationStatus FULFILLED = new BenefitAllocationStatus("FULFILLED");
        /// <summary>
        /// Constant INACTIVE for BenefitAllocationStatus
        /// </summary>
        public static readonly BenefitAllocationStatus INACTIVE = new BenefitAllocationStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BenefitAllocationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BenefitAllocationStatus FindValue(string value)
        {
            return FindValue<BenefitAllocationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BenefitAllocationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BenefitApplicationStatus.
    /// </summary>
    public class BenefitApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_REQUIRED for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus ACTION_REQUIRED = new BenefitApplicationStatus("ACTION_REQUIRED");
        /// <summary>
        /// Constant APPROVED for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus APPROVED = new BenefitApplicationStatus("APPROVED");
        /// <summary>
        /// Constant CANCELED for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus CANCELED = new BenefitApplicationStatus("CANCELED");
        /// <summary>
        /// Constant IN_REVIEW for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus IN_REVIEW = new BenefitApplicationStatus("IN_REVIEW");
        /// <summary>
        /// Constant PENDING_SUBMISSION for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus PENDING_SUBMISSION = new BenefitApplicationStatus("PENDING_SUBMISSION");
        /// <summary>
        /// Constant REJECTED for BenefitApplicationStatus
        /// </summary>
        public static readonly BenefitApplicationStatus REJECTED = new BenefitApplicationStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BenefitApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BenefitApplicationStatus FindValue(string value)
        {
            return FindValue<BenefitApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BenefitApplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BenefitStatus.
    /// </summary>
    public class BenefitStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for BenefitStatus
        /// </summary>
        public static readonly BenefitStatus ACTIVE = new BenefitStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for BenefitStatus
        /// </summary>
        public static readonly BenefitStatus INACTIVE = new BenefitStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BenefitStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BenefitStatus FindValue(string value)
        {
            return FindValue<BenefitStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BenefitStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant AED for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AED = new CurrencyCode("AED");
        /// <summary>
        /// Constant AMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AMD = new CurrencyCode("AMD");
        /// <summary>
        /// Constant ARS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ARS = new CurrencyCode("ARS");
        /// <summary>
        /// Constant AUD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AUD = new CurrencyCode("AUD");
        /// <summary>
        /// Constant AWG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AWG = new CurrencyCode("AWG");
        /// <summary>
        /// Constant AZN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AZN = new CurrencyCode("AZN");
        /// <summary>
        /// Constant BBD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BBD = new CurrencyCode("BBD");
        /// <summary>
        /// Constant BDT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BDT = new CurrencyCode("BDT");
        /// <summary>
        /// Constant BGN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BGN = new CurrencyCode("BGN");
        /// <summary>
        /// Constant BMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BMD = new CurrencyCode("BMD");
        /// <summary>
        /// Constant BND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BND = new CurrencyCode("BND");
        /// <summary>
        /// Constant BOB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BOB = new CurrencyCode("BOB");
        /// <summary>
        /// Constant BRL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BRL = new CurrencyCode("BRL");
        /// <summary>
        /// Constant BSD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BSD = new CurrencyCode("BSD");
        /// <summary>
        /// Constant BYR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BYR = new CurrencyCode("BYR");
        /// <summary>
        /// Constant BZD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BZD = new CurrencyCode("BZD");
        /// <summary>
        /// Constant CAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CAD = new CurrencyCode("CAD");
        /// <summary>
        /// Constant CHF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CHF = new CurrencyCode("CHF");
        /// <summary>
        /// Constant CLP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CLP = new CurrencyCode("CLP");
        /// <summary>
        /// Constant CNY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CNY = new CurrencyCode("CNY");
        /// <summary>
        /// Constant COP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode COP = new CurrencyCode("COP");
        /// <summary>
        /// Constant CRC for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CRC = new CurrencyCode("CRC");
        /// <summary>
        /// Constant CZK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CZK = new CurrencyCode("CZK");
        /// <summary>
        /// Constant DKK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DKK = new CurrencyCode("DKK");
        /// <summary>
        /// Constant DOP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DOP = new CurrencyCode("DOP");
        /// <summary>
        /// Constant EEK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode EEK = new CurrencyCode("EEK");
        /// <summary>
        /// Constant EGP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode EGP = new CurrencyCode("EGP");
        /// <summary>
        /// Constant EUR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode EUR = new CurrencyCode("EUR");
        /// <summary>
        /// Constant GBP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GBP = new CurrencyCode("GBP");
        /// <summary>
        /// Constant GEL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GEL = new CurrencyCode("GEL");
        /// <summary>
        /// Constant GHS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GHS = new CurrencyCode("GHS");
        /// <summary>
        /// Constant GTQ for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GTQ = new CurrencyCode("GTQ");
        /// <summary>
        /// Constant GYD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GYD = new CurrencyCode("GYD");
        /// <summary>
        /// Constant HKD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HKD = new CurrencyCode("HKD");
        /// <summary>
        /// Constant HNL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HNL = new CurrencyCode("HNL");
        /// <summary>
        /// Constant HRK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HRK = new CurrencyCode("HRK");
        /// <summary>
        /// Constant HTG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HTG = new CurrencyCode("HTG");
        /// <summary>
        /// Constant HUF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HUF = new CurrencyCode("HUF");
        /// <summary>
        /// Constant IDR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode IDR = new CurrencyCode("IDR");
        /// <summary>
        /// Constant ILS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ILS = new CurrencyCode("ILS");
        /// <summary>
        /// Constant INR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode INR = new CurrencyCode("INR");
        /// <summary>
        /// Constant ISK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ISK = new CurrencyCode("ISK");
        /// <summary>
        /// Constant JMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode JMD = new CurrencyCode("JMD");
        /// <summary>
        /// Constant JPY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode JPY = new CurrencyCode("JPY");
        /// <summary>
        /// Constant KES for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KES = new CurrencyCode("KES");
        /// <summary>
        /// Constant KHR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KHR = new CurrencyCode("KHR");
        /// <summary>
        /// Constant KRW for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KRW = new CurrencyCode("KRW");
        /// <summary>
        /// Constant KYD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KYD = new CurrencyCode("KYD");
        /// <summary>
        /// Constant KZT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KZT = new CurrencyCode("KZT");
        /// <summary>
        /// Constant LBP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LBP = new CurrencyCode("LBP");
        /// <summary>
        /// Constant LKR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LKR = new CurrencyCode("LKR");
        /// <summary>
        /// Constant LTL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LTL = new CurrencyCode("LTL");
        /// <summary>
        /// Constant LVL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LVL = new CurrencyCode("LVL");
        /// <summary>
        /// Constant MAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MAD = new CurrencyCode("MAD");
        /// <summary>
        /// Constant MNT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MNT = new CurrencyCode("MNT");
        /// <summary>
        /// Constant MOP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MOP = new CurrencyCode("MOP");
        /// <summary>
        /// Constant MUR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MUR = new CurrencyCode("MUR");
        /// <summary>
        /// Constant MVR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MVR = new CurrencyCode("MVR");
        /// <summary>
        /// Constant MXN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MXN = new CurrencyCode("MXN");
        /// <summary>
        /// Constant MYR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MYR = new CurrencyCode("MYR");
        /// <summary>
        /// Constant NAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NAD = new CurrencyCode("NAD");
        /// <summary>
        /// Constant NGN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NGN = new CurrencyCode("NGN");
        /// <summary>
        /// Constant NIO for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NIO = new CurrencyCode("NIO");
        /// <summary>
        /// Constant NOK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NOK = new CurrencyCode("NOK");
        /// <summary>
        /// Constant NZD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NZD = new CurrencyCode("NZD");
        /// <summary>
        /// Constant PAB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PAB = new CurrencyCode("PAB");
        /// <summary>
        /// Constant PEN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PEN = new CurrencyCode("PEN");
        /// <summary>
        /// Constant PHP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PHP = new CurrencyCode("PHP");
        /// <summary>
        /// Constant PKR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PKR = new CurrencyCode("PKR");
        /// <summary>
        /// Constant PLN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PLN = new CurrencyCode("PLN");
        /// <summary>
        /// Constant PYG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PYG = new CurrencyCode("PYG");
        /// <summary>
        /// Constant QAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode QAR = new CurrencyCode("QAR");
        /// <summary>
        /// Constant RON for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RON = new CurrencyCode("RON");
        /// <summary>
        /// Constant RUB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RUB = new CurrencyCode("RUB");
        /// <summary>
        /// Constant SAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SAR = new CurrencyCode("SAR");
        /// <summary>
        /// Constant SEK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SEK = new CurrencyCode("SEK");
        /// <summary>
        /// Constant SGD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SGD = new CurrencyCode("SGD");
        /// <summary>
        /// Constant SIT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SIT = new CurrencyCode("SIT");
        /// <summary>
        /// Constant SKK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SKK = new CurrencyCode("SKK");
        /// <summary>
        /// Constant THB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode THB = new CurrencyCode("THB");
        /// <summary>
        /// Constant TND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TND = new CurrencyCode("TND");
        /// <summary>
        /// Constant TRY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TRY = new CurrencyCode("TRY");
        /// <summary>
        /// Constant TTD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TTD = new CurrencyCode("TTD");
        /// <summary>
        /// Constant TWD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TWD = new CurrencyCode("TWD");
        /// <summary>
        /// Constant TZS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TZS = new CurrencyCode("TZS");
        /// <summary>
        /// Constant UAH for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UAH = new CurrencyCode("UAH");
        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");
        /// <summary>
        /// Constant UYU for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UYU = new CurrencyCode("UYU");
        /// <summary>
        /// Constant UZS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UZS = new CurrencyCode("UZS");
        /// <summary>
        /// Constant VND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode VND = new CurrencyCode("VND");
        /// <summary>
        /// Constant XAF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XAF = new CurrencyCode("XAF");
        /// <summary>
        /// Constant XCD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XCD = new CurrencyCode("XCD");
        /// <summary>
        /// Constant XOF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XOF = new CurrencyCode("XOF");
        /// <summary>
        /// Constant XPF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XPF = new CurrencyCode("XPF");
        /// <summary>
        /// Constant ZAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ZAR = new CurrencyCode("ZAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileType.
    /// </summary>
    public class FileType : ConstantClass
    {

        /// <summary>
        /// Constant ApplicationMsword for FileType
        /// </summary>
        public static readonly FileType ApplicationMsword = new FileType("application/msword");
        /// <summary>
        /// Constant ApplicationPdf for FileType
        /// </summary>
        public static readonly FileType ApplicationPdf = new FileType("application/pdf");
        /// <summary>
        /// Constant ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation for FileType
        /// </summary>
        public static readonly FileType ApplicationVndOpenxmlformatsOfficedocumentPresentationmlPresentation = new FileType("application/vnd.openxmlformats-officedocument.presentationml.presentation");
        /// <summary>
        /// Constant ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet for FileType
        /// </summary>
        public static readonly FileType ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet = new FileType("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        /// <summary>
        /// Constant ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument for FileType
        /// </summary>
        public static readonly FileType ApplicationVndOpenxmlformatsOfficedocumentWordprocessingmlDocument = new FileType("application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        /// <summary>
        /// Constant ImageJpeg for FileType
        /// </summary>
        public static readonly FileType ImageJpeg = new FileType("image/jpeg");
        /// <summary>
        /// Constant ImagePng for FileType
        /// </summary>
        public static readonly FileType ImagePng = new FileType("image/png");
        /// <summary>
        /// Constant ImageSvgXml for FileType
        /// </summary>
        public static readonly FileType ImageSvgXml = new FileType("image/svg+xml");
        /// <summary>
        /// Constant TextCsv for FileType
        /// </summary>
        public static readonly FileType TextCsv = new FileType("text/csv");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileType FindValue(string value)
        {
            return FindValue<FileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FulfillmentType.
    /// </summary>
    public class FulfillmentType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS for FulfillmentType
        /// </summary>
        public static readonly FulfillmentType ACCESS = new FulfillmentType("ACCESS");
        /// <summary>
        /// Constant CASH for FulfillmentType
        /// </summary>
        public static readonly FulfillmentType CASH = new FulfillmentType("CASH");
        /// <summary>
        /// Constant CREDITS for FulfillmentType
        /// </summary>
        public static readonly FulfillmentType CREDITS = new FulfillmentType("CREDITS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FulfillmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FulfillmentType FindValue(string value)
        {
            return FindValue<FulfillmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FulfillmentType(string value)
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
        /// Constant BENEFIT_ALLOCATION for ResourceType
        /// </summary>
        public static readonly ResourceType BENEFIT_ALLOCATION = new ResourceType("BENEFIT_ALLOCATION");
        /// <summary>
        /// Constant OPPORTUNITY for ResourceType
        /// </summary>
        public static readonly ResourceType OPPORTUNITY = new ResourceType("OPPORTUNITY");

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
    /// Constants used for properties of type ValidationExceptionErrorCode.
    /// </summary>
    public class ValidationExceptionErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NOT_PERMITTED for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode ACTION_NOT_PERMITTED = new ValidationExceptionErrorCode("ACTION_NOT_PERMITTED");
        /// <summary>
        /// Constant DUPLICATE_KEY_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode DUPLICATE_KEY_VALUE = new ValidationExceptionErrorCode("DUPLICATE_KEY_VALUE");
        /// <summary>
        /// Constant INVALID_ENUM_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_ENUM_VALUE = new ValidationExceptionErrorCode("INVALID_ENUM_VALUE");
        /// <summary>
        /// Constant INVALID_RESOURCE_STATE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_RESOURCE_STATE = new ValidationExceptionErrorCode("INVALID_RESOURCE_STATE");
        /// <summary>
        /// Constant INVALID_STRING_FORMAT for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_STRING_FORMAT = new ValidationExceptionErrorCode("INVALID_STRING_FORMAT");
        /// <summary>
        /// Constant INVALID_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_VALUE = new ValidationExceptionErrorCode("INVALID_VALUE");
        /// <summary>
        /// Constant NOT_ENOUGH_VALUES for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode NOT_ENOUGH_VALUES = new ValidationExceptionErrorCode("NOT_ENOUGH_VALUES");
        /// <summary>
        /// Constant REQUIRED_FIELD_MISSING for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode REQUIRED_FIELD_MISSING = new ValidationExceptionErrorCode("REQUIRED_FIELD_MISSING");
        /// <summary>
        /// Constant TOO_MANY_VALUES for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode TOO_MANY_VALUES = new ValidationExceptionErrorCode("TOO_MANY_VALUES");
        /// <summary>
        /// Constant VALUE_OUT_OF_RANGE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode VALUE_OUT_OF_RANGE = new ValidationExceptionErrorCode("VALUE_OUT_OF_RANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionErrorCode FindValue(string value)
        {
            return FindValue<ValidationExceptionErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant BUSINESS_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BUSINESS_VALIDATION_FAILED = new ValidationExceptionReason("BUSINESS_VALIDATION_FAILED");
        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}