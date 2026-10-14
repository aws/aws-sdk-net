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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2500)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CedarVersion. 
        /// <para>
        /// The version of the Cedar language used with policies, policy templates, and schemas
        /// in this policy store. For more information, see <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/userguide/cedar4-faq.html">Amazon
        /// Verified Permissions upgrade to Cedar v4 FAQ</a>.
        /// </para>
        /// </summary>
        public CedarVersion CedarVersion { get; set; }

        /// <summary>
        /// Checks to see if the CedarVersion property is set.
        /// </summary>
        internal bool IsSetCedarVersion() => this.CedarVersion != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the policy store was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

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
        public DeletionProtection DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text that you can provide to help with identification of the current policy
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 150)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionState. 
        /// <para>
        /// A structure that contains the encryption configuration for the policy store.
        /// </para>
        /// </summary>
        public EncryptionState EncryptionState { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionState property is set.
        /// </summary>
        internal bool IsSetEncryptionState() => this.EncryptionState != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the policy store was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The ID of the policy store;
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the policy store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationSettings. 
        /// <para>
        /// The current validation settings for the policy store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ValidationSettings ValidationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSettings property is set.
        /// </summary>
        internal bool IsSetValidationSettings() => this.ValidationSettings != null;
    }
}
