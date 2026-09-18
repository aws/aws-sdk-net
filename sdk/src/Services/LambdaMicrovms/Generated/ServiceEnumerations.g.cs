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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.LambdaMicrovms
{
    /// <summary>
    /// Constants used for properties of type Architecture.
    /// </summary>
    public class Architecture : ConstantClass
    {
        /// <summary>
        /// Constant ARM_64 for Architecture
        /// </summary>
        public static readonly Architecture ARM_64 = new Architecture("ARM_64");

        /// <summary>
        /// Constructs a custom Architecture for a value not among the defined constants.
        /// </summary>
        public Architecture(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Architecture FindValue(string value)
        {
            return FindValue<Architecture>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Architecture(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type BuildState.
    /// </summary>
    public class BuildState : ConstantClass
    {
        /// <summary>
        /// Constant FAILED for BuildState
        /// </summary>
        public static readonly BuildState FAILED = new BuildState("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for BuildState
        /// </summary>
        public static readonly BuildState IN_PROGRESS = new BuildState("IN_PROGRESS");

        /// <summary>
        /// Constant PENDING for BuildState
        /// </summary>
        public static readonly BuildState PENDING = new BuildState("PENDING");

        /// <summary>
        /// Constant SUCCESSFUL for BuildState
        /// </summary>
        public static readonly BuildState SUCCESSFUL = new BuildState("SUCCESSFUL");

        /// <summary>
        /// Constructs a custom BuildState for a value not among the defined constants.
        /// </summary>
        public BuildState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BuildState FindValue(string value)
        {
            return FindValue<BuildState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BuildState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Capability.
    /// </summary>
    public class Capability : ConstantClass
    {
        /// <summary>
        /// Constant ALL for Capability
        /// </summary>
        public static readonly Capability ALL = new Capability("ALL");

        /// <summary>
        /// Constructs a custom Capability for a value not among the defined constants.
        /// </summary>
        public Capability(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Capability FindValue(string value)
        {
            return FindValue<Capability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Capability(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type Chipset.
    /// </summary>
    public class Chipset : ConstantClass
    {
        /// <summary>
        /// Constant GRAVITON for Chipset
        /// </summary>
        public static readonly Chipset GRAVITON = new Chipset("GRAVITON");

        /// <summary>
        /// Constructs a custom Chipset for a value not among the defined constants.
        /// </summary>
        public Chipset(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Chipset FindValue(string value)
        {
            return FindValue<Chipset>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Chipset(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type HookState.
    /// </summary>
    public class HookState : ConstantClass
    {
        /// <summary>
        /// Constant DISABLED for HookState
        /// </summary>
        public static readonly HookState DISABLED = new HookState("DISABLED");

        /// <summary>
        /// Constant ENABLED for HookState
        /// </summary>
        public static readonly HookState ENABLED = new HookState("ENABLED");

        /// <summary>
        /// Constructs a custom HookState for a value not among the defined constants.
        /// </summary>
        public HookState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HookState FindValue(string value)
        {
            return FindValue<HookState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HookState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ManagedMicrovmImageVersionStatus.
    /// </summary>
    public class ManagedMicrovmImageVersionStatus : ConstantClass
    {
        /// <summary>
        /// Constant AVAILABLE for ManagedMicrovmImageVersionStatus
        /// </summary>
        public static readonly ManagedMicrovmImageVersionStatus AVAILABLE = new ManagedMicrovmImageVersionStatus("AVAILABLE");

        /// <summary>
        /// Constant DEPRECATED for ManagedMicrovmImageVersionStatus
        /// </summary>
        public static readonly ManagedMicrovmImageVersionStatus DEPRECATED = new ManagedMicrovmImageVersionStatus("DEPRECATED");

        /// <summary>
        /// Constructs a custom ManagedMicrovmImageVersionStatus for a value not among the defined constants.
        /// </summary>
        public ManagedMicrovmImageVersionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManagedMicrovmImageVersionStatus FindValue(string value)
        {
            return FindValue<ManagedMicrovmImageVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManagedMicrovmImageVersionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MicrovmImageState.
    /// </summary>
    public class MicrovmImageState : ConstantClass
    {
        /// <summary>
        /// Constant CREATED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState CREATED = new MicrovmImageState("CREATED");

        /// <summary>
        /// Constant CREATE_FAILED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState CREATE_FAILED = new MicrovmImageState("CREATE_FAILED");

        /// <summary>
        /// Constant CREATING for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState CREATING = new MicrovmImageState("CREATING");

        /// <summary>
        /// Constant DELETED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState DELETED = new MicrovmImageState("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState DELETE_FAILED = new MicrovmImageState("DELETE_FAILED");

        /// <summary>
        /// Constant DELETING for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState DELETING = new MicrovmImageState("DELETING");

        /// <summary>
        /// Constant UPDATED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState UPDATED = new MicrovmImageState("UPDATED");

        /// <summary>
        /// Constant UPDATE_FAILED for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState UPDATE_FAILED = new MicrovmImageState("UPDATE_FAILED");

        /// <summary>
        /// Constant UPDATING for MicrovmImageState
        /// </summary>
        public static readonly MicrovmImageState UPDATING = new MicrovmImageState("UPDATING");

        /// <summary>
        /// Constructs a custom MicrovmImageState for a value not among the defined constants.
        /// </summary>
        public MicrovmImageState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MicrovmImageState FindValue(string value)
        {
            return FindValue<MicrovmImageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MicrovmImageState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MicrovmImageVersionState.
    /// </summary>
    public class MicrovmImageVersionState : ConstantClass
    {
        /// <summary>
        /// Constant DELETED for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState DELETED = new MicrovmImageVersionState("DELETED");

        /// <summary>
        /// Constant DELETE_FAILED for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState DELETE_FAILED = new MicrovmImageVersionState("DELETE_FAILED");

        /// <summary>
        /// Constant DELETING for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState DELETING = new MicrovmImageVersionState("DELETING");

        /// <summary>
        /// Constant FAILED for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState FAILED = new MicrovmImageVersionState("FAILED");

        /// <summary>
        /// Constant IN_PROGRESS for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState IN_PROGRESS = new MicrovmImageVersionState("IN_PROGRESS");

        /// <summary>
        /// Constant PENDING for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState PENDING = new MicrovmImageVersionState("PENDING");

        /// <summary>
        /// Constant SUCCESSFUL for MicrovmImageVersionState
        /// </summary>
        public static readonly MicrovmImageVersionState SUCCESSFUL = new MicrovmImageVersionState("SUCCESSFUL");

        /// <summary>
        /// Constructs a custom MicrovmImageVersionState for a value not among the defined constants.
        /// </summary>
        public MicrovmImageVersionState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MicrovmImageVersionState FindValue(string value)
        {
            return FindValue<MicrovmImageVersionState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MicrovmImageVersionState(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MicrovmImageVersionStatus.
    /// </summary>
    public class MicrovmImageVersionStatus : ConstantClass
    {
        /// <summary>
        /// Constant ACTIVE for MicrovmImageVersionStatus
        /// </summary>
        public static readonly MicrovmImageVersionStatus ACTIVE = new MicrovmImageVersionStatus("ACTIVE");

        /// <summary>
        /// Constant INACTIVE for MicrovmImageVersionStatus
        /// </summary>
        public static readonly MicrovmImageVersionStatus INACTIVE = new MicrovmImageVersionStatus("INACTIVE");

        /// <summary>
        /// Constructs a custom MicrovmImageVersionStatus for a value not among the defined constants.
        /// </summary>
        public MicrovmImageVersionStatus(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MicrovmImageVersionStatus FindValue(string value)
        {
            return FindValue<MicrovmImageVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MicrovmImageVersionStatus(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type MicrovmState.
    /// </summary>
    public class MicrovmState : ConstantClass
    {
        /// <summary>
        /// Constant PENDING for MicrovmState
        /// </summary>
        public static readonly MicrovmState PENDING = new MicrovmState("PENDING");

        /// <summary>
        /// Constant RUNNING for MicrovmState
        /// </summary>
        public static readonly MicrovmState RUNNING = new MicrovmState("RUNNING");

        /// <summary>
        /// Constant SUSPENDED for MicrovmState
        /// </summary>
        public static readonly MicrovmState SUSPENDED = new MicrovmState("SUSPENDED");

        /// <summary>
        /// Constant SUSPENDING for MicrovmState
        /// </summary>
        public static readonly MicrovmState SUSPENDING = new MicrovmState("SUSPENDING");

        /// <summary>
        /// Constant TERMINATED for MicrovmState
        /// </summary>
        public static readonly MicrovmState TERMINATED = new MicrovmState("TERMINATED");

        /// <summary>
        /// Constant TERMINATING for MicrovmState
        /// </summary>
        public static readonly MicrovmState TERMINATING = new MicrovmState("TERMINATING");

        /// <summary>
        /// Constructs a custom MicrovmState for a value not among the defined constants.
        /// </summary>
        public MicrovmState(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MicrovmState FindValue(string value)
        {
            return FindValue<MicrovmState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MicrovmState(string value)
        {
            return FindValue(value);
        }
    }
}
