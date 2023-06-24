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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOriginAccessControl operation.
    /// Creates a new origin access control in CloudFront. After you create an origin access
    /// control, you can add it to an origin in a CloudFront distribution so that CloudFront
    /// sends authenticated (signed) requests to the origin.
    /// 
    ///  
    /// <para>
    /// This makes it possible to block public access to the origin, allowing viewers (users)
    /// to access the origin's content only through CloudFront.
    /// </para>
    ///  
    /// <para>
    /// For more information about using a CloudFront origin access control, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-restricting-access-to-origin.html">Restricting
    /// access to an Amazon Web Services origin</a> in the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateOriginAccessControlRequest : AmazonCloudFrontRequest
    {
        private OriginAccessControlConfig _originAccessControlConfig;

        /// <summary>
        /// Gets and sets the property OriginAccessControlConfig. 
        /// <para>
        /// Contains the origin access control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OriginAccessControlConfig OriginAccessControlConfig
        {
            get { return this._originAccessControlConfig; }
            set { this._originAccessControlConfig = value; }
        }

        // Check to see if OriginAccessControlConfig property is set
        internal bool IsSetOriginAccessControlConfig()
        {
            return this._originAccessControlConfig != null;
        }

    }
}