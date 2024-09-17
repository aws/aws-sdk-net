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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PutPublicAccessBlockConfig operation.
    /// Configure your function's public-access settings.
    /// 
    ///  
    /// <para>
    /// To control public access to a Lambda function, you can choose whether to allow the
    /// creation of <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html">resource-based
    /// policies</a> that allow public access to that function. You can also block public
    /// access to a function, even if it has an existing resource-based policy that allows
    /// it.
    /// </para>
    /// </summary>
    public partial class PutPublicAccessBlockConfigRequest : AmazonLambdaRequest
    {
        private PublicAccessBlockConfig _publicAccessBlockConfig;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfig. 
        /// <para>
        /// An object defining the public-access settings you want to apply.
        /// </para>
        ///  
        /// <para>
        /// To block the creation of resource-based policies that would grant public access to
        /// your function, set <c>BlockPublicPolicy</c> to <c>true</c>. To allow the creation
        /// of resource-based policies that would grant public access to your function, set <c>BlockPublicPolicy</c>
        /// to <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// To block public access to your function, even if its resource-based policy allows
        /// it, set <c>RestrictPublicResource</c> to <c>true</c>. To allow public access to a
        /// function with a resource-based policy that permits it, set <c>RestrictPublicResource</c>
        /// to <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// The default setting for both <c>BlockPublicPolicy</c> and <c>RestrictPublicResource</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PublicAccessBlockConfig PublicAccessBlockConfig
        {
            get { return this._publicAccessBlockConfig; }
            set { this._publicAccessBlockConfig = value; }
        }

        // Check to see if PublicAccessBlockConfig property is set
        internal bool IsSetPublicAccessBlockConfig()
        {
            return this._publicAccessBlockConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function you want to configure public-access
        /// settings for. Public-access settings are applied at the function level, so you can't
        /// apply different settings to function versions or aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=170)]
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

    }
}