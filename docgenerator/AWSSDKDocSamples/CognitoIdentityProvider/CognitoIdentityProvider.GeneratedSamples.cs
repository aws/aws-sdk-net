using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;

namespace AWSSDKDocSamples.Amazon.CognitoIdentityProvider.Generated
{
    class CognitoIdentityProviderSamples : ISample
    {
        public void CognitoIdentityProviderAdminCreateUser()
        {
            #region an-admincreateuser-request-for-for-a-test-user-named-john-1689980900481

            var client = new AmazonCognitoIdentityProviderClient();
            var response = client.AdminCreateUser(new AdminCreateUserRequest 
            {
                DesiredDeliveryMediums = new List<string> {
                    "SMS"
                },
                MessageAction = "SUPPRESS",
                TemporaryPassword = "This-is-my-test-99!",
                UserAttributes = new List<AttributeType> {
                    new AttributeType {
                        Name = "name",
                        Value = "John"
                    },
                    new AttributeType {
                        Name = "phone_number",
                        Value = "+12065551212"
                    },
                    new AttributeType {
                        Name = "email",
                        Value = "testuser@example.com"
                    }
                },
                UserPoolId = "us-east-1_EXAMPLE",
                Username = "testuser"
            });

            UserType user = response.User;

            #endregion
        }

        public void CognitoIdentityProviderCreateUserPool()
        {
            #region example-user-pool-with-email-and-username-sign-in-1689722835145

            var client = new AmazonCognitoIdentityProviderClient();
            var response = client.CreateUserPool(new CreateUserPoolRequest 
            {
                AccountRecoverySetting = new AccountRecoverySettingType { RecoveryMechanisms = new List<RecoveryOptionType> {
                    new RecoveryOptionType {
                        Name = "verified_email",
                        Priority = 1
                    }
                } },
                AdminCreateUserConfig = new AdminCreateUserConfigType {
                    AllowAdminCreateUserOnly = false,
                    InviteMessageTemplate = new MessageTemplateType {
                        EmailMessage = "Your username is {username} and temporary password is {####}.",
                        EmailSubject = "Your sign-in information",
                        SMSMessage = "Your username is {username} and temporary password is {####}."
                    }
                },
                AliasAttributes = new List<string> {
                    "email"
                },
                AutoVerifiedAttributes = new List<string> {
                    "email"
                },
                DeletionProtection = "ACTIVE",
                DeviceConfiguration = new DeviceConfigurationType {
                    ChallengeRequiredOnNewDevice = true,
                    DeviceOnlyRememberedOnUserPrompt = true
                },
                EmailConfiguration = new EmailConfigurationType {
                    ConfigurationSet = "my-test-ses-configuration-set",
                    EmailSendingAccount = "DEVELOPER",
                    From = "support@example.com",
                    ReplyToEmailAddress = "support@example.com",
                    SourceArn = "arn:aws:ses:us-east-1:123456789012:identity/support@example.com"
                },
                EmailVerificationMessage = "Your verification code is {####}.",
                EmailVerificationSubject = "Verify your email address",
                LambdaConfig = new LambdaConfigType {
                    CustomEmailSender = new CustomEmailLambdaVersionConfigType {
                        LambdaArn = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                        LambdaVersion = "V1_0"
                    },
                    CustomMessage = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    CustomSMSSender = new CustomSMSLambdaVersionConfigType {
                        LambdaArn = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                        LambdaVersion = "V1_0"
                    },
                    DefineAuthChallenge = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    KMSKeyID = "arn:aws:kms:us-east-1:123456789012:key/a6c4f8e2-0c45-47db-925f-87854bc9e357",
                    PostAuthentication = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    PostConfirmation = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    PreAuthentication = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    PreSignUp = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    PreTokenGeneration = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    UserMigration = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction",
                    VerifyAuthChallengeResponse = "arn:aws:lambda:us-east-1:123456789012:function:MyFunction"
                },
                MfaConfiguration = "OPTIONAL",
                Policies = new UserPoolPolicyType { PasswordPolicy = new PasswordPolicyType {
                    MinimumLength = 6,
                    RequireLowercase = true,
                    RequireNumbers = true,
                    RequireSymbols = true,
                    RequireUppercase = true,
                    TemporaryPasswordValidityDays = 7
                } },
                PoolName = "my-test-user-pool",
                Schema = new List<SchemaAttributeType> {
                    new SchemaAttributeType {
                        AttributeDataType = "Number",
                        DeveloperOnlyAttribute = true,
                        Mutable = true,
                        Name = "mydev",
                        NumberAttributeConstraints = new NumberAttributeConstraintsType {
                            MaxValue = "99",
                            MinValue = "1"
                        },
                        Required = false,
                        StringAttributeConstraints = new StringAttributeConstraintsType {
                            MaxLength = "99",
                            MinLength = "1"
                        }
                    }
                },
                SmsAuthenticationMessage = "Your verification code is {####}.",
                SmsConfiguration = new SmsConfigurationType {
                    ExternalId = "my-role-external-id",
                    SnsCallerArn = "arn:aws:iam::123456789012:role/service-role/test-cognito-SMS-Role"
                },
                SmsVerificationMessage = "Your verification code is {####}.",
                UserAttributeUpdateSettings = new UserAttributeUpdateSettingsType { AttributesRequireVerificationBeforeUpdate = new List<string> {
                    "email"
                } },
                UserPoolAddOns = new UserPoolAddOnsType { AdvancedSecurityMode = "OFF" },
                UserPoolTags = new Dictionary<string, string> {
                    { "my-test-tag-key", "my-test-tag-key" }
                },
                UsernameConfiguration = new UsernameConfigurationType { CaseSensitive = true },
                VerificationMessageTemplate = new VerificationMessageTemplateType {
                    DefaultEmailOption = "CONFIRM_WITH_CODE",
                    EmailMessage = "Your confirmation code is {####}",
                    EmailMessageByLink = "Choose this link to {##verify your email##}",
                    EmailSubject = "Here is your confirmation code",
                    EmailSubjectByLink = "Here is your confirmation link",
                    SmsMessage = "Your confirmation code is {####}"
                }
            });

            UserPoolType userPool = response.UserPool;

            #endregion
        }

