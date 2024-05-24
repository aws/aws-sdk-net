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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The Identity and Access Management (IAM) configuration.
    /// </summary>
    public partial class AwsIamConfig
    {
        private string _signingRegion;
        private string _signingServiceName;

        /// <summary>
        /// Gets and sets the property SigningRegion. 
        /// <para>
        /// The signing Amazon Web Services Region for IAM authorization.
        /// </para>
        /// </summary>
        public string SigningRegion
        {
            get { return this._signingRegion; }
            set { this._signingRegion = value; }
        }

        // Check to see if SigningRegion property is set
        internal bool IsSetSigningRegion()
        {
            return this._signingRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SigningServiceName. 
        /// <para>
        /// The signing service name for IAM authorization.
        /// </para>
        /// </summary>
        public string SigningServiceName
        {
            get { return this._signingServiceName; }
            set { this._signingServiceName = value; }
        }

        // Check to see if SigningServiceName property is set
        internal bool IsSetSigningServiceName()
        {
            return this._signingServiceName != null;
        }

    }
}