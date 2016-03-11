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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Redshift
{

    /// <summary>
    /// Constants used for properties of type ParameterApplyType.
    /// </summary>
    public class ParameterApplyType : ConstantClass
    {

        /// <summary>
        /// Constant Dynamic for ParameterApplyType
        /// </summary>
        public static readonly ParameterApplyType Dynamic = new ParameterApplyType("dynamic");
        /// <summary>
        /// Constant Static for ParameterApplyType
        /// </summary>
        public static readonly ParameterApplyType Static = new ParameterApplyType("static");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterApplyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterApplyType FindValue(string value)
        {
            return FindValue<ParameterApplyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterApplyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for SourceType
        /// </summary>
        public static readonly SourceType Cluster = new SourceType("cluster");
        /// <summary>
        /// Constant ClusterParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType ClusterParameterGroup = new SourceType("cluster-parameter-group");
        /// <summary>
        /// Constant ClusterSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType ClusterSecurityGroup = new SourceType("cluster-security-group");
        /// <summary>
        /// Constant ClusterSnapshot for SourceType
        /// </summary>
        public static readonly SourceType ClusterSnapshot = new SourceType("cluster-snapshot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TableRestoreStatusType.
    /// </summary>
    public class TableRestoreStatusType : ConstantClass
    {

        /// <summary>
        /// Constant CANCELED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType CANCELED = new TableRestoreStatusType("CANCELED");
        /// <summary>
        /// Constant FAILED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType FAILED = new TableRestoreStatusType("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType IN_PROGRESS = new TableRestoreStatusType("IN_PROGRESS");
        /// <summary>
        /// Constant PENDING for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType PENDING = new TableRestoreStatusType("PENDING");
        /// <summary>
        /// Constant SUCCEEDED for TableRestoreStatusType
        /// </summary>
        public static readonly TableRestoreStatusType SUCCEEDED = new TableRestoreStatusType("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableRestoreStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableRestoreStatusType FindValue(string value)
        {
            return FindValue<TableRestoreStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableRestoreStatusType(string value)
        {
            return FindValue(value);
        }
    }

}