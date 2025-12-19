using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Wickr;
using Amazon.Wickr.Model;

namespace AWSSDKDocSamples.Amazon.Wickr.Generated
{
    class WickrSamples : ISample
    {
        public void WickrBatchCreateUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchCreateUser(new BatchCreateUserRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                NetworkId = "12345678",
                Users = new List<BatchCreateUserRequestItem> {
                    new BatchCreateUserRequestItem {
                        CodeValidation = true,
                        FirstName = "John",
                        InviteCode = "INVITE123",
                        InviteCodeTtl = 7,
                        LastName = "Doe",
                        SecurityGroupIds = new List<string> {
                            "BCTY8Qhe"
                        },
                        Username = "john.doe@example.com"
                    },
                    new BatchCreateUserRequestItem {
                        FirstName = "Jane",
                        LastName = "Smith",
                        SecurityGroupIds = new List<string> {
                            "BCTY8Qhe"
                        },
                        Username = "jane.smith@example.com"
                    }
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            List<User> successful = response.Successful;

            #endregion
        }

        public void WickrBatchCreateUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchCreateUser(new BatchCreateUserRequest 
            {
                NetworkId = "12345678",
                Users = new List<BatchCreateUserRequestItem> {
                    new BatchCreateUserRequestItem {
                        FirstName = "Alice",
                        LastName = "Johnson",
                        SecurityGroupIds = new List<string> {
                            "BCTY8Qhe"
                        },
                        Username = "alice.johnson@example.com"
                    },
                    new BatchCreateUserRequestItem {
                        FirstName = "Bob",
                        LastName = "Wilson",
                        SecurityGroupIds = new List<string> {
                            "BCTY8Qhe"
                        },
                        Username = "existing.user@example.com"
                    }
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            List<User> successful = response.Successful;

            #endregion
        }

        public void WickrBatchDeleteUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchDeleteUser(new BatchDeleteUserRequest 
            {
                ClientToken = "6ba7b814-9dad-11d1-80b4-00c04fd430c8",
                NetworkId = "12345678",
                UserIds = new List<string> {
                    "123",
                    "456"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchDeleteUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchDeleteUser(new BatchDeleteUserRequest 
            {
                NetworkId = "12345678",
                UserIds = new List<string> {
                    "123",
                    "456"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchLookupUserUname()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchLookupUserUname(new BatchLookupUserUnameRequest 
            {
                ClientToken = "f47ac10b-58cc-4372-a567-0e02b2c3d479",
                NetworkId = "12345678",
                Unames = new List<string> {
                    "a1b2c3d4e5f6",
                    "g7h8i9j0k1l2"
                }
            });

            List<BatchUnameErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUnameSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchLookupUserUname()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchLookupUserUname(new BatchLookupUserUnameRequest 
            {
                NetworkId = "12345678",
                Unames = new List<string> {
                    "a1b2c3d4e5f6",
                    "invaliduname"
                }
            });

            List<BatchUnameErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUnameSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchReinviteUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchReinviteUser(new BatchReinviteUserRequest 
            {
                NetworkId = "12345678",
                UserIds = new List<string> {
                    "12345",
                    "67890"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchReinviteUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchReinviteUser(new BatchReinviteUserRequest 
            {
                NetworkId = "12345678",
                UserIds = new List<string> {
                    "12345",
                    "99999"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchReinviteUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.BatchReinviteUser(new BatchReinviteUserRequest 
            {
                NetworkId = "12345678",
                UserIds = new List<string> {
                    "54321"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchResetDevicesForUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchResetDevicesForUser(new BatchResetDevicesForUserRequest 
            {
                AppIds = new List<string> {
                    "d3135a42dcb6437780b16c3ca9581fe64e6822773cd6b965d25fc9929c89aca6",
                    "e4246b53edc7548891c27d4da0692fe75f7933884de7c076e36gca030d90bdb7"
                },
                NetworkId = "12345678",
                UserId = "12345"
            });

            List<BatchDeviceErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchDeviceSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchResetDevicesForUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchResetDevicesForUser(new BatchResetDevicesForUserRequest 
            {
                AppIds = new List<string> {
                    "d3135a42dcb6437780b16c3ca9581fe64e6822773cd6b965d25fc9929c89aca6",
                    "invalid-app-id"
                },
                NetworkId = "12345678",
                UserId = "12345"
            });

            List<BatchDeviceErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchDeviceSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchResetDevicesForUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.BatchResetDevicesForUser(new BatchResetDevicesForUserRequest 
            {
                AppIds = new List<string> {
                    "d3135a42dcb6437780b16c3ca9581fe64e6822773cd6b965d25fc9929c89aca6"
                },
                NetworkId = "00000000",
                UserId = "12345"
            });


            #endregion
        }

        public void WickrBatchToggleUserSuspendStatus()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.BatchToggleUserSuspendStatus(new BatchToggleUserSuspendStatusRequest 
            {
                ClientToken = "6ba7b815-9dad-11d1-80b4-00c04fd430c8",
                NetworkId = "12345678",
                Suspend = true,
                UserIds = new List<string> {
                    "123",
                    "456"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrBatchToggleUserSuspendStatus()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.BatchToggleUserSuspendStatus(new BatchToggleUserSuspendStatusRequest 
            {
                NetworkId = "12345678",
                Suspend = false,
                UserIds = new List<string> {
                    "123",
                    "456"
                }
            });

            List<BatchUserErrorResponseItem> failed = response.Failed;
            string message = response.Message;
            List<BatchUserSuccessResponseItem> successful = response.Successful;

            #endregion
        }

        public void WickrCreateBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.CreateBot(new CreateBotRequest 
            {
                Challenge = "SecureP@ssw0rd123",
                DisplayName = "Analytics Bot",
                GroupId = "analytics_group",
                NetworkId = "12345678",
                Username = "analytics_bot"
            });

            string botId = response.BotId;
            string displayName = response.DisplayName;
            string groupId = response.GroupId;
            string networkId = response.NetworkId;
            string username = response.Username;

            #endregion
        }

        public void WickrCreateBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.CreateBot(new CreateBotRequest 
            {
                Challenge = "SecureP@ssw0rd123",
                DisplayName = "Support Bot",
                GroupId = "default_group",
                NetworkId = "12345678",
                Username = "support_bot"
            });


            #endregion
        }

        public void WickrCreateBot()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.CreateBot(new CreateBotRequest 
            {
                Challenge = "SecureP@ssw0rd123",
                DisplayName = "Test Bot",
                GroupId = "default_group",
                NetworkId = "12345678",
                Username = "bot@invalid"
            });


            #endregion
        }

        public void WickrCreateDataRetentionBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.CreateDataRetentionBot(new CreateDataRetentionBotRequest 
            {
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrCreateDataRetentionBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.CreateDataRetentionBot(new CreateDataRetentionBotRequest 
            {
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrCreateDataRetentionBotChallenge()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.CreateDataRetentionBotChallenge(new CreateDataRetentionBotChallengeRequest 
            {
                NetworkId = "12345678"
            });

            string challenge = response.Challenge;

            #endregion
        }

        public void WickrCreateNetwork()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.CreateNetwork(new CreateNetworkRequest 
            {
                AccessLevel = "PREMIUM",
                EnablePremiumFreeTrial = false,
                NetworkName = "Production Network"
            });

            string networkId = response.NetworkId;
            string networkName = response.NetworkName;

            #endregion
        }

        public void WickrCreateNetwork()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.CreateNetwork(new CreateNetworkRequest 
            {
                AccessLevel = "PREMIUM",
                EnablePremiumFreeTrial = true,
                NetworkName = "Trial Network"
            });

            string networkId = response.NetworkId;
            string networkName = response.NetworkName;

            #endregion
        }

        public void WickrCreateNetwork()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.CreateNetwork(new CreateNetworkRequest 
            {
                AccessLevel = "STANDARD",
                NetworkName = "This network name is way too long"
            });


            #endregion
        }

        public void WickrCreateSecurityGroup()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.CreateSecurityGroup(new CreateSecurityGroupRequest 
            {
                Name = "engineering",
                NetworkId = "12345678",
                SecurityGroupSettings = new SecurityGroupSettingsRequest {
                    FederationMode = 1,
                    LockoutThreshold = 10
                }
            });

            SecurityGroup securityGroup = response.SecurityGroup;

            #endregion
        }

        public void WickrCreateSecurityGroup()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.CreateSecurityGroup(new CreateSecurityGroupRequest 
            {
                Name = "",
                NetworkId = "12345678",
                SecurityGroupSettings = new SecurityGroupSettingsRequest { FederationMode = 1 }
            });


            #endregion
        }

        public void WickrDeleteBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.DeleteBot(new DeleteBotRequest 
            {
                BotId = "98765",
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrDeleteBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.DeleteBot(new DeleteBotRequest 
            {
                BotId = "99999",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrDeleteDataRetentionBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.DeleteDataRetentionBot(new DeleteDataRetentionBotRequest 
            {
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrDeleteNetwork()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.DeleteNetwork(new DeleteNetworkRequest 
            {
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrDeleteNetwork()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.DeleteNetwork(new DeleteNetworkRequest 
            {
                NetworkId = "99999999"
            });


            #endregion
        }

        public void WickrDeleteSecurityGroup()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.DeleteSecurityGroup(new DeleteSecurityGroupRequest 
            {
                GroupId = "def67890",
                NetworkId = "12345678"
            });

            string groupId = response.GroupId;
            string message = response.Message;
            string networkId = response.NetworkId;

            #endregion
        }

        public void WickrDeleteSecurityGroup()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.DeleteSecurityGroup(new DeleteSecurityGroupRequest 
            {
                GroupId = "invalid99",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrGetBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetBot(new GetBotRequest 
            {
                BotId = "98765",
                NetworkId = "12345678"
            });

            string botId = response.BotId;
            string displayName = response.DisplayName;
            string groupId = response.GroupId;
            bool hasChallenge = response.HasChallenge;
            string lastLogin = response.LastLogin;
            string pubkey = response.Pubkey;
            int status = response.Status;
            bool suspended = response.Suspended;
            string uname = response.Uname;
            string username = response.Username;

            #endregion
        }

        public void WickrGetBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetBot(new GetBotRequest 
            {
                BotId = "99999",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrGetBotsCount()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetBotsCount(new GetBotsCountRequest 
            {
                NetworkId = "12345678"
            });

            int active = response.Active;
            int pending = response.Pending;
            int total = response.Total;

            #endregion
        }

        public void WickrGetBotsCount()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetBotsCount(new GetBotsCountRequest 
            {
                NetworkId = "12345678"
            });

            int active = response.Active;
            int pending = response.Pending;
            int total = response.Total;

            #endregion
        }

        public void WickrGetDataRetentionBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetDataRetentionBot(new GetDataRetentionBotRequest 
            {
                NetworkId = "12345678"
            });

            bool botExists = response.BotExists;
            string botName = response.BotName;
            bool isBotActive = response.IsBotActive;
            bool isDataRetentionBotRegistered = response.IsDataRetentionBotRegistered;
            bool isDataRetentionServiceEnabled = response.IsDataRetentionServiceEnabled;
            bool isPubkeyMsgAcked = response.IsPubkeyMsgAcked;

            #endregion
        }

        public void WickrGetDataRetentionBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetDataRetentionBot(new GetDataRetentionBotRequest 
            {
                NetworkId = "12345678"
            });

            bool botExists = response.BotExists;
            string botName = response.BotName;
            bool isBotActive = response.IsBotActive;
            bool isDataRetentionBotRegistered = response.IsDataRetentionBotRegistered;
            bool isDataRetentionServiceEnabled = response.IsDataRetentionServiceEnabled;
            bool isPubkeyMsgAcked = response.IsPubkeyMsgAcked;

            #endregion
        }

        public void WickrGetGuestUserHistoryCount()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetGuestUserHistoryCount(new GetGuestUserHistoryCountRequest 
            {
                NetworkId = "12345678"
            });

            List<GuestUserHistoryCount> history = response.History;

            #endregion
        }

        public void WickrGetGuestUserHistoryCount()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetGuestUserHistoryCount(new GetGuestUserHistoryCountRequest 
            {
                NetworkId = "87654321"
            });

            List<GuestUserHistoryCount> history = response.History;

            #endregion
        }

        public void WickrGetNetwork()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetNetwork(new GetNetworkRequest 
            {
                NetworkId = "12345678"
            });

            string accessLevel = response.AccessLevel;
            string awsAccountId = response.AwsAccountId;
            int migrationState = response.MigrationState;
            string networkArn = response.NetworkArn;
            string networkId = response.NetworkId;
            string networkName = response.NetworkName;
            int standing = response.Standing;

            #endregion
        }

        public void WickrGetNetwork()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetNetwork(new GetNetworkRequest 
            {
                NetworkId = "99999999"
            });


            #endregion
        }

        public void WickrGetNetworkSettings()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetNetworkSettings(new GetNetworkSettingsRequest 
            {
                NetworkId = "12345678"
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void WickrGetNetworkSettings()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetNetworkSettings(new GetNetworkSettingsRequest 
            {
                NetworkId = "87654321"
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void WickrGetNetworkSettings()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.GetNetworkSettings(new GetNetworkSettingsRequest 
            {
                NetworkId = "99999999"
            });


            #endregion
        }

        public void WickrGetOidcInfo()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetOidcInfo(new GetOidcInfoRequest 
            {
                NetworkId = "12345678"
            });

            OidcConfigInfo openidConnectInfo = response.OpenidConnectInfo;

            #endregion
        }

        public void WickrGetOidcInfo()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetOidcInfo(new GetOidcInfoRequest 
            {
                NetworkId = "12345678"
            });

            OidcConfigInfo openidConnectInfo = response.OpenidConnectInfo;

            #endregion
        }

        public void WickrGetSecurityGroup()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetSecurityGroup(new GetSecurityGroupRequest 
            {
                GroupId = "abc12345",
                NetworkId = "12345678"
            });

            SecurityGroup securityGroup = response.SecurityGroup;

            #endregion
        }

        public void WickrGetSecurityGroup()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetSecurityGroup(new GetSecurityGroupRequest 
            {
                GroupId = "invalid99",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrGetUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetUser(new GetUserRequest 
            {
                NetworkId = "12345678",
                UserId = "12345"
            });

            string firstName = response.FirstName;
            bool isAdmin = response.IsAdmin;
            int lastActivity = response.LastActivity;
            int lastLogin = response.LastLogin;
            string lastName = response.LastName;
            List<string> securityGroupIds = response.SecurityGroupIds;
            int status = response.Status;
            bool suspended = response.Suspended;
            string userId = response.UserId;
            string username = response.Username;

            #endregion
        }

        public void WickrGetUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetUser(new GetUserRequest 
            {
                EndTime = DateTime.UtcNow,
                NetworkId = "12345678",
                StartTime = DateTime.UtcNow,
                UserId = "12345"
            });

            string firstName = response.FirstName;
            bool isAdmin = response.IsAdmin;
            int lastActivity = response.LastActivity;
            int lastLogin = response.LastLogin;
            string lastName = response.LastName;
            List<string> securityGroupIds = response.SecurityGroupIds;
            int status = response.Status;
            bool suspended = response.Suspended;
            string userId = response.UserId;
            string username = response.Username;

            #endregion
        }

        public void WickrGetUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.GetUser(new GetUserRequest 
            {
                NetworkId = "12345678",
                UserId = "99999"
            });


            #endregion
        }

        public void WickrGetUser()
        {
            #region example-4

            var client = new AmazonWickrClient();
            var response = client.GetUser(new GetUserRequest 
            {
                NetworkId = "12345678",
                UserId = "99999"
            });


            #endregion
        }

        public void WickrGetUsersCount()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.GetUsersCount(new GetUsersCountRequest 
            {
                NetworkId = "12345678"
            });

            int active = response.Active;
            int pending = response.Pending;
            int rejected = response.Rejected;
            int remaining = response.Remaining;
            int total = response.Total;

            #endregion
        }

        public void WickrGetUsersCount()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.GetUsersCount(new GetUsersCountRequest 
            {
                NetworkId = "87654321"
            });

            int active = response.Active;
            int pending = response.Pending;
            int rejected = response.Rejected;
            int remaining = response.Remaining;
            int total = response.Total;

            #endregion
        }

        public void WickrListBlockedGuestUsers()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListBlockedGuestUsers(new ListBlockedGuestUsersRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                SortDirection = "DESC",
                SortFields = "modified"
            });

            List<BlockedGuestUser> blocklist = response.Blocklist;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListBlockedGuestUsers()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListBlockedGuestUsers(new ListBlockedGuestUsersRequest 
            {
                NetworkId = "12345678",
                Username = "john.doe@example.com"
            });

            List<BlockedGuestUser> blocklist = response.Blocklist;

            #endregion
        }

        public void WickrListBlockedGuestUsers()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.ListBlockedGuestUsers(new ListBlockedGuestUsersRequest 
            {
                NetworkId = "12345678"
            });

            List<BlockedGuestUser> blocklist = response.Blocklist;

            #endregion
        }

        public void WickrListBots()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListBots(new ListBotsRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                SortDirection = "ASC",
                SortFields = "username"
            });

            List<Bot> bots = response.Bots;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListBots()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListBots(new ListBotsRequest 
            {
                DisplayName = "Support",
                MaxResults = 10,
                NetworkId = "12345678",
                Status = 2
            });

            List<Bot> bots = response.Bots;

            #endregion
        }

        public void WickrListDevicesForUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListDevicesForUser(new ListDevicesForUserRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                SortDirection = "DESC",
                SortFields = "appId",
                UserId = "12345"
            });

            List<BasicDeviceObject> devices = response.Devices;

            #endregion
        }

        public void WickrListDevicesForUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListDevicesForUser(new ListDevicesForUserRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                NextToken = "v1:pagination:6ba7b810-9dad-11d1-80b4-00c04fd430c8",
                UserId = "12345"
            });

            List<BasicDeviceObject> devices = response.Devices;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListDevicesForUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.ListDevicesForUser(new ListDevicesForUserRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                UserId = "99999"
            });


            #endregion
        }

        public void WickrListGuestUsers()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListGuestUsers(new ListGuestUsersRequest 
            {
                MaxResults = 20,
                NetworkId = "12345678",
                SortDirection = "DESC",
                SortFields = "billingPeriod"
            });

            List<GuestUser> guestlist = response.Guestlist;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListGuestUsers()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListGuestUsers(new ListGuestUsersRequest 
            {
                BillingPeriod = "2024-01",
                MaxResults = 10,
                NetworkId = "12345678"
            });

            List<GuestUser> guestlist = response.Guestlist;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListGuestUsers()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.ListGuestUsers(new ListGuestUsersRequest 
            {
                NetworkId = "87654321"
            });

            List<GuestUser> guestlist = response.Guestlist;

            #endregion
        }

        public void WickrListNetworks()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListNetworks(new ListNetworksRequest 
            {
                MaxResults = 10,
                SortDirection = "ASC",
                SortFields = "networkName"
            });

            List<Network> networks = response.Networks;
            string nextToken = response.NextToken;

            #endregion
        }

