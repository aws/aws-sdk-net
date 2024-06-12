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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AppTest
{

    /// <summary>
    /// Constants used for properties of type CaptureTool.
    /// </summary>
    public class CaptureTool : ConstantClass
    {

        /// <summary>
        /// Constant AWSDMS for CaptureTool
        /// </summary>
        public static readonly CaptureTool AWSDMS = new CaptureTool("AWS DMS");
        /// <summary>
        /// Constant Precisely for CaptureTool
        /// </summary>
        public static readonly CaptureTool Precisely = new CaptureTool("Precisely");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CaptureTool(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CaptureTool FindValue(string value)
        {
            return FindValue<CaptureTool>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CaptureTool(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CloudFormationActionType.
    /// </summary>
    public class CloudFormationActionType : ConstantClass
    {

        /// <summary>
        /// Constant Create for CloudFormationActionType
        /// </summary>
        public static readonly CloudFormationActionType Create = new CloudFormationActionType("Create");
        /// <summary>
        /// Constant Delete for CloudFormationActionType
        /// </summary>
        public static readonly CloudFormationActionType Delete = new CloudFormationActionType("Delete");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CloudFormationActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CloudFormationActionType FindValue(string value)
        {
            return FindValue<CloudFormationActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CloudFormationActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ComparisonStatusEnum.
    /// </summary>
    public class ComparisonStatusEnum : ConstantClass
    {

        /// <summary>
        /// Constant Different for ComparisonStatusEnum
        /// </summary>
        public static readonly ComparisonStatusEnum Different = new ComparisonStatusEnum("Different");
        /// <summary>
        /// Constant Equal for ComparisonStatusEnum
        /// </summary>
        public static readonly ComparisonStatusEnum Equal = new ComparisonStatusEnum("Equal");
        /// <summary>
        /// Constant Equivalent for ComparisonStatusEnum
        /// </summary>
        public static readonly ComparisonStatusEnum Equivalent = new ComparisonStatusEnum("Equivalent");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ComparisonStatusEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ComparisonStatusEnum FindValue(string value)
        {
            return FindValue<ComparisonStatusEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ComparisonStatusEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSetType.
    /// </summary>
    public class DataSetType : ConstantClass
    {

        /// <summary>
        /// Constant PS for DataSetType
        /// </summary>
        public static readonly DataSetType PS = new DataSetType("PS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSetType FindValue(string value)
        {
            return FindValue<DataSetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Format.
    /// </summary>
    public class Format : ConstantClass
    {

        /// <summary>
        /// Constant FIXED for Format
        /// </summary>
        public static readonly Format FIXED = new Format("FIXED");
        /// <summary>
        /// Constant LINE_SEQUENTIAL for Format
        /// </summary>
        public static readonly Format LINE_SEQUENTIAL = new Format("LINE_SEQUENTIAL");
        /// <summary>
        /// Constant VARIABLE for Format
        /// </summary>
        public static readonly Format VARIABLE = new Format("VARIABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Format(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Format FindValue(string value)
        {
            return FindValue<Format>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Format(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2ManagedActionType.
    /// </summary>
    public class M2ManagedActionType : ConstantClass
    {

        /// <summary>
        /// Constant Configure for M2ManagedActionType
        /// </summary>
        public static readonly M2ManagedActionType Configure = new M2ManagedActionType("Configure");
        /// <summary>
        /// Constant Deconfigure for M2ManagedActionType
        /// </summary>
        public static readonly M2ManagedActionType Deconfigure = new M2ManagedActionType("Deconfigure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2ManagedActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2ManagedActionType FindValue(string value)
        {
            return FindValue<M2ManagedActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2ManagedActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2ManagedRuntime.
    /// </summary>
    public class M2ManagedRuntime : ConstantClass
    {

        /// <summary>
        /// Constant MicroFocus for M2ManagedRuntime
        /// </summary>
        public static readonly M2ManagedRuntime MicroFocus = new M2ManagedRuntime("MicroFocus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2ManagedRuntime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2ManagedRuntime FindValue(string value)
        {
            return FindValue<M2ManagedRuntime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2ManagedRuntime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2NonManagedActionType.
    /// </summary>
    public class M2NonManagedActionType : ConstantClass
    {

        /// <summary>
        /// Constant Configure for M2NonManagedActionType
        /// </summary>
        public static readonly M2NonManagedActionType Configure = new M2NonManagedActionType("Configure");
        /// <summary>
        /// Constant Deconfigure for M2NonManagedActionType
        /// </summary>
        public static readonly M2NonManagedActionType Deconfigure = new M2NonManagedActionType("Deconfigure");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2NonManagedActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2NonManagedActionType FindValue(string value)
        {
            return FindValue<M2NonManagedActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2NonManagedActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type M2NonManagedRuntime.
    /// </summary>
    public class M2NonManagedRuntime : ConstantClass
    {

        /// <summary>
        /// Constant BluAge for M2NonManagedRuntime
        /// </summary>
        public static readonly M2NonManagedRuntime BluAge = new M2NonManagedRuntime("BluAge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public M2NonManagedRuntime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static M2NonManagedRuntime FindValue(string value)
        {
            return FindValue<M2NonManagedRuntime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator M2NonManagedRuntime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScriptType.
    /// </summary>
    public class ScriptType : ConstantClass
    {

        /// <summary>
        /// Constant Selenium for ScriptType
        /// </summary>
        public static readonly ScriptType Selenium = new ScriptType("Selenium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScriptType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScriptType FindValue(string value)
        {
            return FindValue<ScriptType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScriptType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceDatabase.
    /// </summary>
    public class SourceDatabase : ConstantClass
    {

        /// <summary>
        /// Constant ZOSDB2 for SourceDatabase
        /// </summary>
        public static readonly SourceDatabase ZOSDB2 = new SourceDatabase("z/OS-DB2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceDatabase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceDatabase FindValue(string value)
        {
            return FindValue<SourceDatabase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceDatabase(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StepRunStatus.
    /// </summary>
    public class StepRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StepRunStatus
        /// </summary>
        public static readonly StepRunStatus Failed = new StepRunStatus("Failed");
        /// <summary>
        /// Constant Running for StepRunStatus
        /// </summary>
        public static readonly StepRunStatus Running = new StepRunStatus("Running");
        /// <summary>
        /// Constant Success for StepRunStatus
        /// </summary>
        public static readonly StepRunStatus Success = new StepRunStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StepRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StepRunStatus FindValue(string value)
        {
            return FindValue<StepRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StepRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDatabase.
    /// </summary>
    public class TargetDatabase : ConstantClass
    {

        /// <summary>
        /// Constant PostgreSQL for TargetDatabase
        /// </summary>
        public static readonly TargetDatabase PostgreSQL = new TargetDatabase("PostgreSQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDatabase(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDatabase FindValue(string value)
        {
            return FindValue<TargetDatabase>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDatabase(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestCaseLifecycle.
    /// </summary>
    public class TestCaseLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Active for TestCaseLifecycle
        /// </summary>
        public static readonly TestCaseLifecycle Active = new TestCaseLifecycle("Active");
        /// <summary>
        /// Constant Deleting for TestCaseLifecycle
        /// </summary>
        public static readonly TestCaseLifecycle Deleting = new TestCaseLifecycle("Deleting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestCaseLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestCaseLifecycle FindValue(string value)
        {
            return FindValue<TestCaseLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestCaseLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestCaseRunStatus.
    /// </summary>
    public class TestCaseRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for TestCaseRunStatus
        /// </summary>
        public static readonly TestCaseRunStatus Failed = new TestCaseRunStatus("Failed");
        /// <summary>
        /// Constant Running for TestCaseRunStatus
        /// </summary>
        public static readonly TestCaseRunStatus Running = new TestCaseRunStatus("Running");
        /// <summary>
        /// Constant Success for TestCaseRunStatus
        /// </summary>
        public static readonly TestCaseRunStatus Success = new TestCaseRunStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestCaseRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestCaseRunStatus FindValue(string value)
        {
            return FindValue<TestCaseRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestCaseRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestConfigurationLifecycle.
    /// </summary>
    public class TestConfigurationLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Active for TestConfigurationLifecycle
        /// </summary>
        public static readonly TestConfigurationLifecycle Active = new TestConfigurationLifecycle("Active");
        /// <summary>
        /// Constant Deleting for TestConfigurationLifecycle
        /// </summary>
        public static readonly TestConfigurationLifecycle Deleting = new TestConfigurationLifecycle("Deleting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestConfigurationLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestConfigurationLifecycle FindValue(string value)
        {
            return FindValue<TestConfigurationLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestConfigurationLifecycle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestRunStatus.
    /// </summary>
    public class TestRunStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for TestRunStatus
        /// </summary>
        public static readonly TestRunStatus Deleting = new TestRunStatus("Deleting");
        /// <summary>
        /// Constant Failed for TestRunStatus
        /// </summary>
        public static readonly TestRunStatus Failed = new TestRunStatus("Failed");
        /// <summary>
        /// Constant Running for TestRunStatus
        /// </summary>
        public static readonly TestRunStatus Running = new TestRunStatus("Running");
        /// <summary>
        /// Constant Success for TestRunStatus
        /// </summary>
        public static readonly TestRunStatus Success = new TestRunStatus("Success");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestRunStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestRunStatus FindValue(string value)
        {
            return FindValue<TestRunStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestRunStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestSuiteLifecycle.
    /// </summary>
    public class TestSuiteLifecycle : ConstantClass
    {

        /// <summary>
        /// Constant Active for TestSuiteLifecycle
        /// </summary>
        public static readonly TestSuiteLifecycle Active = new TestSuiteLifecycle("Active");
        /// <summary>
        /// Constant Creating for TestSuiteLifecycle
        /// </summary>
        public static readonly TestSuiteLifecycle Creating = new TestSuiteLifecycle("Creating");
        /// <summary>
        /// Constant Deleting for TestSuiteLifecycle
        /// </summary>
        public static readonly TestSuiteLifecycle Deleting = new TestSuiteLifecycle("Deleting");
        /// <summary>
        /// Constant Failed for TestSuiteLifecycle
        /// </summary>
        public static readonly TestSuiteLifecycle Failed = new TestSuiteLifecycle("Failed");
        /// <summary>
        /// Constant Updating for TestSuiteLifecycle
        /// </summary>
        public static readonly TestSuiteLifecycle Updating = new TestSuiteLifecycle("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestSuiteLifecycle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestSuiteLifecycle FindValue(string value)
        {
            return FindValue<TestSuiteLifecycle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestSuiteLifecycle(string value)
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