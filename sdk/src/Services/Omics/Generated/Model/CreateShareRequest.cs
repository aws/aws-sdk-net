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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateShare operation.
    /// Creates a share offer that can be accepted outside the account by a subscriber. The
    /// share is created by the owner and accepted by the principal subscriber.
    /// </summary>
    public partial class CreateShareRequest : AmazonOmicsRequest
    {
        private string _principalSubscriber;
        private string _resourceArn;
        private string _shareName;

        /// <summary>
        /// Gets and sets the property PrincipalSubscriber. 
        /// <para>
        ///  The principal subscriber is the account being given access to the analytics store
        /// data through the share offer. 
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
        ///  The resource ARN for the analytics store to be shared. 
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
        ///  A name given to the share. 
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