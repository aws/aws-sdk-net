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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.NeptuneGraph
{

    /// <summary>
    /// Constants used for properties of type ConflictExceptionReason.
    /// </summary>
    public class ConflictExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CONCURRENT_MODIFICATION for ConflictExceptionReason
        /// </summary>
        public static readonly ConflictExceptionReason CONCURRENT_MODIFICATION = new ConflictExceptionReason("CONCURRENT_MODIFICATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConflictExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConflictExceptionReason FindValue(string value)
        {
            return FindValue<ConflictExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConflictExceptionReason(string value)
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
        /// Constant CSV for Format
        /// </summary>
        public static readonly Format CSV = new Format("CSV");
        /// <summary>
        /// Constant OPEN_CYPHER for Format
        /// </summary>
        public static readonly Format OPEN_CYPHER = new Format("OPEN_CYPHER");

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
    /// Constants used for properties of type GraphStatus.
    /// </summary>
    public class GraphStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for GraphStatus
        /// </summary>
        public static readonly GraphStatus AVAILABLE = new GraphStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for GraphStatus
        /// </summary>
        public static readonly GraphStatus CREATING = new GraphStatus("CREATING");
        /// <summary>
        /// Constant DELETING for GraphStatus
        /// </summary>
        public static readonly GraphStatus DELETING = new GraphStatus("DELETING");
        /// <summary>
        /// Constant FAILED for GraphStatus
        /// </summary>
        public static readonly GraphStatus FAILED = new GraphStatus("FAILED");
        /// <summary>
        /// Constant RESETTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus RESETTING = new GraphStatus("RESETTING");
        /// <summary>
        /// Constant SNAPSHOTTING for GraphStatus
        /// </summary>
        public static readonly GraphStatus SNAPSHOTTING = new GraphStatus("SNAPSHOTTING");
        /// <summary>
        /// Constant UPDATING for GraphStatus
        /// </summary>
        public static readonly GraphStatus UPDATING = new GraphStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GraphStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GraphStatus FindValue(string value)
        {
            return FindValue<GraphStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GraphStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportTaskStatus.
    /// </summary>
    public class ImportTaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANALYZING_DATA for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus ANALYZING_DATA = new ImportTaskStatus("ANALYZING_DATA");
        /// <summary>
        /// Constant CANCELLED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus CANCELLED = new ImportTaskStatus("CANCELLED");
        /// <summary>
        /// Constant CANCELLING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus CANCELLING = new ImportTaskStatus("CANCELLING");
        /// <summary>
        /// Constant EXPORTING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus EXPORTING = new ImportTaskStatus("EXPORTING");
        /// <summary>
        /// Constant FAILED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus FAILED = new ImportTaskStatus("FAILED");
        /// <summary>
        /// Constant IMPORTING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus IMPORTING = new ImportTaskStatus("IMPORTING");
        /// <summary>
        /// Constant INITIALIZING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus INITIALIZING = new ImportTaskStatus("INITIALIZING");
        /// <summary>
        /// Constant REPROVISIONING for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus REPROVISIONING = new ImportTaskStatus("REPROVISIONING");
        /// <summary>
        /// Constant ROLLING_BACK for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus ROLLING_BACK = new ImportTaskStatus("ROLLING_BACK");
        /// <summary>
        /// Constant SUCCEEDED for ImportTaskStatus
        /// </summary>
        public static readonly ImportTaskStatus SUCCEEDED = new ImportTaskStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportTaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportTaskStatus FindValue(string value)
        {
            return FindValue<ImportTaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportTaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrivateGraphEndpointStatus.
    /// </summary>
    public class PrivateGraphEndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus AVAILABLE = new PrivateGraphEndpointStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus CREATING = new PrivateGraphEndpointStatus("CREATING");
        /// <summary>
        /// Constant DELETING for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus DELETING = new PrivateGraphEndpointStatus("DELETING");
        /// <summary>
        /// Constant FAILED for PrivateGraphEndpointStatus
        /// </summary>
        public static readonly PrivateGraphEndpointStatus FAILED = new PrivateGraphEndpointStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrivateGraphEndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrivateGraphEndpointStatus FindValue(string value)
        {
            return FindValue<PrivateGraphEndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrivateGraphEndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotStatus.
    /// </summary>
    public class SnapshotStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus AVAILABLE = new SnapshotStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus CREATING = new SnapshotStatus("CREATING");
        /// <summary>
        /// Constant DELETING for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus DELETING = new SnapshotStatus("DELETING");
        /// <summary>
        /// Constant FAILED for SnapshotStatus
        /// </summary>
        public static readonly SnapshotStatus FAILED = new SnapshotStatus("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotStatus FindValue(string value)
        {
            return FindValue<SnapshotStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotStatus(string value)
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
        /// Constant BAD_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BAD_REQUEST = new ValidationExceptionReason("BAD_REQUEST");
        /// <summary>
        /// Constant CONSTRAINT_VIOLATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CONSTRAINT_VIOLATION = new ValidationExceptionReason("CONSTRAINT_VIOLATION");
        /// <summary>
        /// Constant ILLEGAL_ARGUMENT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason ILLEGAL_ARGUMENT = new ValidationExceptionReason("ILLEGAL_ARGUMENT");
        /// <summary>
        /// Constant MALFORMED_QUERY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MALFORMED_QUERY = new ValidationExceptionReason("MALFORMED_QUERY");
        /// <summary>
        /// Constant QUERY_CANCELLED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QUERY_CANCELLED = new ValidationExceptionReason("QUERY_CANCELLED");
        /// <summary>
        /// Constant QUERY_TOO_LARGE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason QUERY_TOO_LARGE = new ValidationExceptionReason("QUERY_TOO_LARGE");
        /// <summary>
        /// Constant UNSUPPORTED_OPERATION for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNSUPPORTED_OPERATION = new ValidationExceptionReason("UNSUPPORTED_OPERATION");

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