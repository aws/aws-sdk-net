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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Batch
{

    /// <summary>
    /// Constants used for properties of type ArrayJobDependency.
    /// </summary>
    public class ArrayJobDependency : ConstantClass
    {

        /// <summary>
        /// Constant N_TO_N for ArrayJobDependency
        /// </summary>
        public static readonly ArrayJobDependency N_TO_N = new ArrayJobDependency("N_TO_N");
        /// <summary>
        /// Constant SEQUENTIAL for ArrayJobDependency
        /// </summary>
        public static readonly ArrayJobDependency SEQUENTIAL = new ArrayJobDependency("SEQUENTIAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArrayJobDependency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArrayJobDependency FindValue(string value)
        {
            return FindValue<ArrayJobDependency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArrayJobDependency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CEState.
    /// </summary>
    public class CEState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CEState
        /// </summary>
        public static readonly CEState DISABLED = new CEState("DISABLED");
        /// <summary>
        /// Constant ENABLED for CEState
        /// </summary>
        public static readonly CEState ENABLED = new CEState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEState FindValue(string value)
        {
            return FindValue<CEState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CEStatus.
    /// </summary>
    public class CEStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for CEStatus
        /// </summary>
        public static readonly CEStatus CREATING = new CEStatus("CREATING");
        /// <summary>
        /// Constant DELETED for CEStatus
        /// </summary>
        public static readonly CEStatus DELETED = new CEStatus("DELETED");
        /// <summary>
        /// Constant DELETING for CEStatus
        /// </summary>
        public static readonly CEStatus DELETING = new CEStatus("DELETING");
        /// <summary>
        /// Constant INVALID for CEStatus
        /// </summary>
        public static readonly CEStatus INVALID = new CEStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for CEStatus
        /// </summary>
        public static readonly CEStatus UPDATING = new CEStatus("UPDATING");
        /// <summary>
        /// Constant VALID for CEStatus
        /// </summary>
        public static readonly CEStatus VALID = new CEStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEStatus FindValue(string value)
        {
            return FindValue<CEStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CEType.
    /// </summary>
    public class CEType : ConstantClass
    {

        /// <summary>
        /// Constant MANAGED for CEType
        /// </summary>
        public static readonly CEType MANAGED = new CEType("MANAGED");
        /// <summary>
        /// Constant UNMANAGED for CEType
        /// </summary>
        public static readonly CEType UNMANAGED = new CEType("UNMANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CEType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CEType FindValue(string value)
        {
            return FindValue<CEType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CEType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CRType.
    /// </summary>
    public class CRType : ConstantClass
    {

        /// <summary>
        /// Constant EC2 for CRType
        /// </summary>
        public static readonly CRType EC2 = new CRType("EC2");
        /// <summary>
        /// Constant SPOT for CRType
        /// </summary>
        public static readonly CRType SPOT = new CRType("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CRType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CRType FindValue(string value)
        {
            return FindValue<CRType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CRType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobDefinitionType.
    /// </summary>
    public class JobDefinitionType : ConstantClass
    {

        /// <summary>
        /// Constant Container for JobDefinitionType
        /// </summary>
        public static readonly JobDefinitionType Container = new JobDefinitionType("container");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobDefinitionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobDefinitionType FindValue(string value)
        {
            return FindValue<JobDefinitionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobDefinitionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JobStatus.
    /// </summary>
    public class JobStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant PENDING for JobStatus
        /// </summary>
        public static readonly JobStatus PENDING = new JobStatus("PENDING");
        /// <summary>
        /// Constant RUNNABLE for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNABLE = new JobStatus("RUNNABLE");
        /// <summary>
        /// Constant RUNNING for JobStatus
        /// </summary>
        public static readonly JobStatus RUNNING = new JobStatus("RUNNING");
        /// <summary>
        /// Constant STARTING for JobStatus
        /// </summary>
        public static readonly JobStatus STARTING = new JobStatus("STARTING");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCEEDED for JobStatus
        /// </summary>
        public static readonly JobStatus SUCCEEDED = new JobStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobStatus FindValue(string value)
        {
            return FindValue<JobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JQState.
    /// </summary>
    public class JQState : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for JQState
        /// </summary>
        public static readonly JQState DISABLED = new JQState("DISABLED");
        /// <summary>
        /// Constant ENABLED for JQState
        /// </summary>
        public static readonly JQState ENABLED = new JQState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JQState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JQState FindValue(string value)
        {
            return FindValue<JQState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JQState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JQStatus.
    /// </summary>
    public class JQStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATING for JQStatus
        /// </summary>
        public static readonly JQStatus CREATING = new JQStatus("CREATING");
        /// <summary>
        /// Constant DELETED for JQStatus
        /// </summary>
        public static readonly JQStatus DELETED = new JQStatus("DELETED");
        /// <summary>
        /// Constant DELETING for JQStatus
        /// </summary>
        public static readonly JQStatus DELETING = new JQStatus("DELETING");
        /// <summary>
        /// Constant INVALID for JQStatus
        /// </summary>
        public static readonly JQStatus INVALID = new JQStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for JQStatus
        /// </summary>
        public static readonly JQStatus UPDATING = new JQStatus("UPDATING");
        /// <summary>
        /// Constant VALID for JQStatus
        /// </summary>
        public static readonly JQStatus VALID = new JQStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JQStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JQStatus FindValue(string value)
        {
            return FindValue<JQStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JQStatus(string value)
        {
            return FindValue(value);
        }
    }

}