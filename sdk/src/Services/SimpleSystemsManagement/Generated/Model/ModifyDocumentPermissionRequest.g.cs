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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDocumentPermission operation. Shares a Amazon
    /// Web Services Systems Manager document (SSM document)publicly or privately. If you
    /// share a document privately, you must specify the Amazon Web Services user IDs for
    /// those people who can use the document. If you share a document publicly, you must
    /// specify <i>All</i> as the account ID.
    /// </summary>
    public partial class ModifyDocumentPermissionRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIdsToAdd. 
        /// <para>
        /// The Amazon Web Services users that should have access to the document. The account
        /// IDs can either be a group of account IDs or <i>All</i>. You must specify a value for
        /// this parameter or the <c>AccountIdsToRemove</c> parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AccountIdsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIdsToAdd property is set.
        /// </summary>
        internal bool IsSetAccountIdsToAdd() => this.AccountIdsToAdd != null && (this.AccountIdsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountIdsToRemove. 
        /// <para>
        /// The Amazon Web Services users that should no longer have access to the document. The
        /// Amazon Web Services user can either be a group of account IDs or <i>All</i>. This
        /// action has a higher priority than <c>AccountIdsToAdd</c>. If you specify an ID to
        /// add and the same ID to remove, the system removes access to the document. You must
        /// specify a value for this parameter or the <c>AccountIdsToAdd</c> parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> AccountIdsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIdsToRemove property is set.
        /// </summary>
        internal bool IsSetAccountIdsToRemove() => this.AccountIdsToRemove != null && (this.AccountIdsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document that you want to share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// The permission type for the document. The permission type can be <i>Share</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentPermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property SharedDocumentVersion. 
        /// <para>
        /// (Optional) The version of the document to share. If it isn't specified, the system
        /// choose the <c>Default</c> version to share.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public string SharedDocumentVersion { get; set; }

        /// <summary>
        /// Checks to see if the SharedDocumentVersion property is set.
        /// </summary>
        internal bool IsSetSharedDocumentVersion() => this.SharedDocumentVersion != null;
    }
}
