/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.Kinesis
{


    /// <summary>Shard Iterator Type
    /// </summary>
    public class ShardIteratorType : ConstantClass
    {


       /// <summary>Constant AFTER_SEQUENCE_NUMBER for ShardIteratorType
       /// </summary>
        public static readonly ShardIteratorType AFTER_SEQUENCE_NUMBER = new ShardIteratorType("AFTER_SEQUENCE_NUMBER");
    

       /// <summary>Constant AT_SEQUENCE_NUMBER for ShardIteratorType
       /// </summary>
        public static readonly ShardIteratorType AT_SEQUENCE_NUMBER = new ShardIteratorType("AT_SEQUENCE_NUMBER");
    

       /// <summary>Constant LATEST for ShardIteratorType
       /// </summary>
        public static readonly ShardIteratorType LATEST = new ShardIteratorType("LATEST");
    

       /// <summary>Constant TRIM_HORIZON for ShardIteratorType
       /// </summary>
        public static readonly ShardIteratorType TRIM_HORIZON = new ShardIteratorType("TRIM_HORIZON");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ShardIteratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShardIteratorType FindValue(string value)
        {
            return FindValue<ShardIteratorType>(value);
        }

        public static implicit operator ShardIteratorType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Stream Status
    /// </summary>
    public class StreamStatus : ConstantClass
    {


       /// <summary>Constant ACTIVE for StreamStatus
       /// </summary>
        public static readonly StreamStatus ACTIVE = new StreamStatus("ACTIVE");
    

       /// <summary>Constant CREATING for StreamStatus
       /// </summary>
        public static readonly StreamStatus CREATING = new StreamStatus("CREATING");
    

       /// <summary>Constant DELETING for StreamStatus
       /// </summary>
        public static readonly StreamStatus DELETING = new StreamStatus("DELETING");
    

       /// <summary>Constant UPDATING for StreamStatus
       /// </summary>
        public static readonly StreamStatus UPDATING = new StreamStatus("UPDATING");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public StreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamStatus FindValue(string value)
        {
            return FindValue<StreamStatus>(value);
        }

        public static implicit operator StreamStatus(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
