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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AmplifyUIBuilder
{

    /// <summary>
    /// Constants used for properties of type CodegenGenericDataFieldDataType.
    /// </summary>
    public class CodegenGenericDataFieldDataType : ConstantClass
    {

        /// <summary>
        /// Constant AWSDate for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSDate = new CodegenGenericDataFieldDataType("AWSDate");
        /// <summary>
        /// Constant AWSDateTime for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSDateTime = new CodegenGenericDataFieldDataType("AWSDateTime");
        /// <summary>
        /// Constant AWSEmail for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSEmail = new CodegenGenericDataFieldDataType("AWSEmail");
        /// <summary>
        /// Constant AWSIPAddress for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSIPAddress = new CodegenGenericDataFieldDataType("AWSIPAddress");
        /// <summary>
        /// Constant AWSJSON for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSJSON = new CodegenGenericDataFieldDataType("AWSJSON");
        /// <summary>
        /// Constant AWSPhone for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSPhone = new CodegenGenericDataFieldDataType("AWSPhone");
        /// <summary>
        /// Constant AWSTime for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSTime = new CodegenGenericDataFieldDataType("AWSTime");
        /// <summary>
        /// Constant AWSTimestamp for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSTimestamp = new CodegenGenericDataFieldDataType("AWSTimestamp");
        /// <summary>
        /// Constant AWSURL for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType AWSURL = new CodegenGenericDataFieldDataType("AWSURL");
        /// <summary>
        /// Constant Boolean for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType Boolean = new CodegenGenericDataFieldDataType("Boolean");
        /// <summary>
        /// Constant Enum for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType Enum = new CodegenGenericDataFieldDataType("Enum");
        /// <summary>
        /// Constant Float for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType Float = new CodegenGenericDataFieldDataType("Float");
        /// <summary>
        /// Constant ID for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType ID = new CodegenGenericDataFieldDataType("ID");
        /// <summary>
        /// Constant Int for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType Int = new CodegenGenericDataFieldDataType("Int");
        /// <summary>
        /// Constant Model for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType Model = new CodegenGenericDataFieldDataType("Model");
        /// <summary>
        /// Constant NonModel for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType NonModel = new CodegenGenericDataFieldDataType("NonModel");
        /// <summary>
        /// Constant String for CodegenGenericDataFieldDataType
        /// </summary>
        public static readonly CodegenGenericDataFieldDataType String = new CodegenGenericDataFieldDataType("String");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodegenGenericDataFieldDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodegenGenericDataFieldDataType FindValue(string value)
        {
            return FindValue<CodegenGenericDataFieldDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodegenGenericDataFieldDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodegenJobGenericDataSourceType.
    /// </summary>
    public class CodegenJobGenericDataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant DataStore for CodegenJobGenericDataSourceType
        /// </summary>
        public static readonly CodegenJobGenericDataSourceType DataStore = new CodegenJobGenericDataSourceType("DataStore");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodegenJobGenericDataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodegenJobGenericDataSourceType FindValue(string value)
        {
            return FindValue<CodegenJobGenericDataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodegenJobGenericDataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodegenJobStatus.
    /// </summary>
    public class CodegenJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for CodegenJobStatus
        /// </summary>
        public static readonly CodegenJobStatus Failed = new CodegenJobStatus("failed");
        /// <summary>
        /// Constant In_progress for CodegenJobStatus
        /// </summary>
        public static readonly CodegenJobStatus In_progress = new CodegenJobStatus("in_progress");
        /// <summary>
        /// Constant Succeeded for CodegenJobStatus
        /// </summary>
        public static readonly CodegenJobStatus Succeeded = new CodegenJobStatus("succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodegenJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodegenJobStatus FindValue(string value)
        {
            return FindValue<CodegenJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodegenJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FixedPosition.
    /// </summary>
    public class FixedPosition : ConstantClass
    {

        /// <summary>
        /// Constant First for FixedPosition
        /// </summary>
        public static readonly FixedPosition First = new FixedPosition("first");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FixedPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FixedPosition FindValue(string value)
        {
            return FindValue<FixedPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FixedPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormActionType.
    /// </summary>
    public class FormActionType : ConstantClass
    {

        /// <summary>
        /// Constant Create for FormActionType
        /// </summary>
        public static readonly FormActionType Create = new FormActionType("create");
        /// <summary>
        /// Constant Update for FormActionType
        /// </summary>
        public static readonly FormActionType Update = new FormActionType("update");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormActionType FindValue(string value)
        {
            return FindValue<FormActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormButtonsPosition.
    /// </summary>
    public class FormButtonsPosition : ConstantClass
    {

        /// <summary>
        /// Constant Bottom for FormButtonsPosition
        /// </summary>
        public static readonly FormButtonsPosition Bottom = new FormButtonsPosition("bottom");
        /// <summary>
        /// Constant Top for FormButtonsPosition
        /// </summary>
        public static readonly FormButtonsPosition Top = new FormButtonsPosition("top");
        /// <summary>
        /// Constant Top_and_bottom for FormButtonsPosition
        /// </summary>
        public static readonly FormButtonsPosition Top_and_bottom = new FormButtonsPosition("top_and_bottom");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormButtonsPosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormButtonsPosition FindValue(string value)
        {
            return FindValue<FormButtonsPosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormButtonsPosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FormDataSourceType.
    /// </summary>
    public class FormDataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant Custom for FormDataSourceType
        /// </summary>
        public static readonly FormDataSourceType Custom = new FormDataSourceType("Custom");
        /// <summary>
        /// Constant DataStore for FormDataSourceType
        /// </summary>
        public static readonly FormDataSourceType DataStore = new FormDataSourceType("DataStore");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FormDataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FormDataSourceType FindValue(string value)
        {
            return FindValue<FormDataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FormDataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GenericDataRelationshipType.
    /// </summary>
    public class GenericDataRelationshipType : ConstantClass
    {

        /// <summary>
        /// Constant BELONGS_TO for GenericDataRelationshipType
        /// </summary>
        public static readonly GenericDataRelationshipType BELONGS_TO = new GenericDataRelationshipType("BELONGS_TO");
        /// <summary>
        /// Constant HAS_MANY for GenericDataRelationshipType
        /// </summary>
        public static readonly GenericDataRelationshipType HAS_MANY = new GenericDataRelationshipType("HAS_MANY");
        /// <summary>
        /// Constant HAS_ONE for GenericDataRelationshipType
        /// </summary>
        public static readonly GenericDataRelationshipType HAS_ONE = new GenericDataRelationshipType("HAS_ONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GenericDataRelationshipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GenericDataRelationshipType FindValue(string value)
        {
            return FindValue<GenericDataRelationshipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GenericDataRelationshipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JSModule.
    /// </summary>
    public class JSModule : ConstantClass
    {

        /// <summary>
        /// Constant Es2020 for JSModule
        /// </summary>
        public static readonly JSModule Es2020 = new JSModule("es2020");
        /// <summary>
        /// Constant Esnext for JSModule
        /// </summary>
        public static readonly JSModule Esnext = new JSModule("esnext");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JSModule(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JSModule FindValue(string value)
        {
            return FindValue<JSModule>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JSModule(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JSScript.
    /// </summary>
    public class JSScript : ConstantClass
    {

        /// <summary>
        /// Constant Js for JSScript
        /// </summary>
        public static readonly JSScript Js = new JSScript("js");
        /// <summary>
        /// Constant Jsx for JSScript
        /// </summary>
        public static readonly JSScript Jsx = new JSScript("jsx");
        /// <summary>
        /// Constant Tsx for JSScript
        /// </summary>
        public static readonly JSScript Tsx = new JSScript("tsx");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JSScript(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JSScript FindValue(string value)
        {
            return FindValue<JSScript>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JSScript(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JSTarget.
    /// </summary>
    public class JSTarget : ConstantClass
    {

        /// <summary>
        /// Constant Es2015 for JSTarget
        /// </summary>
        public static readonly JSTarget Es2015 = new JSTarget("es2015");
        /// <summary>
        /// Constant Es2020 for JSTarget
        /// </summary>
        public static readonly JSTarget Es2020 = new JSTarget("es2020");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JSTarget(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JSTarget FindValue(string value)
        {
            return FindValue<JSTarget>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JSTarget(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelDecorator.
    /// </summary>
    public class LabelDecorator : ConstantClass
    {

        /// <summary>
        /// Constant None for LabelDecorator
        /// </summary>
        public static readonly LabelDecorator None = new LabelDecorator("none");
        /// <summary>
        /// Constant Optional for LabelDecorator
        /// </summary>
        public static readonly LabelDecorator Optional = new LabelDecorator("optional");
        /// <summary>
        /// Constant Required for LabelDecorator
        /// </summary>
        public static readonly LabelDecorator Required = new LabelDecorator("required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelDecorator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelDecorator FindValue(string value)
        {
            return FindValue<LabelDecorator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelDecorator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortDirection.
    /// </summary>
    public class SortDirection : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortDirection
        /// </summary>
        public static readonly SortDirection ASC = new SortDirection("ASC");
        /// <summary>
        /// Constant DESC for SortDirection
        /// </summary>
        public static readonly SortDirection DESC = new SortDirection("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortDirection(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortDirection FindValue(string value)
        {
            return FindValue<SortDirection>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortDirection(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageAccessLevel.
    /// </summary>
    public class StorageAccessLevel : ConstantClass
    {

        /// <summary>
        /// Constant Private for StorageAccessLevel
        /// </summary>
        public static readonly StorageAccessLevel Private = new StorageAccessLevel("private");
        /// <summary>
        /// Constant Protected for StorageAccessLevel
        /// </summary>
        public static readonly StorageAccessLevel Protected = new StorageAccessLevel("protected");
        /// <summary>
        /// Constant Public for StorageAccessLevel
        /// </summary>
        public static readonly StorageAccessLevel Public = new StorageAccessLevel("public");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageAccessLevel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageAccessLevel FindValue(string value)
        {
            return FindValue<StorageAccessLevel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageAccessLevel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TokenProviders.
    /// </summary>
    public class TokenProviders : ConstantClass
    {

        /// <summary>
        /// Constant Figma for TokenProviders
        /// </summary>
        public static readonly TokenProviders Figma = new TokenProviders("figma");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TokenProviders(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TokenProviders FindValue(string value)
        {
            return FindValue<TokenProviders>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TokenProviders(string value)
        {
            return FindValue(value);
        }
    }

}