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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDefaultView operation.
    /// Sets the specified view as the default for the Amazon Web Services Region in which
    /// you call this operation. When a user performs a <a>Search</a> that doesn't explicitly
    /// specify which view to use, then Amazon Web Services Resource Explorer automatically
    /// chooses this default view for searches performed in this Amazon Web Services Region.
    /// 
    ///  
    /// <para>
    /// If an Amazon Web Services Region doesn't have a default view configured, then users
    /// must explicitly specify a view with every <c>Search</c> operation performed in that
    /// Region.
    /// </para>
    /// </summary>
    public partial class AssociateDefaultViewRequest : AmazonResourceExplorer2Request
    {
        private string _viewArn;

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the view to set as the default for the Amazon Web Services
        /// Region and Amazon Web Services account in which you call this operation. The specified
        /// view must already exist in the called Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ViewArn
        {
            get { return this._viewArn; }
            set { this._viewArn = value; }
        }

        // Check to see if ViewArn property is set
        internal bool IsSetViewArn()
        {
            return this._viewArn != null;
        }

    }
}