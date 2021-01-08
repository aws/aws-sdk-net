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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveThingFromBillingGroup operation.
    /// Removes the given thing from the billing group.
    /// </summary>
    public partial class RemoveThingFromBillingGroupRequest : AmazonIoTRequest
    {
        private string _billingGroupArn;
        private string _billingGroupName;
        private string _thingArn;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        /// The ARN of the billing group.
        /// </para>
        /// </summary>
        public string BillingGroupArn
        {
            get { return this._billingGroupArn; }
            set { this._billingGroupArn = value; }
        }

        // Check to see if BillingGroupArn property is set
        internal bool IsSetBillingGroupArn()
        {
            return this._billingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingGroupName. 
        /// <para>
        /// The name of the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string BillingGroupName
        {
            get { return this._billingGroupName; }
            set { this._billingGroupName = value; }
        }

        // Check to see if BillingGroupName property is set
        internal bool IsSetBillingGroupName()
        {
            return this._billingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingArn. 
        /// <para>
        /// The ARN of the thing to be removed from the billing group.
        /// </para>
        /// </summary>
        public string ThingArn
        {
            get { return this._thingArn; }
            set { this._thingArn = value; }
        }

        // Check to see if ThingArn property is set
        internal bool IsSetThingArn()
        {
            return this._thingArn != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing to be removed from the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}