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

using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an access control list (ACL) for S3. An AccessControlList is represented by an Owner,
    /// and a List of Grants, where each Grant is a Grantee and a Permission.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each bucket and object in Amazon S3 has an ACL that defines its access control policy.
    /// When a request is made, Amazon S3 authenticates the request using its standard
    /// authentication procedure and then checks the ACL to verify the sender was granted access
    /// to the bucket or object. If the sender is approved, the request proceeds.
    /// Otherwise, Amazon S3 returns an error.
    /// </para>
    /// <para>
    /// An ACL is a list of grants. A grant consists of one grantee and one permission.
    /// ACLs only grant permissions; they do not deny them.
    /// </para>
    /// <para>
    /// For convenience, some commonly used Access Control Lists are defined in
    /// S3CannedACL.
    /// </para>
    /// <para>
    /// Note: Bucket and object ACLs are completely independent; an object does not inherit the ACL
    /// from its bucket. For example, if you create a bucket and grant write access to another user,
    /// you will not be able to access the user's objects unless the user explicitly grants access.
    /// This also applies if you grant anonymous write access to a bucket. Only the user "anonymous"
    /// will be able to access objects the user created unless permission is explicitly granted to
    /// the bucket owner.
    /// </para>
    /// <para>
    /// Important: We highly recommend that you do not grant the anonymous group write access to your
    /// buckets as you will have no control over the objects others can store and their associated charges.
    /// For more information, see Grantees and Permissions</para>
    /// </remarks>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class S3AccessControlList
    {
        #region Private Members

        private Owner owner;
        private List<S3Grant> grantList = null;

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a S3Grant and adds it to the list of grants.
        /// </summary>
        /// <param name="grantee">The grantee for the grant.</param>
        /// <param name="permission">The permission for the grantee.</param>
        public void AddGrant(S3Grantee grantee, S3Permission permission)
        {
            S3Grant grant = new S3Grant();
            grant.Grantee = grantee;
            grant.Permission = permission;
            this.Grants.Add(grant);
        }

        /// <summary>
        /// Removes a specific permission for the given grantee.
        /// </summary>
        /// <param name="grantee">The grantee</param>
        /// <param name="permission">The permission for the grantee to remove</param>
        public void RemoveGrant(S3Grantee grantee, S3Permission permission)
        {
            foreach (S3Grant grant in this.Grants)
            {
                if (grant.Grantee.Equals(grantee) && grant.Permission == permission)
                {
                    this.Grants.Remove(grant);
                    break;
                }
            }
        }

        /// <summary>
        /// Removes all permissions for the given grantee.
        /// </summary>
        /// <param name="grantee"></param>
        public void RemoveGrant(S3Grantee grantee)
        {
            List<S3Grant> removeList = new List<S3Grant>();
            foreach (S3Grant grant in this.Grants)
            {
                if (grant.Grantee.Equals(grantee))
                {
                    removeList.Add(grant);
                }
            }
            foreach (S3Grant grant in removeList)
            {
                this.Grants.Remove(grant);
            }
        }

        /// <summary>
        /// Returns a System.String that represents the AccessControlList Object
        /// </summary>
        /// <returns>A System.String representation of the AccessControlList Object.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<AccessControlPolicy xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">");
            sb.Append("<Owner>");
            sb.Append(System.String.Concat("<ID>", this.Owner.Id, "</ID>"));
            sb.Append(System.String.Concat("<DisplayName>", this.Owner.DisplayName, "</DisplayName>"));
            sb.Append("</Owner>");
            sb.Append("<AccessControlList>");
            foreach (S3Grant grant in this.Grants)
            {
                sb.Append(grant.ToXML());
            }
            sb.Append("</AccessControlList>");
            sb.Append("</AccessControlPolicy>");
            return sb.ToString();
        }

        #endregion

        #region Internal Methods

        internal void Sort()
        {
            this.Grants.Sort(new ComparatorGrant());
        }

        #endregion

        #region Owner

        /// <summary>
        /// The owner of the bucket or object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Every bucket and object in Amazon S3 has an owner, the user that
        /// created the bucket or object. The owner of a bucket or object cannot
        /// be changed. However, if the object is overwritten by another user
        /// (deleted and rewritten), the new object will have a new owner.
        /// </para>
        /// <para>
        /// Note: Even the owner is subject to the ACL. For example, if an owner
        /// does not have Permission.READ access to an object, the owner cannot read
        /// that object. However, the owner of an object always has write access to the
        /// access control policy (Permission.WriteAcp) and can change the ACL to
        /// read the object.
        /// </para>
        /// </remarks>
        [XmlElementAttribute(ElementName = "Owner")]
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        /// <summary>
        /// Sets the owner of the bucket or object.
        /// </summary>
        /// <param name="owner">Owner property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3AccessControlList WithOwner(Owner owner)
        {
            this.owner = owner;
            return this;
        }

        /// <summary>
        /// Checks if Owner property is set.
        /// </summary>
        /// <returns>true if Owner property is set.</returns>
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        #endregion

        #region Grants

        /// <summary>
        /// A collection of grants.
        /// </summary>
        [XmlElementAttribute(ElementName = "Grants")]
        public List<S3Grant> Grants
        {
            get
            {
                if (this.grantList == null)
                {
                    this.grantList = new List<S3Grant>();
                }
                return this.grantList;
            }
            set
            {
                this.grantList = value;
            }
        }

        /// <summary>
        /// Sets a collection of grants.
        /// </summary>
        /// <param name="args">Grants property</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3AccessControlList WithGrants(params S3Grant[] args)
        {
            foreach (S3Grant arg in args)
            {
                Grants.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if Grants property is set.
        /// </summary>
        /// <returns>true if Grants property is set.</returns>
        internal bool IsSetGrants()
        {
            return (this.Grants.Count > 0);
        }

        #endregion
    }
}
