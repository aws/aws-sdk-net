using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.VerifiedPermissions;
using Amazon.VerifiedPermissions.Model;

namespace AWSSDKDocSamples.Amazon.VerifiedPermissions.Generated
{
    class VerifiedPermissionsSamples : ISample
    {
        public void VerifiedPermissionsBatchGetPolicy()
        {
            #region BatchGetPolicy-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.BatchGetPolicy(new BatchGetPolicyRequest
            {
                Requests = new List<BatchGetPolicyInputItem> {
                    new BatchGetPolicyInputItem {
                        PolicyId = "PWv5M6d5HePx3gVVLKY1nK",
                        PolicyStoreId = "ERZeDpRc34dkYZeb6FZRVC"
                    },
                    new BatchGetPolicyInputItem {
                        PolicyId = "LzFn6KgLWvv4Mbegus35jn",
                        PolicyStoreId = "ERZeDpRc34dkYZeb6FZRVC"
                    },
                    new BatchGetPolicyInputItem {
                        PolicyId = "77gLjer8H5o3mvrnMGrSL5",
                        PolicyStoreId = "ERZeDpRc34dkYZeb6FZRVC"
                    }
                }
            });

            List<BatchGetPolicyErrorItem> errors = response.Errors;
            List<BatchGetPolicyOutputItem> results = response.Results;

            #endregion
        }

        public void VerifiedPermissionsBatchGetPolicy()
        {
            #region BatchGetPolicy-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.BatchGetPolicy(new BatchGetPolicyRequest
            {
                Requests = new List<BatchGetPolicyInputItem> {
                    new BatchGetPolicyInputItem {
                        PolicyId = "name/example-policy",
                        PolicyStoreId = "ERZeDpRc34dkYZeb6FZRVC"
                    },
                    new BatchGetPolicyInputItem {
                        PolicyId = "name/example-policy-2",
                        PolicyStoreId = "ERZeDpRc34dkYZeb6FZRVC"
                    }
                }
            });

            List<BatchGetPolicyErrorItem> errors = response.Errors;
            List<BatchGetPolicyOutputItem> results = response.Results;

