/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CheckAccessNotGranted operation.
    /// Checks whether the specified access isn't allowed by a policy.
    /// </summary>
    public partial class CheckAccessNotGrantedRequest : AmazonAccessAnalyzerRequest
    {
        private List<Access> _access = AWSConfigs.InitializeCollections ? new List<Access>() : null;
        private string _policyDocument;
        private AccessCheckPolicyType _policyType;

        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        /// An access object containing the permissions that shouldn't be granted by the specified
        /// policy. If only actions are specified, IAM Access Analyzer checks for access to peform
        /// at least one of the actions on any resource in the policy. If only resources are specified,
        /// then IAM Access Analyzer checks for access to perform any action on at least one of
        /// the resources. If both actions and resources are specified, IAM Access Analyzer checks
        /// for access to perform at least one of the specified actions on at least one of the
        /// specified resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<Access> Access
        {
            get { return this._access; }
            set { this._access = value; }
        }

        // Check to see if Access property is set
        internal bool IsSetAccess()
        {
            return this._access != null && (this._access.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The JSON policy document to use as the content for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. Identity policies grant permissions to IAM principals. Identity
        /// policies include managed and inline policies for IAM roles, users, and groups.
        /// </para>
        ///  
        /// <para>
        /// Resource policies grant permissions on Amazon Web Services resources. Resource policies
        /// include trust policies for IAM roles and bucket policies for Amazon S3 buckets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessCheckPolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}