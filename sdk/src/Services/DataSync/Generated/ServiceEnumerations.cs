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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DataSync
{

    /// <summary>
    /// Constants used for properties of type AgentStatus.
    /// </summary>
    public class AgentStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFFLINE for AgentStatus
        /// </summary>
        public static readonly AgentStatus OFFLINE = new AgentStatus("OFFLINE");
        /// <summary>
        /// Constant ONLINE for AgentStatus
        /// </summary>
        public static readonly AgentStatus ONLINE = new AgentStatus("ONLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AgentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AgentStatus FindValue(string value)
        {
            return FindValue<AgentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AgentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Atime.
    /// </summary>
    public class Atime : ConstantClass
    {

        /// <summary>
        /// Constant BEST_EFFORT for Atime
        /// </summary>
        public static readonly Atime BEST_EFFORT = new Atime("BEST_EFFORT");
        /// <summary>
        /// Constant NONE for Atime
        /// </summary>
        public static readonly Atime NONE = new Atime("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Atime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Atime FindValue(string value)
        {
            return FindValue<Atime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Atime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Gid.
    /// </summary>
    public class Gid : ConstantClass
    {

        /// <summary>
        /// Constant BOTH for Gid
        /// </summary>
        public static readonly Gid BOTH = new Gid("BOTH");
        /// <summary>
        /// Constant INT_VALUE for Gid
        /// </summary>
        public static readonly Gid INT_VALUE = new Gid("INT_VALUE");
        /// <summary>
        /// Constant NAME for Gid
        /// </summary>
        public static readonly Gid NAME = new Gid("NAME");
        /// <summary>
        /// Constant NONE for Gid
        /// </summary>
        public static readonly Gid NONE = new Gid("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Gid(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Gid FindValue(string value)
        {
            return FindValue<Gid>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Gid(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mtime.
    /// </summary>
    public class Mtime : ConstantClass
    {

        /// <summary>
        /// Constant NONE for Mtime
        /// </summary>
        public static readonly Mtime NONE = new Mtime("NONE");
        /// <summary>
        /// Constant PRESERVE for Mtime
        /// </summary>
        public static readonly Mtime PRESERVE = new Mtime("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mtime(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mtime FindValue(string value)
        {
            return FindValue<Mtime>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mtime(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PhaseStatus.
    /// </summary>
    public class PhaseStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus ERROR = new PhaseStatus("ERROR");
        /// <summary>
        /// Constant PENDING for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus PENDING = new PhaseStatus("PENDING");
        /// <summary>
        /// Constant SUCCESS for PhaseStatus
        /// </summary>
        public static readonly PhaseStatus SUCCESS = new PhaseStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PhaseStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PhaseStatus FindValue(string value)
        {
            return FindValue<PhaseStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PhaseStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PosixPermissions.
    /// </summary>
    public class PosixPermissions : ConstantClass
    {

        /// <summary>
        /// Constant BEST_EFFORT for PosixPermissions
        /// </summary>
        public static readonly PosixPermissions BEST_EFFORT = new PosixPermissions("BEST_EFFORT");
        /// <summary>
        /// Constant NONE for PosixPermissions
        /// </summary>
        public static readonly PosixPermissions NONE = new PosixPermissions("NONE");
        /// <summary>
        /// Constant PRESERVE for PosixPermissions
        /// </summary>
        public static readonly PosixPermissions PRESERVE = new PosixPermissions("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PosixPermissions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PosixPermissions FindValue(string value)
        {
            return FindValue<PosixPermissions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PosixPermissions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreserveDeletedFiles.
    /// </summary>
    public class PreserveDeletedFiles : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE for PreserveDeletedFiles
        /// </summary>
        public static readonly PreserveDeletedFiles PRESERVE = new PreserveDeletedFiles("PRESERVE");
        /// <summary>
        /// Constant REMOVE for PreserveDeletedFiles
        /// </summary>
        public static readonly PreserveDeletedFiles REMOVE = new PreserveDeletedFiles("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreserveDeletedFiles(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreserveDeletedFiles FindValue(string value)
        {
            return FindValue<PreserveDeletedFiles>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreserveDeletedFiles(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PreserveDevices.
    /// </summary>
    public class PreserveDevices : ConstantClass
    {

        /// <summary>
        /// Constant NONE for PreserveDevices
        /// </summary>
        public static readonly PreserveDevices NONE = new PreserveDevices("NONE");
        /// <summary>
        /// Constant PRESERVE for PreserveDevices
        /// </summary>
        public static readonly PreserveDevices PRESERVE = new PreserveDevices("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PreserveDevices(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PreserveDevices FindValue(string value)
        {
            return FindValue<PreserveDevices>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PreserveDevices(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskExecutionStatus.
    /// </summary>
    public class TaskExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus ERROR = new TaskExecutionStatus("ERROR");
        /// <summary>
        /// Constant LAUNCHING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus LAUNCHING = new TaskExecutionStatus("LAUNCHING");
        /// <summary>
        /// Constant PREPARING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus PREPARING = new TaskExecutionStatus("PREPARING");
        /// <summary>
        /// Constant SUCCESS for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus SUCCESS = new TaskExecutionStatus("SUCCESS");
        /// <summary>
        /// Constant TRANSFERRING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus TRANSFERRING = new TaskExecutionStatus("TRANSFERRING");
        /// <summary>
        /// Constant VERIFYING for TaskExecutionStatus
        /// </summary>
        public static readonly TaskExecutionStatus VERIFYING = new TaskExecutionStatus("VERIFYING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskExecutionStatus FindValue(string value)
        {
            return FindValue<TaskExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for TaskStatus
        /// </summary>
        public static readonly TaskStatus AVAILABLE = new TaskStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for TaskStatus
        /// </summary>
        public static readonly TaskStatus CREATING = new TaskStatus("CREATING");
        /// <summary>
        /// Constant RUNNING for TaskStatus
        /// </summary>
        public static readonly TaskStatus RUNNING = new TaskStatus("RUNNING");
        /// <summary>
        /// Constant UNAVAILABLE for TaskStatus
        /// </summary>
        public static readonly TaskStatus UNAVAILABLE = new TaskStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Uid.
    /// </summary>
    public class Uid : ConstantClass
    {

        /// <summary>
        /// Constant BOTH for Uid
        /// </summary>
        public static readonly Uid BOTH = new Uid("BOTH");
        /// <summary>
        /// Constant INT_VALUE for Uid
        /// </summary>
        public static readonly Uid INT_VALUE = new Uid("INT_VALUE");
        /// <summary>
        /// Constant NAME for Uid
        /// </summary>
        public static readonly Uid NAME = new Uid("NAME");
        /// <summary>
        /// Constant NONE for Uid
        /// </summary>
        public static readonly Uid NONE = new Uid("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Uid(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Uid FindValue(string value)
        {
            return FindValue<Uid>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Uid(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VerifyMode.
    /// </summary>
    public class VerifyMode : ConstantClass
    {

        /// <summary>
        /// Constant NONE for VerifyMode
        /// </summary>
        public static readonly VerifyMode NONE = new VerifyMode("NONE");
        /// <summary>
        /// Constant POINT_IN_TIME_CONSISTENT for VerifyMode
        /// </summary>
        public static readonly VerifyMode POINT_IN_TIME_CONSISTENT = new VerifyMode("POINT_IN_TIME_CONSISTENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VerifyMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerifyMode FindValue(string value)
        {
            return FindValue<VerifyMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VerifyMode(string value)
        {
            return FindValue(value);
        }
    }

}