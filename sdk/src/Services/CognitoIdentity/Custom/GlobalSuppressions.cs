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

// Array properties/fields
[module: SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#CurrentLoginProviders")]
// Identifier suffix
[module: SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Scope = "type", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials+IdentityChangedArgs")]
// Nested types, breaking change
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials+IdentityChangedArgs")]
[module: SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials+IdentityState")]
// Use properties, design decision to suppress
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#GetIdentityId()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#GetCachedIdentityId()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#GetIdentityIdAsync()")]
[module: SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#GetCachedCredentials()")]
// Overridable methods from constructor
[module: SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Amazon.CognitoIdentity.CognitoAWSCredentials.#.ctor(System.String,System.String,System.String,System.String,Amazon.CognitoIdentity.IAmazonCognitoIdentity,Amazon.SecurityToken.IAmazonSecurityTokenService)")]