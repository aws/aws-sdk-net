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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GameSparks
{

    /// <summary>
    /// Constants used for properties of type DeploymentAction.
    /// </summary>
    public class DeploymentAction : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOY for DeploymentAction
        /// </summary>
        public static readonly DeploymentAction DEPLOY = new DeploymentAction("DEPLOY");
        /// <summary>
        /// Constant UNDEPLOY for DeploymentAction
        /// </summary>
        public static readonly DeploymentAction UNDEPLOY = new DeploymentAction("UNDEPLOY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentAction FindValue(string value)
        {
            return FindValue<DeploymentAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeploymentState.
    /// </summary>
    public class DeploymentState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DeploymentState
        /// </summary>
        public static readonly DeploymentState COMPLETED = new DeploymentState("COMPLETED");
        /// <summary>
        /// Constant FAILED for DeploymentState
        /// </summary>
        public static readonly DeploymentState FAILED = new DeploymentState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for DeploymentState
        /// </summary>
        public static readonly DeploymentState IN_PROGRESS = new DeploymentState("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for DeploymentState
        /// </summary>
        public static readonly DeploymentState PENDING = new DeploymentState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeploymentState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeploymentState FindValue(string value)
        {
            return FindValue<DeploymentState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeploymentState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GameState.
    /// </summary>
    public class GameState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for GameState
        /// </summary>
        public static readonly GameState ACTIVE = new GameState("ACTIVE");
        /// <summary>
        /// Constant DELETING for GameState
        /// </summary>
        public static readonly GameState DELETING = new GameState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GameState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GameState FindValue(string value)
        {
            return FindValue<GameState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GameState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GeneratedCodeJobState.
    /// </summary>
    public class GeneratedCodeJobState : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for GeneratedCodeJobState
        /// </summary>
        public static readonly GeneratedCodeJobState COMPLETED = new GeneratedCodeJobState("COMPLETED");
        /// <summary>
        /// Constant FAILED for GeneratedCodeJobState
        /// </summary>
        public static readonly GeneratedCodeJobState FAILED = new GeneratedCodeJobState("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for GeneratedCodeJobState
        /// </summary>
        public static readonly GeneratedCodeJobState IN_PROGRESS = new GeneratedCodeJobState("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for GeneratedCodeJobState
        /// </summary>
        public static readonly GeneratedCodeJobState PENDING = new GeneratedCodeJobState("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GeneratedCodeJobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GeneratedCodeJobState FindValue(string value)
        {
            return FindValue<GeneratedCodeJobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GeneratedCodeJobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operation.
    /// </summary>
    public class Operation : ConstantClass
    {

        /// <summary>
        /// Constant ADD for Operation
        /// </summary>
        public static readonly Operation ADD = new Operation("ADD");
        /// <summary>
        /// Constant REMOVE for Operation
        /// </summary>
        public static readonly Operation REMOVE = new Operation("REMOVE");
        /// <summary>
        /// Constant REPLACE for Operation
        /// </summary>
        public static readonly Operation REPLACE = new Operation("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operation FindValue(string value)
        {
            return FindValue<Operation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StageState.
    /// </summary>
    public class StageState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for StageState
        /// </summary>
        public static readonly StageState ACTIVE = new StageState("ACTIVE");
        /// <summary>
        /// Constant DELETING for StageState
        /// </summary>
        public static readonly StageState DELETING = new StageState("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StageState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StageState FindValue(string value)
        {
            return FindValue<StageState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StageState(string value)
        {
            return FindValue(value);
        }
    }

}