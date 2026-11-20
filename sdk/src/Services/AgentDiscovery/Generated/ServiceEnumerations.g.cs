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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using Amazon.Runtime;

namespace Amazon.AgentDiscovery
{
    /// <summary>
    /// Constants used for properties of type ArdErrorCode.
    /// </summary>
    public class ArdErrorCode : ConstantClass
    {
        /// <summary>
        /// Constant INTERNAL_ERROR for ArdErrorCode
        /// </summary>
        public static readonly ArdErrorCode INTERNAL_ERROR = new ArdErrorCode("INTERNAL_ERROR");

        /// <summary>
        /// Constant INVALID_ARGUMENT for ArdErrorCode
        /// </summary>
        public static readonly ArdErrorCode INVALID_ARGUMENT = new ArdErrorCode("INVALID_ARGUMENT");

        /// <summary>
        /// Constant NOT_FOUND for ArdErrorCode
        /// </summary>
        public static readonly ArdErrorCode NOT_FOUND = new ArdErrorCode("NOT_FOUND");

        /// <summary>
        /// Constant RATE_LIMIT_EXCEEDED for ArdErrorCode
        /// </summary>
        public static readonly ArdErrorCode RATE_LIMIT_EXCEEDED = new ArdErrorCode("RATE_LIMIT_EXCEEDED");

        /// <summary>
        /// Constant UNAUTHENTICATED for ArdErrorCode
        /// </summary>
        public static readonly ArdErrorCode UNAUTHENTICATED = new ArdErrorCode("UNAUTHENTICATED");

        /// <summary>
        /// Constructs a custom ArdErrorCode for a value not among the defined constants.
        /// </summary>
        public ArdErrorCode(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArdErrorCode FindValue(string value)
        {
            return FindValue<ArdErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArdErrorCode(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type ProvenanceRelation.
    /// </summary>
    public class ProvenanceRelation : ConstantClass
    {
        /// <summary>
        /// Constant DiscoveredFrom for ProvenanceRelation
        /// </summary>
        public static readonly ProvenanceRelation DiscoveredFrom = new ProvenanceRelation("discoveredFrom");

        /// <summary>
        /// Constant FederatedFrom for ProvenanceRelation
        /// </summary>
        public static readonly ProvenanceRelation FederatedFrom = new ProvenanceRelation("federatedFrom");

        /// <summary>
        /// Constant PublishedFrom for ProvenanceRelation
        /// </summary>
        public static readonly ProvenanceRelation PublishedFrom = new ProvenanceRelation("publishedFrom");

        /// <summary>
        /// Constructs a custom ProvenanceRelation for a value not among the defined constants.
        /// </summary>
        public ProvenanceRelation(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvenanceRelation FindValue(string value)
        {
            return FindValue<ProvenanceRelation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvenanceRelation(string value)
        {
            return FindValue(value);
        }
    }

    /// <summary>
    /// Constants used for properties of type RecordType.
    /// </summary>
    public class RecordType : ConstantClass
    {
        /// <summary>
        /// Constant AGENT for RecordType
        /// </summary>
        public static readonly RecordType AGENT = new RecordType("AGENT");

        /// <summary>
        /// Constant CUSTOM for RecordType
        /// </summary>
        public static readonly RecordType CUSTOM = new RecordType("CUSTOM");

        /// <summary>
        /// Constant GATEWAY for RecordType
        /// </summary>
        public static readonly RecordType GATEWAY = new RecordType("GATEWAY");

        /// <summary>
        /// Constant SKILL for RecordType
        /// </summary>
        public static readonly RecordType SKILL = new RecordType("SKILL");

        /// <summary>
        /// Constant TOOL for RecordType
        /// </summary>
        public static readonly RecordType TOOL = new RecordType("TOOL");

        /// <summary>
        /// Constant WEB_BOT for RecordType
        /// </summary>
        public static readonly RecordType WEB_BOT = new RecordType("WEB_BOT");

        /// <summary>
        /// Constructs a custom RecordType for a value not among the defined constants.
        /// </summary>
        public RecordType(string value) : base(value) { }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordType FindValue(string value)
        {
            return FindValue<RecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordType(string value)
        {
            return FindValue(value);
        }
    }
}
