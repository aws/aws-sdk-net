/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon.Runtime.Internal;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Paginators
{
    [TestClass]
    public class IdentityManagementServicePaginatorTests
    {

        #region GetGroupEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestGetGroupEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == null)))
                .Returns(new GetGroupResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Users = new List<User> 
                    {
                        new User { Arn = "item1.0" },
                        new User { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == "A")))
                .Returns(new GetGroupResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Users = new List<User> 
                    {
                        new User { Arn = "item2.0" },
                        new User { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.GetGroup(It.Is<GetGroupRequest>(r => r.Marker == "AA")))
                .Returns(new GetGroupResponse
                {
                    Users = new List<User> 
                    {
                        new User { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<User, GetGroupRequest, GetGroupResponse>(new GetGroupRequest(), mock.Object.GetGroup);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.GetGroup(It.IsAny<GetGroupRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.GetGroup(It.IsAny<GetGroupRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListAccessKeysEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListAccessKeysEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListAccessKeys(It.Is<ListAccessKeysRequest>(r => r.Marker == null)))
                .Returns(new ListAccessKeysResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    AccessKeyMetadata = new List<AccessKeyMetadata> 
                    {
                        new AccessKeyMetadata { AccessKeyId = "item1.0" },
                        new AccessKeyMetadata { AccessKeyId = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListAccessKeys(It.Is<ListAccessKeysRequest>(r => r.Marker == "A")))
                .Returns(new ListAccessKeysResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    AccessKeyMetadata = new List<AccessKeyMetadata> 
                    {
                        new AccessKeyMetadata { AccessKeyId = "item2.0" },
                        new AccessKeyMetadata { AccessKeyId = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListAccessKeys(It.Is<ListAccessKeysRequest>(r => r.Marker == "AA")))
                .Returns(new ListAccessKeysResponse
                {
                    AccessKeyMetadata = new List<AccessKeyMetadata> 
                    {
                        new AccessKeyMetadata { AccessKeyId = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<AccessKeyMetadata, ListAccessKeysRequest, ListAccessKeysResponse>(new ListAccessKeysRequest(), mock.Object.ListAccessKeys);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListAccessKeys(It.IsAny<ListAccessKeysRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.AccessKeyId);
                }
            }

            mock.Verify(client => client.ListAccessKeys(It.IsAny<ListAccessKeysRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListAccountAliasesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListAccountAliasesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListAccountAliases(It.Is<ListAccountAliasesRequest>(r => r.Marker == null)))
                .Returns(new ListAccountAliasesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    AccountAliases = new List<string> 
                    {
                        "item1.0", "item1.1"
                    }
                });

            mock.Setup(client => client.ListAccountAliases(It.Is<ListAccountAliasesRequest>(r => r.Marker == "A")))
                .Returns(new ListAccountAliasesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    AccountAliases = new List<string> 
                    {
                        "item2.0", "item2.1"
                    }
                });

            mock.Setup(client => client.ListAccountAliases(It.Is<ListAccountAliasesRequest>(r => r.Marker == "AA")))
                .Returns(new ListAccountAliasesResponse
                {
                    AccountAliases = new List<string> 
                    {
                        "item3.0"
                    }
                });

            var items = Paginator.Paginate<string, ListAccountAliasesRequest, ListAccountAliasesResponse>(new ListAccountAliasesRequest(), mock.Object.ListAccountAliases);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListAccountAliases(It.IsAny<ListAccountAliasesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current);
                }
            }

            mock.Verify(client => client.ListAccountAliases(It.IsAny<ListAccountAliasesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListGroupPoliciesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListGroupPoliciesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListGroupPolicies(It.Is<ListGroupPoliciesRequest>(r => r.Marker == null)))
                .Returns(new ListGroupPoliciesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item1.0", "item1.1"
                    }
                });

            mock.Setup(client => client.ListGroupPolicies(It.Is<ListGroupPoliciesRequest>(r => r.Marker == "A")))
                .Returns(new ListGroupPoliciesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item2.0", "item2.1"
                    }
                });

            mock.Setup(client => client.ListGroupPolicies(It.Is<ListGroupPoliciesRequest>(r => r.Marker == "AA")))
                .Returns(new ListGroupPoliciesResponse
                {
                    PolicyNames = new List<string> 
                    {
                        "item3.0"
                    }
                });

            var items = Paginator.Paginate<string, ListGroupPoliciesRequest, ListGroupPoliciesResponse>(new ListGroupPoliciesRequest(), mock.Object.ListGroupPolicies);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListGroupPolicies(It.IsAny<ListGroupPoliciesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current);
                }
            }

            mock.Verify(client => client.ListGroupPolicies(It.IsAny<ListGroupPoliciesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListGroupsEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListGroupsEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListGroups(It.Is<ListGroupsRequest>(r => r.Marker == null)))
                .Returns(new ListGroupsResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item1.0" },
                        new Group { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListGroups(It.Is<ListGroupsRequest>(r => r.Marker == "A")))
                .Returns(new ListGroupsResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item2.0" },
                        new Group { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListGroups(It.Is<ListGroupsRequest>(r => r.Marker == "AA")))
                .Returns(new ListGroupsResponse
                {
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Group, ListGroupsRequest, ListGroupsResponse>(new ListGroupsRequest(), mock.Object.ListGroups);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListGroups(It.IsAny<ListGroupsRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListGroups(It.IsAny<ListGroupsRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListGroupsForUserEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListGroupsForUserEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListGroupsForUser(It.Is<ListGroupsForUserRequest>(r => r.Marker == null)))
                .Returns(new ListGroupsForUserResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item1.0" },
                        new Group { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListGroupsForUser(It.Is<ListGroupsForUserRequest>(r => r.Marker == "A")))
                .Returns(new ListGroupsForUserResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item2.0" },
                        new Group { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListGroupsForUser(It.Is<ListGroupsForUserRequest>(r => r.Marker == "AA")))
                .Returns(new ListGroupsForUserResponse
                {
                    Groups = new List<Group> 
                    {
                        new Group { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Group, ListGroupsForUserRequest, ListGroupsForUserResponse>(new ListGroupsForUserRequest(), mock.Object.ListGroupsForUser);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListGroupsForUser(It.IsAny<ListGroupsForUserRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListGroupsForUser(It.IsAny<ListGroupsForUserRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListInstanceProfilesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListInstanceProfilesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListInstanceProfiles(It.Is<ListInstanceProfilesRequest>(r => r.Marker == null)))
                .Returns(new ListInstanceProfilesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item1.0" },
                        new InstanceProfile { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListInstanceProfiles(It.Is<ListInstanceProfilesRequest>(r => r.Marker == "A")))
                .Returns(new ListInstanceProfilesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item2.0" },
                        new InstanceProfile { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListInstanceProfiles(It.Is<ListInstanceProfilesRequest>(r => r.Marker == "AA")))
                .Returns(new ListInstanceProfilesResponse
                {
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<InstanceProfile, ListInstanceProfilesRequest, ListInstanceProfilesResponse>(new ListInstanceProfilesRequest(), mock.Object.ListInstanceProfiles);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListInstanceProfiles(It.IsAny<ListInstanceProfilesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListInstanceProfiles(It.IsAny<ListInstanceProfilesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListInstanceProfilesForRoleEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListInstanceProfilesForRoleEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListInstanceProfilesForRole(It.Is<ListInstanceProfilesForRoleRequest>(r => r.Marker == null)))
                .Returns(new ListInstanceProfilesForRoleResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item1.0" },
                        new InstanceProfile { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListInstanceProfilesForRole(It.Is<ListInstanceProfilesForRoleRequest>(r => r.Marker == "A")))
                .Returns(new ListInstanceProfilesForRoleResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item2.0" },
                        new InstanceProfile { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListInstanceProfilesForRole(It.Is<ListInstanceProfilesForRoleRequest>(r => r.Marker == "AA")))
                .Returns(new ListInstanceProfilesForRoleResponse
                {
                    InstanceProfiles = new List<InstanceProfile> 
                    {
                        new InstanceProfile { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<InstanceProfile, ListInstanceProfilesForRoleRequest, ListInstanceProfilesForRoleResponse>(new ListInstanceProfilesForRoleRequest(), mock.Object.ListInstanceProfilesForRole);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListInstanceProfilesForRole(It.IsAny<ListInstanceProfilesForRoleRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListInstanceProfilesForRole(It.IsAny<ListInstanceProfilesForRoleRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListMFADevicesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListMFADevicesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListMFADevices(It.Is<ListMFADevicesRequest>(r => r.Marker == null)))
                .Returns(new ListMFADevicesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    MFADevices = new List<MFADevice> 
                    {
                        new MFADevice { SerialNumber = "item1.0" },
                        new MFADevice { SerialNumber = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListMFADevices(It.Is<ListMFADevicesRequest>(r => r.Marker == "A")))
                .Returns(new ListMFADevicesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    MFADevices = new List<MFADevice> 
                    {
                        new MFADevice { SerialNumber = "item2.0" },
                        new MFADevice { SerialNumber = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListMFADevices(It.Is<ListMFADevicesRequest>(r => r.Marker == "AA")))
                .Returns(new ListMFADevicesResponse
                {
                    MFADevices = new List<MFADevice> 
                    {
                        new MFADevice { SerialNumber = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<MFADevice, ListMFADevicesRequest, ListMFADevicesResponse>(new ListMFADevicesRequest(), mock.Object.ListMFADevices);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListMFADevices(It.IsAny<ListMFADevicesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.SerialNumber);
                }
            }

            mock.Verify(client => client.ListMFADevices(It.IsAny<ListMFADevicesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListRolePoliciesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListRolePoliciesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListRolePolicies(It.Is<ListRolePoliciesRequest>(r => r.Marker == null)))
                .Returns(new ListRolePoliciesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item1.0", "item1.1"
                    }
                });

            mock.Setup(client => client.ListRolePolicies(It.Is<ListRolePoliciesRequest>(r => r.Marker == "A")))
                .Returns(new ListRolePoliciesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item2.0", "item2.1"
                    }
                });

            mock.Setup(client => client.ListRolePolicies(It.Is<ListRolePoliciesRequest>(r => r.Marker == "AA")))
                .Returns(new ListRolePoliciesResponse
                {
                    PolicyNames = new List<string> 
                    {
                        "item3.0"
                    }
                });

            var items = Paginator.Paginate<string, ListRolePoliciesRequest, ListRolePoliciesResponse>(new ListRolePoliciesRequest(), mock.Object.ListRolePolicies);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListRolePolicies(It.IsAny<ListRolePoliciesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current);
                }
            }

            mock.Verify(client => client.ListRolePolicies(It.IsAny<ListRolePoliciesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListRolesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListRolesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListRoles(It.Is<ListRolesRequest>(r => r.Marker == null)))
                .Returns(new ListRolesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Roles = new List<Role> 
                    {
                        new Role { Arn = "item1.0" },
                        new Role { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListRoles(It.Is<ListRolesRequest>(r => r.Marker == "A")))
                .Returns(new ListRolesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Roles = new List<Role> 
                    {
                        new Role { Arn = "item2.0" },
                        new Role { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListRoles(It.Is<ListRolesRequest>(r => r.Marker == "AA")))
                .Returns(new ListRolesResponse
                {
                    Roles = new List<Role> 
                    {
                        new Role { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<Role, ListRolesRequest, ListRolesResponse>(new ListRolesRequest(), mock.Object.ListRoles);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListRoles(It.IsAny<ListRolesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListRoles(It.IsAny<ListRolesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListServerCertificatesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListServerCertificatesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListServerCertificates(It.Is<ListServerCertificatesRequest>(r => r.Marker == null)))
                .Returns(new ListServerCertificatesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    ServerCertificateMetadataList = new List<ServerCertificateMetadata> 
                    {
                        new ServerCertificateMetadata { Arn = "item1.0" },
                        new ServerCertificateMetadata { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListServerCertificates(It.Is<ListServerCertificatesRequest>(r => r.Marker == "A")))
                .Returns(new ListServerCertificatesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    ServerCertificateMetadataList = new List<ServerCertificateMetadata> 
                    {
                        new ServerCertificateMetadata { Arn = "item2.0" },
                        new ServerCertificateMetadata { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListServerCertificates(It.Is<ListServerCertificatesRequest>(r => r.Marker == "AA")))
                .Returns(new ListServerCertificatesResponse
                {
                    ServerCertificateMetadataList = new List<ServerCertificateMetadata> 
                    {
                        new ServerCertificateMetadata { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<ServerCertificateMetadata, ListServerCertificatesRequest, ListServerCertificatesResponse>(new ListServerCertificatesRequest(), mock.Object.ListServerCertificates);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListServerCertificates(It.IsAny<ListServerCertificatesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListServerCertificates(It.IsAny<ListServerCertificatesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListSigningCertificatesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListSigningCertificatesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListSigningCertificates(It.Is<ListSigningCertificatesRequest>(r => r.Marker == null)))
                .Returns(new ListSigningCertificatesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Certificates = new List<SigningCertificate> 
                    {
                        new SigningCertificate { CertificateBody = "item1.0" },
                        new SigningCertificate { CertificateBody = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListSigningCertificates(It.Is<ListSigningCertificatesRequest>(r => r.Marker == "A")))
                .Returns(new ListSigningCertificatesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Certificates = new List<SigningCertificate> 
                    {
                        new SigningCertificate { CertificateBody = "item2.0" },
                        new SigningCertificate { CertificateBody = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListSigningCertificates(It.Is<ListSigningCertificatesRequest>(r => r.Marker == "AA")))
                .Returns(new ListSigningCertificatesResponse
                {
                    Certificates = new List<SigningCertificate> 
                    {
                        new SigningCertificate { CertificateBody = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<SigningCertificate, ListSigningCertificatesRequest, ListSigningCertificatesResponse>(new ListSigningCertificatesRequest(), mock.Object.ListSigningCertificates);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListSigningCertificates(It.IsAny<ListSigningCertificatesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.CertificateBody);
                }
            }

            mock.Verify(client => client.ListSigningCertificates(It.IsAny<ListSigningCertificatesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListUserPoliciesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListUserPoliciesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListUserPolicies(It.Is<ListUserPoliciesRequest>(r => r.Marker == null)))
                .Returns(new ListUserPoliciesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item1.0", "item1.1"
                    }
                });

            mock.Setup(client => client.ListUserPolicies(It.Is<ListUserPoliciesRequest>(r => r.Marker == "A")))
                .Returns(new ListUserPoliciesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    PolicyNames = new List<string> 
                    {
                        "item2.0", "item2.1"
                    }
                });

            mock.Setup(client => client.ListUserPolicies(It.Is<ListUserPoliciesRequest>(r => r.Marker == "AA")))
                .Returns(new ListUserPoliciesResponse
                {
                    PolicyNames = new List<string> 
                    {
                        "item3.0"
                    }
                });

            var items = Paginator.Paginate<string, ListUserPoliciesRequest, ListUserPoliciesResponse>(new ListUserPoliciesRequest(), mock.Object.ListUserPolicies);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListUserPolicies(It.IsAny<ListUserPoliciesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current);
                }
            }

            mock.Verify(client => client.ListUserPolicies(It.IsAny<ListUserPoliciesRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListUsersEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListUsersEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListUsers(It.Is<ListUsersRequest>(r => r.Marker == null)))
                .Returns(new ListUsersResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    Users = new List<User> 
                    {
                        new User { Arn = "item1.0" },
                        new User { Arn = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListUsers(It.Is<ListUsersRequest>(r => r.Marker == "A")))
                .Returns(new ListUsersResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    Users = new List<User> 
                    {
                        new User { Arn = "item2.0" },
                        new User { Arn = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListUsers(It.Is<ListUsersRequest>(r => r.Marker == "AA")))
                .Returns(new ListUsersResponse
                {
                    Users = new List<User> 
                    {
                        new User { Arn = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<User, ListUsersRequest, ListUsersResponse>(new ListUsersRequest(), mock.Object.ListUsers);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListUsers(It.IsAny<ListUsersRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.Arn);
                }
            }

            mock.Verify(client => client.ListUsers(It.IsAny<ListUsersRequest>()), Times.Exactly(3));

        }

        #endregion

        #region ListVirtualMFADevicesEnumerator
      
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Paginators")]
        [TestCategory("IdentityManagementService")]
        public void TestListVirtualMFADevicesEnumerator()
        {
            var mock = new Mock<IAmazonIdentityManagementService>();

            mock.Setup(client => client.ListVirtualMFADevices(It.Is<ListVirtualMFADevicesRequest>(r => r.Marker == null)))
                .Returns(new ListVirtualMFADevicesResponse
                {
                    Marker = "A",
                    IsTruncated = true,
                    VirtualMFADevices = new List<VirtualMFADevice> 
                    {
                        new VirtualMFADevice { SerialNumber = "item1.0" },
                        new VirtualMFADevice { SerialNumber = "item1.1" }
                    }
                });

            mock.Setup(client => client.ListVirtualMFADevices(It.Is<ListVirtualMFADevicesRequest>(r => r.Marker == "A")))
                .Returns(new ListVirtualMFADevicesResponse
                {
                    Marker = "AA",
                    IsTruncated = true,
                    VirtualMFADevices = new List<VirtualMFADevice> 
                    {
                        new VirtualMFADevice { SerialNumber = "item2.0" },
                        new VirtualMFADevice { SerialNumber = "item2.1" }
                    }
                });

            mock.Setup(client => client.ListVirtualMFADevices(It.Is<ListVirtualMFADevicesRequest>(r => r.Marker == "AA")))
                .Returns(new ListVirtualMFADevicesResponse
                {
                    VirtualMFADevices = new List<VirtualMFADevice> 
                    {
                        new VirtualMFADevice { SerialNumber = "item3.0" },
                    }
                });

            var items = Paginator.Paginate<VirtualMFADevice, ListVirtualMFADevicesRequest, ListVirtualMFADevicesResponse>(new ListVirtualMFADevicesRequest(), mock.Object.ListVirtualMFADevices);

            var itemEnumerator = items.GetEnumerator();

            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    if (!itemEnumerator.MoveNext())
                        break;
                    mock.Verify(client => client.ListVirtualMFADevices(It.IsAny<ListVirtualMFADevicesRequest>()), Times.Exactly(i));
                        Assert.AreEqual(String.Format("item{0}.{1}", i, j), itemEnumerator.Current.SerialNumber);
                }
            }

            mock.Verify(client => client.ListVirtualMFADevices(It.IsAny<ListVirtualMFADevicesRequest>()), Times.Exactly(3));

        }

        #endregion

 
      
    }
}