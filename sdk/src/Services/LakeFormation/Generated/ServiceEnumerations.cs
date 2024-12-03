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
    /// Constants used for properties of type ApplicationStatus.
    /// </summary>
    public class ApplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus DISABLED = new ApplicationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for ApplicationStatus
        /// </summary>
        public static readonly ApplicationStatus ENABLED = new ApplicationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplicationStatus FindValue(string value)
        {
            return FindValue<ApplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplicationStatus(string value)
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
        /// Constant LF_NAMED_TAG_EXPRESSION for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType LF_NAMED_TAG_EXPRESSION = new DataLakeResourceType("LF_NAMED_TAG_EXPRESSION");
        /// <summary>
        /// Constant LF_TAG for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType LF_TAG = new DataLakeResourceType("LF_TAG");
        /// <summary>
        /// Constant LF_TAG_POLICY for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType LF_TAG_POLICY = new DataLakeResourceType("LF_TAG_POLICY");
        /// <summary>
        /// Constant LF_TAG_POLICY_DATABASE for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType LF_TAG_POLICY_DATABASE = new DataLakeResourceType("LF_TAG_POLICY_DATABASE");
        /// <summary>
        /// Constant LF_TAG_POLICY_TABLE for DataLakeResourceType
        /// </summary>
        public static readonly DataLakeResourceType LF_TAG_POLICY_TABLE = new DataLakeResourceType("LF_TAG_POLICY_TABLE");
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
    /// Constants used for properties of type EnableStatus.
    /// </summary>
    public class EnableStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for EnableStatus
        /// </summary>
        public static readonly EnableStatus DISABLED = new EnableStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for EnableStatus
        /// </summary>
        public static readonly EnableStatus ENABLED = new EnableStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnableStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnableStatus FindValue(string value)
        {
            return FindValue<EnableStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnableStatus(string value)
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
    /// Constants used for properties of type OptimizerType.
    /// </summary>
    public class OptimizerType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for OptimizerType
        /// </summary>
        public static readonly OptimizerType ALL = new OptimizerType("ALL");
        /// <summary>
        /// Constant COMPACTION for OptimizerType
        /// </summary>
        public static readonly OptimizerType COMPACTION = new OptimizerType("COMPACTION");
        /// <summary>
        /// Constant GARBAGE_COLLECTION for OptimizerType
        /// </summary>
        public static readonly OptimizerType GARBAGE_COLLECTION = new OptimizerType("GARBAGE_COLLECTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptimizerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptimizerType FindValue(string value)
        {
            return FindValue<OptimizerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptimizerType(string value)
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
        /// Constant ASSOCIATE for Permission
        /// </summary>
        public static readonly Permission ASSOCIATE = new Permission("ASSOCIATE");
        /// <summary>
        /// Constant CREATE_CATALOG for Permission
        /// </summary>
        public static readonly Permission CREATE_CATALOG = new Permission("CREATE_CATALOG");
        /// <summary>
        /// Constant CREATE_DATABASE for Permission
        /// </summary>
        public static readonly Permission CREATE_DATABASE = new Permission("CREATE_DATABASE");
        /// <summary>
        /// Constant CREATE_LF_TAG for Permission
        /// </summary>
        public static readonly Permission CREATE_LF_TAG = new Permission("CREATE_LF_TAG");
        /// <summary>
        /// Constant CREATE_LF_TAG_EXPRESSION for Permission
        /// </summary>
        public static readonly Permission CREATE_LF_TAG_EXPRESSION = new Permission("CREATE_LF_TAG_EXPRESSION");
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
        /// Constant GRANT_WITH_LF_TAG_EXPRESSION for Permission
        /// </summary>
        public static readonly Permission GRANT_WITH_LF_TAG_EXPRESSION = new Permission("GRANT_WITH_LF_TAG_EXPRESSION");
        /// <summary>
        /// Constant INSERT for Permission
        /// </summary>
        public static readonly Permission INSERT = new Permission("INSERT");
        /// <summary>
        /// Constant SELECT for Permission
        /// </summary>
        public static readonly Permission SELECT = new Permission("SELECT");
        /// <summary>
        /// Constant SUPER_USER for Permission
        /// </summary>
        public static readonly Permission SUPER_USER = new Permission("SUPER_USER");

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


    /// <summary>
    /// Constants used for properties of type PermissionType.
    /// </summary>
    public class PermissionType : ConstantClass
    {

        /// <summary>
        /// Constant CELL_FILTER_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType CELL_FILTER_PERMISSION = new PermissionType("CELL_FILTER_PERMISSION");
        /// <summary>
        /// Constant COLUMN_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType COLUMN_PERMISSION = new PermissionType("COLUMN_PERMISSION");
        /// <summary>
        /// Constant NESTED_CELL_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType NESTED_CELL_PERMISSION = new PermissionType("NESTED_CELL_PERMISSION");
        /// <summary>
        /// Constant NESTED_PERMISSION for PermissionType
        /// </summary>
        public static readonly PermissionType NESTED_PERMISSION = new PermissionType("NESTED_PERMISSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionType FindValue(string value)
        {
            return FindValue<PermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStateString.
    /// </summary>
    public class QueryStateString : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for QueryStateString
        /// </summary>
        public static readonly QueryStateString ERROR = new QueryStateString("ERROR");
        /// <summary>
        /// Constant EXPIRED for QueryStateString
        /// </summary>
        public static readonly QueryStateString EXPIRED = new QueryStateString("EXPIRED");
        /// <summary>
        /// Constant FINISHED for QueryStateString
        /// </summary>
        public static readonly QueryStateString FINISHED = new QueryStateString("FINISHED");
        /// <summary>
        /// Constant PENDING for QueryStateString
        /// </summary>
        public static readonly QueryStateString PENDING = new QueryStateString("PENDING");
        /// <summary>
        /// Constant WORKUNITS_AVAILABLE for QueryStateString
        /// </summary>
        public static readonly QueryStateString WORKUNITS_AVAILABLE = new QueryStateString("WORKUNITS_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStateString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStateString FindValue(string value)
        {
            return FindValue<QueryStateString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStateString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceShareType.
    /// </summary>
    public class ResourceShareType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ResourceShareType
        /// </summary>
        public static readonly ResourceShareType ALL = new ResourceShareType("ALL");
        /// <summary>
        /// Constant FOREIGN for ResourceShareType
        /// </summary>
        public static readonly ResourceShareType FOREIGN = new ResourceShareType("FOREIGN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceShareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceShareType FindValue(string value)
        {
            return FindValue<ResourceShareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceShareType(string value)
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
        /// Constant DATABASE for ResourceType
        /// </summary>
        public static readonly ResourceType DATABASE = new ResourceType("DATABASE");
        /// <summary>
        /// Constant TABLE for ResourceType
        /// </summary>
        public static readonly ResourceType TABLE = new ResourceType("TABLE");

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
    /// Constants used for properties of type TransactionStatus.
    /// </summary>
    public class TransactionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for TransactionStatus
        /// </summary>
        public static readonly TransactionStatus ABORTED = new TransactionStatus("ABORTED");
        /// <summary>
        /// Constant ACTIVE for TransactionStatus
        /// </summary>
        public static readonly TransactionStatus ACTIVE = new TransactionStatus("ACTIVE");
        /// <summary>
        /// Constant COMMIT_IN_PROGRESS for TransactionStatus
        /// </summary>
        public static readonly TransactionStatus COMMIT_IN_PROGRESS = new TransactionStatus("COMMIT_IN_PROGRESS");
        /// <summary>
        /// Constant COMMITTED for TransactionStatus
        /// </summary>
        public static readonly TransactionStatus COMMITTED = new TransactionStatus("COMMITTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransactionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransactionStatus FindValue(string value)
        {
            return FindValue<TransactionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransactionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransactionStatusFilter.
    /// </summary>
    public class TransactionStatusFilter : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for TransactionStatusFilter
        /// </summary>
        public static readonly TransactionStatusFilter ABORTED = new TransactionStatusFilter("ABORTED");
        /// <summary>
        /// Constant ACTIVE for TransactionStatusFilter
        /// </summary>
        public static readonly TransactionStatusFilter ACTIVE = new TransactionStatusFilter("ACTIVE");
        /// <summary>
        /// Constant ALL for TransactionStatusFilter
        /// </summary>
        public static readonly TransactionStatusFilter ALL = new TransactionStatusFilter("ALL");
        /// <summary>
        /// Constant COMMITTED for TransactionStatusFilter
        /// </summary>
        public static readonly TransactionStatusFilter COMMITTED = new TransactionStatusFilter("COMMITTED");
        /// <summary>
        /// Constant COMPLETED for TransactionStatusFilter
        /// </summary>
        public static readonly TransactionStatusFilter COMPLETED = new TransactionStatusFilter("COMPLETED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransactionStatusFilter(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransactionStatusFilter FindValue(string value)
        {
            return FindValue<TransactionStatusFilter>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransactionStatusFilter(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransactionType.
    /// </summary>
    public class TransactionType : ConstantClass
    {

        /// <summary>
        /// Constant READ_AND_WRITE for TransactionType
        /// </summary>
        public static readonly TransactionType READ_AND_WRITE = new TransactionType("READ_AND_WRITE");
        /// <summary>
        /// Constant READ_ONLY for TransactionType
        /// </summary>
        public static readonly TransactionType READ_ONLY = new TransactionType("READ_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransactionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransactionType FindValue(string value)
        {
            return FindValue<TransactionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransactionType(string value)
        {
            return FindValue(value);
        }
    }

}