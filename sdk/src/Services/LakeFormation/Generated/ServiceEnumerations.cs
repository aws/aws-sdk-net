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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.LakeFormation
{

    /// <summary>
    /// Constants used for properties of type ComparisonOperator.
    /// </summary>
    public class ComparisonOperator : ConstantClass
    {

        /// <summary>
        /// Constant BEGINS_WITH for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BEGINS_WITH = new ComparisonOperator("BEGINS_WITH");
        /// <summary>
        /// Constant BETWEEN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator BETWEEN = new ComparisonOperator("BETWEEN");
        /// <summary>
        /// Constant CONTAINS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator CONTAINS = new ComparisonOperator("CONTAINS");
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
        /// Constant IN for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator IN = new ComparisonOperator("IN");
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
        /// Constant NOT_CONTAINS for ComparisonOperator
        /// </summary>
        public static readonly ComparisonOperator NOT_CONTAINS = new ComparisonOperator("NOT_CONTAINS");

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
    /// Constants used for properties of type DataLakeResourceType.
    /// </summary>
    public class DataLakeResourceType : ConstantClass
    {

        /// <summary>
        /// Constant CATALOG for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType CATALOG = new DataLakeResourceType("CATALOG");
        /// <summary>
        /// Constant DATA_LOCATION for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType DATA_LOCATION = new DataLakeResourceType("DATA_LOCATION");
        /// <summary>
        /// Constant DATABASE for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType DATABASE = new DataLakeResourceType("DATABASE");
        /// <summary>
        /// Constant TABLE for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType TABLE = new DataLakeResourceType("TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLakeResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLakeResourceType FindValue(string value)
        {
            return FindValue<DataLakeResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLakeResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldNameString.
    /// </summary>
    public class FieldNameString : ConstantClass
    {

        /// <summary>
        /// Constant LAST_MODIFIED for FieldNameString
        /// </summary>
        public static readonly FieldNameString LAST_MODIFIED = new FieldNameString("LAST_MODIFIED");
        /// <summary>
        /// Constant RESOURCE_ARN for FieldNameString
        /// </summary>
        public static readonly FieldNameString RESOURCE_ARN = new FieldNameString("RESOURCE_ARN");
        /// <summary>
        /// Constant ROLE_ARN for FieldNameString
        /// </summary>
        public static readonly FieldNameString ROLE_ARN = new FieldNameString("ROLE_ARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldNameString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldNameString FindValue(string value)
        {
            return FindValue<FieldNameString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldNameString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {

        /// <summary>
        /// Constant ALL for Permission
        /// </summary>
        public static readonly Permission ALL = new Permission("ALL");
        /// <summary>
        /// Constant ALTER for Permission
        /// </summary>
        public static readonly Permission ALTER = new Permission("ALTER");
        /// <summary>
        /// Constant CREATE_DATABASE for Permission
        /// </summary>
        public static readonly Permission CREATE_DATABASE = new Permission("CREATE_DATABASE");
        /// <summary>
        /// Constant CREATE_TABLE for Permission
        /// </summary>
        public static readonly Permission CREATE_TABLE = new Permission("CREATE_TABLE");
        /// <summary>
        /// Constant DATA_LOCATION_ACCESS for Permission
        /// </summary>
        public static readonly Permission DATA_LOCATION_ACCESS = new Permission("DATA_LOCATION_ACCESS");
        /// <summary>
        /// Constant DELETE for Permission
        /// </summary>
        public static readonly Permission DELETE = new Permission("DELETE");
        /// <summary>
        /// Constant DESCRIBE for Permission
        /// </summary>
        public static readonly Permission DESCRIBE = new Permission("DESCRIBE");
        /// <summary>
        /// Constant DROP for Permission
        /// </summary>
        public static readonly Permission DROP = new Permission("DROP");
        /// <summary>
        /// Constant INSERT for Permission
        /// </summary>
        public static readonly Permission INSERT = new Permission("INSERT");
        /// <summary>
        /// Constant SELECT for Permission
        /// </summary>
        public static readonly Permission SELECT = new Permission("SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }

}