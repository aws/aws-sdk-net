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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.AmplifyBackend
{

    /// <summary>
    /// Constants used for properties of type AdditionalConstraintsElement.
    /// </summary>
    public class AdditionalConstraintsElement : ConstantClass
    {

        /// <summary>
        /// Constant REQUIRE_DIGIT for AdditionalConstraintsElement
        /// </summary>
        public static readonly AdditionalConstraintsElement REQUIRE_DIGIT = new AdditionalConstraintsElement("REQUIRE_DIGIT");
        /// <summary>
        /// Constant REQUIRE_LOWERCASE for AdditionalConstraintsElement
        /// </summary>
        public static readonly AdditionalConstraintsElement REQUIRE_LOWERCASE = new AdditionalConstraintsElement("REQUIRE_LOWERCASE");
        /// <summary>
        /// Constant REQUIRE_SYMBOL for AdditionalConstraintsElement
        /// </summary>
        public static readonly AdditionalConstraintsElement REQUIRE_SYMBOL = new AdditionalConstraintsElement("REQUIRE_SYMBOL");
        /// <summary>
        /// Constant REQUIRE_UPPERCASE for AdditionalConstraintsElement
        /// </summary>
        public static readonly AdditionalConstraintsElement REQUIRE_UPPERCASE = new AdditionalConstraintsElement("REQUIRE_UPPERCASE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalConstraintsElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalConstraintsElement FindValue(string value)
        {
            return FindValue<AdditionalConstraintsElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalConstraintsElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticatedElement.
    /// </summary>
    public class AuthenticatedElement : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_AND_UPDATE for AuthenticatedElement
        /// </summary>
        public static readonly AuthenticatedElement CREATE_AND_UPDATE = new AuthenticatedElement("CREATE_AND_UPDATE");
        /// <summary>
        /// Constant DELETE for AuthenticatedElement
        /// </summary>
        public static readonly AuthenticatedElement DELETE = new AuthenticatedElement("DELETE");
        /// <summary>
        /// Constant READ for AuthenticatedElement
        /// </summary>
        public static readonly AuthenticatedElement READ = new AuthenticatedElement("READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticatedElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticatedElement FindValue(string value)
        {
            return FindValue<AuthenticatedElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticatedElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthResources.
    /// </summary>
    public class AuthResources : ConstantClass
    {

        /// <summary>
        /// Constant IDENTITY_POOL_AND_USER_POOL for AuthResources
        /// </summary>
        public static readonly AuthResources IDENTITY_POOL_AND_USER_POOL = new AuthResources("IDENTITY_POOL_AND_USER_POOL");
        /// <summary>
        /// Constant USER_POOL_ONLY for AuthResources
        /// </summary>
        public static readonly AuthResources USER_POOL_ONLY = new AuthResources("USER_POOL_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthResources(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthResources FindValue(string value)
        {
            return FindValue<AuthResources>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthResources(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryMethod.
    /// </summary>
    public class DeliveryMethod : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for DeliveryMethod
        /// </summary>
        public static readonly DeliveryMethod EMAIL = new DeliveryMethod("EMAIL");
        /// <summary>
        /// Constant SMS for DeliveryMethod
        /// </summary>
        public static readonly DeliveryMethod SMS = new DeliveryMethod("SMS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryMethod FindValue(string value)
        {
            return FindValue<DeliveryMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MFAMode.
    /// </summary>
    public class MFAMode : ConstantClass
    {

        /// <summary>
        /// Constant OFF for MFAMode
        /// </summary>
        public static readonly MFAMode OFF = new MFAMode("OFF");
        /// <summary>
        /// Constant ON for MFAMode
        /// </summary>
        public static readonly MFAMode ON = new MFAMode("ON");
        /// <summary>
        /// Constant OPTIONAL for MFAMode
        /// </summary>
        public static readonly MFAMode OPTIONAL = new MFAMode("OPTIONAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MFAMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MFAMode FindValue(string value)
        {
            return FindValue<MFAMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MFAMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MfaTypesElement.
    /// </summary>
    public class MfaTypesElement : ConstantClass
    {

        /// <summary>
        /// Constant SMS for MfaTypesElement
        /// </summary>
        public static readonly MfaTypesElement SMS = new MfaTypesElement("SMS");
        /// <summary>
        /// Constant TOTP for MfaTypesElement
        /// </summary>
        public static readonly MfaTypesElement TOTP = new MfaTypesElement("TOTP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MfaTypesElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MfaTypesElement FindValue(string value)
        {
            return FindValue<MfaTypesElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MfaTypesElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_COGNITO_USER_POOLS for Mode
        /// </summary>
        public static readonly Mode AMAZON_COGNITO_USER_POOLS = new Mode("AMAZON_COGNITO_USER_POOLS");
        /// <summary>
        /// Constant API_KEY for Mode
        /// </summary>
        public static readonly Mode API_KEY = new Mode("API_KEY");
        /// <summary>
        /// Constant AWS_IAM for Mode
        /// </summary>
        public static readonly Mode AWS_IAM = new Mode("AWS_IAM");
        /// <summary>
        /// Constant OPENID_CONNECT for Mode
        /// </summary>
        public static readonly Mode OPENID_CONNECT = new Mode("OPENID_CONNECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mode FindValue(string value)
        {
            return FindValue<Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OAuthGrantType.
    /// </summary>
    public class OAuthGrantType : ConstantClass
    {

        /// <summary>
        /// Constant CODE for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType CODE = new OAuthGrantType("CODE");
        /// <summary>
        /// Constant IMPLICIT for OAuthGrantType
        /// </summary>
        public static readonly OAuthGrantType IMPLICIT = new OAuthGrantType("IMPLICIT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuthGrantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthGrantType FindValue(string value)
        {
            return FindValue<OAuthGrantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthGrantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OAuthScopesElement.
    /// </summary>
    public class OAuthScopesElement : ConstantClass
    {

        /// <summary>
        /// Constant AWS_COGNITO_SIGNIN_USER_ADMIN for OAuthScopesElement
        /// </summary>
        public static readonly OAuthScopesElement AWS_COGNITO_SIGNIN_USER_ADMIN = new OAuthScopesElement("AWS_COGNITO_SIGNIN_USER_ADMIN");
        /// <summary>
        /// Constant EMAIL for OAuthScopesElement
        /// </summary>
        public static readonly OAuthScopesElement EMAIL = new OAuthScopesElement("EMAIL");
        /// <summary>
        /// Constant OPENID for OAuthScopesElement
        /// </summary>
        public static readonly OAuthScopesElement OPENID = new OAuthScopesElement("OPENID");
        /// <summary>
        /// Constant PHONE for OAuthScopesElement
        /// </summary>
        public static readonly OAuthScopesElement PHONE = new OAuthScopesElement("PHONE");
        /// <summary>
        /// Constant PROFILE for OAuthScopesElement
        /// </summary>
        public static readonly OAuthScopesElement PROFILE = new OAuthScopesElement("PROFILE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OAuthScopesElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OAuthScopesElement FindValue(string value)
        {
            return FindValue<OAuthScopesElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OAuthScopesElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequiredSignUpAttributesElement.
    /// </summary>
    public class RequiredSignUpAttributesElement : ConstantClass
    {

        /// <summary>
        /// Constant ADDRESS for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement ADDRESS = new RequiredSignUpAttributesElement("ADDRESS");
        /// <summary>
        /// Constant BIRTHDATE for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement BIRTHDATE = new RequiredSignUpAttributesElement("BIRTHDATE");
        /// <summary>
        /// Constant EMAIL for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement EMAIL = new RequiredSignUpAttributesElement("EMAIL");
        /// <summary>
        /// Constant FAMILY_NAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement FAMILY_NAME = new RequiredSignUpAttributesElement("FAMILY_NAME");
        /// <summary>
        /// Constant GENDER for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement GENDER = new RequiredSignUpAttributesElement("GENDER");
        /// <summary>
        /// Constant GIVEN_NAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement GIVEN_NAME = new RequiredSignUpAttributesElement("GIVEN_NAME");
        /// <summary>
        /// Constant LOCALE for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement LOCALE = new RequiredSignUpAttributesElement("LOCALE");
        /// <summary>
        /// Constant MIDDLE_NAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement MIDDLE_NAME = new RequiredSignUpAttributesElement("MIDDLE_NAME");
        /// <summary>
        /// Constant NAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement NAME = new RequiredSignUpAttributesElement("NAME");
        /// <summary>
        /// Constant NICKNAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement NICKNAME = new RequiredSignUpAttributesElement("NICKNAME");
        /// <summary>
        /// Constant PHONE_NUMBER for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement PHONE_NUMBER = new RequiredSignUpAttributesElement("PHONE_NUMBER");
        /// <summary>
        /// Constant PICTURE for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement PICTURE = new RequiredSignUpAttributesElement("PICTURE");
        /// <summary>
        /// Constant PREFERRED_USERNAME for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement PREFERRED_USERNAME = new RequiredSignUpAttributesElement("PREFERRED_USERNAME");
        /// <summary>
        /// Constant PROFILE for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement PROFILE = new RequiredSignUpAttributesElement("PROFILE");
        /// <summary>
        /// Constant UPDATED_AT for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement UPDATED_AT = new RequiredSignUpAttributesElement("UPDATED_AT");
        /// <summary>
        /// Constant WEBSITE for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement WEBSITE = new RequiredSignUpAttributesElement("WEBSITE");
        /// <summary>
        /// Constant ZONE_INFO for RequiredSignUpAttributesElement
        /// </summary>
        public static readonly RequiredSignUpAttributesElement ZONE_INFO = new RequiredSignUpAttributesElement("ZONE_INFO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequiredSignUpAttributesElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequiredSignUpAttributesElement FindValue(string value)
        {
            return FindValue<RequiredSignUpAttributesElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequiredSignUpAttributesElement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolutionStrategy.
    /// </summary>
    public class ResolutionStrategy : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMERGE for ResolutionStrategy
        /// </summary>
        public static readonly ResolutionStrategy AUTOMERGE = new ResolutionStrategy("AUTOMERGE");
        /// <summary>
        /// Constant LAMBDA for ResolutionStrategy
        /// </summary>
        public static readonly ResolutionStrategy LAMBDA = new ResolutionStrategy("LAMBDA");
        /// <summary>
        /// Constant NONE for ResolutionStrategy
        /// </summary>
        public static readonly ResolutionStrategy NONE = new ResolutionStrategy("NONE");
        /// <summary>
        /// Constant OPTIMISTIC_CONCURRENCY for ResolutionStrategy
        /// </summary>
        public static readonly ResolutionStrategy OPTIMISTIC_CONCURRENCY = new ResolutionStrategy("OPTIMISTIC_CONCURRENCY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolutionStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolutionStrategy FindValue(string value)
        {
            return FindValue<ResolutionStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolutionStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Service.
    /// </summary>
    public class Service : ConstantClass
    {

        /// <summary>
        /// Constant COGNITO for Service
        /// </summary>
        public static readonly Service COGNITO = new Service("COGNITO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Service(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Service FindValue(string value)
        {
            return FindValue<Service>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Service(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceName.
    /// </summary>
    public class ServiceName : ConstantClass
    {

        /// <summary>
        /// Constant S3 for ServiceName
        /// </summary>
        public static readonly ServiceName S3 = new ServiceName("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceName FindValue(string value)
        {
            return FindValue<ServiceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SignInMethod.
    /// </summary>
    public class SignInMethod : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for SignInMethod
        /// </summary>
        public static readonly SignInMethod EMAIL = new SignInMethod("EMAIL");
        /// <summary>
        /// Constant EMAIL_AND_PHONE_NUMBER for SignInMethod
        /// </summary>
        public static readonly SignInMethod EMAIL_AND_PHONE_NUMBER = new SignInMethod("EMAIL_AND_PHONE_NUMBER");
        /// <summary>
        /// Constant PHONE_NUMBER for SignInMethod
        /// </summary>
        public static readonly SignInMethod PHONE_NUMBER = new SignInMethod("PHONE_NUMBER");
        /// <summary>
        /// Constant USERNAME for SignInMethod
        /// </summary>
        public static readonly SignInMethod USERNAME = new SignInMethod("USERNAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SignInMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SignInMethod FindValue(string value)
        {
            return FindValue<SignInMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SignInMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant LATEST for Status
        /// </summary>
        public static readonly Status LATEST = new Status("LATEST");
        /// <summary>
        /// Constant STALE for Status
        /// </summary>
        public static readonly Status STALE = new Status("STALE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnAuthenticatedElement.
    /// </summary>
    public class UnAuthenticatedElement : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_AND_UPDATE for UnAuthenticatedElement
        /// </summary>
        public static readonly UnAuthenticatedElement CREATE_AND_UPDATE = new UnAuthenticatedElement("CREATE_AND_UPDATE");
        /// <summary>
        /// Constant DELETE for UnAuthenticatedElement
        /// </summary>
        public static readonly UnAuthenticatedElement DELETE = new UnAuthenticatedElement("DELETE");
        /// <summary>
        /// Constant READ for UnAuthenticatedElement
        /// </summary>
        public static readonly UnAuthenticatedElement READ = new UnAuthenticatedElement("READ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnAuthenticatedElement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnAuthenticatedElement FindValue(string value)
        {
            return FindValue<UnAuthenticatedElement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnAuthenticatedElement(string value)
        {
            return FindValue(value);
        }
    }

}