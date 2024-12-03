using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.QApps;
using Amazon.QApps.Model;

namespace AWSSDKDocSamples.Amazon.QApps.Generated
{
    class QAppsSamples : ISample
    {
        public void QAppsAssociateLibraryItemReview()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.AssociateLibraryItemReview(new AssociateLibraryItemReviewRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                LibraryItemId = "cb9ecf72-8563-450d-9db9-994f98297316"
            });


            #endregion
        }

        public void QAppsAssociateQAppWithUser()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.AssociateQAppWithUser(new AssociateQAppWithUserRequest 
            {
                AppId = "393e77fb-0a30-4f47-ad30-75d71aeaed8a",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsBatchCreateCategory()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.BatchCreateCategory(new BatchCreateCategoryRequest 
            {
                Categories = new List<BatchCreateCategoryInputCategory> {
                    new BatchCreateCategoryInputCategory {
                        Id = "549abfe0-f5c4-45a2-bb9b-c05987a49c6d",
                        Title = "HR"
                    },
                    new BatchCreateCategoryInputCategory {
                        Id = "18cbebaa-196a-4aa5-a840-88d548e07f8f",
                        Title = "Marketing"
                    }
                },
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsBatchDeleteCategory()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.BatchDeleteCategory(new BatchDeleteCategoryRequest 
            {
                Categories = new List<string> {
                    "9c871ed4-1c41-4065-aefe-321cd4b61cf8"
                },
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsBatchUpdateCategory()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.BatchUpdateCategory(new BatchUpdateCategoryRequest 
            {
                Categories = new List<CategoryInput> {
                    new CategoryInput {
                        Id = "549abfe0-f5c4-45a2-bb9b-c05987a49c6d",
                        Title = "HR Management"
                    },
                    new CategoryInput {
                        Id = "18cbebaa-196a-4aa5-a840-88d548e07f8f",
                        Title = "Sales"
                    }
                },
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsCreateLibraryItem()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.CreateLibraryItem(new CreateLibraryItemRequest 
            {
                AppId = "7a11f34b-42d4-4bc8-b668-ae4a788dae1e",
                AppVersion = 6,
                Categories = new List<string> {
                    "9c871ed4-1c41-4065-aefe-321cd4b61cf8"
                },
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });

            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            bool isVerified = response.IsVerified;
            string libraryItemId = response.LibraryItemId;
            int ratingCount = response.RatingCount;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsCreatePresignedUrl()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.CreatePresignedUrl(new CreatePresignedUrlRequest 
            {
                AppId = "4263767c-d889-4cb2-a8f6-8b649bc66af0",
                CardId = "82f69028-22a9-4bea-8727-0eabf58e9fed",
                FileContentsSha256 = "wXY7GD8m4fmHhdtuQyBdXzNQpdCseVwBcOBIlzfm+kg=",
                FileName = "myFile.txt",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Scope = "SESSION",
                SessionId = "4f0e5b87-9d38-41cd-9eb4-ebce2f2917cc"
            });

            string fileId = response.FileId;
            string presignedUrl = response.PresignedUrl;
            DateTime presignedUrlExpiration = response.PresignedUrlExpiration;
            Dictionary<string, string> presignedUrlFields = response.PresignedUrlFields;

            #endregion
        }

        public void QAppsCreatePresignedUrl()
        {
            #region example-2

            var client = new AmazonQAppsClient();
            var response = client.CreatePresignedUrl(new CreatePresignedUrlRequest 
            {
                AppId = "4263767c-d889-4cb2-a8f6-8b649bc66af0",
                CardId = "7a11f34b-42d4-4bc8-b668-ae4a788dae1e",
                FileContentsSha256 = "wXY7GD8m4fmHhdtuQyBdXzNQpdCseVwBcOBIlzfm+kg=",
                FileName = "anApplicationFile.txt",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Scope = "APPLICATION"
            });

            string fileId = response.FileId;
            string presignedUrl = response.PresignedUrl;
            DateTime presignedUrlExpiration = response.PresignedUrlExpiration;
            Dictionary<string, string> presignedUrlFields = response.PresignedUrlFields;

            #endregion
        }

        public void QAppsCreateQApp()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.CreateQApp(new CreateQAppRequest 
            {
                AppDefinition = new AppDefinitionInput {
                    Cards = new List<CardInput> {
                        new CardInput { TextInput = new TextInputCardInput {
                            Type = "text-input",
                            Id = "4cf94d96-8819-45c2-98cc-58c56b35c72f",
                            Title = "Color Base"
                        } },
                        new CardInput { QQuery = new QQueryCardInput {
                            Type = "q-query",
                            Id = "18870b94-1e63-40e0-8c12-669c90ac5acc",
                            Prompt = "Recommend me a list of colors that go well with @4cf94d96-8819-45c2-98cc-58c56b35c72f",
                            Title = "Recommended Palette"
                        } }
                    },
                    InitialPrompt = "Create an app that recommend a list of colors based on input."
                },
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Title = "Color Palette Generator"
            });

            string appArn = response.AppArn;
            string appId = response.AppId;
            int appVersion = response.AppVersion;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            string initialPrompt = response.InitialPrompt;
            List<string> requiredCapabilities = response.RequiredCapabilities;
            string status = response.Status;
            string title = response.Title;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsDeleteLibraryItem()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.DeleteLibraryItem(new DeleteLibraryItemRequest 
            {
                InstanceId = "3642ba81-344c-42fd-a480-9119a5a5f26b",
                LibraryItemId = "72088fd4-78b6-43da-bfb8-8621323c3cfb"
            });


            #endregion
        }

        public void QAppsDeleteQApp()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.DeleteQApp(new DeleteQAppRequest 
            {
                AppId = "393e77fb-0a30-4f47-ad30-75d71aeaed8a",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsDescribeQAppPermissions()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.DescribeQAppPermissions(new DescribeQAppPermissionsRequest 
            {
                AppId = "fe0acf86-49e5-4def-a0c2-40ce0cafee14",
                InstanceId = "01793661-ad73-4c7d-8eaa-1c95a10151c2"
            });

            string appId = response.AppId;
            List<PermissionOutput> permissions = response.Permissions;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void QAppsDisassociateLibraryItemReview()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.DisassociateLibraryItemReview(new DisassociateLibraryItemReviewRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                LibraryItemId = "cb9ecf72-8563-450d-9db9-994f98297316"
            });


            #endregion
        }

        public void QAppsDisassociateQAppFromUser()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.DisassociateQAppFromUser(new DisassociateQAppFromUserRequest 
            {
                AppId = "393e77fb-0a30-4f47-ad30-75d71aeaed8a",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });


            #endregion
        }

        public void QAppsGetLibraryItem()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.GetLibraryItem(new GetLibraryItemRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                LibraryItemId = "18cbebaa-196a-4aa5-a840-88d548e07f8f"
            });

            string appId = response.AppId;
            int appVersion = response.AppVersion;
            List<Category> categories = response.Categories;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            bool isRatedByUser = response.IsRatedByUser;
            bool isVerified = response.IsVerified;
            string libraryItemId = response.LibraryItemId;
            int ratingCount = response.RatingCount;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;
            int userCount = response.UserCount;

            #endregion
        }

        public void QAppsGetQApp()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.GetQApp(new GetQAppRequest 
            {
                AppId = "3d110749-efc3-427c-87e8-15e966e5c168",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });

            string appArn = response.AppArn;
            AppDefinition appDefinition = response.AppDefinition;
            string appId = response.AppId;
            int appVersion = response.AppVersion;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            string status = response.Status;
            string title = response.Title;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsGetQAppSession()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.GetQAppSession(new GetQAppSessionRequest 
            {
                InstanceId = "288ae830-1df2-4871-b6c0-4314d74dadef",
                SessionId = "1fca878e-64c5-4dc4-b1d9-c93effed4e82"
            });

            Dictionary<string, CardStatus> cardStatus = response.CardStatus;
            string sessionArn = response.SessionArn;
            string sessionId = response.SessionId;
            string status = response.Status;

            #endregion
        }

        public void QAppsGetQAppSessionMetadata()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.GetQAppSessionMetadata(new GetQAppSessionMetadataRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                SessionId = "56ae47c3-10bc-4c2c-8b27-9b9fe23b3edb"
            });

            string sessionArn = response.SessionArn;
            string sessionId = response.SessionId;
            string sessionName = response.SessionName;
            bool sessionOwner = response.SessionOwner;
            SessionSharingConfiguration sharingConfiguration = response.SharingConfiguration;

            #endregion
        }

        public void QAppsImportDocument()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.ImportDocument(new ImportDocumentRequest 
            {
                AppId = "4263767c-d889-4cb2-a8f6-8b649bc66af0",
                CardId = "82f69028-22a9-4bea-8727-0eabf58e9fed",
                FileContentsBase64 = "data:text/plain;base64,SomeFileEncodedInBase64",
                FileName = "myFile.txt",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Scope = "SESSION",
                SessionId = "4f0e5b87-9d38-41cd-9eb4-ebce2f2917cc"
            });

            string fileId = response.FileId;

            #endregion
        }

        public void QAppsImportDocument()
        {
            #region example-2

            var client = new AmazonQAppsClient();
            var response = client.ImportDocument(new ImportDocumentRequest 
            {
                AppId = "4263767c-d889-4cb2-a8f6-8b649bc66af0",
                CardId = "7a11f34b-42d4-4bc8-b668-ae4a788dae1e",
                FileContentsBase64 = "data:text/plain;base64,SomeFileEncodedInBase64",
                FileName = "anApplicationFile.txt",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Scope = "APPLICATION"
            });

            string fileId = response.FileId;

            #endregion
        }

        public void QAppsListCategories()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.ListCategories(new ListCategoriesRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });

            List<Category> categories = response.Categories;

            #endregion
        }

        public void QAppsListLibraryItems()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.ListLibraryItems(new ListLibraryItemsRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Limit = 3
            });

            List<LibraryItemMember> libraryItems = response.LibraryItems;
            string nextToken = response.NextToken;

            #endregion
        }

        public void QAppsListQApps()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.ListQApps(new ListQAppsRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Limit = 3
            });

            List<UserAppItem> apps = response.Apps;
            string nextToken = response.NextToken;

            #endregion
        }

        public void QAppsListQApps()
        {
            #region example-2

            var client = new AmazonQAppsClient();
            var response = client.ListQApps(new ListQAppsRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Limit = 3,
                NextToken = "bXlzdGVyaW91c1BhZ2luYXRpb25Ub2tlbg=="
            });

            List<UserAppItem> apps = response.Apps;
            string nextToken = response.NextToken;

            #endregion
        }

        public void QAppsListTagsForResource()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceARN = "arn:aws:qapps:us-west-2:123456789012:application/3642ba81-344c-42fd-a480-9119a5a5f26b/qapp/7212ff04-de7b-4831-bd80-45d6975ba1b0"
            });

            Dictionary<string, string> tags = response.Tags;

            #endregion
        }

        public void QAppsStartQAppSession()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.StartQAppSession(new StartQAppSessionRequest 
            {
                AppId = "65e7dce7-226a-47f9-b689-22850becef89",
                AppVersion = 1,
                InitialValues = new List<CardValue> {
                    new CardValue {
                        Value = "What is the circumference of Earth?",
                        CardId = "6fb5b404-3b7b-48a4-8a8b-56406922a606"
                    }
                },
                InstanceId = "4cc5e4c2-d2a2-4188-a114-9ca125b4aedc"
            });

            string sessionArn = response.SessionArn;
            string sessionId = response.SessionId;

            #endregion
        }

        public void QAppsTagResource()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceARN = "arn:aws:qapps:us-west-2:123456789012:application/3642ba81-344c-42fd-a480-9119a5a5f26b/qapp/7212ff04-de7b-4831-bd80-45d6975ba1b0",
                Tags = new Dictionary<string, string> {
                    { "department", "HR" }
                }
            });


            #endregion
        }

        public void QAppsUntagResource()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceARN = "arn:aws:qapps:us-west-2:123456789012:application/3642ba81-344c-42fd-a480-9119a5a5f26b/qapp/7212ff04-de7b-4831-bd80-45d6975ba1b0",
                TagKeys = new List<string> {
                    "department"
                }
            });


            #endregion
        }

        public void QAppsUpdateLibraryItem()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UpdateLibraryItem(new UpdateLibraryItemRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                LibraryItemId = "cb9ecf72-8563-450d-9db9-994f98297316",
                Status = "DISABLED"
            });

            string appId = response.AppId;
            int appVersion = response.AppVersion;
            List<Category> categories = response.Categories;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            bool isVerified = response.IsVerified;
            string libraryItemId = response.LibraryItemId;
            int ratingCount = response.RatingCount;
            string status = response.Status;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsUpdateLibraryItemMetadata()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UpdateLibraryItemMetadata(new UpdateLibraryItemMetadataRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                IsVerified = true,
                LibraryItemId = "cb9ecf72-8563-450d-9db9-994f98297316"
            });


            #endregion
        }

        public void QAppsUpdateQApp()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UpdateQApp(new UpdateQAppRequest 
            {
                AppId = "7212ff04-de7b-4831-bd80-45d6975ba1b0",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                Title = "This is the new title"
            });

            string appArn = response.AppArn;
            string appId = response.AppId;
            int appVersion = response.AppVersion;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            List<string> requiredCapabilities = response.RequiredCapabilities;
            string status = response.Status;
            string title = response.Title;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsUpdateQApp()
        {
            #region example-2

            var client = new AmazonQAppsClient();
            var response = client.UpdateQApp(new UpdateQAppRequest 
            {
                AppDefinition = new AppDefinitionInput { Cards = new List<CardInput> {
                    new CardInput { QQuery = new QQueryCardInput {
                        Type = "q-query",
                        Id = "18870b94-1e63-40e0-8c12-669c90ac5acc",
                        Prompt = "Recommend me an itinerary for a trip",
                        Title = "Trip Ideas"
                    } }
                } },
                AppId = "7212ff04-de7b-4831-bd80-45d6975ba1b0",
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f"
            });

            string appArn = response.AppArn;
            string appId = response.AppId;
            int appVersion = response.AppVersion;
            DateTime createdAt = response.CreatedAt;
            string createdBy = response.CreatedBy;
            List<string> requiredCapabilities = response.RequiredCapabilities;
            string status = response.Status;
            string title = response.Title;
            DateTime updatedAt = response.UpdatedAt;
            string updatedBy = response.UpdatedBy;

            #endregion
        }

        public void QAppsUpdateQAppPermissions()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UpdateQAppPermissions(new UpdateQAppPermissionsRequest 
            {
                AppId = "fe0acf86-49e5-4def-a0c2-40ce0cafee14",
                GrantPermissions = new List<PermissionInput> {
                    new PermissionInput {
                        Action = "read",
                        Principal = "user2@example.com"
                    }
                },
                InstanceId = "01793661-ad73-4c7d-8eaa-1c95a10151c2"
            });

            string appId = response.AppId;
            List<PermissionOutput> permissions = response.Permissions;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void QAppsUpdateQAppPermissions()
        {
            #region example-2

            var client = new AmazonQAppsClient();
            var response = client.UpdateQAppPermissions(new UpdateQAppPermissionsRequest 
            {
                AppId = "fe0acf86-49e5-4def-a0c2-40ce0cafee14",
                InstanceId = "01793661-ad73-4c7d-8eaa-1c95a10151c2",
                RevokePermissions = new List<PermissionInput> {
                    new PermissionInput {
                        Action = "read",
                        Principal = "user2@example.com"
                    }
                }
            });

            string appId = response.AppId;
            List<PermissionOutput> permissions = response.Permissions;
            string resourceArn = response.ResourceArn;

            #endregion
        }

        public void QAppsUpdateQAppSessionMetadata()
        {
            #region example-1

            var client = new AmazonQAppsClient();
            var response = client.UpdateQAppSessionMetadata(new UpdateQAppSessionMetadataRequest 
            {
                InstanceId = "0b95c9c4-89cc-4aa8-9aae-aa91cbec699f",
                SessionId = "56ae47c3-10bc-4c2c-8b27-9b9fe23b3edb",
                SessionName = "Trip itinerary collection session",
                SharingConfiguration = new SessionSharingConfiguration {
                    AcceptResponses = true,
                    Enabled = true,
                    RevealCards = false
                }
            });

            string sessionArn = response.SessionArn;
            string sessionId = response.SessionId;
            string sessionName = response.SessionName;
            SessionSharingConfiguration sharingConfiguration = response.SharingConfiguration;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}