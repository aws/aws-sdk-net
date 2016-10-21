/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
    public class SAMLRoleSessionManager
    {
        private EncryptedStoreObjectManager objectManager;

        public SAMLRoleSessionManager()
        {
            objectManager = new EncryptedStoreObjectManager(SettingsConstants.RegisteredRoleSessions, true);
        }

        public void Clear()
        {
            foreach (string roleSessionName in objectManager.ListObjectNames())
            {
                objectManager.UnregisterObject(roleSessionName);
            }
        }

        /// <summary>
        /// Attempt to read a role session with the given name.
        /// If the session is invlid or expired it will not be returned.
        /// </summary>
        /// <param name="roleSessionName">The name of the role session to get.</param>
        /// <param name="credentials">The credentials for the session, if found.</param>
        /// <returns>True if the session was found, false otherwise.</returns>
        public bool TryGetRoleSession(string roleSessionName, out SAMLImmutableCredentials credentials)
        {
            Dictionary<string, string> properties;
            credentials = null;
            if (objectManager.TryGetObject(roleSessionName, out properties))
            {
                try
                {
                    credentials = SAMLImmutableCredentials.FromJson(properties[SettingsConstants.RoleSession]);
                }
                catch (Exception e)
                {
                    Logger.GetLogger(typeof(SAMLEndpointManager)).Error(e, "Unable to load SAML role session '{0}'.", roleSessionName);
                }
            }
            return credentials != null;
        }

        public void RegisterRoleSession(string roleSessionName, SAMLImmutableCredentials credentials)
        {
            var properties = new Dictionary<string, string>()
            {
                { SettingsConstants.RoleSession, credentials.ToJson() }
            };
            objectManager.RegisterObject(roleSessionName, properties);
        }

        public void UnregisterRoleSession(string roleSessionName)
        {
            objectManager.UnregisterObject(roleSessionName);
        }
    }
}