using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal.Auth.CredentialProfile
{
    public class Profile
    {
        private HashSet<ProfileType> possibleMatches;
        private ProfileType? profileType;

        public string Name { get; private set; }
        public ImmutableProfileOptions Options { get; private set; }

        public ProfileType? ProfileType
        {
            get
            {
                return profileType;
            }
        }

        public HashSet<ProfileType> PossibleMatches
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

        public Profile(string name, ProfileOptions profileOptions)
        {
            if (profileOptions == null)
            {
                throw new ArgumentNullException("profileOptions");
            }
            Name = name;
            Options = profileOptions;
            ProfileTypeDetector.DetectProfileTypes(profileOptions, out profileType, out possibleMatches);
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

            var p = obj as Profile;
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
