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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Keyspaces
{

    /// <summary>
    /// Constants used for properties of type CdcPropagateTags.
    /// </summary>
    public class CdcPropagateTags : ConstantClass
    {

        /// <summary>
        /// Constant NONE for CdcPropagateTags
        /// </summary>
        public static readonly CdcPropagateTags NONE = new CdcPropagateTags("NONE");
        /// <summary>
        /// Constant TABLE for CdcPropagateTags
        /// </summary>
        public static readonly CdcPropagateTags TABLE = new CdcPropagateTags("TABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CdcPropagateTags(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CdcPropagateTags FindValue(string value)
        {
            return FindValue<CdcPropagateTags>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CdcPropagateTags(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CdcStatus.
    /// </summary>
    public class CdcStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for CdcStatus
        /// </summary>
        public static readonly CdcStatus DISABLED = new CdcStatus("DISABLED");
        /// <summary>
        /// Constant DISABLING for CdcStatus
        /// </summary>
        public static readonly CdcStatus DISABLING = new CdcStatus("DISABLING");
        /// <summary>
        /// Constant ENABLED for CdcStatus
        /// </summary>
        public static readonly CdcStatus ENABLED = new CdcStatus("ENABLED");
        /// <summary>
        /// Constant ENABLING for CdcStatus
        /// </summary>
        public static readonly CdcStatus ENABLING = new CdcStatus("ENABLING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CdcStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CdcStatus FindValue(string value)
        {
            return FindValue<CdcStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CdcStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClientSideTimestampsStatus.
    /// </summary>
    public class ClientSideTimestampsStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for ClientSideTimestampsStatus
        /// </summary>
        public static readonly ClientSideTimestampsStatus ENABLED = new ClientSideTimestampsStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClientSideTimestampsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClientSideTimestampsStatus FindValue(string value)
        {
            return FindValue<ClientSideTimestampsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClientSideTimestampsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType AWS_OWNED_KMS_KEY = new EncryptionType("AWS_OWNED_KMS_KEY");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_KMS_KEY for EncryptionType
        /// </summary>
        public static readonly EncryptionType CUSTOMER_MANAGED_KMS_KEY = new EncryptionType("CUSTOMER_MANAGED_KMS_KEY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyspaceStatus.
    /// </summary>
    public class KeyspaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for KeyspaceStatus
        /// </summary>
        public static readonly KeyspaceStatus ACTIVE = new KeyspaceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for KeyspaceStatus
        /// </summary>
        public static readonly KeyspaceStatus CREATING = new KeyspaceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for KeyspaceStatus
        /// </summary>
        public static readonly KeyspaceStatus DELETING = new KeyspaceStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for KeyspaceStatus
        /// </summary>
        public static readonly KeyspaceStatus UPDATING = new KeyspaceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyspaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyspaceStatus FindValue(string value)
        {
            return FindValue<KeyspaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyspaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PointInTimeRecoveryStatus.
    /// </summary>
    public class PointInTimeRecoveryStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for PointInTimeRecoveryStatus
        /// </summary>
        public static readonly PointInTimeRecoveryStatus DISABLED = new PointInTimeRecoveryStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for PointInTimeRecoveryStatus
        /// </summary>
        public static readonly PointInTimeRecoveryStatus ENABLED = new PointInTimeRecoveryStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PointInTimeRecoveryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PointInTimeRecoveryStatus FindValue(string value)
        {
            return FindValue<PointInTimeRecoveryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PointInTimeRecoveryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Rs.
    /// </summary>
    public class Rs : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_REGION for Rs
        /// </summary>
        public static readonly Rs MULTI_REGION = new Rs("MULTI_REGION");
        /// <summary>
        /// Constant SINGLE_REGION for Rs
        /// </summary>
        public static readonly Rs SINGLE_REGION = new Rs("SINGLE_REGION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Rs(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Rs FindValue(string value)
        {
            return FindValue<Rs>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Rs(string value)
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


    /// <summary>
    /// Constants used for properties of type TableStatus.
    /// </summary>
    public class TableStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TableStatus
        /// </summary>
        public static readonly TableStatus ACTIVE = new TableStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for TableStatus
        /// </summary>
        public static readonly TableStatus CREATING = new TableStatus("CREATING");
        /// <summary>
        /// Constant DELETED for TableStatus
        /// </summary>
        public static readonly TableStatus DELETED = new TableStatus("DELETED");
        /// <summary>
        /// Constant DELETING for TableStatus
        /// </summary>
        public static readonly TableStatus DELETING = new TableStatus("DELETING");
        /// <summary>
        /// Constant INACCESSIBLE_ENCRYPTION_CREDENTIALS for TableStatus
        /// </summary>
        public static readonly TableStatus INACCESSIBLE_ENCRYPTION_CREDENTIALS = new TableStatus("INACCESSIBLE_ENCRYPTION_CREDENTIALS");
        /// <summary>
        /// Constant RESTORING for TableStatus
        /// </summary>
        public static readonly TableStatus RESTORING = new TableStatus("RESTORING");
        /// <summary>
        /// Constant UPDATING for TableStatus
        /// </summary>
        public static readonly TableStatus UPDATING = new TableStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableStatus FindValue(string value)
        {
            return FindValue<TableStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThroughputMode.
    /// </summary>
    public class ThroughputMode : ConstantClass
    {

        /// <summary>
        /// Constant PAY_PER_REQUEST for ThroughputMode
        /// </summary>
        public static readonly ThroughputMode PAY_PER_REQUEST = new ThroughputMode("PAY_PER_REQUEST");
        /// <summary>
        /// Constant PROVISIONED for ThroughputMode
        /// </summary>
        public static readonly ThroughputMode PROVISIONED = new ThroughputMode("PROVISIONED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThroughputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThroughputMode FindValue(string value)
        {
            return FindValue<ThroughputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThroughputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TimeToLiveStatus.
    /// </summary>
    public class TimeToLiveStatus : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for TimeToLiveStatus
        /// </summary>
        public static readonly TimeToLiveStatus ENABLED = new TimeToLiveStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TimeToLiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TimeToLiveStatus FindValue(string value)
        {
            return FindValue<TimeToLiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TimeToLiveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TypeStatus.
    /// </summary>
    public class TypeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for TypeStatus
        /// </summary>
        public static readonly TypeStatus ACTIVE = new TypeStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for TypeStatus
        /// </summary>
        public static readonly TypeStatus CREATING = new TypeStatus("CREATING");
        /// <summary>
        /// Constant DELETING for TypeStatus
        /// </summary>
        public static readonly TypeStatus DELETING = new TypeStatus("DELETING");
        /// <summary>
        /// Constant RESTORING for TypeStatus
        /// </summary>
        public static readonly TypeStatus RESTORING = new TypeStatus("RESTORING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TypeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TypeStatus FindValue(string value)
        {
            return FindValue<TypeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TypeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ViewType.
    /// </summary>
    public class ViewType : ConstantClass
    {

        /// <summary>
        /// Constant KEYS_ONLY for ViewType
        /// </summary>
        public static readonly ViewType KEYS_ONLY = new ViewType("KEYS_ONLY");
        /// <summary>
        /// Constant NEW_AND_OLD_IMAGES for ViewType
        /// </summary>
        public static readonly ViewType NEW_AND_OLD_IMAGES = new ViewType("NEW_AND_OLD_IMAGES");
        /// <summary>
        /// Constant NEW_IMAGE for ViewType
        /// </summary>
        public static readonly ViewType NEW_IMAGE = new ViewType("NEW_IMAGE");
        /// <summary>
        /// Constant OLD_IMAGE for ViewType
        /// </summary>
        public static readonly ViewType OLD_IMAGE = new ViewType("OLD_IMAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ViewType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ViewType FindValue(string value)
        {
            return FindValue<ViewType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ViewType(string value)
        {
            return FindValue(value);
        }
    }

}