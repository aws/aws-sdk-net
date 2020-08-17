/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violations for a resource based on the specified AWS Firewall Manager policy and AWS
    /// account.
    /// </summary>
    public partial class ViolationDetail
    {
        private string _memberAccount;
        private string _policyId;
        private string _resourceDescription;
        private string _resourceId;
        private List<Tag> _resourceTags = new List<Tag>();
        private string _resourceType;
        private List<ResourceViolation> _resourceViolations = new List<ResourceViolation>();

        /// <summary>
        /// Gets and sets the property MemberAccount. 
        /// <para>
        /// The AWS account that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string MemberAccount
        {
            get { return this._memberAccount; }
            set { this._memberAccount = value; }
        }

        // Check to see if MemberAccount property is set
        internal bool IsSetMemberAccount()
        {
            return this._memberAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the AWS Firewall Manager policy that the violation details were requested
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDescription. 
        /// <para>
        /// Brief description for the requested resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ResourceDescription
        {
            get { return this._resourceDescription; }
            set { this._resourceDescription = value; }
        }

        // Check to see if ResourceDescription property is set
        internal bool IsSetResourceDescription()
        {
            return this._resourceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// The <code>ResourceTag</code> objects associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && this._resourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type that the violation details were requested for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceViolations. 
        /// <para>
        /// List of violations for the requested resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceViolation> ResourceViolations
        {
            get { return this._resourceViolations; }
            set { this._resourceViolations = value; }
        }

        // Check to see if ResourceViolations property is set
        internal bool IsSetResourceViolations()
        {
            return this._resourceViolations != null && this._resourceViolations.Count > 0; 
        }

    }
}