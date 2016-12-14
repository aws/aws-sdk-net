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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Amazon.Runtime
{
    /// <summary>
    /// A named group of options that are persisted and used to obtain AWSCredentials.
    /// </summary>
    public class CredentialProfile
    {
        /// <summary>
        /// The name of the CredentialProfile
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The options to be used to create AWSCredentials.
        /// </summary>
        public CredentialProfileOptions Options { get; private set; }

        /// <summary>
        /// An optional dictionary of name-value pairs stored with the CredentialProfile
        /// </summary>
        internal Dictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// True if the properties of the Options object can be converted into AWSCredentials, false otherwise.
        /// See <see cref="CredentialProfileOptions"/> for more details about which options are available.
        /// </summary>
        public bool CanCreateAWSCredentials
        {
            get
            {
                return ProfileType.HasValue;
            }
        }

        /// <summary>
        /// If CanCreateAWSCredentials is true, returns a short description of the type of
        /// credentials that would be created.
        /// If CanCreateAWSCredentials is false, return null.
        /// </summary>
        public string CredentialDescription
        {
            get
            {
                return CredentialProfileTypeDetector.GetUserFriendlyCredentialType(ProfileType);
            }
        }

        /// <summary>
        /// The CredentialProfileType of this CredentialProfile, if one applies.
        /// </summary>
        internal CredentialProfileType? ProfileType
        {
            get
            {
                return CredentialProfileTypeDetector.DetectProfileType(Options);
            }
        }

        /// <summary>
        /// The ProfileStore this CredentialProfile is associated with.
        /// </summary>
        internal ICredentialProfileStore ProfileStore { get; set; }

        /// <summary>
        /// Construct a new CredentialProfile.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="profileOptions"></param>
        /// <param name="profileStore"></param>
        internal CredentialProfile(string name, CredentialProfileOptions profileOptions, ICredentialProfileStore profileStore)
            : this(name, profileOptions, new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase), profileStore)
        {
        }

        /// <summary>
        /// Construct a new CredentialProfile.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="profileOptions"></param>
        /// <param name="properties"></param>
        /// <param name="profileStore"></param>
        internal CredentialProfile(string name, CredentialProfileOptions profileOptions, Dictionary<string, string> properties, ICredentialProfileStore profileStore)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name must not be null or empty.");
            }
            if (profileOptions == null)
            {
                throw new ArgumentNullException("profileOptions");
            }
            if (profileStore == null)
            {
                throw new ArgumentNullException("profileStore");
            }

            if (properties == null)
                properties = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            Name = name;
            Options = profileOptions;
            ProfileStore = profileStore;
            Properties = properties;
        }

        /// <summary>
        /// Persist changes to this CredentialProfile.
        /// </summary>
        public void Persist()
        {
            ProfileStore.RegisterProfile(this);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <returns>AWSCredentials for this profile.</returns>
        public AWSCredentials GetAWSCredentials()
        {
            return GetAWSCredentials(false);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="nonCallbackOnly">If true, throw a descriptive exception for any credentials that would not operate as-is.
        /// In other words, any credentials that require programmatic callbacks at runtime.</param>
        /// <returns>AWSCredentials for this profile.</returns>
        internal AWSCredentials GetAWSCredentials(bool nonCallbackOnly)
        {
            return AWSCredentialsFactory.GetAWSCredentials(this, nonCallbackOnly);
        }

        private string GetPropertiesString()
        {
            return "{" + string.Join(",", Properties.OrderBy(p=>p.Key).Select(p => p.Key + "=" + p.Value).ToArray()) + "}";
        }

        public override string ToString()
        {
            return "[Name=" + Name + "," +
                "Options = " + Options + "," +
                "Properties = " + GetPropertiesString() + "," +
                "ProfileType = " + ProfileType + "," +
                "CanCreateAWSCredentials = " + CanCreateAWSCredentials + "]";
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var p = obj as CredentialProfile;
            if (p == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { Name, Options, ProfileType, CanCreateAWSCredentials },
                new object[] { p.Name, p.Options, p.ProfileType, p.CanCreateAWSCredentials }) &&
                AWSSDKUtils.DictionariesAreEqual(Properties, p.Properties);
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(Name, Options, ProfileType, CanCreateAWSCredentials, GetPropertiesString());
        }
    }
}
