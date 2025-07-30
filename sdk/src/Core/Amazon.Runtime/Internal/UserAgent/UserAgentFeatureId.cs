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

namespace Amazon.Runtime.Internal.UserAgent
{
    /// <summary>
    /// Represents the unique metric identifiers for SDK features tracked under User Agent 2.1 (UA2.1).
    /// </summary>
    [ConstantClassComparer(ConstantClassComparerKind.Ordinal)]
    public class UserAgentFeatureId : ConstantClass
    {
        /// <summary>
        /// An operation called using a paginator.
        /// </summary>
        public static readonly UserAgentFeatureId PAGINATOR = new UserAgentFeatureId("C");

        /// <summary>
        /// An operation called using the standard retry mode.
        /// </summary>
        public static readonly UserAgentFeatureId RETRY_MODE_STANDARD = new UserAgentFeatureId("E");

        /// <summary>
        /// An operation called using the adaptive retry mode.
        /// </summary>
        public static readonly UserAgentFeatureId RETRY_MODE_ADAPTIVE = new UserAgentFeatureId("F");

        /// <summary>
        /// An operation called using the S3 Transfer Manager.
        /// </summary>
        public static readonly UserAgentFeatureId S3_TRANSFER = new UserAgentFeatureId("G");

        /// <summary>
        /// An operation called using the S3 Express feature.
        /// </summary>
        public static readonly UserAgentFeatureId S3_EXPRESS_BUCKET = new UserAgentFeatureId("J");

        /// <summary>
        /// An operation called using GZIP request compression.
        /// </summary>
        public static readonly UserAgentFeatureId GZIP_REQUEST_COMPRESSION = new UserAgentFeatureId("L");

        /// <summary>
        /// An operation called using the Smithy RPC v2 CBOR protocol.
        /// </summary>
        public static readonly UserAgentFeatureId PROTOCOL_RPC_V2_CBOR = new UserAgentFeatureId("M");

        /// <summary>
        /// An operation called using a user provided endpoint URL.
        /// </summary>
        public static readonly UserAgentFeatureId ENDPOINT_OVERRIDE = new UserAgentFeatureId("N");

        /// <summary>
        /// An operation called with account ID mode set to preferred.
        /// </summary>
        public static readonly UserAgentFeatureId ACCOUNT_ID_MODE_PREFERRED = new UserAgentFeatureId("P");

        /// <summary>
        /// An operation called with account ID mode set to disabled.
        /// </summary>
        public static readonly UserAgentFeatureId ACCOUNT_ID_MODE_DISABLED = new UserAgentFeatureId("Q");

        /// <summary>
        /// An operation called with account ID mode set to required.
        /// </summary>
        public static readonly UserAgentFeatureId ACCOUNT_ID_MODE_REQUIRED = new UserAgentFeatureId("R");

        /// <summary>
        /// An operation called using sigv4a signing.
        /// </summary>
        public static readonly UserAgentFeatureId SIGV4A_SIGNING = new UserAgentFeatureId("S");

        /// <summary>
        /// An operation where credential resolution resolved an account ID.
        /// </summary>
        public static readonly UserAgentFeatureId RESOLVED_ACCOUNT_ID = new UserAgentFeatureId("T");

        /// <summary>
        /// Operation included a CRC-32  checksum for request payload.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_CRC32 = new UserAgentFeatureId("U");

        /// <summary>
        /// Operation included a CRC-32C checksum for request payload.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_CRC32C = new UserAgentFeatureId("V");

        /// <summary>
        /// Operation included a CRC-64 checksum for request payload.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_CRC64 = new UserAgentFeatureId("W");

        /// <summary>
        /// Operation included a SHA-1 checksum for request payload.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_SHA1 = new UserAgentFeatureId("X");

        /// <summary>
        /// Operation included a SHA-256 checksum for request payload.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_SHA256 = new UserAgentFeatureId("Y");

        /// <summary>
        /// SDK resolved configuration <see cref="RequestChecksumCalculation.WHEN_SUPPORTED"/>.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_WHEN_SUPPORTED = new UserAgentFeatureId("Z");

        /// <summary>
        /// SDK resolved configuration <see cref="RequestChecksumCalculation.WHEN_REQUIRED"/>.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_REQ_WHEN_REQUIRED = new UserAgentFeatureId("a");

        /// <summary>
        /// SDK resolved configuration <see cref="ResponseChecksumValidation.WHEN_SUPPORTED"/>.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_RES_WHEN_SUPPORTED = new UserAgentFeatureId("b");

        /// <summary>
        /// SDK resolved configuration <see cref="ResponseChecksumValidation.WHEN_REQUIRED"/>.
        /// </summary>
        public static readonly UserAgentFeatureId FLEXIBLE_CHECKSUMS_RES_WHEN_REQUIRED = new UserAgentFeatureId("c");

        /// <summary>
        /// An operation called using a DynamoDB Mapper high level library.
        /// </summary>
        public static readonly UserAgentFeatureId DDB_MAPPER = new UserAgentFeatureId("d");

