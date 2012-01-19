/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for AWS Identity and Access Management.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class IdentityandAccessManagementActionIdentifiers
    {
        public static readonly ActionIdentifier AllIdentityandAccessManagementActions = new ActionIdentifier("iam:*");

        public static readonly ActionIdentifier AddUserToGroup = new ActionIdentifier("iam:AddUserToGroup");
        public static readonly ActionIdentifier CreateAccessKey = new ActionIdentifier("iam:CreateAccessKey");
        public static readonly ActionIdentifier CreateAccountAlias = new ActionIdentifier("iam:CreateAccountAlias");
        public static readonly ActionIdentifier CreateGroup = new ActionIdentifier("iam:CreateGroup");
        public static readonly ActionIdentifier CreateLoginProfile = new ActionIdentifier("iam:CreateLoginProfile");
        public static readonly ActionIdentifier CreateUser = new ActionIdentifier("iam:CreateUser");
        public static readonly ActionIdentifier CreateVirtualMFADevice = new ActionIdentifier("iam:CreateVirtualMFADevice");
        public static readonly ActionIdentifier DeactivateMFADevice = new ActionIdentifier("iam:DeactivateMFADevice");
        public static readonly ActionIdentifier DeleteAccessKey = new ActionIdentifier("iam:DeleteAccessKey");
        public static readonly ActionIdentifier DeleteAccountAlias = new ActionIdentifier("iam:DeleteAccountAlias");
        public static readonly ActionIdentifier DeleteGroup = new ActionIdentifier("iam:DeleteGroup");
        public static readonly ActionIdentifier DeleteGroupPolicy = new ActionIdentifier("iam:DeleteGroupPolicy");
        public static readonly ActionIdentifier DeleteLoginProfile = new ActionIdentifier("iam:DeleteLoginProfile");
        public static readonly ActionIdentifier DeleteServerCertificate = new ActionIdentifier("iam:DeleteServerCertificate");
        public static readonly ActionIdentifier DeleteSigningCertificate = new ActionIdentifier("iam:DeleteSigningCertificate");
        public static readonly ActionIdentifier DeleteUser = new ActionIdentifier("iam:DeleteUser");
        public static readonly ActionIdentifier DeleteUserPolicy = new ActionIdentifier("iam:DeleteUserPolicy");
        public static readonly ActionIdentifier DeleteVirtualMFADevice = new ActionIdentifier("iam:DeleteVirtualMFADevice");
        public static readonly ActionIdentifier EnableMFADevice = new ActionIdentifier("iam:EnableMFADevice");
        public static readonly ActionIdentifier GetAccountSummary = new ActionIdentifier("iam:GetAccountSummary");
        public static readonly ActionIdentifier GetGroup = new ActionIdentifier("iam:GetGroup");
        public static readonly ActionIdentifier GetGroupPolicy = new ActionIdentifier("iam:GetGroupPolicy");
        public static readonly ActionIdentifier GetLoginProfile = new ActionIdentifier("iam:GetLoginProfile");
        public static readonly ActionIdentifier GetServerCertificate = new ActionIdentifier("iam:GetServerCertificate");
        public static readonly ActionIdentifier GetUser = new ActionIdentifier("iam:GetUser");
        public static readonly ActionIdentifier GetUserPolicy = new ActionIdentifier("iam:GetUserPolicy");
        public static readonly ActionIdentifier ListAccessKeys = new ActionIdentifier("iam:ListAccessKeys");
        public static readonly ActionIdentifier ListAccountAliases = new ActionIdentifier("iam:ListAccountAliases");
        public static readonly ActionIdentifier ListGroupPolicies = new ActionIdentifier("iam:ListGroupPolicies");
        public static readonly ActionIdentifier ListGroups = new ActionIdentifier("iam:ListGroups");
        public static readonly ActionIdentifier ListGroupsForUser = new ActionIdentifier("iam:ListGroupsForUser");
        public static readonly ActionIdentifier ListMFADevices = new ActionIdentifier("iam:ListMFADevices");
        public static readonly ActionIdentifier ListServerCertificates = new ActionIdentifier("iam:ListServerCertificates");
        public static readonly ActionIdentifier ListSigningCertificates = new ActionIdentifier("iam:ListSigningCertificates");
        public static readonly ActionIdentifier ListUserPolicies = new ActionIdentifier("iam:ListUserPolicies");
        public static readonly ActionIdentifier ListUsers = new ActionIdentifier("iam:ListUsers");
        public static readonly ActionIdentifier ListVirtualMFADevices = new ActionIdentifier("iam:ListVirtualMFADevices");
        public static readonly ActionIdentifier PutGroupPolicy = new ActionIdentifier("iam:PutGroupPolicy");
        public static readonly ActionIdentifier PutUserPolicy = new ActionIdentifier("iam:PutUserPolicy");
        public static readonly ActionIdentifier RemoveUserFromGroup = new ActionIdentifier("iam:RemoveUserFromGroup");
        public static readonly ActionIdentifier ResyncMFADevice = new ActionIdentifier("iam:ResyncMFADevice");
        public static readonly ActionIdentifier UpdateAccessKey = new ActionIdentifier("iam:UpdateAccessKey");
        public static readonly ActionIdentifier UpdateGroup = new ActionIdentifier("iam:UpdateGroup");
        public static readonly ActionIdentifier UpdateLoginProfile = new ActionIdentifier("iam:UpdateLoginProfile");
        public static readonly ActionIdentifier UpdateServerCertificate = new ActionIdentifier("iam:UpdateServerCertificate");
        public static readonly ActionIdentifier UpdateSigningCertificate = new ActionIdentifier("iam:UpdateSigningCertificate");
        public static readonly ActionIdentifier UpdateUser = new ActionIdentifier("iam:UpdateUser");
        public static readonly ActionIdentifier UploadServerCertificate = new ActionIdentifier("iam:UploadServerCertificate");
        public static readonly ActionIdentifier UploadSigningCertificate = new ActionIdentifier("iam:UploadSigningCertificate");
    }
}
