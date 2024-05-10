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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateInstanceEventWindow operation.
    /// Associates one or more targets with an event window. Only one type of target (instance
    /// IDs, Dedicated Host IDs, or tags) can be specified with an event window.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
    /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateInstanceEventWindowRequest : AmazonEC2Request
    {
        private InstanceEventWindowAssociationRequest _associationTarget;
        private string _instanceEventWindowId;

        /// <summary>
        /// Gets and sets the property AssociationTarget. 
        /// <para>
        /// One or more targets associated with the specified event window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceEventWindowAssociationRequest AssociationTarget
        {
            get { return this._associationTarget; }
            set { this._associationTarget = value; }
        }

        // Check to see if AssociationTarget property is set
        internal bool IsSetAssociationTarget()
        {
            return this._associationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceEventWindowId. 
        /// <para>
        /// The ID of the event window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceEventWindowId
        {
            get { return this._instanceEventWindowId; }
            set { this._instanceEventWindowId = value; }
        }

        // Check to see if InstanceEventWindowId property is set
        internal bool IsSetInstanceEventWindowId()
        {
            return this._instanceEventWindowId != null;
        }

    }
}