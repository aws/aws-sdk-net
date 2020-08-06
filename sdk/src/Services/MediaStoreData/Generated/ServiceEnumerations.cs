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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaStoreData
{

    /// <summary>
    /// Constants used for properties of type ItemType.
    /// </summary>
    public class ItemType : ConstantClass
    {

        /// <summary>
        /// Constant FOLDER for ItemType
        /// </summary>
        public static readonly ItemType FOLDER = new ItemType("FOLDER");
        /// <summary>
        /// Constant OBJECT for ItemType
        /// </summary>
        public static readonly ItemType OBJECT = new ItemType("OBJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ItemType FindValue(string value)
        {
            return FindValue<ItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant TEMPORAL for StorageClass
        /// </summary>
        public static readonly StorageClass TEMPORAL = new StorageClass("TEMPORAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadAvailability.
    /// </summary>
    public class UploadAvailability : ConstantClass
    {

        /// <summary>
        /// Constant STANDARD for UploadAvailability
        /// </summary>
        public static readonly UploadAvailability STANDARD = new UploadAvailability("STANDARD");
        /// <summary>
        /// Constant STREAMING for UploadAvailability
        /// </summary>
        public static readonly UploadAvailability STREAMING = new UploadAvailability("STREAMING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadAvailability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadAvailability FindValue(string value)
        {
            return FindValue<UploadAvailability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadAvailability(string value)
        {
            return FindValue(value);
        }
    }

}