        public void WickrListNetworks()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListNetworks(new ListNetworksRequest 
            {
                MaxResults = 10
            });

            List<Network> networks = response.Networks;

            #endregion
        }

        public void WickrListSecurityGroups()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListSecurityGroups(new ListSecurityGroupsRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678",
                SortDirection = "ASC",
                SortFields = "name"
            });

            string nextToken = response.NextToken;
            List<SecurityGroup> securityGroups = response.SecurityGroups;

            #endregion
        }

        public void WickrListSecurityGroups()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListSecurityGroups(new ListSecurityGroupsRequest 
            {
                MaxResults = 10,
                NetworkId = "12345678"
            });

            List<SecurityGroup> securityGroups = response.SecurityGroups;

            #endregion
        }

        public void WickrListSecurityGroupUsers()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListSecurityGroupUsers(new ListSecurityGroupUsersRequest 
            {
                GroupId = "abc12345",
                MaxResults = 10,
                NetworkId = "12345678",
                SortDirection = "ASC",
                SortFields = "username"
            });

            string nextToken = response.NextToken;
            List<User> users = response.Users;

            #endregion
        }

        public void WickrListUsers()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.ListUsers(new ListUsersRequest 
            {
                MaxResults = 20,
                NetworkId = "12345678",
                SortDirection = "ASC",
                SortFields = "username"
            });

            string nextToken = response.NextToken;
            List<User> users = response.Users;

            #endregion
        }

        public void WickrListUsers()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.ListUsers(new ListUsersRequest 
            {
                GroupId = "BCTY8Qhe",
                MaxResults = 10,
                NetworkId = "12345678",
                Status = 1
            });

            List<User> users = response.Users;

            #endregion
        }

        public void WickrListUsers()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.ListUsers(new ListUsersRequest 
            {
                NetworkId = "12345678"
            });

            List<User> users = response.Users;

            #endregion
        }

        public void WickrRegisterOidcConfig()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfig(new RegisterOidcConfigRequest 
            {
                CompanyId = "us-east-1-company123",
                Issuer = "https://login.example.com",
                NetworkId = "12345678",
                Scopes = "openid profile email",
                SsoTokenBufferMinutes = 5,
                UserId = "email"
            });

            string clientId = response.ClientId;
            string companyId = response.CompanyId;
            string issuer = response.Issuer;
            string redirectUrl = response.RedirectUrl;
            string scopes = response.Scopes;
            int ssoTokenBufferMinutes = response.SsoTokenBufferMinutes;
            string userId = response.UserId;

            #endregion
        }

        public void WickrRegisterOidcConfig()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfig(new RegisterOidcConfigRequest 
            {
                CompanyId = "",
                Issuer = "https://login.example.com",
                NetworkId = "12345678",
                Scopes = "openid profile email"
            });


            #endregion
        }

        public void WickrRegisterOidcConfig()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfig(new RegisterOidcConfigRequest 
            {
                CompanyId = "invalid-company123",
                Issuer = "https://login.example.com",
                NetworkId = "12345678",
                Scopes = "openid profile email"
            });


            #endregion
        }

        public void WickrRegisterOidcConfigTest()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfigTest(new RegisterOidcConfigTestRequest 
            {
                Issuer = "https://login.example.com",
                NetworkId = "12345678",
                Scopes = "openid profile email"
            });

            string authorizationEndpoint = response.AuthorizationEndpoint;
            string issuer = response.Issuer;
            string tokenEndpoint = response.TokenEndpoint;
            string userinfoEndpoint = response.UserinfoEndpoint;

            #endregion
        }

        public void WickrRegisterOidcConfigTest()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfigTest(new RegisterOidcConfigTestRequest 
            {
                Issuer = "",
                NetworkId = "12345678",
                Scopes = "openid profile email"
            });


            #endregion
        }

        public void WickrRegisterOidcConfigTest()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.RegisterOidcConfigTest(new RegisterOidcConfigTestRequest 
            {
                Issuer = "https://blocked-endpoint.com",
                NetworkId = "12345678",
                Scopes = "openid profile email"
            });


            #endregion
        }

        public void WickrUpdateBot()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateBot(new UpdateBotRequest 
            {
                BotId = "98765",
                DisplayName = "Updated Support Bot",
                GroupId = "support_group",
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateBot()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateBot(new UpdateBotRequest 
            {
                BotId = "99999",
                DisplayName = "Updated Bot",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrUpdateDataRetention()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateDataRetention(new UpdateDataRetentionRequest 
            {
                ActionType = "ENABLE",
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateDataRetention()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateDataRetention(new UpdateDataRetentionRequest 
            {
                ActionType = "DISABLE",
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateDataRetention()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.UpdateDataRetention(new UpdateDataRetentionRequest 
            {
                ActionType = "PUBKEY_MSG_ACK",
                NetworkId = "12345678"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateGuestUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateGuestUser(new UpdateGuestUserRequest 
            {
                Block = true,
                NetworkId = "12345678",
                UsernameHash = "032c36d5623781204592a69269ed9480d604484269c8a4c2d39528885a56470d"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateGuestUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateGuestUser(new UpdateGuestUserRequest 
            {
                Block = false,
                NetworkId = "12345678",
                UsernameHash = "032c36d5623781204592a69269ed9480d604484269c8a4c2d39528885a56470d"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateGuestUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.UpdateGuestUser(new UpdateGuestUserRequest 
            {
                Block = true,
                NetworkId = "12345678",
                UsernameHash = "032c36d5623781204592a69269ed9480d604484269c8a4c2d39528885a56470d"
            });


            #endregion
        }

        public void WickrUpdateNetwork()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateNetwork(new UpdateNetworkRequest 
            {
                NetworkId = "12345678",
                NetworkName = "Updated Network Name"
            });

            string message = response.Message;

            #endregion
        }

        public void WickrUpdateNetwork()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateNetwork(new UpdateNetworkRequest 
            {
                NetworkId = "12345678",
                NetworkName = "This name is way too long for a network"
            });


            #endregion
        }

        public void WickrUpdateNetwork()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.UpdateNetwork(new UpdateNetworkRequest 
            {
                NetworkId = "99999999",
                NetworkName = "New Name"
            });


            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "12345678",
                Settings = new NetworkSettings {
                    DataRetention = true,
                    EnableClientMetrics = true
                }
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "12345678",
                Settings = new NetworkSettings { EnableClientMetrics = false }
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "12345678",
                Settings = new NetworkSettings { EnableClientMetrics = true }
            });

            List<Setting> settings = response.Settings;

            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-4

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "12345678",
                Settings = new NetworkSettings { EnableClientMetrics = false }
            });


            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-5

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "99999999",
                Settings = new NetworkSettings { EnableClientMetrics = true }
            });


            #endregion
        }

        public void WickrUpdateNetworkSettings()
        {
            #region example-6

            var client = new AmazonWickrClient();
            var response = client.UpdateNetworkSettings(new UpdateNetworkSettingsRequest 
            {
                NetworkId = "12345678",
                Settings = new NetworkSettings { DataRetention = true }
            });


            #endregion
        }

        public void WickrUpdateSecurityGroup()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateSecurityGroup(new UpdateSecurityGroupRequest 
            {
                Name = "Updated Group Name",
                GroupId = "abc12345",
                NetworkId = "12345678",
                SecurityGroupSettings = new SecurityGroupSettings { LockoutThreshold = 15 }
            });

            SecurityGroup securityGroup = response.SecurityGroup;

            #endregion
        }

        public void WickrUpdateSecurityGroup()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateSecurityGroup(new UpdateSecurityGroupRequest 
            {
                Name = "New Name",
                GroupId = "invalid99",
                NetworkId = "12345678"
            });


            #endregion
        }

        public void WickrUpdateUser()
        {
            #region example-1

            var client = new AmazonWickrClient();
            var response = client.UpdateUser(new UpdateUserRequest 
            {
                NetworkId = "12345678",
                UserDetails = new UpdateUserDetails {
                    FirstName = "Jonathan",
                    LastName = "Doe",
                    SecurityGroupIds = new List<string> {
                        "BCTY8Qhe",
                        "DEPT001"
                    },
                    Username = "john.doe@example.com"
                },
                UserId = "12345"
            });

            string firstName = response.FirstName;
            string lastName = response.LastName;
            int modified = response.Modified;
            string networkId = response.NetworkId;
            List<string> securityGroupIds = response.SecurityGroupIds;
            int status = response.Status;
            bool suspended = response.Suspended;
            string userId = response.UserId;

            #endregion
        }

        public void WickrUpdateUser()
        {
            #region example-2

            var client = new AmazonWickrClient();
            var response = client.UpdateUser(new UpdateUserRequest 
            {
                NetworkId = "12345678",
                UserDetails = new UpdateUserDetails {
                    CodeValidation = true,
                    FirstName = "Jane",
                    InviteCode = "NEWINVITE789",
                    InviteCodeTtl = 14,
                    LastName = "Smith",
                    Username = "jane.smith@example.com"
                },
                UserId = "12345"
            });

            bool codeValidation = response.CodeValidation;
            string firstName = response.FirstName;
            string inviteCode = response.InviteCode;
            int inviteExpiration = response.InviteExpiration;
            string lastName = response.LastName;
            int modified = response.Modified;
            string networkId = response.NetworkId;
            int status = response.Status;
            bool suspended = response.Suspended;
            string userId = response.UserId;

            #endregion
        }

        public void WickrUpdateUser()
        {
            #region example-3

            var client = new AmazonWickrClient();
            var response = client.UpdateUser(new UpdateUserRequest 
            {
                NetworkId = "12345678",
                UserDetails = new UpdateUserDetails {
                    FirstName = "Non",
                    LastName = "Existent",
                    Username = "nonexistent@example.com"
                },
                UserId = "99999"
            });


            #endregion
        }

        public void WickrUpdateUser()
        {
            #region example-4

            var client = new AmazonWickrClient();
            var response = client.UpdateUser(new UpdateUserRequest 
            {
                NetworkId = "12345678",
                UserDetails = new UpdateUserDetails {
                    FirstName = "John",
                    LastName = "Doe",
                    SecurityGroupIds = new List<string> {
                        "BCTY8Qhe"
                    },
                    Username = "john.doe@example.com"
                },
                UserId = "99999"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}