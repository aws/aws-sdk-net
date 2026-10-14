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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the GetAddonInstance operation.
    /// </summary>
    public partial class GetAddonInstanceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AddonInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Add On instance.
        /// </para>
        /// </summary>
        public string AddonInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the AddonInstanceArn property is set.
        /// </summary>
        internal bool IsSetAddonInstanceArn() => this.AddonInstanceArn != null;

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the Add On provider associated to the subscription of the instance.
        /// </para>
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Checks to see if the AddonName property is set.
        /// </summary>
        internal bool IsSetAddonName() => this.AddonName != null;

        /// <summary>
        /// Gets and sets the property AddonSubscriptionId. 
        /// <para>
        /// The subscription ID associated to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 67)]
        public string AddonSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the AddonSubscriptionId property is set.
        /// </summary>
        internal bool IsSetAddonSubscriptionId() => this.AddonSubscriptionId != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the Add On instance was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;
    }
}
