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

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Base class for operation-specific configurations for DynamoDB object persistence operations.
    /// </summary>
    /// <remarks>
    /// This should only contain members that are relevant to all object persistence operations, 
    /// anything operation-specific should be added to derived classes.
    /// </remarks>
    public abstract class BaseOperationConfig
    {
        /// <summary>
        /// Indicates which DynamoDB table to use. This overrides the table specified 
        /// by the <see cref="DynamoDBTableAttribute"/> on the .NET objects that you're saving or loading.
        /// </summary>
        public string OverrideTableName { get; set; }

        /// <summary>
        /// Directs <see cref="DynamoDBContext"/> to prefix all table names
        /// with a specific string. If this is null or empty, no prefix is used 
        /// and default table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }

        /// <summary>
        /// Specification which controls the conversion between .NET and DynamoDB types.
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        /// <summary>
        /// Controls how <see cref="DynamoDBContext"/> interprets empty string values.
        /// If the property is false (or not set), empty string values will be
        /// interpreted as null values.
        /// </summary>
        public bool? IsEmptyStringValueEnabled { get; set; }

        /// <summary>
        /// Converts this to the shared <see cref="DynamoDBOperationConfig"/>
        /// </summary>
        /// <remarks>
        /// Users should interact with the new, operation-specific configs, but we
        /// convert to the internal shared config for the internal code paths.
        /// </remarks>
        /// <returns>A new <see cref="DynamoDBOperationConfig"/> with settings copied from the operation-specific config</returns>
        internal virtual DynamoDBOperationConfig ToDynamoDBOperationConfig()
        {
            return new DynamoDBOperationConfig()
            {
                OverrideTableName = OverrideTableName,
                TableNamePrefix = TableNamePrefix,
                Conversion = Conversion,
                IsEmptyStringValueEnabled = IsEmptyStringValueEnabled
            };
        }
    }
}
