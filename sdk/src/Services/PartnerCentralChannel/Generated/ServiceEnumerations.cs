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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PartnerCentralChannel
{

    /// <summary>
    /// Constants used for properties of type AssociationType.
    /// </summary>
    public class AssociationType : ConstantClass
    {

        /// <summary>
        /// Constant DOWNSTREAM_SELLER for AssociationType
        /// </summary>
        public static readonly AssociationType DOWNSTREAM_SELLER = new AssociationType("DOWNSTREAM_SELLER");
        /// <summary>
        /// Constant END_CUSTOMER for AssociationType
        /// </summary>
        public static readonly AssociationType END_CUSTOMER = new AssociationType("END_CUSTOMER");
        /// <summary>
        /// Constant INTERNAL for AssociationType
        /// </summary>
        public static readonly AssociationType INTERNAL = new AssociationType("INTERNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssociationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationType FindValue(string value)
        {
            return FindValue<AssociationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Coverage.
    /// </summary>
    public class Coverage : ConstantClass
    {

        /// <summary>
        /// Constant ENTIRE_ORGANIZATION for Coverage
        /// </summary>
        public static readonly Coverage ENTIRE_ORGANIZATION = new Coverage("ENTIRE_ORGANIZATION");
        /// <summary>
        /// Constant MANAGEMENT_ACCOUNT_ONLY for Coverage
        /// </summary>
        public static readonly Coverage MANAGEMENT_ACCOUNT_ONLY = new Coverage("MANAGEMENT_ACCOUNT_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Coverage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Coverage FindValue(string value)
        {
            return FindValue<Coverage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Coverage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakeStatus.
    /// </summary>
    public class HandshakeStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for HandshakeStatus
        /// </summary>
        public static readonly HandshakeStatus ACCEPTED = new HandshakeStatus("ACCEPTED");
        /// <summary>
        /// Constant CANCELED for HandshakeStatus
        /// </summary>
        public static readonly HandshakeStatus CANCELED = new HandshakeStatus("CANCELED");
        /// <summary>
        /// Constant EXPIRED for HandshakeStatus
        /// </summary>
        public static readonly HandshakeStatus EXPIRED = new HandshakeStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for HandshakeStatus
        /// </summary>
        public static readonly HandshakeStatus PENDING = new HandshakeStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for HandshakeStatus
        /// </summary>
        public static readonly HandshakeStatus REJECTED = new HandshakeStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakeStatus FindValue(string value)
        {
            return FindValue<HandshakeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HandshakeType.
    /// </summary>
    public class HandshakeType : ConstantClass
    {

        /// <summary>
        /// Constant PROGRAM_MANAGEMENT_ACCOUNT for HandshakeType
        /// </summary>
        public static readonly HandshakeType PROGRAM_MANAGEMENT_ACCOUNT = new HandshakeType("PROGRAM_MANAGEMENT_ACCOUNT");
        /// <summary>
        /// Constant REVOKE_SERVICE_PERIOD for HandshakeType
        /// </summary>
        public static readonly HandshakeType REVOKE_SERVICE_PERIOD = new HandshakeType("REVOKE_SERVICE_PERIOD");
        /// <summary>
        /// Constant START_SERVICE_PERIOD for HandshakeType
        /// </summary>
        public static readonly HandshakeType START_SERVICE_PERIOD = new HandshakeType("START_SERVICE_PERIOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HandshakeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HandshakeType FindValue(string value)
        {
            return FindValue<HandshakeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HandshakeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListProgramManagementAccountsSortName.
    /// </summary>
    public class ListProgramManagementAccountsSortName : ConstantClass
    {

        /// <summary>
        /// Constant UpdatedAt for ListProgramManagementAccountsSortName
        /// </summary>
        public static readonly ListProgramManagementAccountsSortName UpdatedAt = new ListProgramManagementAccountsSortName("UpdatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListProgramManagementAccountsSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListProgramManagementAccountsSortName FindValue(string value)
        {
            return FindValue<ListProgramManagementAccountsSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListProgramManagementAccountsSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListRelationshipsSortName.
    /// </summary>
    public class ListRelationshipsSortName : ConstantClass
    {

        /// <summary>
        /// Constant UpdatedAt for ListRelationshipsSortName
        /// </summary>
        public static readonly ListRelationshipsSortName UpdatedAt = new ListRelationshipsSortName("UpdatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListRelationshipsSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListRelationshipsSortName FindValue(string value)
        {
            return FindValue<ListRelationshipsSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListRelationshipsSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantType.
    /// </summary>
    public class ParticipantType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVER for ParticipantType
        /// </summary>
        public static readonly ParticipantType RECEIVER = new ParticipantType("RECEIVER");
        /// <summary>
        /// Constant SENDER for ParticipantType
        /// </summary>
        public static readonly ParticipantType SENDER = new ParticipantType("SENDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantType FindValue(string value)
        {
            return FindValue<ParticipantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Program.
    /// </summary>
    public class Program : ConstantClass
    {

        /// <summary>
        /// Constant DISTRIBUTION for Program
        /// </summary>
        public static readonly Program DISTRIBUTION = new Program("DISTRIBUTION");
        /// <summary>
        /// Constant DISTRIBUTION_SELLER for Program
        /// </summary>
        public static readonly Program DISTRIBUTION_SELLER = new Program("DISTRIBUTION_SELLER");
        /// <summary>
        /// Constant SOLUTION_PROVIDER for Program
        /// </summary>
        public static readonly Program SOLUTION_PROVIDER = new Program("SOLUTION_PROVIDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Program(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Program FindValue(string value)
        {
            return FindValue<Program>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Program(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProgramManagementAccountStatus.
    /// </summary>
    public class ProgramManagementAccountStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ProgramManagementAccountStatus
        /// </summary>
        public static readonly ProgramManagementAccountStatus ACTIVE = new ProgramManagementAccountStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for ProgramManagementAccountStatus
        /// </summary>
        public static readonly ProgramManagementAccountStatus INACTIVE = new ProgramManagementAccountStatus("INACTIVE");
        /// <summary>
        /// Constant PENDING for ProgramManagementAccountStatus
        /// </summary>
        public static readonly ProgramManagementAccountStatus PENDING = new ProgramManagementAccountStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProgramManagementAccountStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProgramManagementAccountStatus FindValue(string value)
        {
            return FindValue<ProgramManagementAccountStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProgramManagementAccountStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProgramManagementAccountTypeSortName.
    /// </summary>
    public class ProgramManagementAccountTypeSortName : ConstantClass
    {

        /// <summary>
        /// Constant UpdatedAt for ProgramManagementAccountTypeSortName
        /// </summary>
        public static readonly ProgramManagementAccountTypeSortName UpdatedAt = new ProgramManagementAccountTypeSortName("UpdatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProgramManagementAccountTypeSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProgramManagementAccountTypeSortName FindValue(string value)
        {
            return FindValue<ProgramManagementAccountTypeSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProgramManagementAccountTypeSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Provider.
    /// </summary>
    public class Provider : ConstantClass
    {

        /// <summary>
        /// Constant DISTRIBUTION_SELLER for Provider
        /// </summary>
        public static readonly Provider DISTRIBUTION_SELLER = new Provider("DISTRIBUTION_SELLER");
        /// <summary>
        /// Constant DISTRIBUTOR for Provider
        /// </summary>
        public static readonly Provider DISTRIBUTOR = new Provider("DISTRIBUTOR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Provider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Provider FindValue(string value)
        {
            return FindValue<Provider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Provider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResaleAccountModel.
    /// </summary>
    public class ResaleAccountModel : ConstantClass
    {

        /// <summary>
        /// Constant DISTRIBUTOR for ResaleAccountModel
        /// </summary>
        public static readonly ResaleAccountModel DISTRIBUTOR = new ResaleAccountModel("DISTRIBUTOR");
        /// <summary>
        /// Constant END_CUSTOMER for ResaleAccountModel
        /// </summary>
        public static readonly ResaleAccountModel END_CUSTOMER = new ResaleAccountModel("END_CUSTOMER");
        /// <summary>
        /// Constant SOLUTION_PROVIDER for ResaleAccountModel
        /// </summary>
        public static readonly ResaleAccountModel SOLUTION_PROVIDER = new ResaleAccountModel("SOLUTION_PROVIDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResaleAccountModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResaleAccountModel FindValue(string value)
        {
            return FindValue<ResaleAccountModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResaleAccountModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RevokeServicePeriodTypeSortName.
    /// </summary>
    public class RevokeServicePeriodTypeSortName : ConstantClass
    {

        /// <summary>
        /// Constant UpdatedAt for RevokeServicePeriodTypeSortName
        /// </summary>
        public static readonly RevokeServicePeriodTypeSortName UpdatedAt = new RevokeServicePeriodTypeSortName("UpdatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevokeServicePeriodTypeSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevokeServicePeriodTypeSortName FindValue(string value)
        {
            return FindValue<RevokeServicePeriodTypeSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevokeServicePeriodTypeSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Sector.
    /// </summary>
    public class Sector : ConstantClass
    {

        /// <summary>
        /// Constant COMMERCIAL for Sector
        /// </summary>
        public static readonly Sector COMMERCIAL = new Sector("COMMERCIAL");
        /// <summary>
        /// Constant GOVERNMENT for Sector
        /// </summary>
        public static readonly Sector GOVERNMENT = new Sector("GOVERNMENT");
        /// <summary>
        /// Constant GOVERNMENT_EXCEPTION for Sector
        /// </summary>
        public static readonly Sector GOVERNMENT_EXCEPTION = new Sector("GOVERNMENT_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Sector(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Sector FindValue(string value)
        {
            return FindValue<Sector>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Sector(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServicePeriodType.
    /// </summary>
    public class ServicePeriodType : ConstantClass
    {

        /// <summary>
        /// Constant FIXED_COMMITMENT_PERIOD for ServicePeriodType
        /// </summary>
        public static readonly ServicePeriodType FIXED_COMMITMENT_PERIOD = new ServicePeriodType("FIXED_COMMITMENT_PERIOD");
        /// <summary>
        /// Constant MINIMUM_NOTICE_PERIOD for ServicePeriodType
        /// </summary>
        public static readonly ServicePeriodType MINIMUM_NOTICE_PERIOD = new ServicePeriodType("MINIMUM_NOTICE_PERIOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServicePeriodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServicePeriodType FindValue(string value)
        {
            return FindValue<ServicePeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServicePeriodType(string value)
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
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

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
    /// Constants used for properties of type StartServicePeriodTypeSortName.
    /// </summary>
    public class StartServicePeriodTypeSortName : ConstantClass
    {

        /// <summary>
        /// Constant UpdatedAt for StartServicePeriodTypeSortName
        /// </summary>
        public static readonly StartServicePeriodTypeSortName UpdatedAt = new StartServicePeriodTypeSortName("UpdatedAt");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StartServicePeriodTypeSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StartServicePeriodTypeSortName FindValue(string value)
        {
            return FindValue<StartServicePeriodTypeSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StartServicePeriodTypeSortName(string value)
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
        /// Constant BUSINESS_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BUSINESS_VALIDATION_FAILED = new ValidationExceptionReason("BUSINESS_VALIDATION_FAILED");
        /// <summary>
        /// Constant REQUEST_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REQUEST_VALIDATION_FAILED = new ValidationExceptionReason("REQUEST_VALIDATION_FAILED");

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