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

using System;
using System.Security;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Amazon.S3.Model
{
    /// <summary>
    /// IComparable class that is used when sorting a lit of grants.
    /// </summary>
    public class ComparatorGrant : IComparer<S3Grant>
    {
        /// <summary>
        /// Compares the string representation of the grants
        /// </summary>
        public int Compare(S3Grant x, S3Grant y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    /// <summary>
    /// <para>
    /// Represents a grant for a bucket or object ACL. A grant contains
    /// a S3Grantee and a S3Permission for that S3Grantee.
    /// </para>
    /// <para>
    /// For more information on Grants/ACLs refer:
    /// <see href="http://docs.amazonwebservices.com/AmazonS3/latest/index.html?RESTAuthentication.html"/>
    /// </para>
    /// </summary>
    public class S3Grant
    {
        private S3Grantee grantee;
        private S3Permission permission;

        /// <summary>
        /// Creates a string representation of a Grant.
        /// </summary>
        /// <returns>The string representation of the Grant.</returns>
        public override string ToString()
        {
            return String.Concat("S3Grantee: ", grantee, " S3Permission: ", this.Permission);
        }

        /// <summary>
        /// The grantee details.
        /// </summary>
        [XmlElementAttribute(ElementName = "Grantee")]
        public S3Grantee Grantee
        {
            get { return this.grantee; }
            set { this.grantee = value; }
        }

        /// <summary>
        /// Sets the grantee details.
        /// </summary>
        /// <param name="grantee">S3Grantee property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Grant WithGrantee(S3Grantee grantee)
        {
            this.grantee = grantee;
            return this;
        }

        /// <summary>
        /// Checks if S3Grantee property is set.
        /// </summary>
        /// <returns>true if S3Grantee property is set.</returns>
        internal bool IsSetGrantee()
        {
            return this.grantee != null;
        }

        /// <summary>
        /// An S3 permission.
        /// </summary>
        [XmlElementAttribute(ElementName = "Permission")]
        public S3Permission Permission
        {
            get { return this.permission; }
            set { this.permission = value; }
        }

        /// <summary>
        /// Sets an S3 permission.
        /// </summary>
        /// <param name="permission">S3Permission property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Grant WithPermission(S3Permission permission)
        {
            this.permission = permission;
            return this;
        }

        /// <summary>
        /// Checks if S3Permission property is set.
        /// </summary>
        /// <returns>true if S3Permission property is set.</returns>
        internal bool IsSetPermission()
        {
            return this.permission != S3Permission.INVALID;
        }

        internal string ToXML()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<Grant>");
            if (Grantee.CanonicalUser != null && !string.IsNullOrEmpty(Grantee.CanonicalUser.First))
            {
                sb.Append("<Grantee xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"CanonicalUser\">");
                sb.Append("<ID>").Append(SecurityElement.Escape(this.Grantee.CanonicalUser.First)).Append("</ID>");
                sb.Append("<DisplayName>").Append(SecurityElement.Escape(this.Grantee.CanonicalUser.Second)).Append("</DisplayName>");
                sb.Append("</Grantee>");
                sb.Append("<Permission>").Append(this.Permission).Append("</Permission>");
            }
            else if (this.Grantee.IsSetEmailAddress())
            {
                sb.Append("<Grantee xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"AmazonCustomerByEmail\">");
                sb.Append("<EmailAddress>").Append(SecurityElement.Escape(this.Grantee.EmailAddress)).Append("</EmailAddress>");
                sb.Append("</Grantee>");
                sb.Append("<Permission>").Append(this.Permission).Append("</Permission>");
            }
            else if (this.Grantee.IsSetURI())
            {
                sb.Append("<Grantee xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:type=\"Group\">");
                sb.Append("<URI>").Append(SecurityElement.Escape(this.Grantee.URI)).Append("</URI>");
                sb.Append("</Grantee>");
                sb.Append("<Permission>").Append(this.Permission).Append("</Permission>");
            }
            sb.Append("</Grant>");

            return sb.ToString();
        }
    }
}
