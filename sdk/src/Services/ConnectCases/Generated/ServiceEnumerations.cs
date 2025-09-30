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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ConnectCases
{

    /// <summary>
    /// Constants used for properties of type AuditEventType.
    /// </summary>
    public class AuditEventType : ConstantClass
    {

        /// <summary>
        /// Constant CaseCreated for AuditEventType
        /// </summary>
        public static readonly AuditEventType CaseCreated = new AuditEventType("Case.Created");
        /// <summary>
        /// Constant CaseUpdated for AuditEventType
        /// </summary>
        public static readonly AuditEventType CaseUpdated = new AuditEventType("Case.Updated");
        /// <summary>
        /// Constant RelatedItemCreated for AuditEventType
        /// </summary>
        public static readonly AuditEventType RelatedItemCreated = new AuditEventType("RelatedItem.Created");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuditEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuditEventType FindValue(string value)
        {
            return FindValue<AuditEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuditEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommentBodyTextType.
    /// </summary>
    public class CommentBodyTextType : ConstantClass
    {

        /// <summary>
        /// Constant TextPlain for CommentBodyTextType
        /// </summary>
        public static readonly CommentBodyTextType TextPlain = new CommentBodyTextType("Text/Plain");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommentBodyTextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommentBodyTextType FindValue(string value)
        {
            return FindValue<CommentBodyTextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommentBodyTextType(string value)
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
        /// Constant Active for DomainStatus
        /// </summary>
        public static readonly DomainStatus Active = new DomainStatus("Active");
        /// <summary>
        /// Constant CreationFailed for DomainStatus
        /// </summary>
        public static readonly DomainStatus CreationFailed = new DomainStatus("CreationFailed");
        /// <summary>
        /// Constant CreationInProgress for DomainStatus
        /// </summary>
        public static readonly DomainStatus CreationInProgress = new DomainStatus("CreationInProgress");

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
    /// Constants used for properties of type FieldNamespace.
    /// </summary>
    public class FieldNamespace : ConstantClass
    {

        /// <summary>
        /// Constant Custom for FieldNamespace
        /// </summary>
        public static readonly FieldNamespace Custom = new FieldNamespace("Custom");
        /// <summary>
        /// Constant System for FieldNamespace
        /// </summary>
        public static readonly FieldNamespace System = new FieldNamespace("System");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldNamespace(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldNamespace FindValue(string value)
        {
            return FindValue<FieldNamespace>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldNamespace(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FieldType.
    /// </summary>
    public class FieldType : ConstantClass
    {

        /// <summary>
        /// Constant Boolean for FieldType
        /// </summary>
        public static readonly FieldType Boolean = new FieldType("Boolean");
        /// <summary>
        /// Constant DateTime for FieldType
        /// </summary>
        public static readonly FieldType DateTime = new FieldType("DateTime");
        /// <summary>
        /// Constant Number for FieldType
        /// </summary>
        public static readonly FieldType Number = new FieldType("Number");
        /// <summary>
        /// Constant SingleSelect for FieldType
        /// </summary>
        public static readonly FieldType SingleSelect = new FieldType("SingleSelect");
        /// <summary>
        /// Constant Text for FieldType
        /// </summary>
        public static readonly FieldType Text = new FieldType("Text");
        /// <summary>
        /// Constant Url for FieldType
        /// </summary>
        public static readonly FieldType Url = new FieldType("Url");
        /// <summary>
        /// Constant User for FieldType
        /// </summary>
        public static readonly FieldType User = new FieldType("User");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FieldType FindValue(string value)
        {
            return FindValue<FieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant Asc for Order
        /// </summary>
        public static readonly Order Asc = new Order("Asc");
        /// <summary>
        /// Constant Desc for Order
        /// </summary>
        public static readonly Order Desc = new Order("Desc");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelatedItemType.
    /// </summary>
    public class RelatedItemType : ConstantClass
    {

        /// <summary>
        /// Constant Comment for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType Comment = new RelatedItemType("Comment");
        /// <summary>
        /// Constant ConnectCase for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType ConnectCase = new RelatedItemType("ConnectCase");
        /// <summary>
        /// Constant Contact for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType Contact = new RelatedItemType("Contact");
        /// <summary>
        /// Constant Custom for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType Custom = new RelatedItemType("Custom");
        /// <summary>
        /// Constant File for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType File = new RelatedItemType("File");
        /// <summary>
        /// Constant Sla for RelatedItemType
        /// </summary>
        public static readonly RelatedItemType Sla = new RelatedItemType("Sla");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelatedItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelatedItemType FindValue(string value)
        {
            return FindValue<RelatedItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelatedItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RuleType.
    /// </summary>
    public class RuleType : ConstantClass
    {

        /// <summary>
        /// Constant Required for RuleType
        /// </summary>
        public static readonly RuleType Required = new RuleType("Required");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RuleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RuleType FindValue(string value)
        {
            return FindValue<RuleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RuleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlaStatus.
    /// </summary>
    public class SlaStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for SlaStatus
        /// </summary>
        public static readonly SlaStatus Active = new SlaStatus("Active");
        /// <summary>
        /// Constant Met for SlaStatus
        /// </summary>
        public static readonly SlaStatus Met = new SlaStatus("Met");
        /// <summary>
        /// Constant NotMet for SlaStatus
        /// </summary>
        public static readonly SlaStatus NotMet = new SlaStatus("NotMet");
        /// <summary>
        /// Constant Overdue for SlaStatus
        /// </summary>
        public static readonly SlaStatus Overdue = new SlaStatus("Overdue");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlaStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlaStatus FindValue(string value)
        {
            return FindValue<SlaStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlaStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SlaType.
    /// </summary>
    public class SlaType : ConstantClass
    {

        /// <summary>
        /// Constant CaseField for SlaType
        /// </summary>
        public static readonly SlaType CaseField = new SlaType("CaseField");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SlaType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SlaType FindValue(string value)
        {
            return FindValue<SlaType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SlaType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TemplateStatus.
    /// </summary>
    public class TemplateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus Active = new TemplateStatus("Active");
        /// <summary>
        /// Constant Inactive for TemplateStatus
        /// </summary>
        public static readonly TemplateStatus Inactive = new TemplateStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TemplateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TemplateStatus FindValue(string value)
        {
            return FindValue<TemplateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TemplateStatus(string value)
        {
            return FindValue(value);
        }
    }

}