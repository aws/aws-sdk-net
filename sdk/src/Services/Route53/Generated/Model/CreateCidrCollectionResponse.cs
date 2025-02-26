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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the CreateCidrCollection operation.
    /// </summary>
    public partial class CreateCidrCollectionResponse : AmazonWebServiceResponse
    {
        private CidrCollection _collection;
        private string _location;

        /// <summary>
        /// Gets and sets the property Collection. 
        /// <para>
        /// A complex type that contains information about the CIDR collection.
        /// </para>
        /// </summary>
        public CidrCollection Collection
        {
            get { return this._collection; }
            set { this._collection = value; }
        }

        // Check to see if Collection property is set
        internal bool IsSetCollection()
        {
            return this._collection != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// A unique URL that represents the location for the CIDR collection.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}