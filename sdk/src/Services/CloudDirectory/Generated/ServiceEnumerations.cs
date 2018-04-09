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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudDirectory
{

    /// <summary>
    /// Constants used for properties of type BatchReadExceptionType.
    /// </summary>
    public class BatchReadExceptionType : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType AccessDeniedException = new BatchReadExceptionType("AccessDeniedException");
        /// <summary>
        /// Constant CannotListParentOfRootException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType CannotListParentOfRootException = new BatchReadExceptionType("CannotListParentOfRootException");
        /// <summary>
        /// Constant DirectoryNotEnabledException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType DirectoryNotEnabledException = new BatchReadExceptionType("DirectoryNotEnabledException");
        /// <summary>
        /// Constant FacetValidationException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType FacetValidationException = new BatchReadExceptionType("FacetValidationException");
        /// <summary>
        /// Constant InternalServiceException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType InternalServiceException = new BatchReadExceptionType("InternalServiceException");
        /// <summary>
        /// Constant InvalidArnException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType InvalidArnException = new BatchReadExceptionType("InvalidArnException");
        /// <summary>
        /// Constant InvalidNextTokenException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType InvalidNextTokenException = new BatchReadExceptionType("InvalidNextTokenException");
        /// <summary>
        /// Constant LimitExceededException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType LimitExceededException = new BatchReadExceptionType("LimitExceededException");
        /// <summary>
        /// Constant NotIndexException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType NotIndexException = new BatchReadExceptionType("NotIndexException");
        /// <summary>
        /// Constant NotNodeException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType NotNodeException = new BatchReadExceptionType("NotNodeException");
        /// <summary>
        /// Constant NotPolicyException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType NotPolicyException = new BatchReadExceptionType("NotPolicyException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType ResourceNotFoundException = new BatchReadExceptionType("ResourceNotFoundException");
        /// <summary>
        /// Constant ValidationException for BatchReadExceptionType
        /// </summary>
        public static readonly BatchReadExceptionType ValidationException = new BatchReadExceptionType("ValidationException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchReadExceptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchReadExceptionType FindValue(string value)
        {
            return FindValue<BatchReadExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchReadExceptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchWriteExceptionType.
    /// </summary>
    public class BatchWriteExceptionType : ConstantClass
    {

        /// <summary>
        /// Constant AccessDeniedException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType AccessDeniedException = new BatchWriteExceptionType("AccessDeniedException");
        /// <summary>
        /// Constant DirectoryNotEnabledException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType DirectoryNotEnabledException = new BatchWriteExceptionType("DirectoryNotEnabledException");
        /// <summary>
        /// Constant FacetValidationException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType FacetValidationException = new BatchWriteExceptionType("FacetValidationException");
        /// <summary>
        /// Constant IndexedAttributeMissingException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType IndexedAttributeMissingException = new BatchWriteExceptionType("IndexedAttributeMissingException");
        /// <summary>
        /// Constant InternalServiceException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType InternalServiceException = new BatchWriteExceptionType("InternalServiceException");
        /// <summary>
        /// Constant InvalidArnException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType InvalidArnException = new BatchWriteExceptionType("InvalidArnException");
        /// <summary>
        /// Constant InvalidAttachmentException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType InvalidAttachmentException = new BatchWriteExceptionType("InvalidAttachmentException");
        /// <summary>
        /// Constant LimitExceededException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType LimitExceededException = new BatchWriteExceptionType("LimitExceededException");
        /// <summary>
        /// Constant LinkNameAlreadyInUseException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType LinkNameAlreadyInUseException = new BatchWriteExceptionType("LinkNameAlreadyInUseException");
        /// <summary>
        /// Constant NotIndexException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType NotIndexException = new BatchWriteExceptionType("NotIndexException");
        /// <summary>
        /// Constant NotNodeException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType NotNodeException = new BatchWriteExceptionType("NotNodeException");
        /// <summary>
        /// Constant NotPolicyException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType NotPolicyException = new BatchWriteExceptionType("NotPolicyException");
        /// <summary>
        /// Constant ObjectAlreadyDetachedException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType ObjectAlreadyDetachedException = new BatchWriteExceptionType("ObjectAlreadyDetachedException");
        /// <summary>
        /// Constant ObjectNotDetachedException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType ObjectNotDetachedException = new BatchWriteExceptionType("ObjectNotDetachedException");
        /// <summary>
        /// Constant ResourceNotFoundException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType ResourceNotFoundException = new BatchWriteExceptionType("ResourceNotFoundException");
        /// <summary>
        /// Constant StillContainsLinksException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType StillContainsLinksException = new BatchWriteExceptionType("StillContainsLinksException");
        /// <summary>
        /// Constant UnsupportedIndexTypeException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType UnsupportedIndexTypeException = new BatchWriteExceptionType("UnsupportedIndexTypeException");
        /// <summary>
        /// Constant ValidationException for BatchWriteExceptionType
        /// </summary>
        public static readonly BatchWriteExceptionType ValidationException = new BatchWriteExceptionType("ValidationException");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchWriteExceptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchWriteExceptionType FindValue(string value)
        {
            return FindValue<BatchWriteExceptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchWriteExceptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConsistencyLevel.
    /// </summary>
    public class ConsistencyLevel : ConstantClass
    {

        /// <summary>
        /// Constant EVENTUAL for ConsistencyLevel
        /// </summary>
        public static readonly ConsistencyLevel EVENTUAL = new ConsistencyLevel("EVENTUAL");
        /// <summary>
        /// Constant SERIALIZABLE for ConsistencyLevel
        /// </summary>
        public static readonly ConsistencyLevel SERIALIZABLE = new ConsistencyLevel("SERIALIZABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConsistencyLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConsistencyLevel FindValue(string value)
        {
            return FindValue<ConsistencyLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConsistencyLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectoryState.
    /// </summary>
    public class DirectoryState : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for DirectoryState
        /// </summary>
        public static readonly DirectoryState DELETED = new DirectoryState("DELETED");
        /// <summary>
        /// Constant DISABLED for DirectoryState
        /// </summary>
        public static readonly DirectoryState DISABLED = new DirectoryState("DISABLED");
        /// <summary>
        /// Constant ENABLED for DirectoryState
        /// </summary>
        public static readonly DirectoryState ENABLED = new DirectoryState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectoryState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectoryState FindValue(string value)
        {
            return FindValue<DirectoryState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectoryState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FacetAttributeType.
    /// </summary>
    public class FacetAttributeType : ConstantClass
    {

        /// <summary>
        /// Constant BINARY for FacetAttributeType
        /// </summary>
        public static readonly FacetAttributeType BINARY = new FacetAttributeType("BINARY");
        /// <summary>
        /// Constant BOOLEAN for FacetAttributeType
        /// </summary>
        public static readonly FacetAttributeType BOOLEAN = new FacetAttributeType("BOOLEAN");
        /// <summary>
        /// Constant DATETIME for FacetAttributeType
        /// </summary>
        public static readonly FacetAttributeType DATETIME = new FacetAttributeType("DATETIME");
        /// <summary>
        /// Constant NUMBER for FacetAttributeType
        /// </summary>
        public static readonly FacetAttributeType NUMBER = new FacetAttributeType("NUMBER");
        /// <summary>
        /// Constant STRING for FacetAttributeType
        /// </summary>
        public static readonly FacetAttributeType STRING = new FacetAttributeType("STRING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FacetAttributeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FacetAttributeType FindValue(string value)
        {
            return FindValue<FacetAttributeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FacetAttributeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectType.
    /// </summary>
    public class ObjectType : ConstantClass
    {

        /// <summary>
        /// Constant INDEX for ObjectType
        /// </summary>
        public static readonly ObjectType INDEX = new ObjectType("INDEX");
        /// <summary>
        /// Constant LEAF_NODE for ObjectType
        /// </summary>
        public static readonly ObjectType LEAF_NODE = new ObjectType("LEAF_NODE");
        /// <summary>
        /// Constant NODE for ObjectType
        /// </summary>
        public static readonly ObjectType NODE = new ObjectType("NODE");
        /// <summary>
        /// Constant POLICY for ObjectType
        /// </summary>
        public static readonly ObjectType POLICY = new ObjectType("POLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectType FindValue(string value)
        {
            return FindValue<ObjectType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RangeMode.
    /// </summary>
    public class RangeMode : ConstantClass
    {

        /// <summary>
        /// Constant EXCLUSIVE for RangeMode
        /// </summary>
        public static readonly RangeMode EXCLUSIVE = new RangeMode("EXCLUSIVE");
        /// <summary>
        /// Constant FIRST for RangeMode
        /// </summary>
        public static readonly RangeMode FIRST = new RangeMode("FIRST");
        /// <summary>
        /// Constant INCLUSIVE for RangeMode
        /// </summary>
        public static readonly RangeMode INCLUSIVE = new RangeMode("INCLUSIVE");
        /// <summary>
        /// Constant LAST for RangeMode
        /// </summary>
        public static readonly RangeMode LAST = new RangeMode("LAST");
        /// <summary>
        /// Constant LAST_BEFORE_MISSING_VALUES for RangeMode
        /// </summary>
        public static readonly RangeMode LAST_BEFORE_MISSING_VALUES = new RangeMode("LAST_BEFORE_MISSING_VALUES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RangeMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RangeMode FindValue(string value)
        {
            return FindValue<RangeMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RangeMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequiredAttributeBehavior.
    /// </summary>
    public class RequiredAttributeBehavior : ConstantClass
    {

        /// <summary>
        /// Constant NOT_REQUIRED for RequiredAttributeBehavior
        /// </summary>
        public static readonly RequiredAttributeBehavior NOT_REQUIRED = new RequiredAttributeBehavior("NOT_REQUIRED");
        /// <summary>
        /// Constant REQUIRED_ALWAYS for RequiredAttributeBehavior
        /// </summary>
        public static readonly RequiredAttributeBehavior REQUIRED_ALWAYS = new RequiredAttributeBehavior("REQUIRED_ALWAYS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequiredAttributeBehavior(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequiredAttributeBehavior FindValue(string value)
        {
            return FindValue<RequiredAttributeBehavior>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequiredAttributeBehavior(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant BINARY_LENGTH for RuleType
        /// </summary>
        public static readonly RuleType BINARY_LENGTH = new RuleType("BINARY_LENGTH");
        /// <summary>
        /// Constant NUMBER_COMPARISON for RuleType
        /// </summary>
        public static readonly RuleType NUMBER_COMPARISON = new RuleType("NUMBER_COMPARISON");
        /// <summary>
        /// Constant STRING_FROM_SET for RuleType
        /// </summary>
        public static readonly RuleType STRING_FROM_SET = new RuleType("STRING_FROM_SET");
        /// <summary>
        /// Constant STRING_LENGTH for RuleType
        /// </summary>
        public static readonly RuleType STRING_LENGTH = new RuleType("STRING_LENGTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateActionType.
    /// </summary>
    public class UpdateActionType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_OR_UPDATE for UpdateActionType
        /// </summary>
        public static readonly UpdateActionType CREATE_OR_UPDATE = new UpdateActionType("CREATE_OR_UPDATE");
        /// <summary>
        /// Constant DELETE for UpdateActionType
        /// </summary>
        public static readonly UpdateActionType DELETE = new UpdateActionType("DELETE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateActionType FindValue(string value)
        {
            return FindValue<UpdateActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateActionType(string value)
        {
            return FindValue(value);
        }
    }

}