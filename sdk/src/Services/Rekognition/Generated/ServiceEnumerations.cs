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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Rekognition
{

    /// <summary>
    /// Constants used for properties of type Attribute.
    /// </summary>
    public class Attribute : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Attribute
        /// </summary>
        public static readonly Attribute ALL = new Attribute("ALL");
        /// <summary>
        /// Constant DEFAULT for Attribute
        /// </summary>
        public static readonly Attribute DEFAULT = new Attribute("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Attribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Attribute FindValue(string value)
        {
            return FindValue<Attribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Attribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BodyPart.
    /// </summary>
    public class BodyPart : ConstantClass
    {

        /// <summary>
        /// Constant FACE for BodyPart
        /// </summary>
        public static readonly BodyPart FACE = new BodyPart("FACE");
        /// <summary>
        /// Constant HEAD for BodyPart
        /// </summary>
        public static readonly BodyPart HEAD = new BodyPart("HEAD");
        /// <summary>
        /// Constant LEFT_HAND for BodyPart
        /// </summary>
        public static readonly BodyPart LEFT_HAND = new BodyPart("LEFT_HAND");
        /// <summary>
        /// Constant RIGHT_HAND for BodyPart
        /// </summary>
        public static readonly BodyPart RIGHT_HAND = new BodyPart("RIGHT_HAND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BodyPart(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BodyPart FindValue(string value)
        {
            return FindValue<BodyPart>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BodyPart(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CelebrityRecognitionSortBy.
    /// </summary>
    public class CelebrityRecognitionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant ID for CelebrityRecognitionSortBy
        /// </summary>
        public static readonly CelebrityRecognitionSortBy ID = new CelebrityRecognitionSortBy("ID");
        /// <summary>
        /// Constant TIMESTAMP for CelebrityRecognitionSortBy
        /// </summary>
        public static readonly CelebrityRecognitionSortBy TIMESTAMP = new CelebrityRecognitionSortBy("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CelebrityRecognitionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CelebrityRecognitionSortBy FindValue(string value)
        {
            return FindValue<CelebrityRecognitionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CelebrityRecognitionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentClassifier.
    /// </summary>
    public class ContentClassifier : ConstantClass
    {

        /// <summary>
        /// Constant FreeOfAdultContent for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfAdultContent = new ContentClassifier("FreeOfAdultContent");
        /// <summary>
        /// Constant FreeOfPersonallyIdentifiableInformation for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfPersonallyIdentifiableInformation = new ContentClassifier("FreeOfPersonallyIdentifiableInformation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentClassifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentClassifier FindValue(string value)
        {
            return FindValue<ContentClassifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentClassifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentModerationSortBy.
    /// </summary>
    public class ContentModerationSortBy : ConstantClass
    {

        /// <summary>
        /// Constant NAME for ContentModerationSortBy
        /// </summary>
        public static readonly ContentModerationSortBy NAME = new ContentModerationSortBy("NAME");
        /// <summary>
        /// Constant TIMESTAMP for ContentModerationSortBy
        /// </summary>
        public static readonly ContentModerationSortBy TIMESTAMP = new ContentModerationSortBy("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentModerationSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentModerationSortBy FindValue(string value)
        {
            return FindValue<ContentModerationSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentModerationSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetStatus.
    /// </summary>
    public class DatasetStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_COMPLETE = new DatasetStatus("CREATE_COMPLETE");
        /// <summary>
        /// Constant CREATE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_FAILED = new DatasetStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus CREATE_IN_PROGRESS = new DatasetStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus DELETE_IN_PROGRESS = new DatasetStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant UPDATE_COMPLETE for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_COMPLETE = new DatasetStatus("UPDATE_COMPLETE");
        /// <summary>
        /// Constant UPDATE_FAILED for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_FAILED = new DatasetStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATE_IN_PROGRESS for DatasetStatus
        /// </summary>
        public static readonly DatasetStatus UPDATE_IN_PROGRESS = new DatasetStatus("UPDATE_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetStatus FindValue(string value)
        {
            return FindValue<DatasetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetStatusMessageCode.
    /// </summary>
    public class DatasetStatusMessageCode : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for DatasetStatusMessageCode
        /// </summary>
        public static readonly DatasetStatusMessageCode CLIENT_ERROR = new DatasetStatusMessageCode("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVICE_ERROR for DatasetStatusMessageCode
        /// </summary>
        public static readonly DatasetStatusMessageCode SERVICE_ERROR = new DatasetStatusMessageCode("SERVICE_ERROR");
        /// <summary>
        /// Constant SUCCESS for DatasetStatusMessageCode
        /// </summary>
        public static readonly DatasetStatusMessageCode SUCCESS = new DatasetStatusMessageCode("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetStatusMessageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetStatusMessageCode FindValue(string value)
        {
            return FindValue<DatasetStatusMessageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetStatusMessageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatasetType.
    /// </summary>
    public class DatasetType : ConstantClass
    {

        /// <summary>
        /// Constant TEST for DatasetType
        /// </summary>
        public static readonly DatasetType TEST = new DatasetType("TEST");
        /// <summary>
        /// Constant TRAIN for DatasetType
        /// </summary>
        public static readonly DatasetType TRAIN = new DatasetType("TRAIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatasetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatasetType FindValue(string value)
        {
            return FindValue<DatasetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatasetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetectLabelsFeatureName.
    /// </summary>
    public class DetectLabelsFeatureName : ConstantClass
    {

        /// <summary>
        /// Constant GENERAL_LABELS for DetectLabelsFeatureName
        /// </summary>
        public static readonly DetectLabelsFeatureName GENERAL_LABELS = new DetectLabelsFeatureName("GENERAL_LABELS");
        /// <summary>
        /// Constant IMAGE_PROPERTIES for DetectLabelsFeatureName
        /// </summary>
        public static readonly DetectLabelsFeatureName IMAGE_PROPERTIES = new DetectLabelsFeatureName("IMAGE_PROPERTIES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectLabelsFeatureName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectLabelsFeatureName FindValue(string value)
        {
            return FindValue<DetectLabelsFeatureName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectLabelsFeatureName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmotionName.
    /// </summary>
    public class EmotionName : ConstantClass
    {

        /// <summary>
        /// Constant ANGRY for EmotionName
        /// </summary>
        public static readonly EmotionName ANGRY = new EmotionName("ANGRY");
        /// <summary>
        /// Constant CALM for EmotionName
        /// </summary>
        public static readonly EmotionName CALM = new EmotionName("CALM");
        /// <summary>
        /// Constant CONFUSED for EmotionName
        /// </summary>
        public static readonly EmotionName CONFUSED = new EmotionName("CONFUSED");
        /// <summary>
        /// Constant DISGUSTED for EmotionName
        /// </summary>
        public static readonly EmotionName DISGUSTED = new EmotionName("DISGUSTED");
        /// <summary>
        /// Constant FEAR for EmotionName
        /// </summary>
        public static readonly EmotionName FEAR = new EmotionName("FEAR");
        /// <summary>
        /// Constant HAPPY for EmotionName
        /// </summary>
        public static readonly EmotionName HAPPY = new EmotionName("HAPPY");
        /// <summary>
        /// Constant SAD for EmotionName
        /// </summary>
        public static readonly EmotionName SAD = new EmotionName("SAD");
        /// <summary>
        /// Constant SURPRISED for EmotionName
        /// </summary>
        public static readonly EmotionName SURPRISED = new EmotionName("SURPRISED");
        /// <summary>
        /// Constant UNKNOWN for EmotionName
        /// </summary>
        public static readonly EmotionName UNKNOWN = new EmotionName("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmotionName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmotionName FindValue(string value)
        {
            return FindValue<EmotionName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmotionName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FaceAttributes.
    /// </summary>
    public class FaceAttributes : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FaceAttributes
        /// </summary>
        public static readonly FaceAttributes ALL = new FaceAttributes("ALL");
        /// <summary>
        /// Constant DEFAULT for FaceAttributes
        /// </summary>
        public static readonly FaceAttributes DEFAULT = new FaceAttributes("DEFAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FaceAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FaceAttributes FindValue(string value)
        {
            return FindValue<FaceAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FaceAttributes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FaceSearchSortBy.
    /// </summary>
    public class FaceSearchSortBy : ConstantClass
    {

        /// <summary>
        /// Constant INDEX for FaceSearchSortBy
        /// </summary>
        public static readonly FaceSearchSortBy INDEX = new FaceSearchSortBy("INDEX");
        /// <summary>
        /// Constant TIMESTAMP for FaceSearchSortBy
        /// </summary>
        public static readonly FaceSearchSortBy TIMESTAMP = new FaceSearchSortBy("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FaceSearchSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FaceSearchSortBy FindValue(string value)
        {
            return FindValue<FaceSearchSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FaceSearchSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GenderType.
    /// </summary>
    public class GenderType : ConstantClass
    {

        /// <summary>
        /// Constant Female for GenderType
        /// </summary>
        public static readonly GenderType Female = new GenderType("Female");
        /// <summary>
        /// Constant Male for GenderType
        /// </summary>
        public static readonly GenderType Male = new GenderType("Male");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GenderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenderType FindValue(string value)
        {
            return FindValue<GenderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KnownGenderType.
    /// </summary>
    public class KnownGenderType : ConstantClass
    {

        /// <summary>
        /// Constant Female for KnownGenderType
        /// </summary>
        public static readonly KnownGenderType Female = new KnownGenderType("Female");
        /// <summary>
        /// Constant Male for KnownGenderType
        /// </summary>
        public static readonly KnownGenderType Male = new KnownGenderType("Male");
        /// <summary>
        /// Constant Nonbinary for KnownGenderType
        /// </summary>
        public static readonly KnownGenderType Nonbinary = new KnownGenderType("Nonbinary");
        /// <summary>
        /// Constant Unlisted for KnownGenderType
        /// </summary>
        public static readonly KnownGenderType Unlisted = new KnownGenderType("Unlisted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KnownGenderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KnownGenderType FindValue(string value)
        {
            return FindValue<KnownGenderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KnownGenderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelDetectionAggregateBy.
    /// </summary>
    public class LabelDetectionAggregateBy : ConstantClass
    {

        /// <summary>
        /// Constant SEGMENTS for LabelDetectionAggregateBy
        /// </summary>
        public static readonly LabelDetectionAggregateBy SEGMENTS = new LabelDetectionAggregateBy("SEGMENTS");
        /// <summary>
        /// Constant TIMESTAMPS for LabelDetectionAggregateBy
        /// </summary>
        public static readonly LabelDetectionAggregateBy TIMESTAMPS = new LabelDetectionAggregateBy("TIMESTAMPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelDetectionAggregateBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelDetectionAggregateBy FindValue(string value)
        {
            return FindValue<LabelDetectionAggregateBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelDetectionAggregateBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelDetectionFeatureName.
    /// </summary>
    public class LabelDetectionFeatureName : ConstantClass
    {

        /// <summary>
        /// Constant GENERAL_LABELS for LabelDetectionFeatureName
        /// </summary>
        public static readonly LabelDetectionFeatureName GENERAL_LABELS = new LabelDetectionFeatureName("GENERAL_LABELS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelDetectionFeatureName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelDetectionFeatureName FindValue(string value)
        {
            return FindValue<LabelDetectionFeatureName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelDetectionFeatureName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelDetectionSortBy.
    /// </summary>
    public class LabelDetectionSortBy : ConstantClass
    {

        /// <summary>
        /// Constant NAME for LabelDetectionSortBy
        /// </summary>
        public static readonly LabelDetectionSortBy NAME = new LabelDetectionSortBy("NAME");
        /// <summary>
        /// Constant TIMESTAMP for LabelDetectionSortBy
        /// </summary>
        public static readonly LabelDetectionSortBy TIMESTAMP = new LabelDetectionSortBy("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelDetectionSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelDetectionSortBy FindValue(string value)
        {
            return FindValue<LabelDetectionSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelDetectionSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LandmarkType.
    /// </summary>
    public class LandmarkType : ConstantClass
    {

        /// <summary>
        /// Constant ChinBottom for LandmarkType
        /// </summary>
        public static readonly LandmarkType ChinBottom = new LandmarkType("chinBottom");
        /// <summary>
        /// Constant EyeLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType EyeLeft = new LandmarkType("eyeLeft");
        /// <summary>
        /// Constant EyeRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType EyeRight = new LandmarkType("eyeRight");
        /// <summary>
        /// Constant LeftEyeBrowLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeBrowLeft = new LandmarkType("leftEyeBrowLeft");
        /// <summary>
        /// Constant LeftEyeBrowRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeBrowRight = new LandmarkType("leftEyeBrowRight");
        /// <summary>
        /// Constant LeftEyeBrowUp for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeBrowUp = new LandmarkType("leftEyeBrowUp");
        /// <summary>
        /// Constant LeftEyeDown for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeDown = new LandmarkType("leftEyeDown");
        /// <summary>
        /// Constant LeftEyeLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeLeft = new LandmarkType("leftEyeLeft");
        /// <summary>
        /// Constant LeftEyeRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeRight = new LandmarkType("leftEyeRight");
        /// <summary>
        /// Constant LeftEyeUp for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftEyeUp = new LandmarkType("leftEyeUp");
        /// <summary>
        /// Constant LeftPupil for LandmarkType
        /// </summary>
        public static readonly LandmarkType LeftPupil = new LandmarkType("leftPupil");
        /// <summary>
        /// Constant MidJawlineLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType MidJawlineLeft = new LandmarkType("midJawlineLeft");
        /// <summary>
        /// Constant MidJawlineRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType MidJawlineRight = new LandmarkType("midJawlineRight");
        /// <summary>
        /// Constant MouthDown for LandmarkType
        /// </summary>
        public static readonly LandmarkType MouthDown = new LandmarkType("mouthDown");
        /// <summary>
        /// Constant MouthLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType MouthLeft = new LandmarkType("mouthLeft");
        /// <summary>
        /// Constant MouthRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType MouthRight = new LandmarkType("mouthRight");
        /// <summary>
        /// Constant MouthUp for LandmarkType
        /// </summary>
        public static readonly LandmarkType MouthUp = new LandmarkType("mouthUp");
        /// <summary>
        /// Constant Nose for LandmarkType
        /// </summary>
        public static readonly LandmarkType Nose = new LandmarkType("nose");
        /// <summary>
        /// Constant NoseLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType NoseLeft = new LandmarkType("noseLeft");
        /// <summary>
        /// Constant NoseRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType NoseRight = new LandmarkType("noseRight");
        /// <summary>
        /// Constant RightEyeBrowLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeBrowLeft = new LandmarkType("rightEyeBrowLeft");
        /// <summary>
        /// Constant RightEyeBrowRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeBrowRight = new LandmarkType("rightEyeBrowRight");
        /// <summary>
        /// Constant RightEyeBrowUp for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeBrowUp = new LandmarkType("rightEyeBrowUp");
        /// <summary>
        /// Constant RightEyeDown for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeDown = new LandmarkType("rightEyeDown");
        /// <summary>
        /// Constant RightEyeLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeLeft = new LandmarkType("rightEyeLeft");
        /// <summary>
        /// Constant RightEyeRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeRight = new LandmarkType("rightEyeRight");
        /// <summary>
        /// Constant RightEyeUp for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightEyeUp = new LandmarkType("rightEyeUp");
        /// <summary>
        /// Constant RightPupil for LandmarkType
        /// </summary>
        public static readonly LandmarkType RightPupil = new LandmarkType("rightPupil");
        /// <summary>
        /// Constant UpperJawlineLeft for LandmarkType
        /// </summary>
        public static readonly LandmarkType UpperJawlineLeft = new LandmarkType("upperJawlineLeft");
        /// <summary>
        /// Constant UpperJawlineRight for LandmarkType
        /// </summary>
        public static readonly LandmarkType UpperJawlineRight = new LandmarkType("upperJawlineRight");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LandmarkType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LandmarkType FindValue(string value)
        {
            return FindValue<LandmarkType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LandmarkType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrientationCorrection.
    /// </summary>
    public class OrientationCorrection : ConstantClass
    {

        /// <summary>
        /// Constant ROTATE_0 for OrientationCorrection
        /// </summary>
        public static readonly OrientationCorrection ROTATE_0 = new OrientationCorrection("ROTATE_0");
        /// <summary>
        /// Constant ROTATE_180 for OrientationCorrection
        /// </summary>
        public static readonly OrientationCorrection ROTATE_180 = new OrientationCorrection("ROTATE_180");
        /// <summary>
        /// Constant ROTATE_270 for OrientationCorrection
        /// </summary>
        public static readonly OrientationCorrection ROTATE_270 = new OrientationCorrection("ROTATE_270");
        /// <summary>
        /// Constant ROTATE_90 for OrientationCorrection
        /// </summary>
        public static readonly OrientationCorrection ROTATE_90 = new OrientationCorrection("ROTATE_90");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrientationCorrection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrientationCorrection FindValue(string value)
        {
            return FindValue<OrientationCorrection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrientationCorrection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PersonTrackingSortBy.
    /// </summary>
    public class PersonTrackingSortBy : ConstantClass
    {

        /// <summary>
        /// Constant INDEX for PersonTrackingSortBy
        /// </summary>
        public static readonly PersonTrackingSortBy INDEX = new PersonTrackingSortBy("INDEX");
        /// <summary>
        /// Constant TIMESTAMP for PersonTrackingSortBy
        /// </summary>
        public static readonly PersonTrackingSortBy TIMESTAMP = new PersonTrackingSortBy("TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PersonTrackingSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PersonTrackingSortBy FindValue(string value)
        {
            return FindValue<PersonTrackingSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PersonTrackingSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectStatus.
    /// </summary>
    public class ProjectStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus CREATED = new ProjectStatus("CREATED");
        /// <summary>
        /// Constant CREATING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus CREATING = new ProjectStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ProjectStatus
        /// </summary>
        public static readonly ProjectStatus DELETING = new ProjectStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectStatus FindValue(string value)
        {
            return FindValue<ProjectStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectVersionStatus.
    /// </summary>
    public class ProjectVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COPYING_COMPLETED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus COPYING_COMPLETED = new ProjectVersionStatus("COPYING_COMPLETED");
        /// <summary>
        /// Constant COPYING_FAILED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus COPYING_FAILED = new ProjectVersionStatus("COPYING_FAILED");
        /// <summary>
        /// Constant COPYING_IN_PROGRESS for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus COPYING_IN_PROGRESS = new ProjectVersionStatus("COPYING_IN_PROGRESS");
        /// <summary>
        /// Constant DELETING for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus DELETING = new ProjectVersionStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus FAILED = new ProjectVersionStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus RUNNING = new ProjectVersionStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus STARTING = new ProjectVersionStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus STOPPED = new ProjectVersionStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus STOPPING = new ProjectVersionStatus("STOPPING");
        /// <summary>
        /// Constant TRAINING_COMPLETED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus TRAINING_COMPLETED = new ProjectVersionStatus("TRAINING_COMPLETED");
        /// <summary>
        /// Constant TRAINING_FAILED for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus TRAINING_FAILED = new ProjectVersionStatus("TRAINING_FAILED");
        /// <summary>
        /// Constant TRAINING_IN_PROGRESS for ProjectVersionStatus
        /// </summary>
        public static readonly ProjectVersionStatus TRAINING_IN_PROGRESS = new ProjectVersionStatus("TRAINING_IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectVersionStatus FindValue(string value)
        {
            return FindValue<ProjectVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProtectiveEquipmentType.
    /// </summary>
    public class ProtectiveEquipmentType : ConstantClass
    {

        /// <summary>
        /// Constant FACE_COVER for ProtectiveEquipmentType
        /// </summary>
        public static readonly ProtectiveEquipmentType FACE_COVER = new ProtectiveEquipmentType("FACE_COVER");
        /// <summary>
        /// Constant HAND_COVER for ProtectiveEquipmentType
        /// </summary>
        public static readonly ProtectiveEquipmentType HAND_COVER = new ProtectiveEquipmentType("HAND_COVER");
        /// <summary>
        /// Constant HEAD_COVER for ProtectiveEquipmentType
        /// </summary>
        public static readonly ProtectiveEquipmentType HEAD_COVER = new ProtectiveEquipmentType("HEAD_COVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProtectiveEquipmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProtectiveEquipmentType FindValue(string value)
        {
            return FindValue<ProtectiveEquipmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProtectiveEquipmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QualityFilter.
    /// </summary>
    public class QualityFilter : ConstantClass
    {

        /// <summary>
        /// Constant AUTO for QualityFilter
        /// </summary>
        public static readonly QualityFilter AUTO = new QualityFilter("AUTO");
        /// <summary>
        /// Constant HIGH for QualityFilter
        /// </summary>
        public static readonly QualityFilter HIGH = new QualityFilter("HIGH");
        /// <summary>
        /// Constant LOW for QualityFilter
        /// </summary>
        public static readonly QualityFilter LOW = new QualityFilter("LOW");
        /// <summary>
        /// Constant MEDIUM for QualityFilter
        /// </summary>
        public static readonly QualityFilter MEDIUM = new QualityFilter("MEDIUM");
        /// <summary>
        /// Constant NONE for QualityFilter
        /// </summary>
        public static readonly QualityFilter NONE = new QualityFilter("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QualityFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QualityFilter FindValue(string value)
        {
            return FindValue<QualityFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QualityFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Reason.
    /// </summary>
    public class Reason : ConstantClass
    {

        /// <summary>
        /// Constant EXCEEDS_MAX_FACES for Reason
        /// </summary>
        public static readonly Reason EXCEEDS_MAX_FACES = new Reason("EXCEEDS_MAX_FACES");
        /// <summary>
        /// Constant EXTREME_POSE for Reason
        /// </summary>
        public static readonly Reason EXTREME_POSE = new Reason("EXTREME_POSE");
        /// <summary>
        /// Constant LOW_BRIGHTNESS for Reason
        /// </summary>
        public static readonly Reason LOW_BRIGHTNESS = new Reason("LOW_BRIGHTNESS");
        /// <summary>
        /// Constant LOW_CONFIDENCE for Reason
        /// </summary>
        public static readonly Reason LOW_CONFIDENCE = new Reason("LOW_CONFIDENCE");
        /// <summary>
        /// Constant LOW_FACE_QUALITY for Reason
        /// </summary>
        public static readonly Reason LOW_FACE_QUALITY = new Reason("LOW_FACE_QUALITY");
        /// <summary>
        /// Constant LOW_SHARPNESS for Reason
        /// </summary>
        public static readonly Reason LOW_SHARPNESS = new Reason("LOW_SHARPNESS");
        /// <summary>
        /// Constant SMALL_BOUNDING_BOX for Reason
        /// </summary>
        public static readonly Reason SMALL_BOUNDING_BOX = new Reason("SMALL_BOUNDING_BOX");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Reason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Reason FindValue(string value)
        {
            return FindValue<Reason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Reason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SegmentType.
    /// </summary>
    public class SegmentType : ConstantClass
    {

        /// <summary>
        /// Constant SHOT for SegmentType
        /// </summary>
        public static readonly SegmentType SHOT = new SegmentType("SHOT");
        /// <summary>
        /// Constant TECHNICAL_CUE for SegmentType
        /// </summary>
        public static readonly SegmentType TECHNICAL_CUE = new SegmentType("TECHNICAL_CUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SegmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SegmentType FindValue(string value)
        {
            return FindValue<SegmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SegmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamProcessorParameterToDelete.
    /// </summary>
    public class StreamProcessorParameterToDelete : ConstantClass
    {

        /// <summary>
        /// Constant ConnectedHomeMinConfidence for StreamProcessorParameterToDelete
        /// </summary>
        public static readonly StreamProcessorParameterToDelete ConnectedHomeMinConfidence = new StreamProcessorParameterToDelete("ConnectedHomeMinConfidence");
        /// <summary>
        /// Constant RegionsOfInterest for StreamProcessorParameterToDelete
        /// </summary>
        public static readonly StreamProcessorParameterToDelete RegionsOfInterest = new StreamProcessorParameterToDelete("RegionsOfInterest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamProcessorParameterToDelete(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamProcessorParameterToDelete FindValue(string value)
        {
            return FindValue<StreamProcessorParameterToDelete>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamProcessorParameterToDelete(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamProcessorStatus.
    /// </summary>
    public class StreamProcessorStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus FAILED = new StreamProcessorStatus("FAILED");
        /// <summary>
        /// Constant RUNNING for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus RUNNING = new StreamProcessorStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus STARTING = new StreamProcessorStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus STOPPED = new StreamProcessorStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus STOPPING = new StreamProcessorStatus("STOPPING");
        /// <summary>
        /// Constant UPDATING for StreamProcessorStatus
        /// </summary>
        public static readonly StreamProcessorStatus UPDATING = new StreamProcessorStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamProcessorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamProcessorStatus FindValue(string value)
        {
            return FindValue<StreamProcessorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamProcessorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TechnicalCueType.
    /// </summary>
    public class TechnicalCueType : ConstantClass
    {

        /// <summary>
        /// Constant BlackFrames for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType BlackFrames = new TechnicalCueType("BlackFrames");
        /// <summary>
        /// Constant ColorBars for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType ColorBars = new TechnicalCueType("ColorBars");
        /// <summary>
        /// Constant Content for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType Content = new TechnicalCueType("Content");
        /// <summary>
        /// Constant EndCredits for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType EndCredits = new TechnicalCueType("EndCredits");
        /// <summary>
        /// Constant OpeningCredits for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType OpeningCredits = new TechnicalCueType("OpeningCredits");
        /// <summary>
        /// Constant Slate for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType Slate = new TechnicalCueType("Slate");
        /// <summary>
        /// Constant StudioLogo for TechnicalCueType
        /// </summary>
        public static readonly TechnicalCueType StudioLogo = new TechnicalCueType("StudioLogo");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TechnicalCueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TechnicalCueType FindValue(string value)
        {
            return FindValue<TechnicalCueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TechnicalCueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextTypes.
    /// </summary>
    public class TextTypes : ConstantClass
    {

        /// <summary>
        /// Constant LINE for TextTypes
        /// </summary>
        public static readonly TextTypes LINE = new TextTypes("LINE");
        /// <summary>
        /// Constant WORD for TextTypes
        /// </summary>
        public static readonly TextTypes WORD = new TextTypes("WORD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TextTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextTypes FindValue(string value)
        {
            return FindValue<TextTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoColorRange.
    /// </summary>
    public class VideoColorRange : ConstantClass
    {

        /// <summary>
        /// Constant FULL for VideoColorRange
        /// </summary>
        public static readonly VideoColorRange FULL = new VideoColorRange("FULL");
        /// <summary>
        /// Constant LIMITED for VideoColorRange
        /// </summary>
        public static readonly VideoColorRange LIMITED = new VideoColorRange("LIMITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoColorRange(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoColorRange FindValue(string value)
        {
            return FindValue<VideoColorRange>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoColorRange(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VideoJobStatus.
    /// </summary>
    public class VideoJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for VideoJobStatus
        /// </summary>
        public static readonly VideoJobStatus FAILED = new VideoJobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for VideoJobStatus
        /// </summary>
        public static readonly VideoJobStatus IN_PROGRESS = new VideoJobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for VideoJobStatus
        /// </summary>
        public static readonly VideoJobStatus SUCCEEDED = new VideoJobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VideoJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VideoJobStatus FindValue(string value)
        {
            return FindValue<VideoJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VideoJobStatus(string value)
        {
            return FindValue(value);
        }
    }

}