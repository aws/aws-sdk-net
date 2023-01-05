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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInstance operation.
    /// Deletes an Amazon Lightsail instance.
    /// 
    ///  
    /// <para>
    /// The <code>delete instance</code> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <code>instance name</code>. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteInstanceRequest : AmazonLightsailRequest
    {
        private bool? _forceDeleteAddOns;
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property ForceDeleteAddOns. 
        /// <para>
        /// A Boolean value to indicate whether to delete all add-ons for the instance.
        /// </para>
        /// </summary>
        public bool ForceDeleteAddOns
        {
            get { return this._forceDeleteAddOns.GetValueOrDefault(); }
            set { this._forceDeleteAddOns = value; }
        }

        // Check to see if ForceDeleteAddOns property is set
        internal bool IsSetForceDeleteAddOns()
        {
            return this._forceDeleteAddOns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}