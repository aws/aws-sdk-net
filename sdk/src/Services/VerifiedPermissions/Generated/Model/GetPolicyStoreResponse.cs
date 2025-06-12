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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyStore operation.
    /// </summary>
    public partial class GetPolicyStoreResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private CedarVersion _cedarVersion;
        private DateTime? _createdDate;
        private DeletionProtection _deletionProtection;
        private string _description;
        private DateTime? _lastUpdatedDate;
        private string _policyStoreId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ValidationSettings _validationSettings;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2500)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CedarVersion. 
        /// <para>
        /// The version of the Cedar language used with policies, policy templates, and schemas
        /// in this policy store. For more information, see <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/userguide/cedar4-faq.html">Amazon
        /// Verified Permissions upgrade to Cedar v4 FAQ</a>.
        /// </para>
        /// </summary>
        public CedarVersion CedarVersion
        {
            get { return this._cedarVersion; }
            set { this._cedarVersion = value; }
        }

        // Check to see if CedarVersion property is set
        internal bool IsSetCedarVersion()
        {
            return this._cedarVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the policy store was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the policy store can be deleted. If enabled, the policy store can't
        /// be deleted.
        /// </para>
        ///  
        /// <para>
        /// The default state is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public DeletionProtection DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text that you can provide to help with identification of the current policy
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=150)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the policy store was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store;
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the policy store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationSettings. 
        /// <para>
        /// The current validation settings for the policy store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationSettings ValidationSettings
        {
            get { return this._validationSettings; }
            set { this._validationSettings = value; }
        }

        // Check to see if ValidationSettings property is set
        internal bool IsSetValidationSettings()
        {
            return this._validationSettings != null;
        }

    }
}