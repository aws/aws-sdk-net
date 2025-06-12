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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccessControlConfiguration operation.
    /// Updates an access control configuration for your documents in an index. This includes
    /// user and group access information for your documents. This is useful for user context
    /// filtering, where search results are filtered based on the user or their group access
    /// to documents.
    /// 
    ///  
    /// <para>
    /// You can update an access control configuration you created without indexing all of
    /// your documents again. For example, your index contains top-secret company documents
    /// that only certain employees or users should access. You created an 'allow' access
    /// control configuration for one user who recently joined the 'top-secret' team, switching
    /// from a team with 'deny' access to top-secret documents. However, the user suddenly
    /// returns to their previous team and should no longer have access to top secret documents.
    /// You can update the access control configuration to re-configure access control for
    /// your documents as circumstances change.
    /// </para>
    ///  
    /// <para>
    /// You call the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">BatchPutDocument</a>
    /// API to apply the updated access control configuration, with the <c>AccessControlConfigurationId</c>
    /// included in the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Document.html">Document</a>
    /// object. If you use an S3 bucket as a data source, you synchronize your data source
    /// to apply the <c>AccessControlConfigurationId</c> in the <c>.metadata.json</c> file.
    /// Amazon Kendra currently only supports access control configuration for S3 data sources
    /// and documents indexed using the <c>BatchPutDocument</c> API.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can't configure access control using <c>CreateAccessControlConfiguration</c> for
    /// an Amazon Kendra Gen AI Enterprise Edition index. Amazon Kendra will return a <c>ValidationException</c>
    /// error for a <c>Gen_AI_ENTERPRISE_EDITION</c> index.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateAccessControlConfigurationRequest : AmazonKendraRequest
    {
        private List<Principal> _accessControlList = AWSConfigs.InitializeCollections ? new List<Principal>() : null;
        private string _description;
        private List<HierarchicalPrincipal> _hierarchicalAccessControlList = AWSConfigs.InitializeCollections ? new List<HierarchicalPrincipal>() : null;
        private string _id;
        private string _indexId;
        private string _name;

        /// <summary>
        /// Gets and sets the property AccessControlList. 
        /// <para>
        /// Information you want to update on principals (users and/or groups) and which documents
        /// they should have access to. This is useful for user context filtering, where search
        /// results are filtered based on the user or their group access to documents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Principal> AccessControlList
        {
            get { return this._accessControlList; }
            set { this._accessControlList = value; }
        }

        // Check to see if AccessControlList property is set
        internal bool IsSetAccessControlList()
        {
            return this._accessControlList != null && (this._accessControlList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the access control configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property HierarchicalAccessControlList. 
        /// <para>
        /// The updated list of <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Principal.html">principal</a>
        /// lists that define the hierarchy for which documents users should have access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public List<HierarchicalPrincipal> HierarchicalAccessControlList
        {
            get { return this._hierarchicalAccessControlList; }
            set { this._hierarchicalAccessControlList = value; }
        }

        // Check to see if HierarchicalAccessControlList property is set
        internal bool IsSetHierarchicalAccessControlList()
        {
            return this._hierarchicalAccessControlList != null && (this._hierarchicalAccessControlList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the access control configuration you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for an access control configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the access control configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}