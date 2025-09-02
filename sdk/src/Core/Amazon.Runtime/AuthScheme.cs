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

using System;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Represents an authentication scheme that can be used to authenticate requests to AWS services.
    /// </summary>
    public class AuthScheme : IEquatable<AuthScheme>
    {
        /// <summary>
        /// Gets the fully qualified scheme identifier.
        /// </summary>
        public string SchemeId { get; }

        /// <summary>
        /// Gets the short name used for configuration.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the type of authentication scheme.
        /// </summary>
        public AuthSchemeType Type { get; }

        /// <summary>
        /// Initializes a new instance of the AuthScheme class.
        /// </summary>
        /// <param name="schemeId">The fully qualified scheme identifier.</param>
        /// <param name="name">The short name used for configuration.</param>
        /// <param name="type">The type of authentication scheme.</param>
        public AuthScheme(string schemeId, string name, AuthSchemeType type)
        {
            SchemeId = schemeId ?? throw new ArgumentNullException(nameof(schemeId));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Type = type;
        }

        /// <summary>
        /// AWS Signature Version 4 authentication scheme.
        /// </summary>
        public static readonly AuthScheme SigV4 = new AuthScheme("aws.auth#sigv4", "sigv4", AuthSchemeType.SigV4);

        /// <summary>
        /// AWS Signature Version 4a authentication scheme.
        /// </summary>
        public static readonly AuthScheme SigV4a = new AuthScheme("aws.auth#sigv4a", "sigv4a", AuthSchemeType.SigV4a);

        /// <summary>
        /// HTTP Bearer authentication scheme.
        /// </summary>
        public static readonly AuthScheme HttpBearerAuth = new AuthScheme("smithy.api#httpBearerAuth", "httpBearerAuth", AuthSchemeType.HttpBearer);

        /// <summary>
        /// No authentication scheme.
        /// </summary>
        public static readonly AuthScheme NoAuth = new AuthScheme("smithy.api#noAuth", "noAuth", AuthSchemeType.NoAuth);

        /// <summary>
        /// Determines whether the specified object is equal to the current AuthScheme.
        /// </summary>
        /// <param name="obj">The object to compare with the current AuthScheme.</param>
        /// <returns>true if the specified object is equal to the current AuthScheme; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as AuthScheme);
        }

        /// <summary>
        /// Determines whether the specified AuthScheme is equal to the current AuthScheme.
        /// </summary>
        /// <param name="other">The AuthScheme to compare with the current AuthScheme.</param>
        /// <returns>true if the specified AuthScheme is equal to the current AuthScheme; otherwise, false.</returns>
        public bool Equals(AuthScheme other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return SchemeId == other.SchemeId && Name == other.Name && Type == other.Type;
        }

        /// <summary>
        /// Returns the hash code for this AuthScheme.
        /// </summary>
        /// <returns>A hash code for the current AuthScheme.</returns>
        public override int GetHashCode()
        {
            return HashCodeHelper.CombineHashCodes(SchemeId, Name, Type);
        }

        /// <summary>
        /// Returns a string representation of the AuthScheme.
        /// </summary>
        /// <returns>A string representation of the AuthScheme.</returns>
        public override string ToString()
        {
            return $"AuthScheme(SchemeId={SchemeId}, Name={Name}, Type={Type})";
        }

        /// <summary>
        /// Determines whether two AuthScheme instances are equal.
        /// </summary>
        /// <param name="left">The first AuthScheme to compare.</param>
        /// <param name="right">The second AuthScheme to compare.</param>
        /// <returns>true if the AuthScheme instances are equal; otherwise, false.</returns>
        public static bool operator ==(AuthScheme left, AuthScheme right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two AuthScheme instances are not equal.
        /// </summary>
        /// <param name="left">The first AuthScheme to compare.</param>
        /// <param name="right">The second AuthScheme to compare.</param>
        /// <returns>true if the AuthScheme instances are not equal; otherwise, false.</returns>
        public static bool operator !=(AuthScheme left, AuthScheme right)
        {
            return !(left == right);
        }
    }

    /// <summary>
    /// Enumeration of authentication scheme types.
    /// </summary>
    public enum AuthSchemeType
    {
        /// <summary>
        /// AWS Signature Version 4 authentication.
        /// </summary>
        SigV4,

        /// <summary>
        /// AWS Signature Version 4a authentication.
        /// </summary>
        SigV4a,

        /// <summary>
        /// HTTP Bearer token authentication.
        /// </summary>
        HttpBearer,

        /// <summary>
        /// No authentication.
        /// </summary>
        NoAuth
    }
}