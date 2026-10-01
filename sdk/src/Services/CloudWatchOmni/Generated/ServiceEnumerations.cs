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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudWatchOmni
{

    /// <summary>
    /// Constants used for properties of type AccessGrantPermission.
    /// </summary>
    public class AccessGrantPermission : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOM for AccessGrantPermission
        /// </summary>
        public static readonly AccessGrantPermission CUSTOM = new AccessGrantPermission("CUSTOM");
        /// <summary>
        /// Constant READ for AccessGrantPermission
        /// </summary>
        public static readonly AccessGrantPermission READ = new AccessGrantPermission("READ");
        /// <summary>
        /// Constant READ_WRITE_DELETE for AccessGrantPermission
        /// </summary>
        public static readonly AccessGrantPermission READ_WRITE_DELETE = new AccessGrantPermission("READ_WRITE_DELETE");
        /// <summary>
        /// Constant SPACE_ADMIN for AccessGrantPermission
        /// </summary>
        public static readonly AccessGrantPermission SPACE_ADMIN = new AccessGrantPermission("SPACE_ADMIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessGrantPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessGrantPermission FindValue(string value)
        {
            return FindValue<AccessGrantPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessGrantPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessGrantPrincipalType.
    /// </summary>
    public class AccessGrantPrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESS_PROFILE for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType ACCESS_PROFILE = new AccessGrantPrincipalType("ACCESS_PROFILE");
        /// <summary>
        /// Constant AGENT for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType AGENT = new AccessGrantPrincipalType("AGENT");
        /// <summary>
        /// Constant ALERT for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType ALERT = new AccessGrantPrincipalType("ALERT");
        /// <summary>
        /// Constant IAM_ROLE for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType IAM_ROLE = new AccessGrantPrincipalType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_ROOT for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType IAM_ROOT = new AccessGrantPrincipalType("IAM_ROOT");
        /// <summary>
        /// Constant IAM_USER for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType IAM_USER = new AccessGrantPrincipalType("IAM_USER");
        /// <summary>
        /// Constant IDC_GROUP for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType IDC_GROUP = new AccessGrantPrincipalType("IDC_GROUP");
        /// <summary>
        /// Constant IDC_USER for AccessGrantPrincipalType
        /// </summary>
        public static readonly AccessGrantPrincipalType IDC_USER = new AccessGrantPrincipalType("IDC_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessGrantPrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessGrantPrincipalType FindValue(string value)
        {
            return FindValue<AccessGrantPrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessGrantPrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessGrantType.
    /// </summary>
    public class AccessGrantType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_MANAGED for AccessGrantType
        /// </summary>
        public static readonly AccessGrantType CUSTOMER_MANAGED = new AccessGrantType("CUSTOMER_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for AccessGrantType
        /// </summary>
        public static readonly AccessGrantType SERVICE_MANAGED = new AccessGrantType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessGrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessGrantType FindValue(string value)
        {
            return FindValue<AccessGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessGrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AccessProfileType.
    /// </summary>
    public class AccessProfileType : ConstantClass
    {

        /// <summary>
        /// Constant CUSTOMER_MANAGED for AccessProfileType
        /// </summary>
        public static readonly AccessProfileType CUSTOMER_MANAGED = new AccessProfileType("CUSTOMER_MANAGED");
        /// <summary>
        /// Constant SERVICE_MANAGED for AccessProfileType
        /// </summary>
        public static readonly AccessProfileType SERVICE_MANAGED = new AccessProfileType("SERVICE_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessProfileType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessProfileType FindValue(string value)
        {
            return FindValue<AccessProfileType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessProfileType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertSortField.
    /// </summary>
    public class AlertSortField : ConstantClass
    {

        /// <summary>
        /// Constant NAME for AlertSortField
        /// </summary>
        public static readonly AlertSortField NAME = new AlertSortField("NAME");
        /// <summary>
        /// Constant STATE for AlertSortField
        /// </summary>
        public static readonly AlertSortField STATE = new AlertSortField("STATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertSortField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertSortField FindValue(string value)
        {
            return FindValue<AlertSortField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertSortField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertSortOrder.
    /// </summary>
    public class AlertSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for AlertSortOrder
        /// </summary>
        public static readonly AlertSortOrder ASC = new AlertSortOrder("ASC");
        /// <summary>
        /// Constant DESC for AlertSortOrder
        /// </summary>
        public static readonly AlertSortOrder DESC = new AlertSortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertSortOrder FindValue(string value)
        {
            return FindValue<AlertSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertState.
    /// </summary>
    public class AlertState : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for AlertState
        /// </summary>
        public static readonly AlertState CRITICAL = new AlertState("CRITICAL");
        /// <summary>
        /// Constant NODATA for AlertState
        /// </summary>
        public static readonly AlertState NODATA = new AlertState("NODATA");
        /// <summary>
        /// Constant OK for AlertState
        /// </summary>
        public static readonly AlertState OK = new AlertState("OK");
        /// <summary>
        /// Constant WARNING for AlertState
        /// </summary>
        public static readonly AlertState WARNING = new AlertState("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertState FindValue(string value)
        {
            return FindValue<AlertState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssumeStatus.
    /// </summary>
    public class AssumeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ALLOWED for AssumeStatus
        /// </summary>
        public static readonly AssumeStatus ALLOWED = new AssumeStatus("ALLOWED");
        /// <summary>
        /// Constant DENIED for AssumeStatus
        /// </summary>
        public static readonly AssumeStatus DENIED = new AssumeStatus("DENIED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssumeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssumeStatus FindValue(string value)
        {
            return FindValue<AssumeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssumeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthType.
    /// </summary>
    public class AuthType : ConstantClass
    {

        /// <summary>
        /// Constant API_KEY for AuthType
        /// </summary>
        public static readonly AuthType API_KEY = new AuthType("API_KEY");
        /// <summary>
        /// Constant NONE for AuthType
        /// </summary>
        public static readonly AuthType NONE = new AuthType("NONE");
        /// <summary>
        /// Constant OAUTH2 for AuthType
        /// </summary>
        public static readonly AuthType OAUTH2 = new AuthType("OAUTH2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthType FindValue(string value)
        {
            return FindValue<AuthType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Comparator.
    /// </summary>
    public class Comparator : ConstantClass
    {

        /// <summary>
        /// Constant GT for Comparator
        /// </summary>
        public static readonly Comparator GT = new Comparator("GT");
        /// <summary>
        /// Constant GTE for Comparator
        /// </summary>
        public static readonly Comparator GTE = new Comparator("GTE");
        /// <summary>
        /// Constant LT for Comparator
        /// </summary>
        public static readonly Comparator LT = new Comparator("LT");
        /// <summary>
        /// Constant LTE for Comparator
        /// </summary>
        public static readonly Comparator LTE = new Comparator("LTE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Comparator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Comparator FindValue(string value)
        {
            return FindValue<Comparator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Comparator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DomainStatus.
    /// </summary>
    public class DomainStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DomainStatus
        /// </summary>
        public static readonly DomainStatus ACTIVE = new DomainStatus("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DomainStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DomainStatus FindValue(string value)
        {
            return FindValue<DomainStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DomainStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EdgeType.
    /// </summary>
    public class EdgeType : ConstantClass
    {

        /// <summary>
        /// Constant ACCESSES for EdgeType
        /// </summary>
        public static readonly EdgeType ACCESSES = new EdgeType("ACCESSES");
        /// <summary>
        /// Constant CALLS for EdgeType
        /// </summary>
        public static readonly EdgeType CALLS = new EdgeType("CALLS");
        /// <summary>
        /// Constant RUNS_ON for EdgeType
        /// </summary>
        public static readonly EdgeType RUNS_ON = new EdgeType("RUNS_ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EdgeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EdgeType FindValue(string value)
        {
            return FindValue<EdgeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EdgeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionStrategy.
    /// </summary>
    public class EncryptionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED for EncryptionStrategy
        /// </summary>
        public static readonly EncryptionStrategy AWS_OWNED = new EncryptionStrategy("AWS_OWNED");
        /// <summary>
        /// Constant CUSTOMER_MANAGED for EncryptionStrategy
        /// </summary>
        public static readonly EncryptionStrategy CUSTOMER_MANAGED = new EncryptionStrategy("CUSTOMER_MANAGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionStrategy FindValue(string value)
        {
            return FindValue<EncryptionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IdentityProvider.
    /// </summary>
    public class IdentityProvider : ConstantClass
    {

        /// <summary>
        /// Constant IAM for IdentityProvider
        /// </summary>
        public static readonly IdentityProvider IAM = new IdentityProvider("IAM");
        /// <summary>
        /// Constant IDC for IdentityProvider
        /// </summary>
        public static readonly IdentityProvider IDC = new IdentityProvider("IDC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IdentityProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityProvider FindValue(string value)
        {
            return FindValue<IdentityProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IdentityProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationStatus.
    /// </summary>
    public class IntegrationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus ACTIVE = new IntegrationStatus("ACTIVE");
        /// <summary>
        /// Constant DELETED for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus DELETED = new IntegrationStatus("DELETED");
        /// <summary>
        /// Constant ERROR for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus ERROR = new IntegrationStatus("ERROR");
        /// <summary>
        /// Constant FAILED for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus FAILED = new IntegrationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus PENDING = new IntegrationStatus("PENDING");
        /// <summary>
        /// Constant PENDING_OAUTH for IntegrationStatus
        /// </summary>
        public static readonly IntegrationStatus PENDING_OAUTH = new IntegrationStatus("PENDING_OAUTH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationStatus FindValue(string value)
        {
            return FindValue<IntegrationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_CONFIG_SLREC for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS_CONFIG_SLREC = new IntegrationType("AWS_CONFIG_SLREC");
        /// <summary>
        /// Constant AWS_INTEGRATION for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS_INTEGRATION = new IntegrationType("AWS_INTEGRATION");
        /// <summary>
        /// Constant EXTERNAL_AGENT for IntegrationType
        /// </summary>
        public static readonly IntegrationType EXTERNAL_AGENT = new IntegrationType("EXTERNAL_AGENT");
        /// <summary>
        /// Constant SLACK for IntegrationType
        /// </summary>
        public static readonly IntegrationType SLACK = new IntegrationType("SLACK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeCategory.
    /// </summary>
    public class NodeCategory : ConstantClass
    {

        /// <summary>
        /// Constant COMPUTE for NodeCategory
        /// </summary>
        public static readonly NodeCategory COMPUTE = new NodeCategory("COMPUTE");
        /// <summary>
        /// Constant DATABASE for NodeCategory
        /// </summary>
        public static readonly NodeCategory DATABASE = new NodeCategory("DATABASE");
        /// <summary>
        /// Constant GEN_AI_AGENT for NodeCategory
        /// </summary>
        public static readonly NodeCategory GEN_AI_AGENT = new NodeCategory("GEN_AI_AGENT");
        /// <summary>
        /// Constant GEN_AI_MODEL for NodeCategory
        /// </summary>
        public static readonly NodeCategory GEN_AI_MODEL = new NodeCategory("GEN_AI_MODEL");
        /// <summary>
        /// Constant MESSAGING_QUEUE for NodeCategory
        /// </summary>
        public static readonly NodeCategory MESSAGING_QUEUE = new NodeCategory("MESSAGING_QUEUE");
        /// <summary>
        /// Constant NETWORK for NodeCategory
        /// </summary>
        public static readonly NodeCategory NETWORK = new NodeCategory("NETWORK");
        /// <summary>
        /// Constant STORAGE for NodeCategory
        /// </summary>
        public static readonly NodeCategory STORAGE = new NodeCategory("STORAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeCategory FindValue(string value)
        {
            return FindValue<NodeCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodeType.
    /// </summary>
    public class NodeType : ConstantClass
    {

        /// <summary>
        /// Constant REMOTE_SERVICE for NodeType
        /// </summary>
        public static readonly NodeType REMOTE_SERVICE = new NodeType("REMOTE_SERVICE");
        /// <summary>
        /// Constant RESOURCE for NodeType
        /// </summary>
        public static readonly NodeType RESOURCE = new NodeType("RESOURCE");
        /// <summary>
        /// Constant SERVICE for NodeType
        /// </summary>
        public static readonly NodeType SERVICE = new NodeType("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodeType FindValue(string value)
        {
            return FindValue<NodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationStatus.
    /// </summary>
    public class NotificationStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for NotificationStatus
        /// </summary>
        public static readonly NotificationStatus DISABLED = new NotificationStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for NotificationStatus
        /// </summary>
        public static readonly NotificationStatus ENABLED = new NotificationStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationStatus FindValue(string value)
        {
            return FindValue<NotificationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotificationTargetType.
    /// </summary>
    public class NotificationTargetType : ConstantClass
    {

        /// <summary>
        /// Constant Pagerduty for NotificationTargetType
        /// </summary>
        public static readonly NotificationTargetType Pagerduty = new NotificationTargetType("pagerduty");
        /// <summary>
        /// Constant Slack for NotificationTargetType
        /// </summary>
        public static readonly NotificationTargetType Slack = new NotificationTargetType("slack");
        /// <summary>
        /// Constant Sns for NotificationTargetType
        /// </summary>
        public static readonly NotificationTargetType Sns = new NotificationTargetType("sns");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotificationTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationTargetType FindValue(string value)
        {
            return FindValue<NotificationTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotificationTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationCredentialType.
    /// </summary>
    public class OrganizationCredentialType : ConstantClass
    {

        /// <summary>
        /// Constant SPACE_OPERATION for OrganizationCredentialType
        /// </summary>
        public static readonly OrganizationCredentialType SPACE_OPERATION = new OrganizationCredentialType("SPACE_OPERATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationCredentialType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationCredentialType FindValue(string value)
        {
            return FindValue<OrganizationCredentialType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationCredentialType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationGrantPermission.
    /// </summary>
    public class OrganizationGrantPermission : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for OrganizationGrantPermission
        /// </summary>
        public static readonly OrganizationGrantPermission ADMIN = new OrganizationGrantPermission("ADMIN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationGrantPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationGrantPermission FindValue(string value)
        {
            return FindValue<OrganizationGrantPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationGrantPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrganizationGrantPrincipalType.
    /// </summary>
    public class OrganizationGrantPrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant IAM_ROLE for OrganizationGrantPrincipalType
        /// </summary>
        public static readonly OrganizationGrantPrincipalType IAM_ROLE = new OrganizationGrantPrincipalType("IAM_ROLE");
        /// <summary>
        /// Constant IAM_ROOT for OrganizationGrantPrincipalType
        /// </summary>
        public static readonly OrganizationGrantPrincipalType IAM_ROOT = new OrganizationGrantPrincipalType("IAM_ROOT");
        /// <summary>
        /// Constant IAM_USER for OrganizationGrantPrincipalType
        /// </summary>
        public static readonly OrganizationGrantPrincipalType IAM_USER = new OrganizationGrantPrincipalType("IAM_USER");
        /// <summary>
        /// Constant IDC_GROUP for OrganizationGrantPrincipalType
        /// </summary>
        public static readonly OrganizationGrantPrincipalType IDC_GROUP = new OrganizationGrantPrincipalType("IDC_GROUP");
        /// <summary>
        /// Constant IDC_USER for OrganizationGrantPrincipalType
        /// </summary>
        public static readonly OrganizationGrantPrincipalType IDC_USER = new OrganizationGrantPrincipalType("IDC_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrganizationGrantPrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrganizationGrantPrincipalType FindValue(string value)
        {
            return FindValue<OrganizationGrantPrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrganizationGrantPrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryLanguage.
    /// </summary>
    public class QueryLanguage : ConstantClass
    {

        /// <summary>
        /// Constant PROMQL for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage PROMQL = new QueryLanguage("PROMQL");
        /// <summary>
        /// Constant SQL for QueryLanguage
        /// </summary>
        public static readonly QueryLanguage SQL = new QueryLanguage("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryLanguage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryLanguage FindValue(string value)
        {
            return FindValue<QueryLanguage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryLanguage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryStatus.
    /// </summary>
    public class QueryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for QueryStatus
        /// </summary>
        public static readonly QueryStatus Cancelled = new QueryStatus("Cancelled");
        /// <summary>
        /// Constant Complete for QueryStatus
        /// </summary>
        public static readonly QueryStatus Complete = new QueryStatus("Complete");
        /// <summary>
        /// Constant Failed for QueryStatus
        /// </summary>
        public static readonly QueryStatus Failed = new QueryStatus("Failed");
        /// <summary>
        /// Constant Running for QueryStatus
        /// </summary>
        public static readonly QueryStatus Running = new QueryStatus("Running");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryStatus FindValue(string value)
        {
            return FindValue<QueryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RowScopeOperator.
    /// </summary>
    public class RowScopeOperator : ConstantClass
    {

        /// <summary>
        /// Constant IN for RowScopeOperator
        /// </summary>
        public static readonly RowScopeOperator IN = new RowScopeOperator("IN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RowScopeOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RowScopeOperator FindValue(string value)
        {
            return FindValue<RowScopeOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RowScopeOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Scope.
    /// </summary>
    public class Scope : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for Scope
        /// </summary>
        public static readonly Scope ACCOUNT = new Scope("ACCOUNT");
        /// <summary>
        /// Constant ORGANIZATION for Scope
        /// </summary>
        public static readonly Scope ORGANIZATION = new Scope("ORGANIZATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Scope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Scope FindValue(string value)
        {
            return FindValue<Scope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Scope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Signal.
    /// </summary>
    public class Signal : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG for Signal
        /// </summary>
        public static readonly Signal CONFIG = new Signal("CONFIG");
        /// <summary>
        /// Constant LOGS for Signal
        /// </summary>
        public static readonly Signal LOGS = new Signal("LOGS");
        /// <summary>
        /// Constant METRICS for Signal
        /// </summary>
        public static readonly Signal METRICS = new Signal("METRICS");
        /// <summary>
        /// Constant TRACES for Signal
        /// </summary>
        public static readonly Signal TRACES = new Signal("TRACES");
        /// <summary>
        /// Constant UNKNOWN for Signal
        /// </summary>
        public static readonly Signal UNKNOWN = new Signal("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Signal(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Signal FindValue(string value)
        {
            return FindValue<Signal>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Signal(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignalType.
    /// </summary>
    public class SignalType : ConstantClass
    {

        /// <summary>
        /// Constant LOGS for SignalType
        /// </summary>
        public static readonly SignalType LOGS = new SignalType("LOGS");
        /// <summary>
        /// Constant TRACES for SignalType
        /// </summary>
        public static readonly SignalType TRACES = new SignalType("TRACES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignalType FindValue(string value)
        {
            return FindValue<SignalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Source.
    /// </summary>
    public class Source : ConstantClass
    {

        /// <summary>
        /// Constant AWS_INTEGRATION for Source
        /// </summary>
        public static readonly Source AWS_INTEGRATION = new Source("AWS_INTEGRATION");
        /// <summary>
        /// Constant AZURE_VNET_FLOW_LOG for Source
        /// </summary>
        public static readonly Source AZURE_VNET_FLOW_LOG = new Source("AZURE_VNET_FLOW_LOG");
        /// <summary>
        /// Constant CLOUDFRONT_ACCESS_LOG for Source
        /// </summary>
        public static readonly Source CLOUDFRONT_ACCESS_LOG = new Source("CLOUDFRONT_ACCESS_LOG");
        /// <summary>
        /// Constant CLOUDTRAIL for Source
        /// </summary>
        public static readonly Source CLOUDTRAIL = new Source("CLOUDTRAIL");
        /// <summary>
        /// Constant CODE_SEMANTICS for Source
        /// </summary>
        public static readonly Source CODE_SEMANTICS = new Source("CODE_SEMANTICS");
        /// <summary>
        /// Constant CONFIG for Source
        /// </summary>
        public static readonly Source CONFIG = new Source("CONFIG");
        /// <summary>
        /// Constant ELB_ACCESS_LOG for Source
        /// </summary>
        public static readonly Source ELB_ACCESS_LOG = new Source("ELB_ACCESS_LOG");
        /// <summary>
        /// Constant IAM_POLICY for Source
        /// </summary>
        public static readonly Source IAM_POLICY = new Source("IAM_POLICY");
        /// <summary>
        /// Constant S3_ACCESS_LOG for Source
        /// </summary>
        public static readonly Source S3_ACCESS_LOG = new Source("S3_ACCESS_LOG");
        /// <summary>
        /// Constant TELEMETRY for Source
        /// </summary>
        public static readonly Source TELEMETRY = new Source("TELEMETRY");
        /// <summary>
        /// Constant VPC_FLOW_LOG for Source
        /// </summary>
        public static readonly Source VPC_FLOW_LOG = new Source("VPC_FLOW_LOG");
        /// <summary>
        /// Constant WAF_ACCESS_LOG for Source
        /// </summary>
        public static readonly Source WAF_ACCESS_LOG = new Source("WAF_ACCESS_LOG");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Source(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Source FindValue(string value)
        {
            return FindValue<Source>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Source(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SpaceStatus.
    /// </summary>
    public class SpaceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus ACTIVE = new SpaceStatus("ACTIVE");
        /// <summary>
        /// Constant MOVING for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus MOVING = new SpaceStatus("MOVING");
        /// <summary>
        /// Constant SUSPENDED for SpaceStatus
        /// </summary>
        public static readonly SpaceStatus SUSPENDED = new SpaceStatus("SUSPENDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SpaceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SpaceStatus FindValue(string value)
        {
            return FindValue<SpaceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SpaceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TelemetryType.
    /// </summary>
    public class TelemetryType : ConstantClass
    {

        /// <summary>
        /// Constant LOGS for TelemetryType
        /// </summary>
        public static readonly TelemetryType LOGS = new TelemetryType("LOGS");
        /// <summary>
        /// Constant TRACES for TelemetryType
        /// </summary>
        public static readonly TelemetryType TRACES = new TelemetryType("TRACES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TelemetryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TelemetryType FindValue(string value)
        {
            return FindValue<TelemetryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TelemetryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThresholdMode.
    /// </summary>
    public class ThresholdMode : ConstantClass
    {

        /// <summary>
        /// Constant COUNT_OF_RESULTS for ThresholdMode
        /// </summary>
        public static readonly ThresholdMode COUNT_OF_RESULTS = new ThresholdMode("COUNT_OF_RESULTS");
        /// <summary>
        /// Constant FIELD_VALUE for ThresholdMode
        /// </summary>
        public static readonly ThresholdMode FIELD_VALUE = new ThresholdMode("FIELD_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThresholdMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThresholdMode FindValue(string value)
        {
            return FindValue<ThresholdMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThresholdMode(string value)
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
        /// Constant MANAGED for ViewType
        /// </summary>
        public static readonly ViewType MANAGED = new ViewType("MANAGED");
        /// <summary>
        /// Constant USER for ViewType
        /// </summary>
        public static readonly ViewType USER = new ViewType("USER");

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