        /// <summary>
        /// An operation called using credentials resolved from code, cli parameters, session object, or client instance.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_CODE = new UserAgentFeatureId("e");

        /// <summary>
        /// An operation called using credentials resolved from environment variables.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_ENV_VARS = new UserAgentFeatureId("g");

        /// <summary>
        /// An operation called using credentials resolved from environment variables for assuming a role with STS using a web identity token.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_ENV_VARS_STS_WEB_ID_TOKEN = new UserAgentFeatureId("h");

        /// <summary>
        /// An operation called using credentials resolved from STS using assume role.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_STS_ASSUME_ROLE = new UserAgentFeatureId("i");

        /// <summary>
        /// An operation called using credentials resolved from STS using assume role with web identity.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_STS_ASSUME_ROLE_WEB_ID = new UserAgentFeatureId("k");

        /// <summary>
        /// An operation called using credentials resolved from STS using assume role with SAML.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_STS_ASSUME_ROLE_SAML = new UserAgentFeatureId("j");

        /// <summary>
        /// An operation called using credentials resolved from STS using a session token.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_STS_SESSION_TOKEN = new UserAgentFeatureId("m");

        /// <summary>
        /// An operation called using credentials resolved from a config file(s) profile with static credentials.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE = new UserAgentFeatureId("n");

        /// <summary>
        /// An operation called using credentials resolved from a source profile in a config file(s) profile.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_SOURCE_PROFILE = new UserAgentFeatureId("o");

        /// <summary>
        /// An operation called using credentials resolved from a named provider in a config file(s) profile.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_NAMED_PROVIDER = new UserAgentFeatureId("p");

        /// <summary>
        /// An operation called using credentials resolved from configuration for assuming a role with STS using web identity token in a config file(s) profile.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_STS_WEB_ID_TOKEN = new UserAgentFeatureId("q");

        /// <summary>
        /// An operation called using credentials resolved from an SSO session in a config file(s) profile.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_SSO = new UserAgentFeatureId("r");

        /// <summary>
        /// An operation called using credentials resolved from an SSO session.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_SSO = new UserAgentFeatureId("s");

        /// <summary>
        /// An operation called using credentials resolved from an SSO session in a config file(s) profile using legacy format.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_SSO_LEGACY = new UserAgentFeatureId("t");

        /// <summary>
        /// An operation called using credentials resolved from an SSO session using legacy format.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_SSO_LEGACY = new UserAgentFeatureId("u");

        /// <summary>
        /// An operation called using credentials resolved from a process in a config file(s) profile.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROFILE_PROCESS = new UserAgentFeatureId("v");

        /// <summary>
        /// An operation called using credentials resolved from a process.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_PROCESS = new UserAgentFeatureId("w");

        /// <summary>
        /// An operation called using credentials resolved from a profile in an AWS SDK store.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_AWS_SDK_STORE = new UserAgentFeatureId("y");

        /// <summary>
        /// An operation called using credentials resolved from an HTTP endpoint.
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_HTTP = new UserAgentFeatureId("z");

        /// <summary>
        /// An operation called using credentials resolved from the instance metadata service (IMDS).
        /// </summary>
        public static readonly UserAgentFeatureId CREDENTIALS_IMDS = new UserAgentFeatureId("0");

        /// <summary>
        /// Calling an SSO-OIDC operation as part of the SSO login flow, when using the OAuth2.0 device code grant.
        /// </summary>
        public static readonly UserAgentFeatureId SSO_LOGIN_DEVICE = new UserAgentFeatureId("1");

        /// <summary>
        /// Calling an SSO-OIDC operation as part of the SSO login flow, when using the OAuth2.0 authorization code grant.
        /// </summary>
        public static readonly UserAgentFeatureId SSO_LOGIN_AUTH = new UserAgentFeatureId("2");

        /// <summary>
        /// Indicates that an AWS SDK client has been configured with a non-null, non-NoOp tracing provider.
        /// </summary>
        public static readonly UserAgentFeatureId OBSERVABILITY_TRACING = new UserAgentFeatureId("4");

        /// <summary>
        /// Indicates that an AWS SDK client has been configured with a non-null, non-NoOp metrics provider.
        /// </summary>
        public static readonly UserAgentFeatureId OBSERVABILITY_METRICS = new UserAgentFeatureId("5");

        /// <summary>
        /// Indicates that an AWS SDK client has been configured with an OpenTelemetry tracing provider.
        /// </summary>
        public static readonly UserAgentFeatureId OBSERVABILITY_OTEL_TRACING = new UserAgentFeatureId("6");

        /// <summary>
        /// Indicates that an AWS SDK client has been configured with an OpenTelemetry metrics provider.
        /// </summary>
        public static readonly UserAgentFeatureId OBSERVABILITY_OTEL_METRICS = new UserAgentFeatureId("7");

        public UserAgentFeatureId(string value) : base(value) { }

        public static UserAgentFeatureId FindValue(string value)
        {
            return FindValue<UserAgentFeatureId>(value);
        }

        public static implicit operator UserAgentFeatureId(string value)
        {
            return FindValue(value);
        }
    }

}
