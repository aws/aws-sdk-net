/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// BucketLoggingConfig represents a configuration for the S3 bucket
    /// logging operatons. This includes a target bucket name which is where
    /// the logs will be stored, a target prefix which is the prefix assigned
    /// to all log files, and a List of grants which will set the AccessControl
    /// for the logs.
    /// </summary>
    public class S3BucketLoggingConfig
    {
        #region Private Members

        private string targetBucketName;
        private string targetPrefix = "";
        private List<S3Grant> grantList;

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
            grant.WithGrantee(grantee);
            grant.WithPermission(permission);
            Grants.Add(grant);
        }

        /// <summary>
        /// Removes a specific permission for the given grantee.
        /// </summary>
        /// <param name="grantee">The grantee</param>
        /// <param name="permission">The permission for the grantee to remove</param>
        public void RemoveGrant(S3Grantee grantee, S3Permission permission)
        {
            foreach (S3Grant grant in Grants)
            {
                if (grant.Grantee.Equals(grantee) && grant.Permission == permission)
                {
                    Grants.Remove(grant);
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
            foreach (S3Grant grant in Grants)
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
        /// Creates an XML representation of this logging configuration which 
        /// is to be sent to S3 when setting up bucket logging.
        /// </summary>
        /// <returns>
        /// XML representation of the logging configuration
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<BucketLoggingStatus xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">");
            if (IsSetTargetBucketName() && IsSetTargetPrefix() && IsSetGrants())
            {
                sb.Append("<LoggingEnabled>");
                sb.Append(System.String.Concat("<TargetBucket>", TargetBucketName, "</TargetBucket>"));
                sb.Append(System.String.Concat("<TargetPrefix>", TargetPrefix, "</TargetPrefix>"));
                sb.Append("<TargetGrants>");
                foreach (S3Grant grant in this.Grants)
                {
                    sb.Append(grant.ToXML());
                }
                sb.Append("</TargetGrants>");
                @sb.Append("</LoggingEnabled>");
            }
            sb.Append("</BucketLoggingStatus>");
            return sb.ToString();
        }

        #endregion

        #region Grants

        /// <summary>
        /// Gets and sets the Grants property.
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
            set { this.grantList = value; }
        }

        /// <summary>
        /// Sets the Grants property.
        /// </summary>
        /// <param name="args">Grants property</param>
        /// <returns>this instance</returns>
        public S3BucketLoggingConfig WithGrants(params S3Grant[] args)
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
            return (Grants.Count > 0);
        }

        #endregion

        #region TargetBucketName

        /// <summary>
        /// Gets and sets the TargetBucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TargetBucketName")]
        public string TargetBucketName
        {
            get { return this.targetBucketName; }
            set { this.targetBucketName = value; }
        }

        /// <summary>
        /// Sets the TargetBucketName property.
        /// </summary>
        /// <param name="targetBucketName">TargetBucketName property</param>
        /// <returns>this instance</returns>
        public S3BucketLoggingConfig WithTargetBucketName(string targetBucketName)
        {
            this.targetBucketName = targetBucketName;
            return this;
        }

        /// <summary>
        /// Checks if TargetBucketName property is set.
        /// </summary>
        /// <returns>true if TargetBucketName property is set.</returns>
        internal bool IsSetTargetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.targetBucketName);
        }

        #endregion

        #region TargetPrefix

        /// <summary>
        /// Gets and sets the TargetPrefix property.
        /// The default value for the TargetPrefix is the empty string
        /// </summary>
        [XmlElementAttribute(ElementName = "TargetPrefix")]
        public string TargetPrefix
        {
            get { return this.targetPrefix; }
            set { this.targetPrefix = value; }
        }

        /// <summary>
        /// Sets the TargetPrefix property.
        /// If no value is set for the property, the default value 
        /// for the TargetPrefix is the empty string
        /// </summary>
        /// <param name="targetPrefix">TargetPrefix property</param>
        /// <returns>this instance</returns>
        public S3BucketLoggingConfig WithTargetPrefix(string targetPrefix)
        {
            this.targetPrefix = targetPrefix;
            return this;
        }

        /// <summary>
        /// Checks if TargetPrefix property is set to a non-null value.
        /// </summary>
        /// <returns>true if TargetPrefix property is set.</returns>
        internal bool IsSetTargetPrefix()
        {
            return this.targetPrefix != null;
        }

        #endregion
    }
}