using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.WorkSpacesWeb;
using Amazon.WorkSpacesWeb.Model;

namespace AWSSDKDocSamples.Amazon.WorkSpacesWeb.Generated
{
    class WorkSpacesWebSamples : ISample
    {
        public void WorkSpacesWebAssociateSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.AssociateSessionLogger(new AssociateSessionLoggerRequest 
            {
                PortalArn = "arn:aws:workspaces-web:us-west-2:123456789012:portal/12345678-1234-1234-1234-123456789012",
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/11111111-1111-1111-1111-111111111111"
            });

            string portalArn = response.PortalArn;
            string sessionLoggerArn = response.SessionLoggerArn;

            #endregion
        }

        public void WorkSpacesWebCreateSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.CreateSessionLogger(new CreateSessionLoggerRequest 
            {
                DisplayName = "Session Logger with All Events",
                EventFilter = new EventFilter { All = new Unit {  } },
                LogConfiguration = new LogConfiguration { S3 = new S3LogConfiguration {
                    Bucket = "my-session-logs-bucket",
                    BucketOwner = "123456789012",
                    FolderStructure = "Flat",
                    KeyPrefix = "session-logs/all/events",
                    LogFileFormat = "Json"
                } }
            });

            string sessionLoggerArn = response.SessionLoggerArn;

            #endregion
        }

        public void WorkSpacesWebCreateSessionLogger()
        {
            #region example-2

            var client = new AmazonWorkSpacesWebClient();
            var response = client.CreateSessionLogger(new CreateSessionLoggerRequest 
            {
                AdditionalEncryptionContext = new Dictionary<string, string> {
                    { "EncryptionContextKey", "EncryptionContextValue" }
                },
                CustomerManagedKey = "arn:aws:kms:us-west-2:123456789012:key/12345678-1234-1234-1234-123456789012",
                DisplayName = "Session Logger with Each Events",
                EventFilter = new EventFilter { Include = new List<string> {
                    "SessionStart",
                    "SessionEnd",
                    "UrlLoad",
                    "WebsiteInteract"
                } },
                LogConfiguration = new LogConfiguration { S3 = new S3LogConfiguration {
                    Bucket = "my-session-logs-bucket",
                    BucketOwner = "123456789012",
                    FolderStructure = "NestedByDate",
                    KeyPrefix = "session-logs/each/event",
                    LogFileFormat = "JSONLines"
                } },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "KEY-1",
                        Value = "VALUE-1"
                    },
                    new Tag {
                        Key = "KEY-2",
                        Value = "VALUE-2"
                    }
                }
            });

            string sessionLoggerArn = response.SessionLoggerArn;

            #endregion
        }

        public void WorkSpacesWebDeleteSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.DeleteSessionLogger(new DeleteSessionLoggerRequest 
            {
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/12345678-1234-1234-1234-123456789012"
            });


            #endregion
        }

        public void WorkSpacesWebDisassociateSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.DisassociateSessionLogger(new DisassociateSessionLoggerRequest 
            {
                PortalArn = "arn:aws:workspaces-web:us-west-2:123456789012:portal/12345678-1234-1234-1234-123456789012"
            });


            #endregion
        }

        public void WorkSpacesWebGetSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.GetSessionLogger(new GetSessionLoggerRequest 
            {
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/12345678-1234-1234-1234-123456789012"
            });

            SessionLogger sessionLogger = response.SessionLogger;

            #endregion
        }

        public void WorkSpacesWebGetSessionLogger()
        {
            #region example-2

            var client = new AmazonWorkSpacesWebClient();
            var response = client.GetSessionLogger(new GetSessionLoggerRequest 
            {
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/87654321-4321-4321-4321-210987654321"
            });

            SessionLogger sessionLogger = response.SessionLogger;

            #endregion
        }

        public void WorkSpacesWebListSessionLoggers()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.ListSessionLoggers(new ListSessionLoggersRequest 
            {
            });

            List<SessionLoggerSummary> sessionLoggers = response.SessionLoggers;

            #endregion
        }

        public void WorkSpacesWebListSessionLoggers()
        {
            #region example-2

            var client = new AmazonWorkSpacesWebClient();
            var response = client.ListSessionLoggers(new ListSessionLoggersRequest 
            {
                MaxResults = 1,
                NextToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9"
            });

            string nextToken = response.NextToken;
            List<SessionLoggerSummary> sessionLoggers = response.SessionLoggers;

            #endregion
        }

        public void WorkSpacesWebUpdateSessionLogger()
        {
            #region example-1

            var client = new AmazonWorkSpacesWebClient();
            var response = client.UpdateSessionLogger(new UpdateSessionLoggerRequest 
            {
                EventFilter = new EventFilter { Include = new List<string> {
                    "SessionStart",
                    "SessionEnd",
                    "UrlLoad",
                    "WebsiteInteract"
                } },
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/12345678-1234-1234-1234-123456789012"
            });

            SessionLogger sessionLogger = response.SessionLogger;

            #endregion
        }

        public void WorkSpacesWebUpdateSessionLogger()
        {
            #region example-2

            var client = new AmazonWorkSpacesWebClient();
            var response = client.UpdateSessionLogger(new UpdateSessionLoggerRequest 
            {
                LogConfiguration = new LogConfiguration { S3 = new S3LogConfiguration {
                    Bucket = "updated-my-session-logs-bucket-2",
                    BucketOwner = "123456789012",
                    FolderStructure = "Flat",
                    KeyPrefix = "updated/key/prefix",
                    LogFileFormat = "Json"
                } },
                SessionLoggerArn = "arn:aws:workspaces-web:us-west-2:123456789012:sessionLogger/87654321-4321-4321-4321-210987654321"
            });

            SessionLogger sessionLogger = response.SessionLogger;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}