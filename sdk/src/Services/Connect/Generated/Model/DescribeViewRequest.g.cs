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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeView operation. Retrieves the view for
    /// the specified Connect Customer instance and view identifier. <para> The view identifier
    /// can be supplied as a ViewId or ARN. </para> <para> <c>$SAVED</c> needs to be supplied
    /// if a view is unpublished. </para> <para> The view identifier can contain an optional
    /// qualifier, for example, <c>&lt;view-id&gt;:$SAVED</c>, which is either an actual version
    /// number or an Connect Customer managed qualifier <c>$SAVED | $LATEST</c>. If it is
    /// not supplied, then <c>$LATEST</c> is assumed for customer managed views and an error
    /// is returned if there is no published content available. Version 1 is assumed for Amazon
    /// Web Services managed views. </para>
    /// </summary>
    public partial class DescribeViewRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can find the instanceId in the
        /// ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ViewId. 
        /// <para>
        /// The ViewId of the view. This must be an ARN for Amazon Web Services managed views.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ViewId { get; set; }

        /// <summary>
        /// Checks to see if the ViewId property is set.
        /// </summary>
        internal bool IsSetViewId() => this.ViewId != null;
    }
}
