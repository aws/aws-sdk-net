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
    /// Container for the parameters to the DeleteIndex operation.
    /// Deletes the specified index and turns off Amazon Web Services Resource Explorer in
    /// the specified Amazon Web Services Region. When you delete an index, Resource Explorer
    /// stops discovering and indexing resources in that Region. Resource Explorer also deletes
    /// all views in that Region. These actions occur as asynchronous background tasks. You
    /// can check to see when the actions are complete by using the <a>GetIndex</a> operation
    /// and checking the <code>Status</code> response value.
    /// 
    ///  <note> 
    /// <para>
    /// If the index you delete is the aggregator index for the Amazon Web Services account,
    /// you must wait 24 hours before you can promote another local index to be the aggregator
    /// index for the account. Users can't perform account-wide searches using Resource Explorer
    /// until another aggregator index is configured.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteIndexRequest : AmazonResourceExplorer2Request
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the index that you want to delete.
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

    }
}