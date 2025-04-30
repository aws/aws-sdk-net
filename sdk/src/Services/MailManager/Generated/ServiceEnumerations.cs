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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MailManager
{

    /// <summary>
    /// Constants used for properties of type AcceptAction.
    /// </summary>
    public class AcceptAction : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for AcceptAction
        /// </summary>
        public static readonly AcceptAction ALLOW = new AcceptAction("ALLOW");
        /// <summary>
        /// Constant DENY for AcceptAction
        /// </summary>
        public static readonly AcceptAction DENY = new AcceptAction("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AcceptAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AcceptAction FindValue(string value)
        {
            return FindValue<AcceptAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AcceptAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionFailurePolicy.
    /// </summary>
    public class ActionFailurePolicy : ConstantClass
    {

        /// <summary>
        /// Constant CONTINUE for ActionFailurePolicy
        /// </summary>
        public static readonly ActionFailurePolicy CONTINUE = new ActionFailurePolicy("CONTINUE");
        /// <summary>
        /// Constant DROP for ActionFailurePolicy
        /// </summary>
        public static readonly ActionFailurePolicy DROP = new ActionFailurePolicy("DROP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionFailurePolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionFailurePolicy FindValue(string value)
        {
            return FindValue<ActionFailurePolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionFailurePolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveBooleanEmailAttribute.
    /// </summary>
    public class ArchiveBooleanEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant HAS_ATTACHMENTS for ArchiveBooleanEmailAttribute
        /// </summary>
        public static readonly ArchiveBooleanEmailAttribute HAS_ATTACHMENTS = new ArchiveBooleanEmailAttribute("HAS_ATTACHMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveBooleanEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveBooleanEmailAttribute FindValue(string value)
        {
            return FindValue<ArchiveBooleanEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveBooleanEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveBooleanOperator.
    /// </summary>
    public class ArchiveBooleanOperator : ConstantClass
    {

        /// <summary>
        /// Constant IS_FALSE for ArchiveBooleanOperator
        /// </summary>
        public static readonly ArchiveBooleanOperator IS_FALSE = new ArchiveBooleanOperator("IS_FALSE");
        /// <summary>
        /// Constant IS_TRUE for ArchiveBooleanOperator
        /// </summary>
        public static readonly ArchiveBooleanOperator IS_TRUE = new ArchiveBooleanOperator("IS_TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveBooleanOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveBooleanOperator FindValue(string value)
        {
            return FindValue<ArchiveBooleanOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveBooleanOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveState.
    /// </summary>
    public class ArchiveState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ArchiveState
        /// </summary>
        public static readonly ArchiveState ACTIVE = new ArchiveState("ACTIVE");
        /// <summary>
        /// Constant PENDING_DELETION for ArchiveState
        /// </summary>
        public static readonly ArchiveState PENDING_DELETION = new ArchiveState("PENDING_DELETION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveState FindValue(string value)
        {
            return FindValue<ArchiveState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveStringEmailAttribute.
    /// </summary>
    public class ArchiveStringEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CC for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute CC = new ArchiveStringEmailAttribute("CC");
        /// <summary>
        /// Constant ENVELOPE_FROM for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute ENVELOPE_FROM = new ArchiveStringEmailAttribute("ENVELOPE_FROM");
        /// <summary>
        /// Constant ENVELOPE_TO for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute ENVELOPE_TO = new ArchiveStringEmailAttribute("ENVELOPE_TO");
        /// <summary>
        /// Constant FROM for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute FROM = new ArchiveStringEmailAttribute("FROM");
        /// <summary>
        /// Constant SUBJECT for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute SUBJECT = new ArchiveStringEmailAttribute("SUBJECT");
        /// <summary>
        /// Constant TO for ArchiveStringEmailAttribute
        /// </summary>
        public static readonly ArchiveStringEmailAttribute TO = new ArchiveStringEmailAttribute("TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveStringEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveStringEmailAttribute FindValue(string value)
        {
            return FindValue<ArchiveStringEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveStringEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveStringOperator.
    /// </summary>
    public class ArchiveStringOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for ArchiveStringOperator
        /// </summary>
        public static readonly ArchiveStringOperator CONTAINS = new ArchiveStringOperator("CONTAINS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveStringOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveStringOperator FindValue(string value)
        {
            return FindValue<ArchiveStringOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveStringOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExportState.
    /// </summary>
    public class ExportState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for ExportState
        /// </summary>
        public static readonly ExportState CANCELLED = new ExportState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for ExportState
        /// </summary>
        public static readonly ExportState COMPLETED = new ExportState("COMPLETED");
        /// <summary>
        /// Constant FAILED for ExportState
        /// </summary>
        public static readonly ExportState FAILED = new ExportState("FAILED");
        /// <summary>
        /// Constant PREPROCESSING for ExportState
        /// </summary>
        public static readonly ExportState PREPROCESSING = new ExportState("PREPROCESSING");
        /// <summary>
        /// Constant PROCESSING for ExportState
        /// </summary>
        public static readonly ExportState PROCESSING = new ExportState("PROCESSING");
        /// <summary>
        /// Constant QUEUED for ExportState
        /// </summary>
        public static readonly ExportState QUEUED = new ExportState("QUEUED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExportState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExportState FindValue(string value)
        {
            return FindValue<ExportState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExportState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportDataType.
    /// </summary>
    public class ImportDataType : ConstantClass
    {

        /// <summary>
        /// Constant CSV for ImportDataType
        /// </summary>
        public static readonly ImportDataType CSV = new ImportDataType("CSV");
        /// <summary>
        /// Constant JSON for ImportDataType
        /// </summary>
        public static readonly ImportDataType JSON = new ImportDataType("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportDataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportDataType FindValue(string value)
        {
            return FindValue<ImportDataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportDataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImportJobStatus.
    /// </summary>
    public class ImportJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus COMPLETED = new ImportJobStatus("COMPLETED");
        /// <summary>
        /// Constant CREATED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus CREATED = new ImportJobStatus("CREATED");
        /// <summary>
        /// Constant FAILED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus FAILED = new ImportJobStatus("FAILED");
        /// <summary>
        /// Constant PROCESSING for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus PROCESSING = new ImportJobStatus("PROCESSING");
        /// <summary>
        /// Constant STOPPED for ImportJobStatus
        /// </summary>
        public static readonly ImportJobStatus STOPPED = new ImportJobStatus("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportJobStatus FindValue(string value)
        {
            return FindValue<ImportJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressAddressListEmailAttribute.
    /// </summary>
    public class IngressAddressListEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant RECIPIENT for IngressAddressListEmailAttribute
        /// </summary>
        public static readonly IngressAddressListEmailAttribute RECIPIENT = new IngressAddressListEmailAttribute("RECIPIENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressAddressListEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressAddressListEmailAttribute FindValue(string value)
        {
            return FindValue<IngressAddressListEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressAddressListEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressBooleanOperator.
    /// </summary>
    public class IngressBooleanOperator : ConstantClass
    {

        /// <summary>
        /// Constant IS_FALSE for IngressBooleanOperator
        /// </summary>
        public static readonly IngressBooleanOperator IS_FALSE = new IngressBooleanOperator("IS_FALSE");
        /// <summary>
        /// Constant IS_TRUE for IngressBooleanOperator
        /// </summary>
        public static readonly IngressBooleanOperator IS_TRUE = new IngressBooleanOperator("IS_TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressBooleanOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressBooleanOperator FindValue(string value)
        {
            return FindValue<IngressBooleanOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressBooleanOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressIpOperator.
    /// </summary>
    public class IngressIpOperator : ConstantClass
    {

        /// <summary>
        /// Constant CIDR_MATCHES for IngressIpOperator
        /// </summary>
        public static readonly IngressIpOperator CIDR_MATCHES = new IngressIpOperator("CIDR_MATCHES");
        /// <summary>
        /// Constant NOT_CIDR_MATCHES for IngressIpOperator
        /// </summary>
        public static readonly IngressIpOperator NOT_CIDR_MATCHES = new IngressIpOperator("NOT_CIDR_MATCHES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressIpOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressIpOperator FindValue(string value)
        {
            return FindValue<IngressIpOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressIpOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressIpv4Attribute.
    /// </summary>
    public class IngressIpv4Attribute : ConstantClass
    {

        /// <summary>
        /// Constant SENDER_IP for IngressIpv4Attribute
        /// </summary>
        public static readonly IngressIpv4Attribute SENDER_IP = new IngressIpv4Attribute("SENDER_IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressIpv4Attribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressIpv4Attribute FindValue(string value)
        {
            return FindValue<IngressIpv4Attribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressIpv4Attribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressIpv6Attribute.
    /// </summary>
    public class IngressIpv6Attribute : ConstantClass
    {

        /// <summary>
        /// Constant SENDER_IPV6 for IngressIpv6Attribute
        /// </summary>
        public static readonly IngressIpv6Attribute SENDER_IPV6 = new IngressIpv6Attribute("SENDER_IPV6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressIpv6Attribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressIpv6Attribute FindValue(string value)
        {
            return FindValue<IngressIpv6Attribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressIpv6Attribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressPointStatus.
    /// </summary>
    public class IngressPointStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus ACTIVE = new IngressPointStatus("ACTIVE");
        /// <summary>
        /// Constant CLOSED for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus CLOSED = new IngressPointStatus("CLOSED");
        /// <summary>
        /// Constant DEPROVISIONING for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus DEPROVISIONING = new IngressPointStatus("DEPROVISIONING");
        /// <summary>
        /// Constant FAILED for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus FAILED = new IngressPointStatus("FAILED");
        /// <summary>
        /// Constant PROVISIONING for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus PROVISIONING = new IngressPointStatus("PROVISIONING");
        /// <summary>
        /// Constant UPDATING for IngressPointStatus
        /// </summary>
        public static readonly IngressPointStatus UPDATING = new IngressPointStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressPointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressPointStatus FindValue(string value)
        {
            return FindValue<IngressPointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressPointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressPointStatusToUpdate.
    /// </summary>
    public class IngressPointStatusToUpdate : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IngressPointStatusToUpdate
        /// </summary>
        public static readonly IngressPointStatusToUpdate ACTIVE = new IngressPointStatusToUpdate("ACTIVE");
        /// <summary>
        /// Constant CLOSED for IngressPointStatusToUpdate
        /// </summary>
        public static readonly IngressPointStatusToUpdate CLOSED = new IngressPointStatusToUpdate("CLOSED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressPointStatusToUpdate(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressPointStatusToUpdate FindValue(string value)
        {
            return FindValue<IngressPointStatusToUpdate>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressPointStatusToUpdate(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressPointType.
    /// </summary>
    public class IngressPointType : ConstantClass
    {

        /// <summary>
        /// Constant AUTH for IngressPointType
        /// </summary>
        public static readonly IngressPointType AUTH = new IngressPointType("AUTH");
        /// <summary>
        /// Constant OPEN for IngressPointType
        /// </summary>
        public static readonly IngressPointType OPEN = new IngressPointType("OPEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressPointType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressPointType FindValue(string value)
        {
            return FindValue<IngressPointType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressPointType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressStringEmailAttribute.
    /// </summary>
    public class IngressStringEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant RECIPIENT for IngressStringEmailAttribute
        /// </summary>
        public static readonly IngressStringEmailAttribute RECIPIENT = new IngressStringEmailAttribute("RECIPIENT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressStringEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressStringEmailAttribute FindValue(string value)
        {
            return FindValue<IngressStringEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressStringEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressStringOperator.
    /// </summary>
    public class IngressStringOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for IngressStringOperator
        /// </summary>
        public static readonly IngressStringOperator CONTAINS = new IngressStringOperator("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for IngressStringOperator
        /// </summary>
        public static readonly IngressStringOperator ENDS_WITH = new IngressStringOperator("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for IngressStringOperator
        /// </summary>
        public static readonly IngressStringOperator EQUALS = new IngressStringOperator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for IngressStringOperator
        /// </summary>
        public static readonly IngressStringOperator NOT_EQUALS = new IngressStringOperator("NOT_EQUALS");
        /// <summary>
        /// Constant STARTS_WITH for IngressStringOperator
        /// </summary>
        public static readonly IngressStringOperator STARTS_WITH = new IngressStringOperator("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressStringOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressStringOperator FindValue(string value)
        {
            return FindValue<IngressStringOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressStringOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressTlsAttribute.
    /// </summary>
    public class IngressTlsAttribute : ConstantClass
    {

        /// <summary>
        /// Constant TLS_PROTOCOL for IngressTlsAttribute
        /// </summary>
        public static readonly IngressTlsAttribute TLS_PROTOCOL = new IngressTlsAttribute("TLS_PROTOCOL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressTlsAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressTlsAttribute FindValue(string value)
        {
            return FindValue<IngressTlsAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressTlsAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressTlsProtocolAttribute.
    /// </summary>
    public class IngressTlsProtocolAttribute : ConstantClass
    {

        /// <summary>
        /// Constant TLS1_2 for IngressTlsProtocolAttribute
        /// </summary>
        public static readonly IngressTlsProtocolAttribute TLS1_2 = new IngressTlsProtocolAttribute("TLS1_2");
        /// <summary>
        /// Constant TLS1_3 for IngressTlsProtocolAttribute
        /// </summary>
        public static readonly IngressTlsProtocolAttribute TLS1_3 = new IngressTlsProtocolAttribute("TLS1_3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressTlsProtocolAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressTlsProtocolAttribute FindValue(string value)
        {
            return FindValue<IngressTlsProtocolAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressTlsProtocolAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IngressTlsProtocolOperator.
    /// </summary>
    public class IngressTlsProtocolOperator : ConstantClass
    {

        /// <summary>
        /// Constant IS for IngressTlsProtocolOperator
        /// </summary>
        public static readonly IngressTlsProtocolOperator IS = new IngressTlsProtocolOperator("IS");
        /// <summary>
        /// Constant MINIMUM_TLS_VERSION for IngressTlsProtocolOperator
        /// </summary>
        public static readonly IngressTlsProtocolOperator MINIMUM_TLS_VERSION = new IngressTlsProtocolOperator("MINIMUM_TLS_VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IngressTlsProtocolOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IngressTlsProtocolOperator FindValue(string value)
        {
            return FindValue<IngressTlsProtocolOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IngressTlsProtocolOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpType.
    /// </summary>
    public class IpType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL_STACK for IpType
        /// </summary>
        public static readonly IpType DUAL_STACK = new IpType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4 for IpType
        /// </summary>
        public static readonly IpType IPV4 = new IpType("IPV4");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpType FindValue(string value)
        {
            return FindValue<IpType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MailFrom.
    /// </summary>
    public class MailFrom : ConstantClass
    {

        /// <summary>
        /// Constant PRESERVE for MailFrom
        /// </summary>
        public static readonly MailFrom PRESERVE = new MailFrom("PRESERVE");
        /// <summary>
        /// Constant REPLACE for MailFrom
        /// </summary>
        public static readonly MailFrom REPLACE = new MailFrom("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MailFrom(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MailFrom FindValue(string value)
        {
            return FindValue<MailFrom>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MailFrom(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RetentionPeriod.
    /// </summary>
    public class RetentionPeriod : ConstantClass
    {

        /// <summary>
        /// Constant EIGHT_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod EIGHT_YEARS = new RetentionPeriod("EIGHT_YEARS");
        /// <summary>
        /// Constant EIGHTEEN_MONTHS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod EIGHTEEN_MONTHS = new RetentionPeriod("EIGHTEEN_MONTHS");
        /// <summary>
        /// Constant FIVE_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod FIVE_YEARS = new RetentionPeriod("FIVE_YEARS");
        /// <summary>
        /// Constant FOUR_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod FOUR_YEARS = new RetentionPeriod("FOUR_YEARS");
        /// <summary>
        /// Constant NINE_MONTHS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod NINE_MONTHS = new RetentionPeriod("NINE_MONTHS");
        /// <summary>
        /// Constant NINE_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod NINE_YEARS = new RetentionPeriod("NINE_YEARS");
        /// <summary>
        /// Constant ONE_YEAR for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod ONE_YEAR = new RetentionPeriod("ONE_YEAR");
        /// <summary>
        /// Constant PERMANENT for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod PERMANENT = new RetentionPeriod("PERMANENT");
        /// <summary>
        /// Constant SEVEN_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod SEVEN_YEARS = new RetentionPeriod("SEVEN_YEARS");
        /// <summary>
        /// Constant SIX_MONTHS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod SIX_MONTHS = new RetentionPeriod("SIX_MONTHS");
        /// <summary>
        /// Constant SIX_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod SIX_YEARS = new RetentionPeriod("SIX_YEARS");
        /// <summary>
        /// Constant TEN_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod TEN_YEARS = new RetentionPeriod("TEN_YEARS");
        /// <summary>
        /// Constant THIRTY_MONTHS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod THIRTY_MONTHS = new RetentionPeriod("THIRTY_MONTHS");
        /// <summary>
        /// Constant THREE_MONTHS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod THREE_MONTHS = new RetentionPeriod("THREE_MONTHS");
        /// <summary>
        /// Constant THREE_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod THREE_YEARS = new RetentionPeriod("THREE_YEARS");
        /// <summary>
        /// Constant TWO_YEARS for RetentionPeriod
        /// </summary>
        public static readonly RetentionPeriod TWO_YEARS = new RetentionPeriod("TWO_YEARS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RetentionPeriod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RetentionPeriod FindValue(string value)
        {
            return FindValue<RetentionPeriod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RetentionPeriod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleAddressListEmailAttribute.
    /// </summary>
    public class RuleAddressListEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CC for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute CC = new RuleAddressListEmailAttribute("CC");
        /// <summary>
        /// Constant FROM for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute FROM = new RuleAddressListEmailAttribute("FROM");
        /// <summary>
        /// Constant MAIL_FROM for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute MAIL_FROM = new RuleAddressListEmailAttribute("MAIL_FROM");
        /// <summary>
        /// Constant RECIPIENT for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute RECIPIENT = new RuleAddressListEmailAttribute("RECIPIENT");
        /// <summary>
        /// Constant SENDER for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute SENDER = new RuleAddressListEmailAttribute("SENDER");
        /// <summary>
        /// Constant TO for RuleAddressListEmailAttribute
        /// </summary>
        public static readonly RuleAddressListEmailAttribute TO = new RuleAddressListEmailAttribute("TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleAddressListEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleAddressListEmailAttribute FindValue(string value)
        {
            return FindValue<RuleAddressListEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleAddressListEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleBooleanEmailAttribute.
    /// </summary>
    public class RuleBooleanEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant READ_RECEIPT_REQUESTED for RuleBooleanEmailAttribute
        /// </summary>
        public static readonly RuleBooleanEmailAttribute READ_RECEIPT_REQUESTED = new RuleBooleanEmailAttribute("READ_RECEIPT_REQUESTED");
        /// <summary>
        /// Constant TLS for RuleBooleanEmailAttribute
        /// </summary>
        public static readonly RuleBooleanEmailAttribute TLS = new RuleBooleanEmailAttribute("TLS");
        /// <summary>
        /// Constant TLS_WRAPPED for RuleBooleanEmailAttribute
        /// </summary>
        public static readonly RuleBooleanEmailAttribute TLS_WRAPPED = new RuleBooleanEmailAttribute("TLS_WRAPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleBooleanEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleBooleanEmailAttribute FindValue(string value)
        {
            return FindValue<RuleBooleanEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleBooleanEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleBooleanOperator.
    /// </summary>
    public class RuleBooleanOperator : ConstantClass
    {

        /// <summary>
        /// Constant IS_FALSE for RuleBooleanOperator
        /// </summary>
        public static readonly RuleBooleanOperator IS_FALSE = new RuleBooleanOperator("IS_FALSE");
        /// <summary>
        /// Constant IS_TRUE for RuleBooleanOperator
        /// </summary>
        public static readonly RuleBooleanOperator IS_TRUE = new RuleBooleanOperator("IS_TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleBooleanOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleBooleanOperator FindValue(string value)
        {
            return FindValue<RuleBooleanOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleBooleanOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleDmarcOperator.
    /// </summary>
    public class RuleDmarcOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for RuleDmarcOperator
        /// </summary>
        public static readonly RuleDmarcOperator EQUALS = new RuleDmarcOperator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for RuleDmarcOperator
        /// </summary>
        public static readonly RuleDmarcOperator NOT_EQUALS = new RuleDmarcOperator("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleDmarcOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleDmarcOperator FindValue(string value)
        {
            return FindValue<RuleDmarcOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleDmarcOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleDmarcPolicy.
    /// </summary>
    public class RuleDmarcPolicy : ConstantClass
    {

        /// <summary>
        /// Constant NONE for RuleDmarcPolicy
        /// </summary>
        public static readonly RuleDmarcPolicy NONE = new RuleDmarcPolicy("NONE");
        /// <summary>
        /// Constant QUARANTINE for RuleDmarcPolicy
        /// </summary>
        public static readonly RuleDmarcPolicy QUARANTINE = new RuleDmarcPolicy("QUARANTINE");
        /// <summary>
        /// Constant REJECT for RuleDmarcPolicy
        /// </summary>
        public static readonly RuleDmarcPolicy REJECT = new RuleDmarcPolicy("REJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleDmarcPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleDmarcPolicy FindValue(string value)
        {
            return FindValue<RuleDmarcPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleDmarcPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleIpEmailAttribute.
    /// </summary>
    public class RuleIpEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant SOURCE_IP for RuleIpEmailAttribute
        /// </summary>
        public static readonly RuleIpEmailAttribute SOURCE_IP = new RuleIpEmailAttribute("SOURCE_IP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleIpEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleIpEmailAttribute FindValue(string value)
        {
            return FindValue<RuleIpEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleIpEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleIpOperator.
    /// </summary>
    public class RuleIpOperator : ConstantClass
    {

        /// <summary>
        /// Constant CIDR_MATCHES for RuleIpOperator
        /// </summary>
        public static readonly RuleIpOperator CIDR_MATCHES = new RuleIpOperator("CIDR_MATCHES");
        /// <summary>
        /// Constant NOT_CIDR_MATCHES for RuleIpOperator
        /// </summary>
        public static readonly RuleIpOperator NOT_CIDR_MATCHES = new RuleIpOperator("NOT_CIDR_MATCHES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleIpOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleIpOperator FindValue(string value)
        {
            return FindValue<RuleIpOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleIpOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleNumberEmailAttribute.
    /// </summary>
    public class RuleNumberEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant MESSAGE_SIZE for RuleNumberEmailAttribute
        /// </summary>
        public static readonly RuleNumberEmailAttribute MESSAGE_SIZE = new RuleNumberEmailAttribute("MESSAGE_SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleNumberEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleNumberEmailAttribute FindValue(string value)
        {
            return FindValue<RuleNumberEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleNumberEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleNumberOperator.
    /// </summary>
    public class RuleNumberOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator EQUALS = new RuleNumberOperator("EQUALS");
        /// <summary>
        /// Constant GREATER_THAN for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator GREATER_THAN = new RuleNumberOperator("GREATER_THAN");
        /// <summary>
        /// Constant GREATER_THAN_OR_EQUAL for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator GREATER_THAN_OR_EQUAL = new RuleNumberOperator("GREATER_THAN_OR_EQUAL");
        /// <summary>
        /// Constant LESS_THAN for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator LESS_THAN = new RuleNumberOperator("LESS_THAN");
        /// <summary>
        /// Constant LESS_THAN_OR_EQUAL for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator LESS_THAN_OR_EQUAL = new RuleNumberOperator("LESS_THAN_OR_EQUAL");
        /// <summary>
        /// Constant NOT_EQUALS for RuleNumberOperator
        /// </summary>
        public static readonly RuleNumberOperator NOT_EQUALS = new RuleNumberOperator("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleNumberOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleNumberOperator FindValue(string value)
        {
            return FindValue<RuleNumberOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleNumberOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleStringEmailAttribute.
    /// </summary>
    public class RuleStringEmailAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CC for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute CC = new RuleStringEmailAttribute("CC");
        /// <summary>
        /// Constant FROM for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute FROM = new RuleStringEmailAttribute("FROM");
        /// <summary>
        /// Constant HELO for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute HELO = new RuleStringEmailAttribute("HELO");
        /// <summary>
        /// Constant MAIL_FROM for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute MAIL_FROM = new RuleStringEmailAttribute("MAIL_FROM");
        /// <summary>
        /// Constant RECIPIENT for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute RECIPIENT = new RuleStringEmailAttribute("RECIPIENT");
        /// <summary>
        /// Constant SENDER for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute SENDER = new RuleStringEmailAttribute("SENDER");
        /// <summary>
        /// Constant SUBJECT for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute SUBJECT = new RuleStringEmailAttribute("SUBJECT");
        /// <summary>
        /// Constant TO for RuleStringEmailAttribute
        /// </summary>
        public static readonly RuleStringEmailAttribute TO = new RuleStringEmailAttribute("TO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleStringEmailAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStringEmailAttribute FindValue(string value)
        {
            return FindValue<RuleStringEmailAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStringEmailAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleStringOperator.
    /// </summary>
    public class RuleStringOperator : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for RuleStringOperator
        /// </summary>
        public static readonly RuleStringOperator CONTAINS = new RuleStringOperator("CONTAINS");
        /// <summary>
        /// Constant ENDS_WITH for RuleStringOperator
        /// </summary>
        public static readonly RuleStringOperator ENDS_WITH = new RuleStringOperator("ENDS_WITH");
        /// <summary>
        /// Constant EQUALS for RuleStringOperator
        /// </summary>
        public static readonly RuleStringOperator EQUALS = new RuleStringOperator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for RuleStringOperator
        /// </summary>
        public static readonly RuleStringOperator NOT_EQUALS = new RuleStringOperator("NOT_EQUALS");
        /// <summary>
        /// Constant STARTS_WITH for RuleStringOperator
        /// </summary>
        public static readonly RuleStringOperator STARTS_WITH = new RuleStringOperator("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleStringOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleStringOperator FindValue(string value)
        {
            return FindValue<RuleStringOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleStringOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleVerdict.
    /// </summary>
    public class RuleVerdict : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for RuleVerdict
        /// </summary>
        public static readonly RuleVerdict FAIL = new RuleVerdict("FAIL");
        /// <summary>
        /// Constant GRAY for RuleVerdict
        /// </summary>
        public static readonly RuleVerdict GRAY = new RuleVerdict("GRAY");
        /// <summary>
        /// Constant PASS for RuleVerdict
        /// </summary>
        public static readonly RuleVerdict PASS = new RuleVerdict("PASS");
        /// <summary>
        /// Constant PROCESSING_FAILED for RuleVerdict
        /// </summary>
        public static readonly RuleVerdict PROCESSING_FAILED = new RuleVerdict("PROCESSING_FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleVerdict(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleVerdict FindValue(string value)
        {
            return FindValue<RuleVerdict>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleVerdict(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleVerdictAttribute.
    /// </summary>
    public class RuleVerdictAttribute : ConstantClass
    {

        /// <summary>
        /// Constant DKIM for RuleVerdictAttribute
        /// </summary>
        public static readonly RuleVerdictAttribute DKIM = new RuleVerdictAttribute("DKIM");
        /// <summary>
        /// Constant SPF for RuleVerdictAttribute
        /// </summary>
        public static readonly RuleVerdictAttribute SPF = new RuleVerdictAttribute("SPF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleVerdictAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleVerdictAttribute FindValue(string value)
        {
            return FindValue<RuleVerdictAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleVerdictAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleVerdictOperator.
    /// </summary>
    public class RuleVerdictOperator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for RuleVerdictOperator
        /// </summary>
        public static readonly RuleVerdictOperator EQUALS = new RuleVerdictOperator("EQUALS");
        /// <summary>
        /// Constant NOT_EQUALS for RuleVerdictOperator
        /// </summary>
        public static readonly RuleVerdictOperator NOT_EQUALS = new RuleVerdictOperator("NOT_EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleVerdictOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleVerdictOperator FindValue(string value)
        {
            return FindValue<RuleVerdictOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleVerdictOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchState.
    /// </summary>
    public class SearchState : ConstantClass
    {

        /// <summary>
        /// Constant CANCELLED for SearchState
        /// </summary>
        public static readonly SearchState CANCELLED = new SearchState("CANCELLED");
        /// <summary>
        /// Constant COMPLETED for SearchState
        /// </summary>
        public static readonly SearchState COMPLETED = new SearchState("COMPLETED");
        /// <summary>
        /// Constant FAILED for SearchState
        /// </summary>
        public static readonly SearchState FAILED = new SearchState("FAILED");
        /// <summary>
        /// Constant QUEUED for SearchState
        /// </summary>
        public static readonly SearchState QUEUED = new SearchState("QUEUED");
        /// <summary>
        /// Constant RUNNING for SearchState
        /// </summary>
        public static readonly SearchState RUNNING = new SearchState("RUNNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchState FindValue(string value)
        {
            return FindValue<SearchState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnsNotificationEncoding.
    /// </summary>
    public class SnsNotificationEncoding : ConstantClass
    {

        /// <summary>
        /// Constant BASE64 for SnsNotificationEncoding
        /// </summary>
        public static readonly SnsNotificationEncoding BASE64 = new SnsNotificationEncoding("BASE64");
        /// <summary>
        /// Constant UTF8 for SnsNotificationEncoding
        /// </summary>
        public static readonly SnsNotificationEncoding UTF8 = new SnsNotificationEncoding("UTF-8");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnsNotificationEncoding(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnsNotificationEncoding FindValue(string value)
        {
            return FindValue<SnsNotificationEncoding>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnsNotificationEncoding(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnsNotificationPayloadType.
    /// </summary>
    public class SnsNotificationPayloadType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT for SnsNotificationPayloadType
        /// </summary>
        public static readonly SnsNotificationPayloadType CONTENT = new SnsNotificationPayloadType("CONTENT");
        /// <summary>
        /// Constant HEADERS for SnsNotificationPayloadType
        /// </summary>
        public static readonly SnsNotificationPayloadType HEADERS = new SnsNotificationPayloadType("HEADERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnsNotificationPayloadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnsNotificationPayloadType FindValue(string value)
        {
            return FindValue<SnsNotificationPayloadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnsNotificationPayloadType(string value)
        {
            return FindValue(value);
        }
    }

}