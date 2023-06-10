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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the CreateAccessPointForObjectLambda operation.
    /// </summary>
    public partial class CreateAccessPointForObjectLambdaResponse : AmazonWebServiceResponse
    {
        private ObjectLambdaAccessPointAlias _alias;
        private string _objectLambdaAccessPointArn;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of the Object Lambda Access Point.
        /// </para>
        /// </summary>
        public ObjectLambdaAccessPointAlias Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLambdaAccessPointArn. 
        /// <para>
        /// Specifies the ARN for the Object Lambda Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ObjectLambdaAccessPointArn
        {
            get { return this._objectLambdaAccessPointArn; }
            set { this._objectLambdaAccessPointArn = value; }
        }

        // Check to see if ObjectLambdaAccessPointArn property is set
        internal bool IsSetObjectLambdaAccessPointArn()
        {
            return this._objectLambdaAccessPointArn != null;
        }

    }
}