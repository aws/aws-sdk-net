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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the SetResourceAccessForBucket operation. Sets the
    /// Amazon Lightsail resources that can access the specified Lightsail bucket. <para>
    /// Lightsail buckets currently support setting access for Lightsail instances in the
    /// same Amazon Web Services Region. </para>
    /// </summary>
    public partial class SetResourceAccessForBucketRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        /// The access setting.
        /// </para>
        ///  
        /// <para>
        /// The following access settings are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>allow</c> - Allows access to the bucket and its objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deny</c> - Denies access to the bucket and its objects. Use this setting to remove
        /// access for a resource previously set to <c>allow</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceBucketAccess Access { get; set; }

        /// <summary>
        /// Checks to see if the Access property is set.
        /// </summary>
        internal bool IsSetAccess() => this.Access != null;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which to set access to another Lightsail resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 54)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the Lightsail instance for which to set bucket access. The instance must
        /// be in a running or stopped state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;
    }
}