        public void CognitoIdentityProviderCreateUserPoolClient()
        {
            #region example-user-pool-app-client-with-email-and-username-sign-in-1689885750745

            var client = new AmazonCognitoIdentityProviderClient();
            var response = client.CreateUserPoolClient(new CreateUserPoolClientRequest 
            {
                AccessTokenValidity = 6,
                AllowedOAuthFlows = new List<string> {
                    "code"
                },
                AllowedOAuthFlowsUserPoolClient = true,
                AllowedOAuthScopes = new List<string> {
                    "aws.cognito.signin.user.admin",
                    "openid"
                },
                AnalyticsConfiguration = new AnalyticsConfigurationType {
                    ApplicationId = "d70b2ba36a8c4dc5a04a0451a31a1e12",
                    ExternalId = "my-external-id",
                    RoleArn = "arn:aws:iam::123456789012:role/test-cognitouserpool-role",
                    UserDataShared = true
                },
                CallbackURLs = new List<string> {
                    "https://example.com",
                    "http://localhost",
                    "myapp://example"
                },
                ClientName = "my-test-app-client",
                DefaultRedirectURI = "https://example.com",
                ExplicitAuthFlows = new List<string> {
                    "ALLOW_ADMIN_USER_PASSWORD_AUTH",
                    "ALLOW_USER_PASSWORD_AUTH",
                    "ALLOW_REFRESH_TOKEN_AUTH"
                },
                GenerateSecret = true,
                IdTokenValidity = 6,
                LogoutURLs = new List<string> {
                    "https://example.com/logout"
                },
                PreventUserExistenceErrors = "ENABLED",
                ReadAttributes = new List<string> {
                    "email",
                    "address",
                    "preferred_username"
                },
                RefreshTokenValidity = 6,
                SupportedIdentityProviders = new List<string> {
                    "SignInWithApple",
                    "MySSO"
                },
                TokenValidityUnits = new TokenValidityUnitsType {
                    AccessToken = "hours",
                    IdToken = "minutes",
                    RefreshToken = "days"
                },
                UserPoolId = "us-east-1_EXAMPLE",
                WriteAttributes = new List<string> {
                    "family_name",
                    "email"
                }
            });

            UserPoolClientType userPoolClient = response.UserPoolClient;

            #endregion
        }

        public void CognitoIdentityProviderInitiateAuth()
        {
            #region example-username-and-password-sign-in-for-a-user-who-has-totp-mfa-1689887395219

            var client = new AmazonCognitoIdentityProviderClient();
            var response = client.InitiateAuth(new InitiateAuthRequest 
            {
                AnalyticsMetadata = new AnalyticsMetadataType { AnalyticsEndpointId = "d70b2ba36a8c4dc5a04a0451a31a1e12" },
                AuthFlow = "USER_PASSWORD_AUTH",
                AuthParameters = new Dictionary<string, string> {
                    { "PASSWORD", "This-is-my-test-99!" },
                    { "SECRET_HASH", "oT5ZkS8ctnrhYeeGsGTvOzPhoc/Jd1cO5fueBWFVmp8=" },
                    { "USERNAME", "mytestuser" }
                },
                ClientId = "1example23456789",
                ClientMetadata = new Dictionary<string, string> {
                    { "MyTestKey", "MyTestValue" }
                },
                UserContextData = new UserContextDataType {
                    EncodedData = "AmazonCognitoAdvancedSecurityData_object",
                    IpAddress = "192.0.2.1"
                }
            });

            string challengeName = response.ChallengeName;
            Dictionary<string, string> challengeParameters = response.ChallengeParameters;
            string session = response.Session;

            #endregion
        }

        public void CognitoIdentityProviderListUsers()
        {
            #region a-listusers-request-for-the-next-3-users-whose-email-address-starts-with-testuser-1689977648246

            var client = new AmazonCognitoIdentityProviderClient();
            var response = client.ListUsers(new ListUsersRequest 
            {
                AttributesToGet = new List<string> {
                    "email",
                    "sub"
                },
                Filter = "\"email\"^=\"testuser\"",
                Limit = 3,
                PaginationToken = "abcd1234EXAMPLE",
                UserPoolId = "us-east-1_EXAMPLE"
            });

            string paginationToken = response.PaginationToken;
            List<UserType> users = response.Users;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}