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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudSearch
{

    /// <summary>
    /// Constants used for properties of type AlgorithmicStemming.
    /// </summary>
    public class AlgorithmicStemming : ConstantClass
    {

        /// <summary>
        /// Constant Full for AlgorithmicStemming
        /// </summary>
        public static readonly AlgorithmicStemming Full = new AlgorithmicStemming("full");
        /// <summary>
        /// Constant Light for AlgorithmicStemming
        /// </summary>
        public static readonly AlgorithmicStemming Light = new AlgorithmicStemming("light");
        /// <summary>
        /// Constant Minimal for AlgorithmicStemming
        /// </summary>
        public static readonly AlgorithmicStemming Minimal = new AlgorithmicStemming("minimal");
        /// <summary>
        /// Constant None for AlgorithmicStemming
        /// </summary>
        public static readonly AlgorithmicStemming None = new AlgorithmicStemming("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmicStemming(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmicStemming FindValue(string value)
        {
            return FindValue<AlgorithmicStemming>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmicStemming(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AnalysisSchemeLanguage.
    /// </summary>
    public class AnalysisSchemeLanguage : ConstantClass
    {

        /// <summary>
        /// Constant Ar for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ar = new AnalysisSchemeLanguage("ar");
        /// <summary>
        /// Constant Bg for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Bg = new AnalysisSchemeLanguage("bg");
        /// <summary>
        /// Constant Ca for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ca = new AnalysisSchemeLanguage("ca");
        /// <summary>
        /// Constant Cs for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Cs = new AnalysisSchemeLanguage("cs");
        /// <summary>
        /// Constant Da for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Da = new AnalysisSchemeLanguage("da");
        /// <summary>
        /// Constant De for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage De = new AnalysisSchemeLanguage("de");
        /// <summary>
        /// Constant El for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage El = new AnalysisSchemeLanguage("el");
        /// <summary>
        /// Constant En for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage En = new AnalysisSchemeLanguage("en");
        /// <summary>
        /// Constant Es for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Es = new AnalysisSchemeLanguage("es");
        /// <summary>
        /// Constant Eu for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Eu = new AnalysisSchemeLanguage("eu");
        /// <summary>
        /// Constant Fa for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Fa = new AnalysisSchemeLanguage("fa");
        /// <summary>
        /// Constant Fi for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Fi = new AnalysisSchemeLanguage("fi");
        /// <summary>
        /// Constant Fr for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Fr = new AnalysisSchemeLanguage("fr");
        /// <summary>
        /// Constant Ga for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ga = new AnalysisSchemeLanguage("ga");
        /// <summary>
        /// Constant Gl for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Gl = new AnalysisSchemeLanguage("gl");
        /// <summary>
        /// Constant He for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage He = new AnalysisSchemeLanguage("he");
        /// <summary>
        /// Constant Hi for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Hi = new AnalysisSchemeLanguage("hi");
        /// <summary>
        /// Constant Hu for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Hu = new AnalysisSchemeLanguage("hu");
        /// <summary>
        /// Constant Hy for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Hy = new AnalysisSchemeLanguage("hy");
        /// <summary>
        /// Constant Id for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Id = new AnalysisSchemeLanguage("id");
        /// <summary>
        /// Constant It for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage It = new AnalysisSchemeLanguage("it");
        /// <summary>
        /// Constant Ja for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ja = new AnalysisSchemeLanguage("ja");
        /// <summary>
        /// Constant Ko for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ko = new AnalysisSchemeLanguage("ko");
        /// <summary>
        /// Constant Lv for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Lv = new AnalysisSchemeLanguage("lv");
        /// <summary>
        /// Constant Mul for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Mul = new AnalysisSchemeLanguage("mul");
        /// <summary>
        /// Constant Nl for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Nl = new AnalysisSchemeLanguage("nl");
        /// <summary>
        /// Constant No for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage No = new AnalysisSchemeLanguage("no");
        /// <summary>
        /// Constant Pt for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Pt = new AnalysisSchemeLanguage("pt");
        /// <summary>
        /// Constant Ro for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ro = new AnalysisSchemeLanguage("ro");
        /// <summary>
        /// Constant Ru for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Ru = new AnalysisSchemeLanguage("ru");
        /// <summary>
        /// Constant Sv for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Sv = new AnalysisSchemeLanguage("sv");
        /// <summary>
        /// Constant Th for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Th = new AnalysisSchemeLanguage("th");
        /// <summary>
        /// Constant Tr for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage Tr = new AnalysisSchemeLanguage("tr");
        /// <summary>
        /// Constant ZhHans for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage ZhHans = new AnalysisSchemeLanguage("zh-Hans");
        /// <summary>
        /// Constant ZhHant for AnalysisSchemeLanguage
        /// </summary>
        public static readonly AnalysisSchemeLanguage ZhHant = new AnalysisSchemeLanguage("zh-Hant");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisSchemeLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisSchemeLanguage FindValue(string value)
        {
            return FindValue<AnalysisSchemeLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisSchemeLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexFieldType.
    /// </summary>
    public class IndexFieldType : ConstantClass
    {

        /// <summary>
        /// Constant Date for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Date = new IndexFieldType("date");
        /// <summary>
        /// Constant DateArray for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType DateArray = new IndexFieldType("date-array");
        /// <summary>
        /// Constant Double for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Double = new IndexFieldType("double");
        /// <summary>
        /// Constant DoubleArray for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType DoubleArray = new IndexFieldType("double-array");
        /// <summary>
        /// Constant Int for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Int = new IndexFieldType("int");
        /// <summary>
        /// Constant IntArray for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType IntArray = new IndexFieldType("int-array");
        /// <summary>
        /// Constant Latlon for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Latlon = new IndexFieldType("latlon");
        /// <summary>
        /// Constant Literal for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Literal = new IndexFieldType("literal");
        /// <summary>
        /// Constant LiteralArray for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType LiteralArray = new IndexFieldType("literal-array");
        /// <summary>
        /// Constant Text for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType Text = new IndexFieldType("text");
        /// <summary>
        /// Constant TextArray for IndexFieldType
        /// </summary>
        public static readonly IndexFieldType TextArray = new IndexFieldType("text-array");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexFieldType FindValue(string value)
        {
            return FindValue<IndexFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptionState.
    /// </summary>
    public class OptionState : ConstantClass
    {

        /// <summary>
        /// Constant Active for OptionState
        /// </summary>
        public static readonly OptionState Active = new OptionState("Active");
        /// <summary>
        /// Constant FailedToValidate for OptionState
        /// </summary>
        public static readonly OptionState FailedToValidate = new OptionState("FailedToValidate");
        /// <summary>
        /// Constant Processing for OptionState
        /// </summary>
        public static readonly OptionState Processing = new OptionState("Processing");
        /// <summary>
        /// Constant RequiresIndexDocuments for OptionState
        /// </summary>
        public static readonly OptionState RequiresIndexDocuments = new OptionState("RequiresIndexDocuments");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptionState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionState FindValue(string value)
        {
            return FindValue<OptionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptionState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartitionInstanceType.
    /// </summary>
    public class PartitionInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant Search2xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType Search2xlarge = new PartitionInstanceType("search.2xlarge");
        /// <summary>
        /// Constant SearchLarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchLarge = new PartitionInstanceType("search.large");
        /// <summary>
        /// Constant SearchM1Large for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM1Large = new PartitionInstanceType("search.m1.large");
        /// <summary>
        /// Constant SearchM1Small for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM1Small = new PartitionInstanceType("search.m1.small");
        /// <summary>
        /// Constant SearchM22xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM22xlarge = new PartitionInstanceType("search.m2.2xlarge");
        /// <summary>
        /// Constant SearchM2Xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM2Xlarge = new PartitionInstanceType("search.m2.xlarge");
        /// <summary>
        /// Constant SearchM32xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM32xlarge = new PartitionInstanceType("search.m3.2xlarge");
        /// <summary>
        /// Constant SearchM3Large for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM3Large = new PartitionInstanceType("search.m3.large");
        /// <summary>
        /// Constant SearchM3Medium for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM3Medium = new PartitionInstanceType("search.m3.medium");
        /// <summary>
        /// Constant SearchM3Xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchM3Xlarge = new PartitionInstanceType("search.m3.xlarge");
        /// <summary>
        /// Constant SearchMedium for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchMedium = new PartitionInstanceType("search.medium");
        /// <summary>
        /// Constant SearchPreviousgeneration2xlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchPreviousgeneration2xlarge = new PartitionInstanceType("search.previousgeneration.2xlarge");
        /// <summary>
        /// Constant SearchPreviousgenerationLarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchPreviousgenerationLarge = new PartitionInstanceType("search.previousgeneration.large");
        /// <summary>
        /// Constant SearchPreviousgenerationSmall for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchPreviousgenerationSmall = new PartitionInstanceType("search.previousgeneration.small");
        /// <summary>
        /// Constant SearchPreviousgenerationXlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchPreviousgenerationXlarge = new PartitionInstanceType("search.previousgeneration.xlarge");
        /// <summary>
        /// Constant SearchSmall for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchSmall = new PartitionInstanceType("search.small");
        /// <summary>
        /// Constant SearchXlarge for PartitionInstanceType
        /// </summary>
        public static readonly PartitionInstanceType SearchXlarge = new PartitionInstanceType("search.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionInstanceType FindValue(string value)
        {
            return FindValue<PartitionInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SuggesterFuzzyMatching.
    /// </summary>
    public class SuggesterFuzzyMatching : ConstantClass
    {

        /// <summary>
        /// Constant High for SuggesterFuzzyMatching
        /// </summary>
        public static readonly SuggesterFuzzyMatching High = new SuggesterFuzzyMatching("high");
        /// <summary>
        /// Constant Low for SuggesterFuzzyMatching
        /// </summary>
        public static readonly SuggesterFuzzyMatching Low = new SuggesterFuzzyMatching("low");
        /// <summary>
        /// Constant None for SuggesterFuzzyMatching
        /// </summary>
        public static readonly SuggesterFuzzyMatching None = new SuggesterFuzzyMatching("none");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SuggesterFuzzyMatching(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SuggesterFuzzyMatching FindValue(string value)
        {
            return FindValue<SuggesterFuzzyMatching>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SuggesterFuzzyMatching(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TLSSecurityPolicy.
    /// </summary>
    public class TLSSecurityPolicy : ConstantClass
    {

        /// <summary>
        /// Constant PolicyMinTLS10201907 for TLSSecurityPolicy
        /// </summary>
        public static readonly TLSSecurityPolicy PolicyMinTLS10201907 = new TLSSecurityPolicy("Policy-Min-TLS-1-0-2019-07");
        /// <summary>
        /// Constant PolicyMinTLS12201907 for TLSSecurityPolicy
        /// </summary>
        public static readonly TLSSecurityPolicy PolicyMinTLS12201907 = new TLSSecurityPolicy("Policy-Min-TLS-1-2-2019-07");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TLSSecurityPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TLSSecurityPolicy FindValue(string value)
        {
            return FindValue<TLSSecurityPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TLSSecurityPolicy(string value)
        {
            return FindValue(value);
        }
    }

}