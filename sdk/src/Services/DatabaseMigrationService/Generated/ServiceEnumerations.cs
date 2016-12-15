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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DatabaseMigrationService
{

    /// <summary>
    /// Constants used for properties of type DmsSslModeValue.
    /// </summary>
    public class DmsSslModeValue : ConstantClass
    {

        /// <summary>
        /// Constant None for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue None = new DmsSslModeValue("none");
        /// <summary>
        /// Constant Require for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue Require = new DmsSslModeValue("require");
        /// <summary>
        /// Constant VerifyCa for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue VerifyCa = new DmsSslModeValue("verify-ca");
        /// <summary>
        /// Constant VerifyFull for DmsSslModeValue
        /// </summary>
        public static readonly DmsSslModeValue VerifyFull = new DmsSslModeValue("verify-full");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DmsSslModeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DmsSslModeValue FindValue(string value)
        {
            return FindValue<DmsSslModeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DmsSslModeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MigrationTypeValue.
    /// </summary>
    public class MigrationTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Cdc for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue Cdc = new MigrationTypeValue("cdc");
        /// <summary>
        /// Constant FullLoad for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue FullLoad = new MigrationTypeValue("full-load");
        /// <summary>
        /// Constant FullLoadAndCdc for MigrationTypeValue
        /// </summary>
        public static readonly MigrationTypeValue FullLoadAndCdc = new MigrationTypeValue("full-load-and-cdc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MigrationTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MigrationTypeValue FindValue(string value)
        {
            return FindValue<MigrationTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MigrationTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RefreshSchemasStatusTypeValue.
    /// </summary>
    public class RefreshSchemasStatusTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Failed for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Failed = new RefreshSchemasStatusTypeValue("failed");
        /// <summary>
        /// Constant Refreshing for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Refreshing = new RefreshSchemasStatusTypeValue("refreshing");
        /// <summary>
        /// Constant Successful for RefreshSchemasStatusTypeValue
        /// </summary>
        public static readonly RefreshSchemasStatusTypeValue Successful = new RefreshSchemasStatusTypeValue("successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RefreshSchemasStatusTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RefreshSchemasStatusTypeValue FindValue(string value)
        {
            return FindValue<RefreshSchemasStatusTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RefreshSchemasStatusTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationEndpointServiceTypeValue.
    /// </summary>
    public class ReplicationEndpointServiceTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Source for ReplicationEndpointServiceTypeValue
        /// </summary>
        public static readonly ReplicationEndpointServiceTypeValue Source = new ReplicationEndpointServiceTypeValue("source");
        /// <summary>
        /// Constant Target for ReplicationEndpointServiceTypeValue
        /// </summary>
        public static readonly ReplicationEndpointServiceTypeValue Target = new ReplicationEndpointServiceTypeValue("target");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationEndpointServiceTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationEndpointServiceTypeValue FindValue(string value)
        {
            return FindValue<ReplicationEndpointServiceTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationEndpointServiceTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationEndpointTypeValue.
    /// </summary>
    public class ReplicationEndpointTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant Source for ReplicationEndpointTypeValue
        /// </summary>
        public static readonly ReplicationEndpointTypeValue Source = new ReplicationEndpointTypeValue("source");
        /// <summary>
        /// Constant Target for ReplicationEndpointTypeValue
        /// </summary>
        public static readonly ReplicationEndpointTypeValue Target = new ReplicationEndpointTypeValue("target");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationEndpointTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationEndpointTypeValue FindValue(string value)
        {
            return FindValue<ReplicationEndpointTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationEndpointTypeValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StartReplicationTaskTypeValue.
    /// </summary>
    public class StartReplicationTaskTypeValue : ConstantClass
    {

        /// <summary>
        /// Constant ReloadTarget for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue ReloadTarget = new StartReplicationTaskTypeValue("reload-target");
        /// <summary>
        /// Constant ResumeProcessing for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue ResumeProcessing = new StartReplicationTaskTypeValue("resume-processing");
        /// <summary>
        /// Constant StartReplication for StartReplicationTaskTypeValue
        /// </summary>
        public static readonly StartReplicationTaskTypeValue StartReplication = new StartReplicationTaskTypeValue("start-replication");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartReplicationTaskTypeValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartReplicationTaskTypeValue FindValue(string value)
        {
            return FindValue<StartReplicationTaskTypeValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartReplicationTaskTypeValue(string value)
        {
            return FindValue(value);
        }
    }

}