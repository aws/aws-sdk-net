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

using System.Diagnostics.CodeAnalysis;

// Suppressions for identifiers in base classes
[module: SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Scope = "member", Target = "Amazon.SimpleDB.IAmazonSimpleDB.#Select(Amazon.SimpleDB.Model.SelectRequest)", MessageId = "Select")]
// Identifiers should not contain type names
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeRealNumberRangeFloat(System.String,System.Int32,System.Int32)", MessageId = "float")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeRealNumberRangeInt(System.String,System.Int32)", MessageId = "int")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeZeroPaddingFloat(System.String)", MessageId = "float")]
[module: SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Scope = "member", Target = "Amazon.SimpleDB.Util.AmazonSimpleDBUtil.#DecodeZeroPaddingInt(System.String)", MessageId = "int")]
