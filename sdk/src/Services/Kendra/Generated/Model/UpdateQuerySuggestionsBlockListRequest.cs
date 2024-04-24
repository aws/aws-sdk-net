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
    /// Container for the parameters to the UpdateQuerySuggestionsBlockList operation.
    /// Updates a block list used for query suggestions for an index.
    /// 
    ///  
    /// <para>
    /// Updates to a block list might not take effect right away. Amazon Kendra needs to refresh
    /// the entire suggestions list to apply any updates to the block list. Other changes
    /// not related to the block list apply immediately.
    /// </para>
    ///  
    /// <para>
    /// If a block list is updating, then you need to wait for the first update to finish
    /// before submitting another update.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kendra supports partial updates, so you only need to provide the fields you
    /// want to update.
    /// </para>
    ///  
    /// <para>
    ///  <c>UpdateQuerySuggestionsBlockList</c> is currently not supported in the Amazon Web
    /// Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class UpdateQuerySuggestionsBlockListRequest : AmazonKendraRequest
    {
        private string _description;
        private string _id;
        private string _indexId;
        private string _name;
        private string _roleArn;
        private S3Path _sourceS3Path;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the block list.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the block list you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// The identifier of the index for the block list.
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
        /// A new name for the block list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM (Identity and Access Management) role used to access the block list text file
        /// in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Path. 
        /// <para>
        /// The S3 path where your block list text file sits in S3.
        /// </para>
        ///  
        /// <para>
        /// If you update your block list and provide the same path to the block list text file
        /// in S3, then Amazon Kendra reloads the file to refresh the block list. Amazon Kendra
        /// does not automatically refresh your block list. You need to call the <c>UpdateQuerySuggestionsBlockList</c>
        /// API to refresh you block list.
        /// </para>
        ///  
        /// <para>
        /// If you update your block list, then Amazon Kendra asynchronously refreshes all query
        /// suggestions with the latest content in the S3 file. This means changes might not take
        /// effect immediately.
        /// </para>
        /// </summary>
        public S3Path SourceS3Path
        {
            get { return this._sourceS3Path; }
            set { this._sourceS3Path = value; }
        }

        // Check to see if SourceS3Path property is set
        internal bool IsSetSourceS3Path()
        {
            return this._sourceS3Path != null;
        }

    }
}