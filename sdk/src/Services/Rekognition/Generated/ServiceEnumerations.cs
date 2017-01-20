/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Constants used for properties of type GenderType.
    /// </summary>
    public class GenderType : ConstantClass
    {

        /// <summary>
        /// Constant FEMALE for GenderType
        /// </summary>
        public static readonly GenderType FEMALE = new GenderType("FEMALE");
        /// <summary>
        /// Constant MALE for GenderType
        /// </summary>
        public static readonly GenderType MALE = new GenderType("MALE");

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
    /// Constants used for properties of type LandmarkType.
    /// </summary>
    public class LandmarkType : ConstantClass
    {

        /// <summary>
        /// Constant EYE_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType EYE_LEFT = new LandmarkType("EYE_LEFT");
        /// <summary>
        /// Constant EYE_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType EYE_RIGHT = new LandmarkType("EYE_RIGHT");
        /// <summary>
        /// Constant LEFT_EYE_DOWN for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYE_DOWN = new LandmarkType("LEFT_EYE_DOWN");
        /// <summary>
        /// Constant LEFT_EYE_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYE_LEFT = new LandmarkType("LEFT_EYE_LEFT");
        /// <summary>
        /// Constant LEFT_EYE_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYE_RIGHT = new LandmarkType("LEFT_EYE_RIGHT");
        /// <summary>
        /// Constant LEFT_EYE_UP for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYE_UP = new LandmarkType("LEFT_EYE_UP");
        /// <summary>
        /// Constant LEFT_EYEBROW_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYEBROW_LEFT = new LandmarkType("LEFT_EYEBROW_LEFT");
        /// <summary>
        /// Constant LEFT_EYEBROW_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYEBROW_RIGHT = new LandmarkType("LEFT_EYEBROW_RIGHT");
        /// <summary>
        /// Constant LEFT_EYEBROW_UP for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_EYEBROW_UP = new LandmarkType("LEFT_EYEBROW_UP");
        /// <summary>
        /// Constant LEFT_PUPIL for LandmarkType
        /// </summary>
        public static readonly LandmarkType LEFT_PUPIL = new LandmarkType("LEFT_PUPIL");
        /// <summary>
        /// Constant MOUTH_DOWN for LandmarkType
        /// </summary>
        public static readonly LandmarkType MOUTH_DOWN = new LandmarkType("MOUTH_DOWN");
        /// <summary>
        /// Constant MOUTH_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType MOUTH_LEFT = new LandmarkType("MOUTH_LEFT");
        /// <summary>
        /// Constant MOUTH_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType MOUTH_RIGHT = new LandmarkType("MOUTH_RIGHT");
        /// <summary>
        /// Constant MOUTH_UP for LandmarkType
        /// </summary>
        public static readonly LandmarkType MOUTH_UP = new LandmarkType("MOUTH_UP");
        /// <summary>
        /// Constant NOSE for LandmarkType
        /// </summary>
        public static readonly LandmarkType NOSE = new LandmarkType("NOSE");
        /// <summary>
        /// Constant NOSE_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType NOSE_LEFT = new LandmarkType("NOSE_LEFT");
        /// <summary>
        /// Constant NOSE_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType NOSE_RIGHT = new LandmarkType("NOSE_RIGHT");
        /// <summary>
        /// Constant RIGHT_EYE_DOWN for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYE_DOWN = new LandmarkType("RIGHT_EYE_DOWN");
        /// <summary>
        /// Constant RIGHT_EYE_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYE_LEFT = new LandmarkType("RIGHT_EYE_LEFT");
        /// <summary>
        /// Constant RIGHT_EYE_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYE_RIGHT = new LandmarkType("RIGHT_EYE_RIGHT");
        /// <summary>
        /// Constant RIGHT_EYE_UP for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYE_UP = new LandmarkType("RIGHT_EYE_UP");
        /// <summary>
        /// Constant RIGHT_EYEBROW_LEFT for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYEBROW_LEFT = new LandmarkType("RIGHT_EYEBROW_LEFT");
        /// <summary>
        /// Constant RIGHT_EYEBROW_RIGHT for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYEBROW_RIGHT = new LandmarkType("RIGHT_EYEBROW_RIGHT");
        /// <summary>
        /// Constant RIGHT_EYEBROW_UP for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_EYEBROW_UP = new LandmarkType("RIGHT_EYEBROW_UP");
        /// <summary>
        /// Constant RIGHT_PUPIL for LandmarkType
        /// </summary>
        public static readonly LandmarkType RIGHT_PUPIL = new LandmarkType("RIGHT_PUPIL");

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

}