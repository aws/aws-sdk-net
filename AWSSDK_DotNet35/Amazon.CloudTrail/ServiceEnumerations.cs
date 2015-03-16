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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CloudTrail
{

    /// <summary>
    /// Constants used for properties of type LookupAttributeKey.
    /// </summary>
    public class LookupAttributeKey : ConstantClass
    {

        /// <summary>
        /// Constant EventId for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventId = new LookupAttributeKey("EventId");
        /// <summary>
        /// Constant EventName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey EventName = new LookupAttributeKey("EventName");
        /// <summary>
        /// Constant ResourceName for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceName = new LookupAttributeKey("ResourceName");
        /// <summary>
        /// Constant ResourceType for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey ResourceType = new LookupAttributeKey("ResourceType");
        /// <summary>
        /// Constant Username for LookupAttributeKey
        /// </summary>
        public static readonly LookupAttributeKey Username = new LookupAttributeKey("Username");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LookupAttributeKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LookupAttributeKey FindValue(string value)
        {
            return FindValue<LookupAttributeKey>(value);
        }

        public static implicit operator LookupAttributeKey(string value)
        {
            return FindValue(value);
        }
    }

}