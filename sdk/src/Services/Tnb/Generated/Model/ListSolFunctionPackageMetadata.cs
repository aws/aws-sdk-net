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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Details for the function package metadata.
    /// 
    ///  
    /// <para>
    /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
    /// a network function (an ETSI standard telecommunication application) and function package
    /// descriptor that uses the TOSCA standard to describe how the network functions should
    /// run on your network.
    /// </para>
    /// </summary>
    public partial class ListSolFunctionPackageMetadata
    {
        private DateTime? _createdAt;
        private DateTime? _lastModified;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date that the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the resource was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

    }
}