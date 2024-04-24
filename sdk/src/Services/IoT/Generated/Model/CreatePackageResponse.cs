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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreatePackage operation.
    /// </summary>
    public partial class CreatePackageResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _packageArn;
        private string _packageName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The package description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the package.
        /// </para>
        /// </summary>
        public string PackageArn
        {
            get { return this._packageArn; }
            set { this._packageArn = value; }
        }

        // Check to see if PackageArn property is set
        internal bool IsSetPackageArn()
        {
            return this._packageArn != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The name of the software package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

    }
}