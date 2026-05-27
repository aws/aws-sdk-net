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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElementalInference
{

    /// <summary>
    /// Constants used for properties of type DictionaryLanguage.
    /// </summary>
    public class DictionaryLanguage : ConstantClass
    {

        /// <summary>
        /// Constant Deu for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Deu = new DictionaryLanguage("deu");
        /// <summary>
        /// Constant Eng for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Eng = new DictionaryLanguage("eng");
        /// <summary>
        /// Constant Fra for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Fra = new DictionaryLanguage("fra");
        /// <summary>
        /// Constant Ita for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Ita = new DictionaryLanguage("ita");
        /// <summary>
        /// Constant Por for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Por = new DictionaryLanguage("por");
        /// <summary>
        /// Constant Spa for DictionaryLanguage
        /// </summary>
        public static readonly DictionaryLanguage Spa = new DictionaryLanguage("spa");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DictionaryLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DictionaryLanguage FindValue(string value)
        {
            return FindValue<DictionaryLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DictionaryLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DictionaryStatus.
    /// </summary>
    public class DictionaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DictionaryStatus
        /// </summary>
        public static readonly DictionaryStatus AVAILABLE = new DictionaryStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for DictionaryStatus
        /// </summary>
        public static readonly DictionaryStatus CREATING = new DictionaryStatus("CREATING");
        /// <summary>
        /// Constant DELETED for DictionaryStatus
        /// </summary>
        public static readonly DictionaryStatus DELETED = new DictionaryStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DictionaryStatus
        /// </summary>
        public static readonly DictionaryStatus DELETING = new DictionaryStatus("DELETING");
        /// <summary>
        /// Constant REFERENCED for DictionaryStatus
        /// </summary>
        public static readonly DictionaryStatus REFERENCED = new DictionaryStatus("REFERENCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DictionaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DictionaryStatus FindValue(string value)
        {
            return FindValue<DictionaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DictionaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeedStatus.
    /// </summary>
    public class FeedStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FeedStatus
        /// </summary>
        public static readonly FeedStatus ACTIVE = new FeedStatus("ACTIVE");
        /// <summary>
        /// Constant ARCHIVED for FeedStatus
        /// </summary>
        public static readonly FeedStatus ARCHIVED = new FeedStatus("ARCHIVED");
        /// <summary>
        /// Constant AVAILABLE for FeedStatus
        /// </summary>
        public static readonly FeedStatus AVAILABLE = new FeedStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for FeedStatus
        /// </summary>
        public static readonly FeedStatus CREATING = new FeedStatus("CREATING");
        /// <summary>
        /// Constant DELETED for FeedStatus
        /// </summary>
        public static readonly FeedStatus DELETED = new FeedStatus("DELETED");
        /// <summary>
        /// Constant DELETING for FeedStatus
        /// </summary>
        public static readonly FeedStatus DELETING = new FeedStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for FeedStatus
        /// </summary>
        public static readonly FeedStatus UPDATING = new FeedStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeedStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeedStatus FindValue(string value)
        {
            return FindValue<FeedStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeedStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OutputStatus.
    /// </summary>
    public class OutputStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus DISABLED = new OutputStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for OutputStatus
        /// </summary>
        public static readonly OutputStatus ENABLED = new OutputStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OutputStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OutputStatus FindValue(string value)
        {
            return FindValue<OutputStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OutputStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProfanityFilterMode.
    /// </summary>
    public class ProfanityFilterMode : ConstantClass
    {

        /// <summary>
        /// Constant CENSOR for ProfanityFilterMode
        /// </summary>
        public static readonly ProfanityFilterMode CENSOR = new ProfanityFilterMode("CENSOR");
        /// <summary>
        /// Constant DISABLED for ProfanityFilterMode
        /// </summary>
        public static readonly ProfanityFilterMode DISABLED = new ProfanityFilterMode("DISABLED");
        /// <summary>
        /// Constant DROP for ProfanityFilterMode
        /// </summary>
        public static readonly ProfanityFilterMode DROP = new ProfanityFilterMode("DROP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProfanityFilterMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProfanityFilterMode FindValue(string value)
        {
            return FindValue<ProfanityFilterMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProfanityFilterMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TranscriptionLanguage.
    /// </summary>
    public class TranscriptionLanguage : ConstantClass
    {

        /// <summary>
        /// Constant Deu for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Deu = new TranscriptionLanguage("deu");
        /// <summary>
        /// Constant Eng for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Eng = new TranscriptionLanguage("eng");
        /// <summary>
        /// Constant EngAu for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage EngAu = new TranscriptionLanguage("eng-au");
        /// <summary>
        /// Constant EngGb for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage EngGb = new TranscriptionLanguage("eng-gb");
        /// <summary>
        /// Constant EngUs for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage EngUs = new TranscriptionLanguage("eng-us");
        /// <summary>
        /// Constant Fra for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Fra = new TranscriptionLanguage("fra");
        /// <summary>
        /// Constant Ita for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Ita = new TranscriptionLanguage("ita");
        /// <summary>
        /// Constant Por for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Por = new TranscriptionLanguage("por");
        /// <summary>
        /// Constant Spa for TranscriptionLanguage
        /// </summary>
        public static readonly TranscriptionLanguage Spa = new TranscriptionLanguage("spa");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TranscriptionLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TranscriptionLanguage FindValue(string value)
        {
            return FindValue<TranscriptionLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TranscriptionLanguage(string value)
        {
            return FindValue(value);
        }
    }

}