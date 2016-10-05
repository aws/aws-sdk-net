using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal
{
    public class CredentialProfile
    {
        private HashSet<CredentialProfileType> possibleMatches;
        private CredentialProfileType? profileType;

        public string Name { get; private set; }
        public ImmutableCredentialProfileOptions Options { get; private set; }

        public CredentialProfileType? ProfileType
        {
            get
            {
                return profileType;
            }
        }

        public HashSet<CredentialProfileType> PossibleMatches
        {
            get
            {
                return possibleMatches;
            }
        }

        public bool IsValid
        {
            get
            {
                return ProfileType.HasValue;
            }
        }

        public CredentialProfile(string name, CredentialProfileOptions profileOptions)
        {
            if (profileOptions == null)
            {
                throw new ArgumentNullException("profileOptions");
            }
            Name = name;
            Options = profileOptions;
            CredentialProfileTypeDetector.DetectProfileTypes(profileOptions, out profileType, out possibleMatches);
        }

        public override string ToString()
        {
            return "[Name=" + Name + "," +
                "Options = " + Options + "," +
                "ProfileType = " + ProfileType + "," +
                "PossibleMatches = " + PossibleMatches + "," +
                "IsValid = " + IsValid + "]";
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var p = obj as CredentialProfile;
            if (p == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { Name, Options, ProfileType, IsValid },
                new object[] { p.Name, p.Options, p.ProfileType, p.IsValid }) &&
                PossibleMatches.SetEquals(p.PossibleMatches);
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(Name, Options, ProfileType, IsValid, PossibleMatches);
        }
    }
}
