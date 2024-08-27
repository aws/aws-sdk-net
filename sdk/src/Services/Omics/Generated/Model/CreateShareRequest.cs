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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
    /// Container for the parameters to the CreateShare operation.
    /// Creates a cross-account shared resource. The resource owner makes an offer to share
    /// the resource with the principal subscriber (an AWS user with a different account than
    /// the resource owner).
    /// 
    ///  
    /// <para>
    /// The following resources support cross-account sharing:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// HealthOmics variant stores
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HealthOmics annotation stores
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Private workflows
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateShareRequest : AmazonOmicsRequest
    {
        private string _principalSubscriber;
        private string _resourceArn;
        private string _shareName;

        /// <summary>
        /// Gets and sets the property PrincipalSubscriber. 
        /// <para>
        /// The principal subscriber is the account being offered shared access to the resource.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalSubscriber
        {
            get { return this._principalSubscriber; }
            set { this._principalSubscriber = value; }
        }

        // Check to see if PrincipalSubscriber property is set
        internal bool IsSetPrincipalSubscriber()
        {
            return this._principalSubscriber != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to be shared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        /// A name that the owner defines for the share.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ShareName
        {
            get { return this._shareName; }
            set { this._shareName = value; }
        }

        // Check to see if ShareName property is set
        internal bool IsSetShareName()
        {
            return this._shareName != null;
        }

    }
}