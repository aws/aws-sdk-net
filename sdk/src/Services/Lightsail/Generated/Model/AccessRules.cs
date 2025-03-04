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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the anonymous access permissions for an Amazon Lightsail bucket and its
    /// objects.
    /// 
    ///  
    /// <para>
    /// For more information about bucket access permissions, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-understanding-bucket-permissions">Understanding
    /// bucket permissions in Amazon Lightsail</a> in the 
    /// </para>
    ///  
    /// <para>
    ///  <i>Amazon Lightsail Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AccessRules
    {
        private bool? _allowPublicOverrides;
        private AccessType _getObject;

        /// <summary>
        /// Gets and sets the property AllowPublicOverrides. 
        /// <para>
        /// A Boolean value that indicates whether the access control list (ACL) permissions that
        /// are applied to individual objects override the <c>getObject</c> option that is currently
        /// specified.
        /// </para>
        ///  
        /// <para>
        /// When this is true, you can use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObjectAcl.html">PutObjectAcl</a>
        /// Amazon S3 API action to set individual objects to public (read-only) using the <c>public-read</c>
        /// ACL, or to private using the <c>private</c> ACL.
        /// </para>
        /// </summary>
        public bool? AllowPublicOverrides
        {
            get { return this._allowPublicOverrides; }
            set { this._allowPublicOverrides = value; }
        }

        // Check to see if AllowPublicOverrides property is set
        internal bool IsSetAllowPublicOverrides()
        {
            return this._allowPublicOverrides.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GetObject. 
        /// <para>
        /// Specifies the anonymous access to all objects in a bucket.
        /// </para>
        ///  
        /// <para>
        /// The following options can be specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>public</c> - Sets all objects in the bucket to public (read-only), making them
        /// readable by anyone in the world.
        /// </para>
        ///  
        /// <para>
        /// If the <c>getObject</c> value is set to <c>public</c>, then all objects in the bucket
        /// default to public regardless of the <c>allowPublicOverrides</c> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private</c> - Sets all objects in the bucket to private, making them readable
        /// only by you or anyone you give access to.
        /// </para>
        ///  
        /// <para>
        /// If the <c>getObject</c> value is set to <c>private</c>, and the <c>allowPublicOverrides</c>
        /// value is set to <c>true</c>, then all objects in the bucket default to private unless
        /// they are configured with a <c>public-read</c> ACL. Individual objects with a <c>public-read</c>
        /// ACL are readable by anyone in the world.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AccessType GetObject
        {
            get { return this._getObject; }
            set { this._getObject = value; }
        }

        // Check to see if GetObject property is set
        internal bool IsSetGetObject()
        {
            return this._getObject != null;
        }

    }
}