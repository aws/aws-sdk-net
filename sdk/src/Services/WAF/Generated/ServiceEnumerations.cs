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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WAF
{

    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant DELETE for ChangeAction
        /// </summary>
        public static readonly ChangeAction DELETE = new ChangeAction("DELETE");
        /// <summary>
        /// Constant INSERT for ChangeAction
        /// </summary>
        public static readonly ChangeAction INSERT = new ChangeAction("INSERT");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeTokenStatus.
    /// </summary>
    public class ChangeTokenStatus : ConstantClass
    {

        /// <summary>
        /// Constant INSYNC for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus INSYNC = new ChangeTokenStatus("INSYNC");
        /// <summary>
        /// Constant PENDING for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus PENDING = new ChangeTokenStatus("PENDING");
        /// <summary>
        /// Constant PROVISIONED for ChangeTokenStatus
        /// </summary>
        public static readonly ChangeTokenStatus PROVISIONED = new ChangeTokenStatus("PROVISIONED");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChangeTokenStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeTokenStatus FindValue(string value)
        {
            return FindValue<ChangeTokenStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeTokenStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IPSetDescriptorType.
    /// </summary>
    public class IPSetDescriptorType : ConstantClass
    {

        /// <summary>
        /// Constant IPV4 for IPSetDescriptorType
        /// </summary>
        public static readonly IPSetDescriptorType IPV4 = new IPSetDescriptorType("IPV4");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public IPSetDescriptorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IPSetDescriptorType FindValue(string value)
        {
            return FindValue<IPSetDescriptorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IPSetDescriptorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchFieldType.
    /// </summary>
    public class MatchFieldType : ConstantClass
    {

        /// <summary>
        /// Constant HEADER for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType HEADER = new MatchFieldType("HEADER");
        /// <summary>
        /// Constant METHOD for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType METHOD = new MatchFieldType("METHOD");
        /// <summary>
        /// Constant QUERY_STRING for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType QUERY_STRING = new MatchFieldType("QUERY_STRING");
        /// <summary>
        /// Constant URI for MatchFieldType
        /// </summary>
        public static readonly MatchFieldType URI = new MatchFieldType("URI");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MatchFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchFieldType FindValue(string value)
        {
            return FindValue<MatchFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterExceptionField.
    /// </summary>
    public class ParameterExceptionField : ConstantClass
    {

        /// <summary>
        /// Constant BYTE_MATCH_FIELD_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_FIELD_TYPE = new ParameterExceptionField("BYTE_MATCH_FIELD_TYPE");
        /// <summary>
        /// Constant BYTE_MATCH_POSITIONAL_CONSTRAINT for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_POSITIONAL_CONSTRAINT = new ParameterExceptionField("BYTE_MATCH_POSITIONAL_CONSTRAINT");
        /// <summary>
        /// Constant BYTE_MATCH_TEXT_TRANSFORMATION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField BYTE_MATCH_TEXT_TRANSFORMATION = new ParameterExceptionField("BYTE_MATCH_TEXT_TRANSFORMATION");
        /// <summary>
        /// Constant CHANGE_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField CHANGE_ACTION = new ParameterExceptionField("CHANGE_ACTION");
        /// <summary>
        /// Constant IPSET_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField IPSET_TYPE = new ParameterExceptionField("IPSET_TYPE");
        /// <summary>
        /// Constant PREDICATE_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField PREDICATE_TYPE = new ParameterExceptionField("PREDICATE_TYPE");
        /// <summary>
        /// Constant SQL_INJECTION_MATCH_FIELD_TYPE for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField SQL_INJECTION_MATCH_FIELD_TYPE = new ParameterExceptionField("SQL_INJECTION_MATCH_FIELD_TYPE");
        /// <summary>
        /// Constant WAF_ACTION for ParameterExceptionField
        /// </summary>
        public static readonly ParameterExceptionField WAF_ACTION = new ParameterExceptionField("WAF_ACTION");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ParameterExceptionField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterExceptionField FindValue(string value)
        {
            return FindValue<ParameterExceptionField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterExceptionField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PositionalConstraint.
    /// </summary>
    public class PositionalConstraint : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint CONTAINS = new PositionalConstraint("CONTAINS");
        /// <summary>
        /// Constant CONTAINS_WORD for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint CONTAINS_WORD = new PositionalConstraint("CONTAINS_WORD");
        /// <summary>
        /// Constant ENDS_WITH for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint ENDS_WITH = new PositionalConstraint("ENDS_WITH");
        /// <summary>
        /// Constant EXACTLY for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint EXACTLY = new PositionalConstraint("EXACTLY");
        /// <summary>
        /// Constant STARTS_WITH for PositionalConstraint
        /// </summary>
        public static readonly PositionalConstraint STARTS_WITH = new PositionalConstraint("STARTS_WITH");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PositionalConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PositionalConstraint FindValue(string value)
        {
            return FindValue<PositionalConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PositionalConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PredicateType.
    /// </summary>
    public class PredicateType : ConstantClass
    {

        /// <summary>
        /// Constant ByteMatch for PredicateType
        /// </summary>
        public static readonly PredicateType ByteMatch = new PredicateType("ByteMatch");
        /// <summary>
        /// Constant IPMatch for PredicateType
        /// </summary>
        public static readonly PredicateType IPMatch = new PredicateType("IPMatch");
        /// <summary>
        /// Constant SqlInjectionMatch for PredicateType
        /// </summary>
        public static readonly PredicateType SqlInjectionMatch = new PredicateType("SqlInjectionMatch");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PredicateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PredicateType FindValue(string value)
        {
            return FindValue<PredicateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PredicateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TextTransformation.
    /// </summary>
    public class TextTransformation : ConstantClass
    {

        /// <summary>
        /// Constant CMD_LINE for TextTransformation
        /// </summary>
        public static readonly TextTransformation CMD_LINE = new TextTransformation("CMD_LINE");
        /// <summary>
        /// Constant COMPRESS_WHITE_SPACE for TextTransformation
        /// </summary>
        public static readonly TextTransformation COMPRESS_WHITE_SPACE = new TextTransformation("COMPRESS_WHITE_SPACE");
        /// <summary>
        /// Constant HTML_ENTITY_DECODE for TextTransformation
        /// </summary>
        public static readonly TextTransformation HTML_ENTITY_DECODE = new TextTransformation("HTML_ENTITY_DECODE");
        /// <summary>
        /// Constant LOWERCASE for TextTransformation
        /// </summary>
        public static readonly TextTransformation LOWERCASE = new TextTransformation("LOWERCASE");
        /// <summary>
        /// Constant NONE for TextTransformation
        /// </summary>
        public static readonly TextTransformation NONE = new TextTransformation("NONE");
        /// <summary>
        /// Constant URL_DECODE for TextTransformation
        /// </summary>
        public static readonly TextTransformation URL_DECODE = new TextTransformation("URL_DECODE");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public TextTransformation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TextTransformation FindValue(string value)
        {
            return FindValue<TextTransformation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TextTransformation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WafActionType.
    /// </summary>
    public class WafActionType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for WafActionType
        /// </summary>
        public static readonly WafActionType ALLOW = new WafActionType("ALLOW");
        /// <summary>
        /// Constant BLOCK for WafActionType
        /// </summary>
        public static readonly WafActionType BLOCK = new WafActionType("BLOCK");
        /// <summary>
        /// Constant COUNT for WafActionType
        /// </summary>
        public static readonly WafActionType COUNT = new WafActionType("COUNT");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public WafActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WafActionType FindValue(string value)
        {
            return FindValue<WafActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WafActionType(string value)
        {
            return FindValue(value);
        }
    }

}