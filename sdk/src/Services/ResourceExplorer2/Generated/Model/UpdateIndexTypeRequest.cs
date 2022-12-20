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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIndexType operation.
    /// Changes the type of the index from one of the following types to the other. For more
    /// information about indexes and the role they perform in Amazon Web Services Resource
    /// Explorer, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
    /// on cross-Region search by creating an aggregator index</a> in the <i>Amazon Web Services
    /// Resource Explorer User Guide</i>.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b> <code>AGGREGATOR</code> index type</b> 
    /// </para>
    ///  
    /// <para>
    /// The index contains information about resources from all Amazon Web Services Regions
    /// in the Amazon Web Services account in which you've created a Resource Explorer index.
    /// Resource information from all other Regions is replicated to this Region's index.
    /// </para>
    ///  
    /// <para>
    /// When you change the index type to <code>AGGREGATOR</code>, Resource Explorer turns
    /// on replication of all discovered resource information from the other Amazon Web Services
    /// Regions in your account to this index. You can then, from this Region only, perform
    /// resource search queries that span all Amazon Web Services Regions in the Amazon Web
    /// Services account. Turning on replication from all other Regions is performed by asynchronous
    /// background tasks. You can check the status of the asynchronous tasks by using the
    /// <a>GetIndex</a> operation. When the asynchronous tasks complete, the <code>Status</code>
    /// response of that operation changes from <code>UPDATING</code> to <code>ACTIVE</code>.
    /// After that, you can start to see results from other Amazon Web Services Regions in
    /// query results. However, it can take several hours for replication from all other Regions
    /// to complete.
    /// </para>
    ///  <important> 
    /// <para>
    /// You can have only one aggregator index per Amazon Web Services account. Before you
    /// can promote a different index to be the aggregator index for the account, you must
    /// first demote the existing aggregator index to type <code>LOCAL</code>.
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    ///  <b> <code>LOCAL</code> index type</b> 
    /// </para>
    ///  
    /// <para>
    /// The index contains information about resources in only the Amazon Web Services Region
    /// in which the index exists. If an aggregator index in another Region exists, then information
    /// in this local index is replicated to the aggregator index.
    /// </para>
    ///  
    /// <para>
    /// When you change the index type to <code>LOCAL</code>, Resource Explorer turns off
    /// the replication of resource information from all other Amazon Web Services Regions
    /// in the Amazon Web Services account to this Region. The aggregator index remains in
    /// the <code>UPDATING</code> state until all replication with other Regions successfully
    /// stops. You can check the status of the asynchronous task by using the <a>GetIndex</a>
    /// operation. When Resource Explorer successfully stops all replication with other Regions,
    /// the <code>Status</code> response of that operation changes from <code>UPDATING</code>
    /// to <code>ACTIVE</code>. Separately, the resource information from other Regions that
    /// was previously stored in the index is deleted within 30 days by another background
    /// task. Until that asynchronous task completes, some results from other Regions can
    /// continue to appear in search results.
    /// </para>
    ///  <important> 
    /// <para>
    /// After you demote an aggregator index to a local index, you must wait 24 hours before
    /// you can promote another index to be the new aggregator index for the account.
    /// </para>
    ///  </important> </li> </ul>
    /// </summary>
    public partial class UpdateIndexTypeRequest : AmazonResourceExplorer2Request
    {
        private string _arn;
        private IndexType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the index that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the index. To understand the difference between <code>LOCAL</code> and
        /// <code>AGGREGATOR</code>, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/manage-aggregator-region.html">Turning
        /// on cross-Region search</a> in the <i>Amazon Web Services Resource Explorer User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IndexType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}