            #endregion
        }

        public void VerifiedPermissionsBatchIsAuthorized()
        {
            #region BatchIsAuthorized-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.BatchIsAuthorized(new BatchIsAuthorizedRequest
            {
                Entities = new EntitiesDefinition { EntityList = new List<EntityItem> {
                    new EntityItem {
                        Attributes = new Dictionary<string, AttributeValue> {
                            { "Account", new AttributeValue { EntityIdentifier = new EntityIdentifier {
                                EntityId = "1234",
                                EntityType = "PhotoFlash::Account"
                            } } },
                            { "Email", new AttributeValue { String = "" } }
                        },
                        Identifier = new EntityIdentifier {
                            EntityId = "Alice",
                            EntityType = "PhotoFlash::User"
                        },
                        Parents = new List<EntityIdentifier> {
                        }
                    },
                    new EntityItem {
                        Attributes = new Dictionary<string, AttributeValue> {
                            { "Account", new AttributeValue { EntityIdentifier = new EntityIdentifier {
                                EntityId = "5678",
                                EntityType = "PhotoFlash::Account"
                            } } },
                            { "Email", new AttributeValue { String = "" } }
                        },
                        Identifier = new EntityIdentifier {
                            EntityId = "Annalisa",
                            EntityType = "PhotoFlash::User"
                        },
                        Parents = new List<EntityIdentifier> {
                        }
                    },
                    new EntityItem {
                        Attributes = new Dictionary<string, AttributeValue> {
                            { "IsPrivate", new AttributeValue { Boolean = false } },
                            { "Name", new AttributeValue { String = "" } }
                        },
                        Identifier = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        },
                        Parents = new List<EntityIdentifier> {
                            new EntityIdentifier {
                                EntityId = "1234",
                                EntityType = "PhotoFlash::Account"
                            }
                        }
                    },
                    new EntityItem {
                        Attributes = new Dictionary<string, AttributeValue> {
                            { "Name", new AttributeValue { String = "" } }
                        },
                        Identifier = new EntityIdentifier {
                            EntityId = "1234",
                            EntityType = "PhotoFlash::Account"
                        },
                        Parents = new List<EntityIdentifier> {
                        }
                    }
                } },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Requests = new List<BatchIsAuthorizedInputItem> {
                    new BatchIsAuthorizedInputItem {
                        Action = new ActionIdentifier {
                            ActionId = "ViewPhoto",
                            ActionType = "PhotoFlash::Action"
                        },
                        Principal = new EntityIdentifier {
                            EntityId = "Alice",
                            EntityType = "PhotoFlash::User"
                        },
                        Resource = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        }
                    },
                    new BatchIsAuthorizedInputItem {
                        Action = new ActionIdentifier {
                            ActionId = "DeletePhoto",
                            ActionType = "PhotoFlash::Action"
                        },
                        Principal = new EntityIdentifier {
                            EntityId = "Annalisa",
                            EntityType = "PhotoFlash::User"
                        },
                        Resource = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        }
                    }
                }
            });

            List<BatchIsAuthorizedOutputItem> results = response.Results;

            #endregion
        }

        public void VerifiedPermissionsBatchIsAuthorizedWithToken()
        {
            #region BatchIsAuthorizedWithToken-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.BatchIsAuthorizedWithToken(new BatchIsAuthorizedWithTokenRequest
            {
                Entities = new EntitiesDefinition { EntityList = new List<EntityItem> {
                    new EntityItem {
                        Identifier = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        },
                        Parents = new List<EntityIdentifier> {
                            new EntityIdentifier {
                                EntityId = "MyExampleAlbum1",
                                EntityType = "PhotoFlash::Album"
                            }
                        }
                    },
                    new EntityItem {
                        Identifier = new EntityIdentifier {
                            EntityId = "OfficePhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        },
                        Parents = new List<EntityIdentifier> {
                            new EntityIdentifier {
                                EntityId = "MyExampleAlbum2",
                                EntityType = "PhotoFlash::Album"
                            }
                        }
                    }
                } },
                IdentityToken = "eyJra12345EXAMPLE",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Requests = new List<BatchIsAuthorizedWithTokenInputItem> {
                    new BatchIsAuthorizedWithTokenInputItem {
                        Action = new ActionIdentifier {
                            ActionId = "ViewPhoto",
                            ActionType = "PhotoFlash::Action"
                        },
                        Resource = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        }
                    },
                    new BatchIsAuthorizedWithTokenInputItem {
                        Action = new ActionIdentifier {
                            ActionId = "SharePhoto",
                            ActionType = "PhotoFlash::Action"
                        },
                        Resource = new EntityIdentifier {
                            EntityId = "VacationPhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        }
                    },
                    new BatchIsAuthorizedWithTokenInputItem {
                        Action = new ActionIdentifier {
                            ActionId = "ViewPhoto",
                            ActionType = "PhotoFlash::Action"
                        },
                        Resource = new EntityIdentifier {
                            EntityId = "OfficePhoto94.jpg",
                            EntityType = "PhotoFlash::Photo"
                        }
                    }
                }
            });

            EntityIdentifier principal = response.Principal;
            List<BatchIsAuthorizedWithTokenOutputItem> results = response.Results;

            #endregion
        }

        public void VerifiedPermissionsCreateIdentitySource()
        {
            #region CreateIdentitySource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreateIdentitySource(new CreateIdentitySourceRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                Configuration = new Configuration { CognitoUserPoolConfiguration = new CognitoUserPoolConfiguration {
                    ClientIds = new List<string> {
                        "a1b2c3d4e5f6g7h8i9j0kalbmc"
                    },
                    UserPoolArn = "arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5"
                } },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                PrincipalEntityType = "User"
            });

            DateTime? createdDate = response.CreatedDate;
            string identitySourceId = response.IdentitySourceId;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicy()
        {
            #region CreatePolicy-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicy(new CreatePolicyRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                Definition = new PolicyDefinition { Static = new StaticPolicyDefinition {
                    Description = "Grant members of janeFriends UserGroup access to the vacationFolder Album",
                    Statement = "permit( principal in UserGroup::\"janeFriends\", action, resource in Album::\"vacationFolder\" );"
                } },
                Name = "name/example-policy",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyId = response.PolicyId;
            string policyStoreId = response.PolicyStoreId;
            PolicyType policyType = response.PolicyType;
            EntityIdentifier principal = response.Principal;
            EntityIdentifier resource = response.Resource;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicy()
        {
            #region CreatePolicy-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicy(new CreatePolicyRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                Definition = new PolicyDefinition { TemplateLinked = new TemplateLinkedPolicyDefinition {
                    PolicyTemplateId = "PTEXAMPLEabcdefg111111",
                    Principal = new EntityIdentifier {
                        EntityId = "alice",
                        EntityType = "User"
                    }
                } },
                Name = "name/example-template-linked-policy",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyId = response.PolicyId;
            string policyStoreId = response.PolicyStoreId;
            PolicyType policyType = response.PolicyType;
            EntityIdentifier principal = response.Principal;
            EntityIdentifier resource = response.Resource;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicyStore()
        {
            #region CreatePolicyStore-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicyStore(new CreatePolicyStoreRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                ValidationSettings = new ValidationSettings { Mode = "STRICT" }
            });

            string arn = response.Arn;
            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicyStore()
        {
            #region CreatePolicyStore-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicyStore(new CreatePolicyStoreRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                EncryptionSettings = new EncryptionSettings { KmsEncryptionSettings = new KmsEncryptionSettings {
                    EncryptionContext = new Dictionary<string, string> {
                        { "policy_store_owner", "Tim" }
                    },
                    Key = "arn:aws:kms:us-east-1:123456789012:key/abcdefgh-ijkl-mnop-qrst-uvwxyz123456"
                } },
                ValidationSettings = new ValidationSettings { Mode = "STRICT" }
            });

            string arn = response.Arn;
            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicyStoreAlias()
        {
            #region CreatePolicyStoreAlias-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicyStoreAlias(new CreatePolicyStoreAliasRequest
            {
                AliasName = "policy-store-alias/example-policy-store",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            string aliasArn = response.AliasArn;
            string aliasName = response.AliasName;
            DateTime? createdAt = response.CreatedAt;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsCreatePolicyTemplate()
        {
            #region CreatePolicyTemplate-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.CreatePolicyTemplate(new CreatePolicyTemplateRequest
            {
                ClientToken = "a1b2c3d4-e5f6-a1b2-c3d4-TOKEN1111111",
                Description = "Template for research dept",
                Name = "name/example-policy-template",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Statement = "\"AccessVacation\"\npermit(\n    principal in ?principal,\n    action == Action::\"view\",\n    resource == Photo::\"VacationPhoto94.jpg\"\n)\nwhen {\n    principal has department && principal.department == \"research\"\n};"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            string policyTemplateId = response.PolicyTemplateId;

            #endregion
        }

        public void VerifiedPermissionsDeleteIdentitySource()
        {
            #region DeleteIdentitySource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeleteIdentitySource(new DeleteIdentitySourceRequest
            {
                IdentitySourceId = "ISEXAMPLEabcdefg111111",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });


            #endregion
        }

        public void VerifiedPermissionsDeletePolicy()
        {
            #region DeletePolicy-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeletePolicy(new DeletePolicyRequest
            {
                PolicyId = "9wYxMpljbbZQb5fcZHyJhY",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });


            #endregion
        }

        public void VerifiedPermissionsDeletePolicyStore()
        {
            #region DeletePolicyStore-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeletePolicyStore(new DeletePolicyStoreRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });


            #endregion
        }

        public void VerifiedPermissionsDeletePolicyStoreAlias()
        {
            #region DeletePolicyStoreAlias-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeletePolicyStoreAlias(new DeletePolicyStoreAliasRequest
            {
                AliasName = "policy-store-alias/example-policy-store"
            });


            #endregion
        }

        public void VerifiedPermissionsDeletePolicyStoreAlias()
        {
            #region DeletePolicyStoreAlias-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeletePolicyStoreAlias(new DeletePolicyStoreAliasRequest
            {
                AliasName = "policy-store-alias/example-policy-store",
                DeletionMode = "HardDelete"
            });


            #endregion
        }

        public void VerifiedPermissionsDeletePolicyTemplate()
        {
            #region DeletePolicyTemplate-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.DeletePolicyTemplate(new DeletePolicyTemplateRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                PolicyTemplateId = "PTEXAMPLEabcdefg111111"
            });


            #endregion
        }

        public void VerifiedPermissionsGetIdentitySource()
        {
            #region GetIdentitySource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetIdentitySource(new GetIdentitySourceRequest
            {
                IdentitySourceId = "ISEXAMPLEabcdefg111111",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            IdentitySourceDetails details = response.Details;
            string identitySourceId = response.IdentitySourceId;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            string principalEntityType = response.PrincipalEntityType;

            #endregion
        }

        public void VerifiedPermissionsGetPolicy()
        {
            #region GetPolicy-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicy(new GetPolicyRequest
            {
                PolicyId = "9wYixMplbbZQb5fcZHyJhY",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            PolicyDefinitionDetail definition = response.Definition;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyId = response.PolicyId;
            string policyStoreId = response.PolicyStoreId;
            PolicyType policyType = response.PolicyType;
            EntityIdentifier resource = response.Resource;

            #endregion
        }

        public void VerifiedPermissionsGetPolicy()
        {
            #region GetPolicy-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicy(new GetPolicyRequest
            {
                PolicyId = "name/example-policy",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            PolicyDefinitionDetail definition = response.Definition;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            string policyId = response.PolicyId;
            string policyStoreId = response.PolicyStoreId;
            PolicyType policyType = response.PolicyType;
            EntityIdentifier resource = response.Resource;

            #endregion
        }

        public void VerifiedPermissionsGetPolicyStore()
        {
            #region GetPolicyStore-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicyStore(new GetPolicyStoreRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            string arn = response.Arn;
            DateTime? createdDate = response.CreatedDate;
            EncryptionState encryptionState = response.EncryptionState;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            ValidationSettings validationSettings = response.ValidationSettings;

            #endregion
        }

        public void VerifiedPermissionsGetPolicyStore()
        {
            #region GetPolicyStore-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicyStore(new GetPolicyStoreRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            string arn = response.Arn;
            DateTime? createdDate = response.CreatedDate;
            EncryptionState encryptionState = response.EncryptionState;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            ValidationSettings validationSettings = response.ValidationSettings;

            #endregion
        }

        public void VerifiedPermissionsGetPolicyStoreAlias()
        {
            #region GetPolicyStoreAlias-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicyStoreAlias(new GetPolicyStoreAliasRequest
            {
                AliasName = "policy-store-alias/example-policy-store"
            });

            string aliasArn = response.AliasArn;
            string aliasName = response.AliasName;
            DateTime? createdAt = response.CreatedAt;
            string policyStoreId = response.PolicyStoreId;
            AliasState state = response.State;

            #endregion
        }

        public void VerifiedPermissionsGetPolicyTemplate()
        {
            #region GetPolicyTemplate-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicyTemplate(new GetPolicyTemplateRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                PolicyTemplateId = "PTEXAMPLEabcdefg111111"
            });

            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            string policyTemplateId = response.PolicyTemplateId;
            string statement = response.Statement;

            #endregion
        }

        public void VerifiedPermissionsGetPolicyTemplate()
        {
            #region GetPolicyTemplate-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetPolicyTemplate(new GetPolicyTemplateRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                PolicyTemplateId = "name/example-policy-template"
            });

            DateTime? createdDate = response.CreatedDate;
            string description = response.Description;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string name = response.Name;
            string policyStoreId = response.PolicyStoreId;
            string policyTemplateId = response.PolicyTemplateId;
            string statement = response.Statement;

            #endregion
        }

        public void VerifiedPermissionsGetSchema()
        {
            #region GetSchema-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.GetSchema(new GetSchemaRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            string schema = response.Schema;

            #endregion
        }

        public void VerifiedPermissionsIsAuthorized()
        {
            #region IsAuthorized-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.IsAuthorized(new IsAuthorizedRequest
            {
                Action = new ActionIdentifier {
                    ActionId = "updatePhoto",
                    ActionType = "Action"
                },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Principal = new EntityIdentifier {
                    EntityId = "alice",
                    EntityType = "User"
                },
                Resource = new EntityIdentifier {
                    EntityId = "VacationPhoto94.jpg",
                    EntityType = "Photo"
                }
            });

            Decision decision = response.Decision;
            List<DeterminingPolicyItem> determiningPolicies = response.DeterminingPolicies;
            List<EvaluationErrorItem> errors = response.Errors;

            #endregion
        }

        public void VerifiedPermissionsIsAuthorized()
        {
            #region IsAuthorized-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.IsAuthorized(new IsAuthorizedRequest
            {
                Action = new ActionIdentifier {
                    ActionId = "view",
                    ActionType = "Action"
                },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Principal = new EntityIdentifier {
                    EntityId = "bob",
                    EntityType = "User"
                },
                Resource = new EntityIdentifier {
                    EntityId = "VacationPhoto94.jpg",
                    EntityType = "Photo"
                }
            });

            Decision decision = response.Decision;
            List<DeterminingPolicyItem> determiningPolicies = response.DeterminingPolicies;
            List<EvaluationErrorItem> errors = response.Errors;

            #endregion
        }

        public void VerifiedPermissionsIsAuthorizedWithToken()
        {
            #region IsAuthorizedWithToken-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.IsAuthorizedWithToken(new IsAuthorizedWithTokenRequest
            {
                Action = new ActionIdentifier {
                    ActionId = "View",
                    ActionType = "Action"
                },
                IdentityToken = "EgZjxMPlbWUyBggAEEUYOdIBCDM3NDlqMGo3qAIAsAIA",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                Resource = new EntityIdentifier {
                    EntityId = "vacationPhoto94.jpg",
                    EntityType = "Photo"
                }
            });

            Decision decision = response.Decision;
            List<DeterminingPolicyItem> determiningPolicies = response.DeterminingPolicies;
            List<EvaluationErrorItem> errors = response.Errors;

            #endregion
        }

        public void VerifiedPermissionsListIdentitySources()
        {
            #region ListIdentitySources-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListIdentitySources(new ListIdentitySourcesRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            List<IdentitySourceItem> identitySources = response.IdentitySources;

            #endregion
        }

        public void VerifiedPermissionsListPolicies()
        {
            #region ListPolicies-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicies(new ListPoliciesRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            List<PolicyItem> policies = response.Policies;

            #endregion
        }

        public void VerifiedPermissionsListPolicies()
        {
            #region ListPolicies-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicies(new ListPoliciesRequest
            {
                Filter = new PolicyFilter { Principal = new EntityReference { Identifier = new EntityIdentifier {
                    EntityId = "alice",
                    EntityType = "User"
                } } },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            List<PolicyItem> policies = response.Policies;

            #endregion
        }

        public void VerifiedPermissionsListPolicies()
        {
            #region ListPolicies-3

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicies(new ListPoliciesRequest
            {
                Filter = new PolicyFilter { PolicyType = "TEMPLATE_LINKED" },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            List<PolicyItem> policies = response.Policies;

            #endregion
        }

        public void VerifiedPermissionsListPolicyStoreAliases()
        {
            #region ListPolicyStoreAliases-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicyStoreAliases(new ListPolicyStoreAliasesRequest
            {
            });

            List<PolicyStoreAliasItem> policyStoreAliases = response.PolicyStoreAliases;

            #endregion
        }

        public void VerifiedPermissionsListPolicyStoreAliases()
        {
            #region ListPolicyStoreAliases-2

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicyStoreAliases(new ListPolicyStoreAliasesRequest
            {
                Filter = new PolicyStoreAliasFilter { PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a" }
            });

            List<PolicyStoreAliasItem> policyStoreAliases = response.PolicyStoreAliases;

            #endregion
        }

        public void VerifiedPermissionsListPolicyStores()
        {
            #region ListPolicyStores-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicyStores(new ListPolicyStoresRequest
            {
            });

            List<PolicyStoreItem> policyStores = response.PolicyStores;

            #endregion
        }

        public void VerifiedPermissionsListPolicyTemplates()
        {
            #region ListPolicyTemplates-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListPolicyTemplates(new ListPolicyTemplatesRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            List<PolicyTemplateItem> policyTemplates = response.PolicyTemplates;

            #endregion
        }

        public void VerifiedPermissionsListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                ResourceArn = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void VerifiedPermissionsPutSchema()
        {
            #region PutSchema-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.PutSchema(new PutSchemaRequest
            {
                Definition = new SchemaDefinition { CedarJson = "{\"MySampleNamespace\": {\"actions\": {\"remoteAccess\": {\"appliesTo\": {\"principalTypes\": [\"Employee\"]}}},\"entityTypes\": {\"Employee\": {\"shape\": {\"attributes\": {\"jobLevel\": {\"type\": \"Long\"},\"name\": {\"type\": \"String\"}},\"type\": \"Record\"}}}}}" },
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            List<string> namespaces = response.Namespaces;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsTagResource()
        {
            #region TagResource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.TagResource(new TagResourceRequest
            {
                ResourceArn = "C7v5xMplfFH3i3e4Jrzb1a",
                Tags = new Dictionary<string, string> {
                    { "key1", "value1" },
                    { "key2", "value2" }
                }
            });


            #endregion
        }

        public void VerifiedPermissionsUntagResource()
        {
            #region UntagResource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.UntagResource(new UntagResourceRequest
            {
                ResourceArn = "C7v5xMplfFH3i3e4Jrzb1a",
                TagKeys = new List<string> {
                    "key1",
                    "key2"
                }
            });


            #endregion
        }

        public void VerifiedPermissionsUpdateIdentitySource()
        {
            #region UpdateIdentitySource-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.UpdateIdentitySource(new UpdateIdentitySourceRequest
            {
                IdentitySourceId = "ISEXAMPLEabcdefg111111",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                UpdateConfiguration = new UpdateConfiguration { CognitoUserPoolConfiguration = new UpdateCognitoUserPoolConfiguration {
                    ClientIds = new List<string> {
                        "a1b2c3d4e5f6g7h8i9j0kalbmc"
                    },
                    UserPoolArn = "arn:aws:cognito-idp:us-east-1:123456789012:userpool/us-east-1_1a2b3c4d5"
                } }
            });

            DateTime? createdDate = response.CreatedDate;
            string identitySourceId = response.IdentitySourceId;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsUpdatePolicy()
        {
            #region UpdatePolicy-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.UpdatePolicy(new UpdatePolicyRequest
            {
                Definition = new UpdatePolicyDefinition { Static = new UpdateStaticPolicyDefinition { Statement = "permit(principal, action, resource in Album::\"public_folder\");" } },
                Name = "name/example-policy-2",
                PolicyId = "9wYxMpljbbZQb5fcZHyJhY",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyId = response.PolicyId;
            string policyStoreId = response.PolicyStoreId;
            PolicyType policyType = response.PolicyType;
            EntityIdentifier resource = response.Resource;

            #endregion
        }

        public void VerifiedPermissionsUpdatePolicyStore()
        {
            #region UpdatePolicyStore-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.UpdatePolicyStore(new UpdatePolicyStoreRequest
            {
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                ValidationSettings = new ValidationSettings { Mode = "OFF" }
            });

            string arn = response.Arn;
            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;

            #endregion
        }

        public void VerifiedPermissionsUpdatePolicyTemplate()
        {
            #region UpdatePolicyTemplate-1

            var client = new AmazonVerifiedPermissionsClient();
            var response = client.UpdatePolicyTemplate(new UpdatePolicyTemplateRequest
            {
                Description = "My updated template description",
                Name = "name/example-policy-template-2",
                PolicyStoreId = "C7v5xMplfFH3i3e4Jrzb1a",
                PolicyTemplateId = "PTEXAMPLEabcdefg111111",
                Statement = "\"ResearchAccess\"\npermit(\nprincipal in ?principal,\naction == Action::\"view\",\nresource in ?resource\"\n)\nwhen {\nprincipal has department && principal.department == \"research\"\n};"
            });

            DateTime? createdDate = response.CreatedDate;
            DateTime? lastUpdatedDate = response.LastUpdatedDate;
            string policyStoreId = response.PolicyStoreId;
            string policyTemplateId = response.PolicyTemplateId;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
