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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeView operation.
    /// Retrieves the view for the specified Amazon Connect instance and view identifier.
    /// 
    ///  
    /// <para>
    /// The view identifier can be supplied as a ViewId or ARN.
    /// </para>
    ///  
    /// <para>
    ///  <c>$SAVED</c> needs to be supplied if a view is unpublished.
    /// </para>
    ///  
    /// <para>
    /// The view identifier can contain an optional qualifier, for example, <c>&lt;view-id&gt;:$SAVED</c>,
    /// which is either an actual version number or an Amazon Connect managed qualifier <c>$SAVED
    /// | $LATEST</c>. If it is not supplied, then <c>$LATEST</c> is assumed for customer
    /// managed views and an error is returned if there is no published content available.
    /// Version 1 is assumed for Amazon Web Services managed views.
    /// </para>
    /// </summary>
    public partial class DescribeViewRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _viewId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ViewId. 
        /// <para>
        /// The ViewId of the view. This must be an ARN for Amazon Web Services managed views.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ViewId
        {
            get { return this._viewId; }
            set { this._viewId = value; }
        }

        // Check to see if ViewId property is set
        internal bool IsSetViewId()
        {
            return this._viewId != null;
        }

    }
}