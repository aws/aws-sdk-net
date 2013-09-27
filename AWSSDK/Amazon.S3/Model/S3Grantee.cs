/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System.Text;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{

    /// <summary>
    /// <para>
    /// A S3Grantee represents an Owner/User/Group that can be given permissions
    /// on a bucket or object.
    /// </para>
    /// <para>
    /// For more information about Grantees or ACLs see:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/index.html?RESTAuthentication.html"/>
    /// </para>
    /// </summary>
    public class S3Grantee
    {
        #region Private Members

        private string emailAddress;
        private string uri;
        private Tuple<string, string> canonicalUser;

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a System.String that represents the Grantee Object.
        /// </summary>
        /// <returns>A System.String representation of the Grantee Object.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (IsSetEmailAddress())
            {
                sb.Append(System.String.Concat("EmailAddress:", this.EmailAddress));
            }
            if (IsSetURI())
            {
                sb.Append(System.String.Concat("URI:", this.URI));
            }
            if (IsSetCanonicalUser())
            {
                sb.Append(System.String.Concat("ID:", this.canonicalUser.First, " DisplayName:", this.canonicalUser.Second));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Determines whether two Tuple objects have the same value.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true if obj is a String  and its value is the same as this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Equals((S3Grantee)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>A hash code for the current S3Grantee</returns>
        public override int GetHashCode()
        {
            if (this.IsSetCanonicalUser())
            {
                return this.canonicalUser.First.GetHashCode() ^
                    this.canonicalUser.Second.GetHashCode();
            }

            if (this.IsSetEmailAddress())
            {
                return this.EmailAddress.GetHashCode();
            }

            if (this.IsSetURI())
            {
                return this.URI.GetHashCode();
            }

            return base.GetHashCode();
        }

        /// <summary>
        /// Determines whether is specified Grantee is equal to the current Grantee.
        /// </summary>
        /// <param name="grantee">The specified Grantee</param>
        /// <returns>true if the Grantees are equal, false otherwise</returns>
        private bool Equals(S3Grantee grantee)
        {
            if (grantee.IsSetCanonicalUser() && this.IsSetCanonicalUser())
            {
                return grantee.canonicalUser.Equals(this.canonicalUser);
            }

            if (grantee.IsSetEmailAddress() && this.IsSetEmailAddress())
            {
                return grantee.EmailAddress.Equals(this.EmailAddress);
            }

            if (grantee.IsSetURI() && this.IsSetURI())
            {
                return grantee.URI.Equals(this.URI);
            }

            return false;
        }

        #endregion

        #region CanonicalUser

        /// <summary>
        /// The canonical user details.
        /// </summary>
        [XmlElementAttribute(ElementName = "CanonicalUser")]
        public Tuple<string, string> CanonicalUser
        {
            get
            {
                if (this.canonicalUser == null)
                {
                    this.canonicalUser = new Tuple<string, string>("", "");
                }
                return this.canonicalUser;
            }
            set { this.canonicalUser = value; }
        }

        /// <summary>
        /// Sets the canonical user details.
        /// </summary>
        /// <param name="displayName">Display name of the canonical user</param>
        /// <param name="id">The ID of the canonical user</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Grantee WithCanonicalUser(string id, string displayName)
        {
            canonicalUser = new Tuple<string, string>(id, displayName);
            return this;
        }

        /// <summary>
        /// Checks if the CanonicalUser property is set.
        /// </summary>
        /// <returns>true if the CanonicalUser property is set.</returns>
        internal bool IsSetCanonicalUser()
        {
            return (this.canonicalUser != null) &&
                (!System.String.IsNullOrEmpty(CanonicalUser.First)) &&
                (!System.String.IsNullOrEmpty(CanonicalUser.Second));
        }

        #endregion

        #region EmailAddress

        /// <summary>
        /// The email address associated with the grantee.
        /// </summary>
        [XmlElementAttribute(ElementName = "EmailAddress")]
        public string EmailAddress
        {
            get { return this.emailAddress; }
            set { this.emailAddress = value; }
        }

        /// <summary>
        /// Sets the email address associated with the grantee.
        /// </summary>
        /// <param name="emailAddress">EmailAddress property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Grantee WithEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
            return this;
        }

        /// <summary>
        /// Checks if EmailAddress property is set.
        /// </summary>
        /// <returns>true if EmailAddress property is set.</returns>
        internal bool IsSetEmailAddress()
        {
            return !System.String.IsNullOrEmpty(this.emailAddress);
        }

        #endregion

        #region URI

        /// <summary>
        /// The URI property of the grantee.
        /// </summary>
        [XmlElementAttribute(ElementName = "URI")]
        public string URI
        {
            get { return this.uri; }
            set { this.uri = value; }
        }

        /// <summary>
        /// Sets the URI property of the grantee.
        /// </summary>
        /// <param name="uri">URI property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Grantee WithURI(string uri)
        {
            this.uri = uri;
            return this;
        }

        /// <summary>
        /// Checks if URI property is set.
        /// </summary>
        /// <returns>true if URI property is set.</returns>
        internal bool IsSetURI()
        {
            return this.uri != null;
        }

        #endregion
    }
}
