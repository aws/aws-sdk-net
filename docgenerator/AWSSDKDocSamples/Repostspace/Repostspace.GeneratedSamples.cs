using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Repostspace;
using Amazon.Repostspace.Model;

namespace AWSSDKDocSamples.Amazon.Repostspace.Generated
{
    class RepostspaceSamples : ISample
    {
        public void RepostspaceBatchAddChannelRoleToAccessors()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.BatchAddChannelRoleToAccessors(new BatchAddChannelRoleToAccessorsRequest 
            {
                AccessorIds = new List<string> {
                    "12345678-1234-1234-1234-1234567890ab"
                },
                ChannelId = "WS1234567890abcdefghijkl",
                ChannelRole = "MODERATOR",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            List<BatchError> errors = response.Errors;
            List<string> addedAccessorIds = response.AddedAccessorIds;

            #endregion
        }

        public void RepostspaceBatchAddRole()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.BatchAddRole(new BatchAddRoleRequest 
            {
                AccessorIds = new List<string> {
                    "12345678-1234-1234-1234-1234567890ab"
                },
                Role = "EXPERT",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            List<BatchError> errors = response.Errors;
            List<string> addedAccessorIds = response.AddedAccessorIds;

            #endregion
        }

        public void RepostspaceBatchRemoveChannelRoleFromAccessors()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.BatchRemoveChannelRoleFromAccessors(new BatchRemoveChannelRoleFromAccessorsRequest 
            {
                AccessorIds = new List<string> {
                    "12345678-1234-1234-1234-1234567890ab"
                },
                ChannelId = "WS1234567890abcdefghijkl",
                ChannelRole = "MODERATOR",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            List<BatchError> errors = response.Errors;
            List<string> removedAccessorIds = response.RemovedAccessorIds;

            #endregion
        }

        public void RepostspaceBatchRemoveRole()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.BatchRemoveRole(new BatchRemoveRoleRequest 
            {
                AccessorIds = new List<string> {
                    "12345678-1234-1234-1234-1234567890ab"
                },
                Role = "EXPERT",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            List<BatchError> errors = response.Errors;
            List<string> removedAccessorIds = response.RemovedAccessorIds;

            #endregion
        }

        public void RepostspaceCreateChannel()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.CreateChannel(new CreateChannelRequest 
            {
                ChannelDescription = "Useful channel description",
                ChannelName = "My First Channel",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            string channelId = response.ChannelId;

            #endregion
        }

        public void RepostspaceGetChannel()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.GetChannel(new GetChannelRequest 
            {
                ChannelId = "WS1234567890abcdefghijkl",
                SpaceId = "SP1234567890abcdefghijkl"
            });

            string channelDescription = response.ChannelDescription;
            string channelId = response.ChannelId;
            string channelName = response.ChannelName;
            Dictionary<string, List<string>> channelRoles = response.ChannelRoles;
            string channelStatus = response.ChannelStatus;
            DateTime createDateTime = response.CreateDateTime;
            string spaceId = response.SpaceId;

            #endregion
        }

        public void RepostspaceListChannels()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.ListChannels(new ListChannelsRequest 
            {
                SpaceId = "SP1234567890abcdefghijkl"
            });

            List<ChannelData> channels = response.Channels;

            #endregion
        }

        public void RepostspaceUpdateChannel()
        {
            #region example-1

            var client = new AmazonRepostspaceClient();
            var response = client.UpdateChannel(new UpdateChannelRequest 
            {
                ChannelDescription = "Better channel description",
                ChannelId = "WS1234567890abcdefghijkl",
                ChannelName = "Better Channel",
                SpaceId = "SP1234567890abcdefghijkl"
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