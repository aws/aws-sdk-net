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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateShare operation. Creates a cross-account
    /// shared resource. The resource owner makes an offer to share the resource with the
    /// principal subscriber (an Amazon Web Services user with a different account than the
    /// resource owner). <para> The following resources support cross-account sharing: </para>
    /// <ul> <li> <para> HealthOmics variant stores </para> </li> <li> <para> HealthOmics
    /// annotation stores </para> </li> <li> <para> Private workflows </para> </li> </ul>
    /// </summary>
    public partial class CreateShareRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property PrincipalSubscriber. 
        /// <para>
        /// The principal subscriber is the account being offered shared access to the resource.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PrincipalSubscriber { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalSubscriber property is set.
        /// </summary>
        internal bool IsSetPrincipalSubscriber() => this.PrincipalSubscriber != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to be shared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// A name that the owner defines for the share.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ShareName { get; set; }

        /// <summary>
        /// Checks to see if the ShareName property is set.
        /// </summary>
        internal bool IsSetShareName() => this.ShareName != null;
    }
}
