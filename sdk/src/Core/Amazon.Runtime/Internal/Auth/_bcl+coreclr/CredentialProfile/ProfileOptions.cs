using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Runtime.Internal.Auth.CredentialProfile
{
    abstract public class ImmutableProfileOptions
    {
        public string AccessKey { get; protected set; }
        public string ExternalID { get; protected set; }
        public string MfaSerial { get; protected set; }
        public string RoleArn { get; protected set; }
        public string SecretKey { get; protected set; }
        public string SourceProfile { get; protected set; }
        public string Token { get; protected set; }

        public override string ToString()
        {
            return
                "[AccessKey=" + AccessKey + ", " +
                "ExternalID=" + ExternalID + ", " +
                "MfaSerial=" + MfaSerial + ", " +
                "RoleArn=" + RoleArn + ", " +
                "SecretKey=XXXXX, " +
                "SourceProfile=" + SourceProfile + ", " +
                "Token=" + Token + "]";
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;

            var ipo = obj as ImmutableProfileOptions;
            if (ipo == null)
                return false;

            return AWSSDKUtils.AreEqual(
                new object[] { AccessKey, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token },
                new object[] { ipo.AccessKey, ipo.ExternalID, ipo.MfaSerial, ipo.RoleArn, ipo.SecretKey, ipo.SourceProfile, ipo.Token });
        }

        public override int GetHashCode()
        {
            return Hashing.Hash(AccessKey, ExternalID, MfaSerial, RoleArn, SecretKey, SourceProfile, Token);
        }
    }

    public class ProfileOptions : ImmutableProfileOptions
    {
        new public string AccessKey { get { return base.AccessKey; } set { base.AccessKey = value; } }
        new public string ExternalID { get { return base.ExternalID; } set { base.ExternalID = value; } }
        new public string MfaSerial { get { return base.MfaSerial; } set { base.MfaSerial = value; } }
        new public string RoleArn { get { return base.RoleArn; } set { base.RoleArn = value; } }
        new public string SecretKey { get { return base.SecretKey; } set { base.SecretKey = value; } }
        new public string SourceProfile { get { return base.SourceProfile; } set { base.SourceProfile = value; } }
        new public string Token { get { return base.Token; } set { base.Token = value; } }
    }
}
