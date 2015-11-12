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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DeviceFarm
{

    /// <summary>
    /// Constants used for properties of type ArtifactCategory.
    /// </summary>
    public class ArtifactCategory : ConstantClass
    {

        /// <summary>
        /// Constant FILE for ArtifactCategory
        /// </summary>
        public static readonly ArtifactCategory FILE = new ArtifactCategory("FILE");
        /// <summary>
        /// Constant LOG for ArtifactCategory
        /// </summary>
        public static readonly ArtifactCategory LOG = new ArtifactCategory("LOG");
        /// <summary>
        /// Constant SCREENSHOT for ArtifactCategory
        /// </summary>
        public static readonly ArtifactCategory SCREENSHOT = new ArtifactCategory("SCREENSHOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactCategory FindValue(string value)
        {
            return FindValue<ArtifactCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArtifactType.
    /// </summary>
    public class ArtifactType : ConstantClass
    {

        /// <summary>
        /// Constant APPIUM_JAVA_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType APPIUM_JAVA_OUTPUT = new ArtifactType("APPIUM_JAVA_OUTPUT");
        /// <summary>
        /// Constant APPIUM_JAVA_XML_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType APPIUM_JAVA_XML_OUTPUT = new ArtifactType("APPIUM_JAVA_XML_OUTPUT");
        /// <summary>
        /// Constant APPIUM_SERVER_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType APPIUM_SERVER_OUTPUT = new ArtifactType("APPIUM_SERVER_OUTPUT");
        /// <summary>
        /// Constant APPLICATION_CRASH_REPORT for ArtifactType
        /// </summary>
        public static readonly ArtifactType APPLICATION_CRASH_REPORT = new ArtifactType("APPLICATION_CRASH_REPORT");
        /// <summary>
        /// Constant AUTOMATION_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType AUTOMATION_OUTPUT = new ArtifactType("AUTOMATION_OUTPUT");
        /// <summary>
        /// Constant CALABASH_JAVA_XML_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType CALABASH_JAVA_XML_OUTPUT = new ArtifactType("CALABASH_JAVA_XML_OUTPUT");
        /// <summary>
        /// Constant CALABASH_JSON_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType CALABASH_JSON_OUTPUT = new ArtifactType("CALABASH_JSON_OUTPUT");
        /// <summary>
        /// Constant CALABASH_PRETTY_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType CALABASH_PRETTY_OUTPUT = new ArtifactType("CALABASH_PRETTY_OUTPUT");
        /// <summary>
        /// Constant CALABASH_STANDARD_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType CALABASH_STANDARD_OUTPUT = new ArtifactType("CALABASH_STANDARD_OUTPUT");
        /// <summary>
        /// Constant DEVICE_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType DEVICE_LOG = new ArtifactType("DEVICE_LOG");
        /// <summary>
        /// Constant EXERCISER_MONKEY_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType EXERCISER_MONKEY_OUTPUT = new ArtifactType("EXERCISER_MONKEY_OUTPUT");
        /// <summary>
        /// Constant EXPLORER_EVENT_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType EXPLORER_EVENT_LOG = new ArtifactType("EXPLORER_EVENT_LOG");
        /// <summary>
        /// Constant EXPLORER_SUMMARY_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType EXPLORER_SUMMARY_LOG = new ArtifactType("EXPLORER_SUMMARY_LOG");
        /// <summary>
        /// Constant INSTRUMENTATION_OUTPUT for ArtifactType
        /// </summary>
        public static readonly ArtifactType INSTRUMENTATION_OUTPUT = new ArtifactType("INSTRUMENTATION_OUTPUT");
        /// <summary>
        /// Constant MESSAGE_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType MESSAGE_LOG = new ArtifactType("MESSAGE_LOG");
        /// <summary>
        /// Constant RESULT_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType RESULT_LOG = new ArtifactType("RESULT_LOG");
        /// <summary>
        /// Constant SCREENSHOT for ArtifactType
        /// </summary>
        public static readonly ArtifactType SCREENSHOT = new ArtifactType("SCREENSHOT");
        /// <summary>
        /// Constant SERVICE_LOG for ArtifactType
        /// </summary>
        public static readonly ArtifactType SERVICE_LOG = new ArtifactType("SERVICE_LOG");
        /// <summary>
        /// Constant UNKNOWN for ArtifactType
        /// </summary>
        public static readonly ArtifactType UNKNOWN = new ArtifactType("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArtifactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArtifactType FindValue(string value)
        {
            return FindValue<ArtifactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArtifactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillingMethod.
    /// </summary>
    public class BillingMethod : ConstantClass
    {

        /// <summary>
        /// Constant METERED for BillingMethod
        /// </summary>
        public static readonly BillingMethod METERED = new BillingMethod("METERED");
        /// <summary>
        /// Constant UNMETERED for BillingMethod
        /// </summary>
        public static readonly BillingMethod UNMETERED = new BillingMethod("UNMETERED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingMethod FindValue(string value)
        {
            return FindValue<BillingMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceAttribute.
    /// </summary>
    public class DeviceAttribute : ConstantClass
    {

        /// <summary>
        /// Constant ARN for DeviceAttribute
        /// </summary>
        public static readonly DeviceAttribute ARN = new DeviceAttribute("ARN");
        /// <summary>
        /// Constant FORM_FACTOR for DeviceAttribute
        /// </summary>
        public static readonly DeviceAttribute FORM_FACTOR = new DeviceAttribute("FORM_FACTOR");
        /// <summary>
        /// Constant MANUFACTURER for DeviceAttribute
        /// </summary>
        public static readonly DeviceAttribute MANUFACTURER = new DeviceAttribute("MANUFACTURER");
        /// <summary>
        /// Constant PLATFORM for DeviceAttribute
        /// </summary>
        public static readonly DeviceAttribute PLATFORM = new DeviceAttribute("PLATFORM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceAttribute FindValue(string value)
        {
            return FindValue<DeviceAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeviceFormFactor.
    /// </summary>
    public class DeviceFormFactor : ConstantClass
    {

        /// <summary>
        /// Constant PHONE for DeviceFormFactor
        /// </summary>
        public static readonly DeviceFormFactor PHONE = new DeviceFormFactor("PHONE");
        /// <summary>
        /// Constant TABLET for DeviceFormFactor
        /// </summary>
        public static readonly DeviceFormFactor TABLET = new DeviceFormFactor("TABLET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeviceFormFactor(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeviceFormFactor FindValue(string value)
        {
            return FindValue<DeviceFormFactor>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeviceFormFactor(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DevicePlatform.
    /// </summary>
    public class DevicePlatform : ConstantClass
    {

        /// <summary>
        /// Constant ANDROID for DevicePlatform
        /// </summary>
        public static readonly DevicePlatform ANDROID = new DevicePlatform("ANDROID");
        /// <summary>
        /// Constant IOS for DevicePlatform
        /// </summary>
        public static readonly DevicePlatform IOS = new DevicePlatform("IOS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DevicePlatform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DevicePlatform FindValue(string value)
        {
            return FindValue<DevicePlatform>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DevicePlatform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DevicePoolType.
    /// </summary>
    public class DevicePoolType : ConstantClass
    {

        /// <summary>
        /// Constant CURATED for DevicePoolType
        /// </summary>
        public static readonly DevicePoolType CURATED = new DevicePoolType("CURATED");
        /// <summary>
        /// Constant PRIVATE for DevicePoolType
        /// </summary>
        public static readonly DevicePoolType PRIVATE = new DevicePoolType("PRIVATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DevicePoolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DevicePoolType FindValue(string value)
        {
            return FindValue<DevicePoolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DevicePoolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionResult.
    /// </summary>
    public class ExecutionResult : ConstantClass
    {

        /// <summary>
        /// Constant ERRORED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult ERRORED = new ExecutionResult("ERRORED");
        /// <summary>
        /// Constant FAILED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult FAILED = new ExecutionResult("FAILED");
        /// <summary>
        /// Constant PASSED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult PASSED = new ExecutionResult("PASSED");
        /// <summary>
        /// Constant PENDING for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult PENDING = new ExecutionResult("PENDING");
        /// <summary>
        /// Constant SKIPPED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult SKIPPED = new ExecutionResult("SKIPPED");
        /// <summary>
        /// Constant STOPPED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult STOPPED = new ExecutionResult("STOPPED");
        /// <summary>
        /// Constant WARNED for ExecutionResult
        /// </summary>
        public static readonly ExecutionResult WARNED = new ExecutionResult("WARNED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionResult(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionResult FindValue(string value)
        {
            return FindValue<ExecutionResult>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionResult(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus COMPLETED = new ExecutionStatus("COMPLETED");
        /// <summary>
        /// Constant PENDING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus PENDING = new ExecutionStatus("PENDING");
        /// <summary>
        /// Constant PROCESSING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus PROCESSING = new ExecutionStatus("PROCESSING");
        /// <summary>
        /// Constant RUNNING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus RUNNING = new ExecutionStatus("RUNNING");
        /// <summary>
        /// Constant SCHEDULING for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus SCHEDULING = new ExecutionStatus("SCHEDULING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleOperator.
    /// </summary>
    public class RuleOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS_TO for RuleOperator
        /// </summary>
        public static readonly RuleOperator EQUALS_TO = new RuleOperator("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN for RuleOperator
        /// </summary>
        public static readonly RuleOperator GREATER_THAN = new RuleOperator("GREATER_THAN");
        /// <summary>
        /// Constant IN for RuleOperator
        /// </summary>
        public static readonly RuleOperator IN = new RuleOperator("IN");
        /// <summary>
        /// Constant LESS_THAN for RuleOperator
        /// </summary>
        public static readonly RuleOperator LESS_THAN = new RuleOperator("LESS_THAN");
        /// <summary>
        /// Constant NOT_IN for RuleOperator
        /// </summary>
        public static readonly RuleOperator NOT_IN = new RuleOperator("NOT_IN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleOperator FindValue(string value)
        {
            return FindValue<RuleOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SampleType.
    /// </summary>
    public class SampleType : ConstantClass
    {

        /// <summary>
        /// Constant CPU for SampleType
        /// </summary>
        public static readonly SampleType CPU = new SampleType("CPU");
        /// <summary>
        /// Constant MEMORY for SampleType
        /// </summary>
        public static readonly SampleType MEMORY = new SampleType("MEMORY");
        /// <summary>
        /// Constant NATIVE_AVG_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType NATIVE_AVG_DRAWTIME = new SampleType("NATIVE_AVG_DRAWTIME");
        /// <summary>
        /// Constant NATIVE_FPS for SampleType
        /// </summary>
        public static readonly SampleType NATIVE_FPS = new SampleType("NATIVE_FPS");
        /// <summary>
        /// Constant NATIVE_FRAMES for SampleType
        /// </summary>
        public static readonly SampleType NATIVE_FRAMES = new SampleType("NATIVE_FRAMES");
        /// <summary>
        /// Constant NATIVE_MAX_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType NATIVE_MAX_DRAWTIME = new SampleType("NATIVE_MAX_DRAWTIME");
        /// <summary>
        /// Constant NATIVE_MIN_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType NATIVE_MIN_DRAWTIME = new SampleType("NATIVE_MIN_DRAWTIME");
        /// <summary>
        /// Constant OPENGL_AVG_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType OPENGL_AVG_DRAWTIME = new SampleType("OPENGL_AVG_DRAWTIME");
        /// <summary>
        /// Constant OPENGL_FPS for SampleType
        /// </summary>
        public static readonly SampleType OPENGL_FPS = new SampleType("OPENGL_FPS");
        /// <summary>
        /// Constant OPENGL_FRAMES for SampleType
        /// </summary>
        public static readonly SampleType OPENGL_FRAMES = new SampleType("OPENGL_FRAMES");
        /// <summary>
        /// Constant OPENGL_MAX_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType OPENGL_MAX_DRAWTIME = new SampleType("OPENGL_MAX_DRAWTIME");
        /// <summary>
        /// Constant OPENGL_MIN_DRAWTIME for SampleType
        /// </summary>
        public static readonly SampleType OPENGL_MIN_DRAWTIME = new SampleType("OPENGL_MIN_DRAWTIME");
        /// <summary>
        /// Constant RX for SampleType
        /// </summary>
        public static readonly SampleType RX = new SampleType("RX");
        /// <summary>
        /// Constant RX_RATE for SampleType
        /// </summary>
        public static readonly SampleType RX_RATE = new SampleType("RX_RATE");
        /// <summary>
        /// Constant THREADS for SampleType
        /// </summary>
        public static readonly SampleType THREADS = new SampleType("THREADS");
        /// <summary>
        /// Constant TX for SampleType
        /// </summary>
        public static readonly SampleType TX = new SampleType("TX");
        /// <summary>
        /// Constant TX_RATE for SampleType
        /// </summary>
        public static readonly SampleType TX_RATE = new SampleType("TX_RATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SampleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SampleType FindValue(string value)
        {
            return FindValue<SampleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SampleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TestType.
    /// </summary>
    public class TestType : ConstantClass
    {

        /// <summary>
        /// Constant APPIUM_JAVA_JUNIT for TestType
        /// </summary>
        public static readonly TestType APPIUM_JAVA_JUNIT = new TestType("APPIUM_JAVA_JUNIT");
        /// <summary>
        /// Constant APPIUM_JAVA_TESTNG for TestType
        /// </summary>
        public static readonly TestType APPIUM_JAVA_TESTNG = new TestType("APPIUM_JAVA_TESTNG");
        /// <summary>
        /// Constant BUILTIN_EXPLORER for TestType
        /// </summary>
        public static readonly TestType BUILTIN_EXPLORER = new TestType("BUILTIN_EXPLORER");
        /// <summary>
        /// Constant BUILTIN_FUZZ for TestType
        /// </summary>
        public static readonly TestType BUILTIN_FUZZ = new TestType("BUILTIN_FUZZ");
        /// <summary>
        /// Constant CALABASH for TestType
        /// </summary>
        public static readonly TestType CALABASH = new TestType("CALABASH");
        /// <summary>
        /// Constant INSTRUMENTATION for TestType
        /// </summary>
        public static readonly TestType INSTRUMENTATION = new TestType("INSTRUMENTATION");
        /// <summary>
        /// Constant UIAUTOMATION for TestType
        /// </summary>
        public static readonly TestType UIAUTOMATION = new TestType("UIAUTOMATION");
        /// <summary>
        /// Constant UIAUTOMATOR for TestType
        /// </summary>
        public static readonly TestType UIAUTOMATOR = new TestType("UIAUTOMATOR");
        /// <summary>
        /// Constant XCTEST for TestType
        /// </summary>
        public static readonly TestType XCTEST = new TestType("XCTEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TestType FindValue(string value)
        {
            return FindValue<TestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadStatus.
    /// </summary>
    public class UploadStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for UploadStatus
        /// </summary>
        public static readonly UploadStatus FAILED = new UploadStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for UploadStatus
        /// </summary>
        public static readonly UploadStatus INITIALIZED = new UploadStatus("INITIALIZED");
        /// <summary>
        /// Constant PROCESSING for UploadStatus
        /// </summary>
        public static readonly UploadStatus PROCESSING = new UploadStatus("PROCESSING");
        /// <summary>
        /// Constant SUCCEEDED for UploadStatus
        /// </summary>
        public static readonly UploadStatus SUCCEEDED = new UploadStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadStatus FindValue(string value)
        {
            return FindValue<UploadStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UploadType.
    /// </summary>
    public class UploadType : ConstantClass
    {

        /// <summary>
        /// Constant ANDROID_APP for UploadType
        /// </summary>
        public static readonly UploadType ANDROID_APP = new UploadType("ANDROID_APP");
        /// <summary>
        /// Constant APPIUM_JAVA_JUNIT_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType APPIUM_JAVA_JUNIT_TEST_PACKAGE = new UploadType("APPIUM_JAVA_JUNIT_TEST_PACKAGE");
        /// <summary>
        /// Constant APPIUM_JAVA_TESTNG_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType APPIUM_JAVA_TESTNG_TEST_PACKAGE = new UploadType("APPIUM_JAVA_TESTNG_TEST_PACKAGE");
        /// <summary>
        /// Constant CALABASH_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType CALABASH_TEST_PACKAGE = new UploadType("CALABASH_TEST_PACKAGE");
        /// <summary>
        /// Constant EXTERNAL_DATA for UploadType
        /// </summary>
        public static readonly UploadType EXTERNAL_DATA = new UploadType("EXTERNAL_DATA");
        /// <summary>
        /// Constant INSTRUMENTATION_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType INSTRUMENTATION_TEST_PACKAGE = new UploadType("INSTRUMENTATION_TEST_PACKAGE");
        /// <summary>
        /// Constant IOS_APP for UploadType
        /// </summary>
        public static readonly UploadType IOS_APP = new UploadType("IOS_APP");
        /// <summary>
        /// Constant UIAUTOMATION_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType UIAUTOMATION_TEST_PACKAGE = new UploadType("UIAUTOMATION_TEST_PACKAGE");
        /// <summary>
        /// Constant UIAUTOMATOR_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType UIAUTOMATOR_TEST_PACKAGE = new UploadType("UIAUTOMATOR_TEST_PACKAGE");
        /// <summary>
        /// Constant XCTEST_TEST_PACKAGE for UploadType
        /// </summary>
        public static readonly UploadType XCTEST_TEST_PACKAGE = new UploadType("XCTEST_TEST_PACKAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UploadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UploadType FindValue(string value)
        {
            return FindValue<UploadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UploadType(string value)
        {
            return FindValue(value);
        }
    }

}