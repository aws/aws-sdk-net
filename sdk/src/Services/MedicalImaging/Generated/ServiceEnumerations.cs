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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MedicalImaging
{

    /// <summary>
    /// Constants used for properties of type DatastoreStatus.
    /// </summary>
    public class DatastoreStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus ACTIVE = new DatastoreStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus CREATE_FAILED = new DatastoreStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus CREATING = new DatastoreStatus("CREATING");
        /// <summary>
        /// Constant DELETED for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus DELETED = new DatastoreStatus("DELETED");
        /// <summary>
        /// Constant DELETING for DatastoreStatus
        /// </summary>
        public static readonly DatastoreStatus DELETING = new DatastoreStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatastoreStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatastoreStatus FindValue(string value)
        {
            return FindValue<DatastoreStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatastoreStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSetState.
    /// </summary>
    public class ImageSetState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ImageSetState
        /// </summary>
        public static readonly ImageSetState ACTIVE = new ImageSetState("ACTIVE");
        /// <summary>
        /// Constant DELETED for ImageSetState
        /// </summary>
        public static readonly ImageSetState DELETED = new ImageSetState("DELETED");
        /// <summary>
        /// Constant LOCKED for ImageSetState
        /// </summary>
        public static readonly ImageSetState LOCKED = new ImageSetState("LOCKED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSetState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSetState FindValue(string value)
        {
            return FindValue<ImageSetState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSetState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageSetWorkflowStatus.
    /// </summary>
    public class ImageSetWorkflowStatus : ConstantClass
    {

        /// <summary>
        /// Constant COPIED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus COPIED = new ImageSetWorkflowStatus("COPIED");
        /// <summary>
        /// Constant COPY_FAILED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus COPY_FAILED = new ImageSetWorkflowStatus("COPY_FAILED");
        /// <summary>
        /// Constant COPYING for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus COPYING = new ImageSetWorkflowStatus("COPYING");
        /// <summary>
        /// Constant COPYING_WITH_READ_ONLY_ACCESS for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus COPYING_WITH_READ_ONLY_ACCESS = new ImageSetWorkflowStatus("COPYING_WITH_READ_ONLY_ACCESS");
        /// <summary>
        /// Constant CREATED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus CREATED = new ImageSetWorkflowStatus("CREATED");
        /// <summary>
        /// Constant DELETED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus DELETED = new ImageSetWorkflowStatus("DELETED");
        /// <summary>
        /// Constant DELETING for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus DELETING = new ImageSetWorkflowStatus("DELETING");
        /// <summary>
        /// Constant IMPORT_FAILED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus IMPORT_FAILED = new ImageSetWorkflowStatus("IMPORT_FAILED");
        /// <summary>
        /// Constant IMPORTED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus IMPORTED = new ImageSetWorkflowStatus("IMPORTED");
        /// <summary>
        /// Constant IMPORTING for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus IMPORTING = new ImageSetWorkflowStatus("IMPORTING");
        /// <summary>
        /// Constant UPDATE_FAILED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus UPDATE_FAILED = new ImageSetWorkflowStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATED for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus UPDATED = new ImageSetWorkflowStatus("UPDATED");
        /// <summary>
        /// Constant UPDATING for ImageSetWorkflowStatus
        /// </summary>
        public static readonly ImageSetWorkflowStatus UPDATING = new ImageSetWorkflowStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageSetWorkflowStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageSetWorkflowStatus FindValue(string value)
        {
            return FindValue<ImageSetWorkflowStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageSetWorkflowStatus(string value)
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
        /// Constant COMPLETED for JobStatus
        /// </summary>
        public static readonly JobStatus COMPLETED = new JobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for JobStatus
        /// </summary>
        public static readonly JobStatus FAILED = new JobStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for JobStatus
        /// </summary>
        public static readonly JobStatus IN_PROGRESS = new JobStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUBMITTED for JobStatus
        /// </summary>
        public static readonly JobStatus SUBMITTED = new JobStatus("SUBMITTED");

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
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for Operator
        /// </summary>
        public static readonly Operator BETWEEN = new Operator("BETWEEN");
        /// <summary>
        /// Constant EQUAL for Operator
        /// </summary>
        public static readonly Operator EQUAL = new Operator("EQUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortField.
    /// </summary>
    public class SortField : ConstantClass
    {

        /// <summary>
        /// Constant CreatedAt for SortField
        /// </summary>
        public static readonly SortField CreatedAt = new SortField("createdAt");
        /// <summary>
        /// Constant DICOMStudyDateAndTime for SortField
        /// </summary>
        public static readonly SortField DICOMStudyDateAndTime = new SortField("DICOMStudyDateAndTime");
        /// <summary>
        /// Constant UpdatedAt for SortField
        /// </summary>
        public static readonly SortField UpdatedAt = new SortField("updatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortField FindValue(string value)
        {
            return FindValue<SortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }

}