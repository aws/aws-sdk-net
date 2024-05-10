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
    /// This is the response object from the DetachVerifiedAccessTrustProvider operation.
    /// </summary>
    public partial class DetachVerifiedAccessTrustProviderResponse : AmazonWebServiceResponse
    {
        private VerifiedAccessInstance _verifiedAccessInstance;
        private VerifiedAccessTrustProvider _verifiedAccessTrustProvider;

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstance. 
        /// <para>
        /// Details about the Verified Access instance.
        /// </para>
        /// </summary>
        public VerifiedAccessInstance VerifiedAccessInstance
        {
            get { return this._verifiedAccessInstance; }
            set { this._verifiedAccessInstance = value; }
        }

        // Check to see if VerifiedAccessInstance property is set
        internal bool IsSetVerifiedAccessInstance()
        {
            return this._verifiedAccessInstance != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProvider. 
        /// <para>
        /// Details about the Verified Access trust provider.
        /// </para>
        /// </summary>
        public VerifiedAccessTrustProvider VerifiedAccessTrustProvider
        {
            get { return this._verifiedAccessTrustProvider; }
            set { this._verifiedAccessTrustProvider = value; }
        }

        // Check to see if VerifiedAccessTrustProvider property is set
        internal bool IsSetVerifiedAccessTrustProvider()
        {
            return this._verifiedAccessTrustProvider != null;
        }

    }
}